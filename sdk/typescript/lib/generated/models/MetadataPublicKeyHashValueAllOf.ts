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
import type { PublicKeyHash } from './PublicKeyHash';
import {
    PublicKeyHashFromJSON,
    PublicKeyHashFromJSONTyped,
    PublicKeyHashToJSON,
} from './PublicKeyHash';

/**
 * 
 * @export
 * @interface MetadataPublicKeyHashValueAllOf
 */
export interface MetadataPublicKeyHashValueAllOf {
    /**
     * 
     * @type {PublicKeyHash}
     * @memberof MetadataPublicKeyHashValueAllOf
     */
    value: PublicKeyHash;
    /**
     * 
     * @type {string}
     * @memberof MetadataPublicKeyHashValueAllOf
     */
    type?: MetadataPublicKeyHashValueAllOfTypeEnum;
}


/**
 * @export
 */
export const MetadataPublicKeyHashValueAllOfTypeEnum = {
    PublicKeyHash: 'PublicKeyHash'
} as const;
export type MetadataPublicKeyHashValueAllOfTypeEnum = typeof MetadataPublicKeyHashValueAllOfTypeEnum[keyof typeof MetadataPublicKeyHashValueAllOfTypeEnum];


/**
 * Check if a given object implements the MetadataPublicKeyHashValueAllOf interface.
 */
export function instanceOfMetadataPublicKeyHashValueAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "value" in value;

    return isInstance;
}

export function MetadataPublicKeyHashValueAllOfFromJSON(json: any): MetadataPublicKeyHashValueAllOf {
    return MetadataPublicKeyHashValueAllOfFromJSONTyped(json, false);
}

export function MetadataPublicKeyHashValueAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): MetadataPublicKeyHashValueAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'value': PublicKeyHashFromJSON(json['value']),
        'type': !exists(json, 'type') ? undefined : json['type'],
    };
}

export function MetadataPublicKeyHashValueAllOfToJSON(value?: MetadataPublicKeyHashValueAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'value': PublicKeyHashToJSON(value.value),
        'type': value.type,
    };
}

