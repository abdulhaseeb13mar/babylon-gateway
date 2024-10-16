/* tslint:disable */
/* eslint-disable */
/**
 * Radix Gateway API - Babylon
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers, and for light queries from front-end dApps. For exchange/asset integrations, back-end dApp integrations, or simple use cases, you should consider using the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  All responses may have additional fields added at any release, so clients are advised to use JSON parsers which ignore unknown fields on JSON objects.  When the Radix protocol is updated, new functionality may be added, and so discriminated unions returned by the API may need to be updated to have new variants added, corresponding to the updated data. Clients may need to update in advance to be able to handle these new variants when a protocol update comes out.  On the very rare occasions we need to make breaking changes to the API, these will be warned in advance with deprecation notices on previous versions. These deprecation notices will include a safe migration path. Deprecation notes or breaking changes will be flagged clearly in release notes for new versions of the Gateway.  The Gateway DB schema is not subject to any compatibility guarantees, and may be changed at any release. DB changes will be flagged in the release notes so clients doing custom DB integrations can prepare. 
 *
 * The version of the OpenAPI document: v1.8.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { NativeResourceRedemptionValueItem } from './NativeResourceRedemptionValueItem';
import {
    NativeResourceRedemptionValueItemFromJSON,
    NativeResourceRedemptionValueItemFromJSONTyped,
    NativeResourceRedemptionValueItemToJSON,
} from './NativeResourceRedemptionValueItem';

/**
 * 
 * @export
 * @interface NativeResourceMultiResourcePoolUnitValueAllOf
 */
export interface NativeResourceMultiResourcePoolUnitValueAllOf {
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof NativeResourceMultiResourcePoolUnitValueAllOf
     */
    pool_address: string;
    /**
     * 
     * @type {number}
     * @memberof NativeResourceMultiResourcePoolUnitValueAllOf
     */
    redemption_resource_count: number;
    /**
     * 
     * @type {Array<NativeResourceRedemptionValueItem>}
     * @memberof NativeResourceMultiResourcePoolUnitValueAllOf
     */
    unit_redemption_value: Array<NativeResourceRedemptionValueItem>;
    /**
     * 
     * @type {string}
     * @memberof NativeResourceMultiResourcePoolUnitValueAllOf
     */
    kind?: NativeResourceMultiResourcePoolUnitValueAllOfKindEnum;
}


/**
 * @export
 */
export const NativeResourceMultiResourcePoolUnitValueAllOfKindEnum = {
    MultiResourcePoolUnit: 'MultiResourcePoolUnit'
} as const;
export type NativeResourceMultiResourcePoolUnitValueAllOfKindEnum = typeof NativeResourceMultiResourcePoolUnitValueAllOfKindEnum[keyof typeof NativeResourceMultiResourcePoolUnitValueAllOfKindEnum];


/**
 * Check if a given object implements the NativeResourceMultiResourcePoolUnitValueAllOf interface.
 */
export function instanceOfNativeResourceMultiResourcePoolUnitValueAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "pool_address" in value;
    isInstance = isInstance && "redemption_resource_count" in value;
    isInstance = isInstance && "unit_redemption_value" in value;

    return isInstance;
}

export function NativeResourceMultiResourcePoolUnitValueAllOfFromJSON(json: any): NativeResourceMultiResourcePoolUnitValueAllOf {
    return NativeResourceMultiResourcePoolUnitValueAllOfFromJSONTyped(json, false);
}

export function NativeResourceMultiResourcePoolUnitValueAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): NativeResourceMultiResourcePoolUnitValueAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'pool_address': json['pool_address'],
        'redemption_resource_count': json['redemption_resource_count'],
        'unit_redemption_value': ((json['unit_redemption_value'] as Array<any>).map(NativeResourceRedemptionValueItemFromJSON)),
        'kind': !exists(json, 'kind') ? undefined : json['kind'],
    };
}

export function NativeResourceMultiResourcePoolUnitValueAllOfToJSON(value?: NativeResourceMultiResourcePoolUnitValueAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'pool_address': value.pool_address,
        'redemption_resource_count': value.redemption_resource_count,
        'unit_redemption_value': ((value.unit_redemption_value as Array<any>).map(NativeResourceRedemptionValueItemToJSON)),
        'kind': value.kind,
    };
}

