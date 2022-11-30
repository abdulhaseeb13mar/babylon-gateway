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
 * @interface NonFungibleIdsCollectionItem
 */
export interface NonFungibleIdsCollectionItem {
    /**
     * 
     * @type {string}
     * @memberof NonFungibleIdsCollectionItem
     */
    id_hex: string;
}

/**
 * Check if a given object implements the NonFungibleIdsCollectionItem interface.
 */
export function instanceOfNonFungibleIdsCollectionItem(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "id_hex" in value;

    return isInstance;
}

export function NonFungibleIdsCollectionItemFromJSON(json: any): NonFungibleIdsCollectionItem {
    return NonFungibleIdsCollectionItemFromJSONTyped(json, false);
}

export function NonFungibleIdsCollectionItemFromJSONTyped(json: any, ignoreDiscriminator: boolean): NonFungibleIdsCollectionItem {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id_hex': json['id_hex'],
    };
}

export function NonFungibleIdsCollectionItemToJSON(value?: NonFungibleIdsCollectionItem | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'id_hex': value.id_hex,
    };
}

