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
import type { FungibleResourcesCollection } from './FungibleResourcesCollection';
import {
    FungibleResourcesCollectionFromJSON,
    FungibleResourcesCollectionFromJSONTyped,
    FungibleResourcesCollectionToJSON,
} from './FungibleResourcesCollection';
import type { NonFungibleResourcesCollection } from './NonFungibleResourcesCollection';
import {
    NonFungibleResourcesCollectionFromJSON,
    NonFungibleResourcesCollectionFromJSONTyped,
    NonFungibleResourcesCollectionToJSON,
} from './NonFungibleResourcesCollection';

/**
 * 
 * @export
 * @interface EntityResourcesResponseAllOf
 */
export interface EntityResourcesResponseAllOf {
    /**
     * The Bech32m-encoded human readable version of the entity's global address.
     * @type {string}
     * @memberof EntityResourcesResponseAllOf
     */
    address: string;
    /**
     * 
     * @type {FungibleResourcesCollection}
     * @memberof EntityResourcesResponseAllOf
     */
    fungible_resources: FungibleResourcesCollection;
    /**
     * 
     * @type {NonFungibleResourcesCollection}
     * @memberof EntityResourcesResponseAllOf
     */
    non_fungible_resources: NonFungibleResourcesCollection;
}

/**
 * Check if a given object implements the EntityResourcesResponseAllOf interface.
 */
export function instanceOfEntityResourcesResponseAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "address" in value;
    isInstance = isInstance && "fungible_resources" in value;
    isInstance = isInstance && "non_fungible_resources" in value;

    return isInstance;
}

export function EntityResourcesResponseAllOfFromJSON(json: any): EntityResourcesResponseAllOf {
    return EntityResourcesResponseAllOfFromJSONTyped(json, false);
}

export function EntityResourcesResponseAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityResourcesResponseAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'address': json['address'],
        'fungible_resources': FungibleResourcesCollectionFromJSON(json['fungible_resources']),
        'non_fungible_resources': NonFungibleResourcesCollectionFromJSON(json['non_fungible_resources']),
    };
}

export function EntityResourcesResponseAllOfToJSON(value?: EntityResourcesResponseAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'address': value.address,
        'fungible_resources': FungibleResourcesCollectionToJSON(value.fungible_resources),
        'non_fungible_resources': NonFungibleResourcesCollectionToJSON(value.non_fungible_resources),
    };
}

