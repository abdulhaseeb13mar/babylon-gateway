/* tslint:disable */
/* eslint-disable */
/**
 * Radix Babylon Gateway API
 * See https://docs.radixdlt.com/main/apis/introduction.html 
 *
 * The version of the OpenAPI document: 2.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { LedgerState } from './LedgerState';
import {
    LedgerStateFromJSON,
    LedgerStateFromJSONTyped,
    LedgerStateToJSON,
} from './LedgerState';

/**
 * 
 * @export
 * @interface TransactionConstructionResponse
 */
export interface TransactionConstructionResponse {
    /**
     * 
     * @type {LedgerState}
     * @memberof TransactionConstructionResponse
     */
    ledger_state: LedgerState;
}

/**
 * Check if a given object implements the TransactionConstructionResponse interface.
 */
export function instanceOfTransactionConstructionResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "ledger_state" in value;

    return isInstance;
}

export function TransactionConstructionResponseFromJSON(json: any): TransactionConstructionResponse {
    return TransactionConstructionResponseFromJSONTyped(json, false);
}

export function TransactionConstructionResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): TransactionConstructionResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ledger_state': LedgerStateFromJSON(json['ledger_state']),
    };
}

export function TransactionConstructionResponseToJSON(value?: TransactionConstructionResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ledger_state': LedgerStateToJSON(value.ledger_state),
    };
}

