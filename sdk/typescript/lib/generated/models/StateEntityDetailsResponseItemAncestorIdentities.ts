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
/**
 * 
 * @export
 * @interface StateEntityDetailsResponseItemAncestorIdentities
 */
export interface StateEntityDetailsResponseItemAncestorIdentities {
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof StateEntityDetailsResponseItemAncestorIdentities
     */
    parent_address?: string;
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof StateEntityDetailsResponseItemAncestorIdentities
     */
    owner_address?: string;
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof StateEntityDetailsResponseItemAncestorIdentities
     */
    global_address?: string;
}

/**
 * Check if a given object implements the StateEntityDetailsResponseItemAncestorIdentities interface.
 */
export function instanceOfStateEntityDetailsResponseItemAncestorIdentities(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function StateEntityDetailsResponseItemAncestorIdentitiesFromJSON(json: any): StateEntityDetailsResponseItemAncestorIdentities {
    return StateEntityDetailsResponseItemAncestorIdentitiesFromJSONTyped(json, false);
}

export function StateEntityDetailsResponseItemAncestorIdentitiesFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsResponseItemAncestorIdentities {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'parent_address': !exists(json, 'parent_address') ? undefined : json['parent_address'],
        'owner_address': !exists(json, 'owner_address') ? undefined : json['owner_address'],
        'global_address': !exists(json, 'global_address') ? undefined : json['global_address'],
    };
}

export function StateEntityDetailsResponseItemAncestorIdentitiesToJSON(value?: StateEntityDetailsResponseItemAncestorIdentities | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'parent_address': value.parent_address,
        'owner_address': value.owner_address,
        'global_address': value.global_address,
    };
}
