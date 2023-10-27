/* tslint:disable */
/* eslint-disable */
/**
 * Radix Gateway API - Babylon
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers, and for light queries from front-end dApps. For exchange/asset integrations, back-end dApp integrations, or simple use cases, you should consider using the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  All responses may have additional fields added at any release, so clients are advised to use JSON parsers which ignore unknown fields on JSON objects.  When the Radix protocol is updated, new functionality may be added, and so discriminated unions returned by the API may need to be updated to have new variants added, corresponding to the updated data. Clients may need to update in advance to be able to handle these new variants when a protocol update comes out.  On the very rare occasions we need to make breaking changes to the API, these will be warned in advance with deprecation notices on previous versions. These deprecation notices will include a safe migration path. Deprecation notes or breaking changes will be flagged clearly in release notes for new versions of the Gateway.  The Gateway DB schema is not subject to any compatibility guarantees, and may be changed at any release. DB changes will be flagged in the release notes so clients doing custom DB integrations can prepare. 
 *
 * The version of the OpenAPI document: v1.2.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { TransactionBalanceChanges } from './TransactionBalanceChanges';
import {
    TransactionBalanceChangesFromJSON,
    TransactionBalanceChangesFromJSONTyped,
    TransactionBalanceChangesToJSON,
} from './TransactionBalanceChanges';
import type { TransactionReceipt } from './TransactionReceipt';
import {
    TransactionReceiptFromJSON,
    TransactionReceiptFromJSONTyped,
    TransactionReceiptToJSON,
} from './TransactionReceipt';
import type { TransactionStatus } from './TransactionStatus';
import {
    TransactionStatusFromJSON,
    TransactionStatusFromJSONTyped,
    TransactionStatusToJSON,
} from './TransactionStatus';

/**
 * 
 * @export
 * @interface CommittedTransactionInfo
 */
export interface CommittedTransactionInfo {
    /**
     * 
     * @type {number}
     * @memberof CommittedTransactionInfo
     */
    state_version: number;
    /**
     * 
     * @type {number}
     * @memberof CommittedTransactionInfo
     */
    epoch: number;
    /**
     * 
     * @type {number}
     * @memberof CommittedTransactionInfo
     */
    round: number;
    /**
     * 
     * @type {string}
     * @memberof CommittedTransactionInfo
     */
    round_timestamp: string;
    /**
     * 
     * @type {TransactionStatus}
     * @memberof CommittedTransactionInfo
     */
    transaction_status: TransactionStatus;
    /**
     * Bech32m-encoded hash.
     * @type {string}
     * @memberof CommittedTransactionInfo
     */
    payload_hash?: string;
    /**
     * Bech32m-encoded hash.
     * @type {string}
     * @memberof CommittedTransactionInfo
     */
    intent_hash?: string;
    /**
     * String-encoded decimal representing the amount of a related fungible resource.
     * @type {string}
     * @memberof CommittedTransactionInfo
     */
    fee_paid?: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof CommittedTransactionInfo
     */
    affected_global_entities?: Array<string>;
    /**
     * 
     * @type {Date}
     * @memberof CommittedTransactionInfo
     */
    confirmed_at?: Date | null;
    /**
     * 
     * @type {string}
     * @memberof CommittedTransactionInfo
     */
    error_message?: string | null;
    /**
     * Hex-encoded binary blob.
     * @type {string}
     * @memberof CommittedTransactionInfo
     */
    raw_hex?: string;
    /**
     * 
     * @type {TransactionReceipt}
     * @memberof CommittedTransactionInfo
     */
    receipt?: TransactionReceipt;
    /**
     * The optional transaction message.
     * This type is defined in the Core API as `TransactionMessage`. See the Core API documentation for more details.
     * @type {object}
     * @memberof CommittedTransactionInfo
     */
    message?: object;
    /**
     * 
     * @type {TransactionBalanceChanges}
     * @memberof CommittedTransactionInfo
     */
    balance_changes?: TransactionBalanceChanges | null;
}

/**
 * Check if a given object implements the CommittedTransactionInfo interface.
 */
export function instanceOfCommittedTransactionInfo(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "state_version" in value;
    isInstance = isInstance && "epoch" in value;
    isInstance = isInstance && "round" in value;
    isInstance = isInstance && "round_timestamp" in value;
    isInstance = isInstance && "transaction_status" in value;

    return isInstance;
}

export function CommittedTransactionInfoFromJSON(json: any): CommittedTransactionInfo {
    return CommittedTransactionInfoFromJSONTyped(json, false);
}

export function CommittedTransactionInfoFromJSONTyped(json: any, ignoreDiscriminator: boolean): CommittedTransactionInfo {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'state_version': json['state_version'],
        'epoch': json['epoch'],
        'round': json['round'],
        'round_timestamp': json['round_timestamp'],
        'transaction_status': TransactionStatusFromJSON(json['transaction_status']),
        'payload_hash': !exists(json, 'payload_hash') ? undefined : json['payload_hash'],
        'intent_hash': !exists(json, 'intent_hash') ? undefined : json['intent_hash'],
        'fee_paid': !exists(json, 'fee_paid') ? undefined : json['fee_paid'],
        'affected_global_entities': !exists(json, 'affected_global_entities') ? undefined : json['affected_global_entities'],
        'confirmed_at': !exists(json, 'confirmed_at') ? undefined : (json['confirmed_at'] === null ? null : new Date(json['confirmed_at'])),
        'error_message': !exists(json, 'error_message') ? undefined : json['error_message'],
        'raw_hex': !exists(json, 'raw_hex') ? undefined : json['raw_hex'],
        'receipt': !exists(json, 'receipt') ? undefined : TransactionReceiptFromJSON(json['receipt']),
        'message': !exists(json, 'message') ? undefined : json['message'],
        'balance_changes': !exists(json, 'balance_changes') ? undefined : TransactionBalanceChangesFromJSON(json['balance_changes']),
    };
}

export function CommittedTransactionInfoToJSON(value?: CommittedTransactionInfo | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'state_version': value.state_version,
        'epoch': value.epoch,
        'round': value.round,
        'round_timestamp': value.round_timestamp,
        'transaction_status': TransactionStatusToJSON(value.transaction_status),
        'payload_hash': value.payload_hash,
        'intent_hash': value.intent_hash,
        'fee_paid': value.fee_paid,
        'affected_global_entities': value.affected_global_entities,
        'confirmed_at': value.confirmed_at === undefined ? undefined : (value.confirmed_at === null ? null : value.confirmed_at.toISOString()),
        'error_message': value.error_message,
        'raw_hex': value.raw_hex,
        'receipt': TransactionReceiptToJSON(value.receipt),
        'message': value.message,
        'balance_changes': TransactionBalanceChangesToJSON(value.balance_changes),
    };
}

