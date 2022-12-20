/* tslint:disable */
/* eslint-disable */
/**
 * Radix Babylon Gateway API
 * This API is designed to enable clients to efficiently query information on the RadixDLT ledger, and allow clients to build and submit transactions to the network. It is designed for use by wallets and explorers.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/main/apis/gateway-api.html) to learn more about different usage scenarios.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network. 
 *
 * The version of the OpenAPI document: 0.1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { LedgerStateSelector } from './LedgerStateSelector';
import {
    LedgerStateSelectorFromJSON,
    LedgerStateSelectorFromJSONTyped,
    LedgerStateSelectorToJSON,
} from './LedgerStateSelector';

/**
 * 
 * @export
 * @interface TransactionRecentRequest
 */
export interface TransactionRecentRequest {
    /**
     * 
     * @type {LedgerStateSelector}
     * @memberof TransactionRecentRequest
     */
    at_ledger_state?: LedgerStateSelector | null;
    /**
     * 
     * @type {LedgerStateSelector}
     * @memberof TransactionRecentRequest
     */
    from_ledger_state?: LedgerStateSelector | null;
    /**
     * This cursor allows forward pagination, by providing the cursor from the previous request.
     * @type {string}
     * @memberof TransactionRecentRequest
     */
    cursor?: string | null;
    /**
     * The page size requested.
     * @type {number}
     * @memberof TransactionRecentRequest
     */
    limit?: number | null;
}

/**
 * Check if a given object implements the TransactionRecentRequest interface.
 */
export function instanceOfTransactionRecentRequest(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function TransactionRecentRequestFromJSON(json: any): TransactionRecentRequest {
    return TransactionRecentRequestFromJSONTyped(json, false);
}

export function TransactionRecentRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): TransactionRecentRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'at_ledger_state': !exists(json, 'at_ledger_state') ? undefined : LedgerStateSelectorFromJSON(json['at_ledger_state']),
        'from_ledger_state': !exists(json, 'from_ledger_state') ? undefined : LedgerStateSelectorFromJSON(json['from_ledger_state']),
        'cursor': !exists(json, 'cursor') ? undefined : json['cursor'],
        'limit': !exists(json, 'limit') ? undefined : json['limit'],
    };
}

export function TransactionRecentRequestToJSON(value?: TransactionRecentRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'at_ledger_state': LedgerStateSelectorToJSON(value.at_ledger_state),
        'from_ledger_state': LedgerStateSelectorToJSON(value.from_ledger_state),
        'cursor': value.cursor,
        'limit': value.limit,
    };
}
