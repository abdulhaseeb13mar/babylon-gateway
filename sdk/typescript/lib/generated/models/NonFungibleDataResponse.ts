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
 * @interface NonFungibleDataResponse
 */
export interface NonFungibleDataResponse {
    /**
     * 
     * @type {LedgerState}
     * @memberof NonFungibleDataResponse
     */
    ledger_state: LedgerState;
    /**
     * The Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address.
     * @type {string}
     * @memberof NonFungibleDataResponse
     */
    address: string;
    /**
     * 
     * @type {string}
     * @memberof NonFungibleDataResponse
     */
    non_fungible_id_hex: string;
    /**
     * 
     * @type {string}
     * @memberof NonFungibleDataResponse
     */
    mutable_data_hex: string;
    /**
     * 
     * @type {string}
     * @memberof NonFungibleDataResponse
     */
    immutable_data_hex: string;
}

/**
 * Check if a given object implements the NonFungibleDataResponse interface.
 */
export function instanceOfNonFungibleDataResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "ledger_state" in value;
    isInstance = isInstance && "address" in value;
    isInstance = isInstance && "non_fungible_id_hex" in value;
    isInstance = isInstance && "mutable_data_hex" in value;
    isInstance = isInstance && "immutable_data_hex" in value;

    return isInstance;
}

export function NonFungibleDataResponseFromJSON(json: any): NonFungibleDataResponse {
    return NonFungibleDataResponseFromJSONTyped(json, false);
}

export function NonFungibleDataResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): NonFungibleDataResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ledger_state': LedgerStateFromJSON(json['ledger_state']),
        'address': json['address'],
        'non_fungible_id_hex': json['non_fungible_id_hex'],
        'mutable_data_hex': json['mutable_data_hex'],
        'immutable_data_hex': json['immutable_data_hex'],
    };
}

export function NonFungibleDataResponseToJSON(value?: NonFungibleDataResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ledger_state': LedgerStateToJSON(value.ledger_state),
        'address': value.address,
        'non_fungible_id_hex': value.non_fungible_id_hex,
        'mutable_data_hex': value.mutable_data_hex,
        'immutable_data_hex': value.immutable_data_hex,
    };
}

