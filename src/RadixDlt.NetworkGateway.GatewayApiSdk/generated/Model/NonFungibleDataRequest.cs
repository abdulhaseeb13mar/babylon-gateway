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

/*
 * Radix Babylon Gateway API
 *
 * This API is designed to enable clients to efficiently query information on the RadixDLT ledger, and allow clients to build and submit transactions to the network. It is designed for use by the Radix Foundation's [Desktop Wallet](https://wallet.radixdlt.com/), [Explorer](https://explorer.radixdlt.com/) and any 3rd-party willing to interact with the network.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/main/apis/gateway-api.html) to learn more about different usage scenarios.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from full node(s) to extract and index data from the network. 
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using FileParameter = RadixDlt.NetworkGateway.GatewayApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.NetworkGateway.GatewayApiSdk.Client.OpenAPIDateConverter;

namespace RadixDlt.NetworkGateway.GatewayApiSdk.Model
{
    /// <summary>
    /// NonFungibleDataRequest
    /// </summary>
    [DataContract(Name = "NonFungibleDataRequest")]
    public partial class NonFungibleDataRequest : IEquatable<NonFungibleDataRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonFungibleDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NonFungibleDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonFungibleDataRequest" /> class.
        /// </summary>
        /// <param name="atLedgerState">atLedgerState.</param>
        /// <param name="address">Bech32m-encoded human readable version of the entity&#39;s global address. (required).</param>
        /// <param name="nonFungibleId">String-encoded non-fungible ID. (required).</param>
        /// <param name="cursor">This cursor allows forward pagination, by providing the cursor from the previous request..</param>
        /// <param name="limit">The page size requested..</param>
        public NonFungibleDataRequest(LedgerStateSelector atLedgerState = default(LedgerStateSelector), string address = default(string), string nonFungibleId = default(string), string cursor = default(string), int? limit = default(int?))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for NonFungibleDataRequest and cannot be null");
            }
            this.Address = address;
            // to ensure "nonFungibleId" is required (not null)
            if (nonFungibleId == null)
            {
                throw new ArgumentNullException("nonFungibleId is a required property for NonFungibleDataRequest and cannot be null");
            }
            this.NonFungibleId = nonFungibleId;
            this.AtLedgerState = atLedgerState;
            this.Cursor = cursor;
            this.Limit = limit;
        }

        /// <summary>
        /// Gets or Sets AtLedgerState
        /// </summary>
        [DataMember(Name = "at_ledger_state", EmitDefaultValue = true)]
        public LedgerStateSelector AtLedgerState { get; set; }

        /// <summary>
        /// Bech32m-encoded human readable version of the entity&#39;s global address.
        /// </summary>
        /// <value>Bech32m-encoded human readable version of the entity&#39;s global address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// String-encoded non-fungible ID.
        /// </summary>
        /// <value>String-encoded non-fungible ID.</value>
        [DataMember(Name = "non_fungible_id", IsRequired = true, EmitDefaultValue = true)]
        public string NonFungibleId { get; set; }

        /// <summary>
        /// This cursor allows forward pagination, by providing the cursor from the previous request.
        /// </summary>
        /// <value>This cursor allows forward pagination, by providing the cursor from the previous request.</value>
        [DataMember(Name = "cursor", EmitDefaultValue = true)]
        public string Cursor { get; set; }

        /// <summary>
        /// The page size requested.
        /// </summary>
        /// <value>The page size requested.</value>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public int? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NonFungibleDataRequest {\n");
            sb.Append("  AtLedgerState: ").Append(AtLedgerState).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  NonFungibleId: ").Append(NonFungibleId).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NonFungibleDataRequest);
        }

        /// <summary>
        /// Returns true if NonFungibleDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of NonFungibleDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonFungibleDataRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AtLedgerState == input.AtLedgerState ||
                    (this.AtLedgerState != null &&
                    this.AtLedgerState.Equals(input.AtLedgerState))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.NonFungibleId == input.NonFungibleId ||
                    (this.NonFungibleId != null &&
                    this.NonFungibleId.Equals(input.NonFungibleId))
                ) && 
                (
                    this.Cursor == input.Cursor ||
                    (this.Cursor != null &&
                    this.Cursor.Equals(input.Cursor))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AtLedgerState != null)
                {
                    hashCode = (hashCode * 59) + this.AtLedgerState.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.NonFungibleId != null)
                {
                    hashCode = (hashCode * 59) + this.NonFungibleId.GetHashCode();
                }
                if (this.Cursor != null)
                {
                    hashCode = (hashCode * 59) + this.Cursor.GetHashCode();
                }
                if (this.Limit != null)
                {
                    hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
