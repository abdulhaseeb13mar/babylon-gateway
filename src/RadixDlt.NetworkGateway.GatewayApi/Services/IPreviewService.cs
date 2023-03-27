/* Copyright 2021 Radix Publishing Ltd incorporated in Jersey (Channel Islands).
 *
 * Licensed under the Radix License, Version 1.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at:
 *
 * radixfoundation.org/licenses/LICENSE-v1
 *
 * The Licensor hereby grants permission for the Canonical version of the Work to be
 * published, distributed and used under or by reference to the Licensor’s trademark
 * Radix ® and use of any unregistered trade names, logos or get-up.
 *
 * The Licensor provides the Work (and each Contributor provides its Contributions) on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied,
 * including, without limitation, any warranties or conditions of TITLE, NON-INFRINGEMENT,
 * MERCHANTABILITY, or FITNESS FOR A PARTICULAR PURPOSE.
 *
 * Whilst the Work is capable of being deployed, used and adopted (instantiated) to create
 * a distributed ledger it is your responsibility to test and validate the code, together
 * with all logic and performance of that code under all foreseeable scenarios.
 *
 * The Licensor does not make or purport to make and hereby excludes liability for all
 * and any representation, warranty or undertaking in any form whatsoever, whether express
 * or implied, to any entity or person, including any representation, warranty or
 * undertaking, as to the functionality security use, value or other characteristics of
 * any distributed ledger nor in respect the functioning or value of any tokens which may
 * be created stored or transferred using the Work. The Licensor does not warrant that the
 * Work or any use of the Work complies with any law or regulation in any territory where
 * it may be implemented or used or that it will be appropriate for any specific purpose.
 *
 * Neither the licensor nor any current or former employees, officers, directors, partners,
 * trustees, representatives, agents, advisors, contractors, or volunteers of the Licensor
 * shall be liable for any direct or indirect, special, incidental, consequential or other
 * losses of any kind, in tort, contract or otherwise (including but not limited to loss
 * of revenue, income or profits, or loss of use or data, or loss of reputation, or loss
 * of any economic or other opportunity of whatsoever nature or howsoever arising), arising
 * out of or in connection with (without limitation of any use, misuse, of any ledger system
 * or use made or its functionality or any performance or operation of any code or protocol
 * caused by bugs or programming or logic errors or otherwise);
 *
 * A. any offer, purchase, holding, use, sale, exchange or transmission of any
 * cryptographic keys, tokens or assets created, exchanged, stored or arising from any
 * interaction with the Work;
 *
 * B. any failure in a transmission or loss of any token or assets keys or other digital
 * artefacts due to errors in transmission;
 *
 * C. bugs, hacks, logic errors or faults in the Work or any communication;
 *
 * D. system software or apparatus including but not limited to losses caused by errors
 * in holding or transmitting tokens by any third-party;
 *
 * E. breaches or failure of security including hacker attacks, loss or disclosure of
 * password, loss of private key, unauthorised use or misuse of such passwords or keys;
 *
 * F. any losses including loss of anticipated savings or other benefits resulting from
 * use of the Work or any changes to the Work (however implemented).
 *
 * You are solely responsible for; testing, validating and evaluation of all operation
 * logic, functionality, security and appropriateness of using the Work for any commercial
 * or non-commercial purpose and for any reproduction or redistribution by You of the
 * Work. You assume all risks associated with Your use of the Work and the exercise of
 * permissions under this License.
 */

using RadixDlt.NetworkGateway.Abstractions.Extensions;
using RadixDlt.NetworkGateway.GatewayApi.CoreCommunications;
using RadixDlt.NetworkGateway.GatewayApi.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoreClient = RadixDlt.CoreApiSdk.Client;
using CoreModel = RadixDlt.CoreApiSdk.Model;
using GatewayModel = RadixDlt.NetworkGateway.GatewayApiSdk.Model;

