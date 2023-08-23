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
import type { TransactionStatus } from './TransactionStatus';
import {
    TransactionStatusFromJSON,
    TransactionStatusFromJSONTyped,
    TransactionStatusToJSON,
} from './TransactionStatus';

/**
 * 
 * @export
 * @interface TransactionStatusResponseKnownPayloadItem
 */
export interface TransactionStatusResponseKnownPayloadItem {
    /**
     * Bech32m-encoded hash.
     * @type {string}
     * @memberof TransactionStatusResponseKnownPayloadItem
     */
    payload_hash: string;
    /**
     * 
     * @type {TransactionStatus}
     * @memberof TransactionStatusResponseKnownPayloadItem
     */
    status: TransactionStatus;
    /**
     * 
     * @type {string}
     * @memberof TransactionStatusResponseKnownPayloadItem
     */
    error_message?: string | null;
}

/**
 * Check if a given object implements the TransactionStatusResponseKnownPayloadItem interface.
 */
export function instanceOfTransactionStatusResponseKnownPayloadItem(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "payload_hash" in value;
    isInstance = isInstance && "status" in value;

    return isInstance;
}

export function TransactionStatusResponseKnownPayloadItemFromJSON(json: any): TransactionStatusResponseKnownPayloadItem {
    return TransactionStatusResponseKnownPayloadItemFromJSONTyped(json, false);
}

export function TransactionStatusResponseKnownPayloadItemFromJSONTyped(json: any, ignoreDiscriminator: boolean): TransactionStatusResponseKnownPayloadItem {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'payload_hash': json['payload_hash'],
        'status': TransactionStatusFromJSON(json['status']),
        'error_message': !exists(json, 'error_message') ? undefined : json['error_message'],
    };
}

export function TransactionStatusResponseKnownPayloadItemToJSON(value?: TransactionStatusResponseKnownPayloadItem | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'payload_hash': value.payload_hash,
        'status': TransactionStatusToJSON(value.status),
        'error_message': value.error_message,
    };
}

