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


/**
 * 
 * @export
 */
export const EntityDetailsResponseDetailsType = {
    FungibleResource: 'fungible_resource',
    NonFungibleResource: 'non_fungible_resource',
    AccountComponent: 'account_component'
} as const;
export type EntityDetailsResponseDetailsType = typeof EntityDetailsResponseDetailsType[keyof typeof EntityDetailsResponseDetailsType];


export function EntityDetailsResponseDetailsTypeFromJSON(json: any): EntityDetailsResponseDetailsType {
    return EntityDetailsResponseDetailsTypeFromJSONTyped(json, false);
}

export function EntityDetailsResponseDetailsTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityDetailsResponseDetailsType {
    return json as EntityDetailsResponseDetailsType;
}

export function EntityDetailsResponseDetailsTypeToJSON(value?: EntityDetailsResponseDetailsType | null): any {
    return value as any;
}