namespace RadixDlt.NetworkGateway.GatewayApi.Services;

public interface IPreviewService
{
    Task<GatewayModel.TransactionPreviewResponse> HandlePreviewRequest(GatewayModel.TransactionPreviewRequest request, CancellationToken token = default);
}

internal class PreviewService : IPreviewService
{
    private readonly ICoreApiHandler _coreApiHandler;
    private readonly IEnumerable<IPreviewServiceObserver> _observers;

    public PreviewService(ICoreApiHandler coreApiHandler, IEnumerable<IPreviewServiceObserver> observers)
    {
        _coreApiHandler = coreApiHandler;
        _observers = observers;
    }

    public async Task<GatewayModel.TransactionPreviewResponse> HandlePreviewRequest(GatewayModel.TransactionPreviewRequest request, CancellationToken token = default)
    {
        try
        {
            await _observers.ForEachAsync(x => x.PreHandlePreviewRequest(request));

            var response = await HandlePreviewAndCreateResponse(request, token);

            await _observers.ForEachAsync(x => x.PostHandlePreviewRequest(request, response));

            return response;
        }
        catch (Exception ex)
        {
            await _observers.ForEachAsync(x => x.HandlePreviewRequestFailed(request, ex));

            throw;
        }
    }

    private async Task<GatewayModel.TransactionPreviewResponse> HandlePreviewAndCreateResponse(GatewayModel.TransactionPreviewRequest request, CancellationToken token)
    {
        CoreModel.PublicKey ToCoreModel(GatewayModel.PublicKey publicKey) => publicKey switch
        {
            GatewayModel.PublicKeyEcdsaSecp256k1 ecdsaSecp256K1 => new CoreModel.EcdsaSecp256k1PublicKey(ecdsaSecp256K1.KeyHex),
            GatewayModel.PublicKeyEddsaEd25519 eddsaEd25519 => new CoreModel.EddsaEd25519PublicKey(eddsaEd25519.KeyHex),
            _ => throw new UnreachableException($"Didn't expect {publicKey.GetType().Name} type"),
        };

        var coreRequestFlags = new CoreModel.TransactionPreviewRequestFlags(
            unlimitedLoan: request.Flags.UnlimitedLoan,
            assumeAllSignatureProofs: request.Flags.AssumeAllSignatureProofs,
            permitDuplicateIntentHash: request.Flags.PermitDuplicateIntentHash,
            permitInvalidHeaderEpoch: request.Flags.PermitInvalidHeaderEpoch);

        var coreRequest = new CoreModel.TransactionPreviewRequest(
            network: _coreApiHandler.GetNetworkName(),
            manifest: request.Manifest,
            blobsHex: request.BlobsHex,
            startEpochInclusive: request.StartEpochInclusive,
            endEpochExclusive: request.EndEpochExclusive,
            notaryPublicKey: ToCoreModel(request.NotaryPublicKey),
            notaryAsSignatory: request.NotaryAsSignatory,
            costUnitLimit: request.CostUnitLimit,
            tipPercentage: request.TipPercentage,
            nonce: request.Nonce,
            signerPublicKeys: request.SignerPublicKeys.Select(ToCoreModel).ToList(),
            flags: coreRequestFlags);

        var result = await _coreApiHandler.PreviewTransaction(coreRequest, token);

        if (result.Succeeded)
        {
            var coreResponse = result.SuccessResponse;

            return new GatewayModel.TransactionPreviewResponse(
                encodedReceipt: coreResponse.EncodedReceipt,
                receipt: coreResponse.Receipt,
                resourceChanges: coreResponse.InstructionResourceChanges.Cast<object>().ToList(),
                logs: coreResponse.Logs.Select(l => new GatewayModel.TransactionPreviewResponseLogsInner(l.Level, l.Message)).ToList());
        }

        throw InvalidRequestException.FromOtherError(result.FailureResponse.Message);
    }
}
