/* tslint:disable */
/* eslint-disable */
/**
 * Radix Gateway API - Babylon
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers, and for light queries from front-end dApps. For exchange/asset integrations, back-end dApp integrations, or simple use cases, you should consider using the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  All responses may have additional fields added at any release, so clients are advised to use JSON parsers which ignore unknown fields on JSON objects.  When the Radix protocol is updated, new functionality may be added, and so discriminated unions returned by the API may need to be updated to have new variants added, corresponding to the updated data. Clients may need to update in advance to be able to handle these new variants when a protocol update comes out.  On the very rare occasions we need to make breaking changes to the API, these will be warned in advance with deprecation notices on previous versions. These deprecation notices will include a safe migration path. Deprecation notes or breaking changes will be flagged clearly in release notes for new versions of the Gateway.  The Gateway DB schema is not subject to any compatibility guarantees, and may be changed at any release. DB changes will be flagged in the release notes so clients doing custom DB integrations can prepare. 
 *
 * The version of the OpenAPI document: v1.8.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface TransactionPreviewRequestFlags
 */
export interface TransactionPreviewRequestFlags {
    /**
     * Whether to use a virtual, preview-only pool of XRD to pay for all execution fees.

     * @type {boolean}
     * @memberof TransactionPreviewRequestFlags
     */
    use_free_credit: boolean;
    /**
     * Whether the virtual signature proofs should be automatically placed in the auth zone.

     * @type {boolean}
     * @memberof TransactionPreviewRequestFlags
     */
    assume_all_signature_proofs: boolean;
    /**
     * Whether to skip the epoch range check (i.e. ignoring the `start_epoch_inclusive` and
`end_epoch_exclusive` parameters, if specified).

Note: effectively, without an epoch range, the Radix Engine cannot perform the
*intent hash duplicate* detection, which means that this check will be skipped as well.

     * @type {boolean}
     * @memberof TransactionPreviewRequestFlags
     */
    skip_epoch_check: boolean;
    /**
     * Whether to skip the auth checks during execution.

This could be used to e.g.:
* Preview protocol update style transactions.
* Mint resources for previewing trades with resources you don't own. If doing this, be warned:
  * Only resources which were potentially mintable/burnable at creation time
    will be mintable/burnable, due to feature flags on the resource.
  * Please see the below warning about unexpected results if using this approach.

Warning: this mode of operation is quite a departure from normal operation:
* Calculated fees will likely be lower than a standard execution.
* This mode can subtly break invariants some dApp code might rely on, or result in unexpected
  behaviour, so the resulting execution result might not be valid for your needs. For example,
  if I used this flag to mint pool units to preview a redemption (or some dApp interaction which
  behind the scenes redeemed them), they'd redeem for less than they're currently worth,
  because the blueprint code relies on the total supply of the pool units to calculate their
  redemption worth, and you've just inflated the total supply through the mint operation.

     * @type {boolean}
     * @memberof TransactionPreviewRequestFlags
     */
    disable_auth_checks?: boolean;
}

/**
 * Check if a given object implements the TransactionPreviewRequestFlags interface.
 */
export function instanceOfTransactionPreviewRequestFlags(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "use_free_credit" in value;
    isInstance = isInstance && "assume_all_signature_proofs" in value;
    isInstance = isInstance && "skip_epoch_check" in value;

    return isInstance;
}

export function TransactionPreviewRequestFlagsFromJSON(json: any): TransactionPreviewRequestFlags {
    return TransactionPreviewRequestFlagsFromJSONTyped(json, false);
}

export function TransactionPreviewRequestFlagsFromJSONTyped(json: any, ignoreDiscriminator: boolean): TransactionPreviewRequestFlags {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'use_free_credit': json['use_free_credit'],
        'assume_all_signature_proofs': json['assume_all_signature_proofs'],
        'skip_epoch_check': json['skip_epoch_check'],
        'disable_auth_checks': !exists(json, 'disable_auth_checks') ? undefined : json['disable_auth_checks'],
    };
}

export function TransactionPreviewRequestFlagsToJSON(value?: TransactionPreviewRequestFlags | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'use_free_credit': value.use_free_credit,
        'assume_all_signature_proofs': value.assume_all_signature_proofs,
        'skip_epoch_check': value.skip_epoch_check,
        'disable_auth_checks': value.disable_auth_checks,
    };
}

