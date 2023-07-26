/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V2
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.4.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { ComponentEntityAccessRules } from './ComponentEntityAccessRules';
import {
    ComponentEntityAccessRulesFromJSON,
    ComponentEntityAccessRulesFromJSONTyped,
    ComponentEntityAccessRulesToJSON,
} from './ComponentEntityAccessRules';

/**
 * 
 * @export
 * @interface StateEntityDetailsResponseComponentDetails
 */
export interface StateEntityDetailsResponseComponentDetails {
    /**
     * 
     * @type {string}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    type: StateEntityDetailsResponseComponentDetailsTypeEnum;
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    package_address?: string;
    /**
     * 
     * @type {string}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    blueprint_name: string;
    /**
     * 
     * @type {object}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    state?: object;
    /**
     * 
     * @type {ComponentEntityAccessRules}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    access_rules: ComponentEntityAccessRules;
    /**
     * String-encoded decimal representing the amount of a related fungible resource.
     * @type {string}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    royalty_vault_balance?: string;
}


/**
 * @export
 */
export const StateEntityDetailsResponseComponentDetailsTypeEnum = {
    Component: 'Component'
} as const;
export type StateEntityDetailsResponseComponentDetailsTypeEnum = typeof StateEntityDetailsResponseComponentDetailsTypeEnum[keyof typeof StateEntityDetailsResponseComponentDetailsTypeEnum];


/**
 * Check if a given object implements the StateEntityDetailsResponseComponentDetails interface.
 */
export function instanceOfStateEntityDetailsResponseComponentDetails(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "type" in value;
    isInstance = isInstance && "blueprint_name" in value;
    isInstance = isInstance && "access_rules" in value;

    return isInstance;
}

export function StateEntityDetailsResponseComponentDetailsFromJSON(json: any): StateEntityDetailsResponseComponentDetails {
    return StateEntityDetailsResponseComponentDetailsFromJSONTyped(json, false);
}

export function StateEntityDetailsResponseComponentDetailsFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsResponseComponentDetails {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'type': json['type'],
        'package_address': !exists(json, 'package_address') ? undefined : json['package_address'],
        'blueprint_name': json['blueprint_name'],
        'state': !exists(json, 'state') ? undefined : json['state'],
        'access_rules': ComponentEntityAccessRulesFromJSON(json['access_rules']),
        'royalty_vault_balance': !exists(json, 'royalty_vault_balance') ? undefined : json['royalty_vault_balance'],
    };
}

export function StateEntityDetailsResponseComponentDetailsToJSON(value?: StateEntityDetailsResponseComponentDetails | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'type': value.type,
        'package_address': value.package_address,
        'blueprint_name': value.blueprint_name,
        'state': value.state,
        'access_rules': ComponentEntityAccessRulesToJSON(value.access_rules),
        'royalty_vault_balance': value.royalty_vault_balance,
    };
}

