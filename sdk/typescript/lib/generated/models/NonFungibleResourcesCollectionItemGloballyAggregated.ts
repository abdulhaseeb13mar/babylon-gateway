/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V3
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.5.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { EntityMetadataCollection } from './EntityMetadataCollection';
import {
    EntityMetadataCollectionFromJSON,
    EntityMetadataCollectionFromJSONTyped,
    EntityMetadataCollectionToJSON,
} from './EntityMetadataCollection';

/**
 * 
 * @export
 * @interface NonFungibleResourcesCollectionItemGloballyAggregated
 */
export interface NonFungibleResourcesCollectionItemGloballyAggregated {
    /**
     * 
     * @type {string}
     * @memberof NonFungibleResourcesCollectionItemGloballyAggregated
     */
    aggregation_level: NonFungibleResourcesCollectionItemGloballyAggregatedAggregationLevelEnum;
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof NonFungibleResourcesCollectionItemGloballyAggregated
     */
    resource_address: string;
    /**
     * 
     * @type {EntityMetadataCollection}
     * @memberof NonFungibleResourcesCollectionItemGloballyAggregated
     */
    explicit_metadata?: EntityMetadataCollection;
    /**
     * TBA
     * @type {number}
     * @memberof NonFungibleResourcesCollectionItemGloballyAggregated
     */
    amount: number;
    /**
     * TBD
     * @type {number}
     * @memberof NonFungibleResourcesCollectionItemGloballyAggregated
     */
    last_updated_at_state_version: number;
}


/**
 * @export
 */
export const NonFungibleResourcesCollectionItemGloballyAggregatedAggregationLevelEnum = {
    Global: 'Global'
} as const;
export type NonFungibleResourcesCollectionItemGloballyAggregatedAggregationLevelEnum = typeof NonFungibleResourcesCollectionItemGloballyAggregatedAggregationLevelEnum[keyof typeof NonFungibleResourcesCollectionItemGloballyAggregatedAggregationLevelEnum];


/**
 * Check if a given object implements the NonFungibleResourcesCollectionItemGloballyAggregated interface.
 */
export function instanceOfNonFungibleResourcesCollectionItemGloballyAggregated(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "aggregation_level" in value;
    isInstance = isInstance && "resource_address" in value;
    isInstance = isInstance && "amount" in value;
    isInstance = isInstance && "last_updated_at_state_version" in value;

    return isInstance;
}

export function NonFungibleResourcesCollectionItemGloballyAggregatedFromJSON(json: any): NonFungibleResourcesCollectionItemGloballyAggregated {
    return NonFungibleResourcesCollectionItemGloballyAggregatedFromJSONTyped(json, false);
}

export function NonFungibleResourcesCollectionItemGloballyAggregatedFromJSONTyped(json: any, ignoreDiscriminator: boolean): NonFungibleResourcesCollectionItemGloballyAggregated {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'aggregation_level': json['aggregation_level'],
        'resource_address': json['resource_address'],
        'explicit_metadata': !exists(json, 'explicit_metadata') ? undefined : EntityMetadataCollectionFromJSON(json['explicit_metadata']),
        'amount': json['amount'],
        'last_updated_at_state_version': json['last_updated_at_state_version'],
    };
}

export function NonFungibleResourcesCollectionItemGloballyAggregatedToJSON(value?: NonFungibleResourcesCollectionItemGloballyAggregated | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'aggregation_level': value.aggregation_level,
        'resource_address': value.resource_address,
        'explicit_metadata': EntityMetadataCollectionToJSON(value.explicit_metadata),
        'amount': value.amount,
        'last_updated_at_state_version': value.last_updated_at_state_version,
    };
}
