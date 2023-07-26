/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V2
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.4.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { EntityMetadataItem } from './EntityMetadataItem';
import {
    EntityMetadataItemFromJSON,
    EntityMetadataItemFromJSONTyped,
    EntityMetadataItemToJSON,
} from './EntityMetadataItem';
import type { LedgerState } from './LedgerState';
import {
    LedgerStateFromJSON,
    LedgerStateFromJSONTyped,
    LedgerStateToJSON,
} from './LedgerState';

/**
 * 
 * @export
 * @interface StateEntityMetadataPageResponse
 */
export interface StateEntityMetadataPageResponse {
    /**
     * 
     * @type {LedgerState}
     * @memberof StateEntityMetadataPageResponse
     */
    ledger_state: LedgerState;
    /**
     * Total number of items in underlying collection, fragment of which is available in `items` collection.
     * @type {number}
     * @memberof StateEntityMetadataPageResponse
     */
    total_count?: number | null;
    /**
     * If specified, contains a cursor to query previous page of the `items` collection.
     * @type {string}
     * @memberof StateEntityMetadataPageResponse
     */
    previous_cursor?: string | null;
    /**
     * If specified, contains a cursor to query next page of the `items` collection.
     * @type {string}
     * @memberof StateEntityMetadataPageResponse
     */
    next_cursor?: string | null;
    /**
     * 
     * @type {Array<EntityMetadataItem>}
     * @memberof StateEntityMetadataPageResponse
     */
    items: Array<EntityMetadataItem>;
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof StateEntityMetadataPageResponse
     */
    address: string;
}

/**
 * Check if a given object implements the StateEntityMetadataPageResponse interface.
 */
export function instanceOfStateEntityMetadataPageResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "ledger_state" in value;
    isInstance = isInstance && "items" in value;
    isInstance = isInstance && "address" in value;

    return isInstance;
}

export function StateEntityMetadataPageResponseFromJSON(json: any): StateEntityMetadataPageResponse {
    return StateEntityMetadataPageResponseFromJSONTyped(json, false);
}

export function StateEntityMetadataPageResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityMetadataPageResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ledger_state': LedgerStateFromJSON(json['ledger_state']),
        'total_count': !exists(json, 'total_count') ? undefined : json['total_count'],
        'previous_cursor': !exists(json, 'previous_cursor') ? undefined : json['previous_cursor'],
        'next_cursor': !exists(json, 'next_cursor') ? undefined : json['next_cursor'],
        'items': ((json['items'] as Array<any>).map(EntityMetadataItemFromJSON)),
        'address': json['address'],
    };
}

export function StateEntityMetadataPageResponseToJSON(value?: StateEntityMetadataPageResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ledger_state': LedgerStateToJSON(value.ledger_state),
        'total_count': value.total_count,
        'previous_cursor': value.previous_cursor,
        'next_cursor': value.next_cursor,
        'items': ((value.items as Array<any>).map(EntityMetadataItemToJSON)),
        'address': value.address,
    };
}

