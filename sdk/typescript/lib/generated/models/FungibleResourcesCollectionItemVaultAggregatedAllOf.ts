/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V1
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.3.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { FungibleResourcesCollectionItemVaultAggregatedVault } from './FungibleResourcesCollectionItemVaultAggregatedVault';
import {
    FungibleResourcesCollectionItemVaultAggregatedVaultFromJSON,
    FungibleResourcesCollectionItemVaultAggregatedVaultFromJSONTyped,
    FungibleResourcesCollectionItemVaultAggregatedVaultToJSON,
} from './FungibleResourcesCollectionItemVaultAggregatedVault';

/**
 * 
 * @export
 * @interface FungibleResourcesCollectionItemVaultAggregatedAllOf
 */
export interface FungibleResourcesCollectionItemVaultAggregatedAllOf {
    /**
     * 
     * @type {FungibleResourcesCollectionItemVaultAggregatedVault}
     * @memberof FungibleResourcesCollectionItemVaultAggregatedAllOf
     */
    vaults: FungibleResourcesCollectionItemVaultAggregatedVault;
    /**
     * 
     * @type {string}
     * @memberof FungibleResourcesCollectionItemVaultAggregatedAllOf
     */
    aggregation_level?: FungibleResourcesCollectionItemVaultAggregatedAllOfAggregationLevelEnum;
}


/**
 * @export
 */
export const FungibleResourcesCollectionItemVaultAggregatedAllOfAggregationLevelEnum = {
    Vault: 'Vault'
} as const;
export type FungibleResourcesCollectionItemVaultAggregatedAllOfAggregationLevelEnum = typeof FungibleResourcesCollectionItemVaultAggregatedAllOfAggregationLevelEnum[keyof typeof FungibleResourcesCollectionItemVaultAggregatedAllOfAggregationLevelEnum];


/**
 * Check if a given object implements the FungibleResourcesCollectionItemVaultAggregatedAllOf interface.
 */
export function instanceOfFungibleResourcesCollectionItemVaultAggregatedAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "vaults" in value;

    return isInstance;
}

export function FungibleResourcesCollectionItemVaultAggregatedAllOfFromJSON(json: any): FungibleResourcesCollectionItemVaultAggregatedAllOf {
    return FungibleResourcesCollectionItemVaultAggregatedAllOfFromJSONTyped(json, false);
}

export function FungibleResourcesCollectionItemVaultAggregatedAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): FungibleResourcesCollectionItemVaultAggregatedAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'vaults': FungibleResourcesCollectionItemVaultAggregatedVaultFromJSON(json['vaults']),
        'aggregation_level': !exists(json, 'aggregation_level') ? undefined : json['aggregation_level'],
    };
}

export function FungibleResourcesCollectionItemVaultAggregatedAllOfToJSON(value?: FungibleResourcesCollectionItemVaultAggregatedAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'vaults': FungibleResourcesCollectionItemVaultAggregatedVaultToJSON(value.vaults),
        'aggregation_level': value.aggregation_level,
    };
}

