/* tslint:disable */
/* eslint-disable */
/**
 * Radix Gateway API - Babylon
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers, and for light queries from front-end dApps. For exchange/asset integrations, back-end dApp integrations, or simple use cases, you should consider using the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  All responses may have additional fields added at any release, so clients are advised to use JSON parsers which ignore unknown fields on JSON objects.  When the Radix protocol is updated, new functionality may be added, and so discriminated unions returned by the API may need to be updated to have new variants added, corresponding to the updated data. Clients may need to update in advance to be able to handle these new variants when a protocol update comes out.  On the very rare occasions we need to make breaking changes to the API, these will be warned in advance with deprecation notices on previous versions. These deprecation notices will include a safe migration path. Deprecation notes or breaking changes will be flagged clearly in release notes for new versions of the Gateway.  The Gateway DB schema is not subject to any compatibility guarantees, and may be changed at any release. DB changes will be flagged in the release notes so clients doing custom DB integrations can prepare. 
 *
 * The version of the OpenAPI document: v1.2.2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * Check detailed [OptIns](#section/Using-endpoints-with-opt-in-features) documentation for more details
 * @export
 * @interface StateEntityDetailsOptIns
 */
export interface StateEntityDetailsOptIns {
    /**
     * if set to `true`, ancestor addresses - `parent_address`, `owner_address` and `global_address` for entities are returned.
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    ancestor_identities?: boolean;
    /**
     * if set to `true`, `royalty_vault_balance` for component entities is returned.
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    component_royalty_vault_balance?: boolean;
    /**
     * if set to `true`, `royalty_vault_balance` for package entities is returned.
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    package_royalty_vault_balance?: boolean;
    /**
     * if set to `true`, first page of non fungible ids are returned for each non fungible resource, with `next_cursor` which can be later used at `/state/entity/page/non-fungible-vault/ids` endpoint.
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    non_fungible_include_nfids?: boolean;
    /**
     * allows specifying explicitly metadata properties which should be returned in response.
     * @type {Array<string>}
     * @memberof StateEntityDetailsOptIns
     */
    explicit_metadata?: Array<string>;
}

/**
 * Check if a given object implements the StateEntityDetailsOptIns interface.
 */
export function instanceOfStateEntityDetailsOptIns(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function StateEntityDetailsOptInsFromJSON(json: any): StateEntityDetailsOptIns {
    return StateEntityDetailsOptInsFromJSONTyped(json, false);
}

export function StateEntityDetailsOptInsFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsOptIns {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ancestor_identities': !exists(json, 'ancestor_identities') ? undefined : json['ancestor_identities'],
        'component_royalty_vault_balance': !exists(json, 'component_royalty_vault_balance') ? undefined : json['component_royalty_vault_balance'],
        'package_royalty_vault_balance': !exists(json, 'package_royalty_vault_balance') ? undefined : json['package_royalty_vault_balance'],
        'non_fungible_include_nfids': !exists(json, 'non_fungible_include_nfids') ? undefined : json['non_fungible_include_nfids'],
        'explicit_metadata': !exists(json, 'explicit_metadata') ? undefined : json['explicit_metadata'],
    };
}

export function StateEntityDetailsOptInsToJSON(value?: StateEntityDetailsOptIns | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ancestor_identities': value.ancestor_identities,
        'component_royalty_vault_balance': value.component_royalty_vault_balance,
        'package_royalty_vault_balance': value.package_royalty_vault_balance,
        'non_fungible_include_nfids': value.non_fungible_include_nfids,
        'explicit_metadata': value.explicit_metadata,
    };
}

