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
import type { EntityDetailsResponseDetails } from './EntityDetailsResponseDetails';
import {
    EntityDetailsResponseDetailsFromJSON,
    EntityDetailsResponseDetailsFromJSONTyped,
    EntityDetailsResponseDetailsToJSON,
} from './EntityDetailsResponseDetails';
import type { EntityMetadataCollection } from './EntityMetadataCollection';
import {
    EntityMetadataCollectionFromJSON,
    EntityMetadataCollectionFromJSONTyped,
    EntityMetadataCollectionToJSON,
} from './EntityMetadataCollection';

/**
 * 
 * @export
 * @interface EntityDetailsResponseAllOf
 */
export interface EntityDetailsResponseAllOf {
    /**
     * Bech32m-encoded human readable version of the entity's global address.
     * @type {string}
     * @memberof EntityDetailsResponseAllOf
     */
    address: string;
    /**
     * 
     * @type {EntityMetadataCollection}
     * @memberof EntityDetailsResponseAllOf
     */
    metadata: EntityMetadataCollection;
    /**
     * 
     * @type {EntityDetailsResponseDetails}
     * @memberof EntityDetailsResponseAllOf
     */
    details: EntityDetailsResponseDetails;
}

/**
 * Check if a given object implements the EntityDetailsResponseAllOf interface.
 */
export function instanceOfEntityDetailsResponseAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "address" in value;
    isInstance = isInstance && "metadata" in value;
    isInstance = isInstance && "details" in value;

    return isInstance;
}

export function EntityDetailsResponseAllOfFromJSON(json: any): EntityDetailsResponseAllOf {
    return EntityDetailsResponseAllOfFromJSONTyped(json, false);
}

export function EntityDetailsResponseAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityDetailsResponseAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'address': json['address'],
        'metadata': EntityMetadataCollectionFromJSON(json['metadata']),
        'details': EntityDetailsResponseDetailsFromJSON(json['details']),
    };
}

export function EntityDetailsResponseAllOfToJSON(value?: EntityDetailsResponseAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'address': value.address,
        'metadata': EntityMetadataCollectionToJSON(value.metadata),
        'details': EntityDetailsResponseDetailsToJSON(value.details),
    };
}

