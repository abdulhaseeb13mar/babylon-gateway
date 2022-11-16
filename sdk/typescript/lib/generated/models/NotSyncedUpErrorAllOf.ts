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
/**
 * 
 * @export
 * @interface NotSyncedUpErrorAllOf
 */
export interface NotSyncedUpErrorAllOf {
    /**
     * The request type that triggered this exception.
     * @type {string}
     * @memberof NotSyncedUpErrorAllOf
     */
    request_type: string;
    /**
     * The current delay between the Gateway DB and the network ledger round timestamp.
     * @type {number}
     * @memberof NotSyncedUpErrorAllOf
     */
    current_sync_delay_seconds: number;
    /**
     * The maximum allowed delay between the Gateway DB and the network ledger round timestamp for this `request_type`.
     * @type {number}
     * @memberof NotSyncedUpErrorAllOf
     */
    max_allowed_sync_delay_seconds: number;
}

/**
 * Check if a given object implements the NotSyncedUpErrorAllOf interface.
 */
export function instanceOfNotSyncedUpErrorAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "request_type" in value;
    isInstance = isInstance && "current_sync_delay_seconds" in value;
    isInstance = isInstance && "max_allowed_sync_delay_seconds" in value;

    return isInstance;
}

export function NotSyncedUpErrorAllOfFromJSON(json: any): NotSyncedUpErrorAllOf {
    return NotSyncedUpErrorAllOfFromJSONTyped(json, false);
}

export function NotSyncedUpErrorAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): NotSyncedUpErrorAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'request_type': json['request_type'],
        'current_sync_delay_seconds': json['current_sync_delay_seconds'],
        'max_allowed_sync_delay_seconds': json['max_allowed_sync_delay_seconds'],
    };
}

export function NotSyncedUpErrorAllOfToJSON(value?: NotSyncedUpErrorAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'request_type': value.request_type,
        'current_sync_delay_seconds': value.current_sync_delay_seconds,
        'max_allowed_sync_delay_seconds': value.max_allowed_sync_delay_seconds,
    };
}
