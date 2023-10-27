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
    /**
     * 
     * @type {string}
     * @memberof NotSyncedUpErrorAllOf
     */
    type?: NotSyncedUpErrorAllOfTypeEnum;
}


/**
 * @export
 */
export const NotSyncedUpErrorAllOfTypeEnum = {
    NotSyncedUpError: 'NotSyncedUpError'
} as const;
export type NotSyncedUpErrorAllOfTypeEnum = typeof NotSyncedUpErrorAllOfTypeEnum[keyof typeof NotSyncedUpErrorAllOfTypeEnum];


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
        'type': !exists(json, 'type') ? undefined : json['type'],
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
        'type': value.type,
    };
}

