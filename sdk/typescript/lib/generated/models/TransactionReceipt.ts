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
/**
 * 
 * @export
 * @interface TransactionReceipt
 */
export interface TransactionReceipt {
    /**
     * The status of the transaction.
     * @type {object}
     * @memberof TransactionReceipt
     */
    status?: object;
    /**
     * Fees paid, Only present if the `status` is not `Rejected`.
     * @type {object}
     * @memberof TransactionReceipt
     */
    fee_summary?: object;
    /**
     * Transaction state updates (only present if status is Succeeded or Failed).
     * @type {object}
     * @memberof TransactionReceipt
     */
    state_updates?: object;
    /**
     * Information (number and active validator list) about new epoch if occured.
     * @type {object}
     * @memberof TransactionReceipt
     */
    next_epoch?: object;
    /**
     * The manifest line-by-line engine return data (only present if `status` is `Succeeded`).
     * @type {object}
     * @memberof TransactionReceipt
     */
    output?: object;
    /**
     * Events emitted by a transaction.
     * @type {object}
     * @memberof TransactionReceipt
     */
    events?: object;
    /**
     * Error message (only present if status is `Failed` or `Rejected`)
     * @type {string}
     * @memberof TransactionReceipt
     */
    error_message?: string | null;
}

/**
 * Check if a given object implements the TransactionReceipt interface.
 */
export function instanceOfTransactionReceipt(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function TransactionReceiptFromJSON(json: any): TransactionReceipt {
    return TransactionReceiptFromJSONTyped(json, false);
}

export function TransactionReceiptFromJSONTyped(json: any, ignoreDiscriminator: boolean): TransactionReceipt {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'status': !exists(json, 'status') ? undefined : json['status'],
        'fee_summary': !exists(json, 'fee_summary') ? undefined : json['fee_summary'],
        'state_updates': !exists(json, 'state_updates') ? undefined : json['state_updates'],
        'next_epoch': !exists(json, 'next_epoch') ? undefined : json['next_epoch'],
        'output': !exists(json, 'output') ? undefined : json['output'],
        'events': !exists(json, 'events') ? undefined : json['events'],
        'error_message': !exists(json, 'error_message') ? undefined : json['error_message'],
    };
}

export function TransactionReceiptToJSON(value?: TransactionReceipt | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'status': value.status,
        'fee_summary': value.fee_summary,
        'state_updates': value.state_updates,
        'next_epoch': value.next_epoch,
        'output': value.output,
        'events': value.events,
        'error_message': value.error_message,
    };
}

