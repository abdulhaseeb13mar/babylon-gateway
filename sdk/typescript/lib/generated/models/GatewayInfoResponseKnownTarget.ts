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
/**
 * 
 * @export
 * @interface GatewayInfoResponseKnownTarget
 */
export interface GatewayInfoResponseKnownTarget {
    /**
     * The latest-seen state version of the tip of the network's ledger. If this is significantly ahead of the current ledger state version, the Network Gateway is possibly behind and may be reporting outdated information.
     * @type {number}
     * @memberof GatewayInfoResponseKnownTarget
     */
    state_version: number;
}

/**
 * Check if a given object implements the GatewayInfoResponseKnownTarget interface.
 */
export function instanceOfGatewayInfoResponseKnownTarget(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "state_version" in value;

    return isInstance;
}

export function GatewayInfoResponseKnownTargetFromJSON(json: any): GatewayInfoResponseKnownTarget {
    return GatewayInfoResponseKnownTargetFromJSONTyped(json, false);
}

export function GatewayInfoResponseKnownTargetFromJSONTyped(json: any, ignoreDiscriminator: boolean): GatewayInfoResponseKnownTarget {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'state_version': json['state_version'],
    };
}

export function GatewayInfoResponseKnownTargetToJSON(value?: GatewayInfoResponseKnownTarget | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'state_version': value.state_version,
    };
}
