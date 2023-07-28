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
import type { StateEntityNonFungibleResourceVaultsPageOptIns } from './StateEntityNonFungibleResourceVaultsPageOptIns';
import {
    StateEntityNonFungibleResourceVaultsPageOptInsFromJSON,
    StateEntityNonFungibleResourceVaultsPageOptInsFromJSONTyped,
    StateEntityNonFungibleResourceVaultsPageOptInsToJSON,
} from './StateEntityNonFungibleResourceVaultsPageOptIns';

/**
 * 
 * @export
 * @interface StateEntityNonFungibleResourceVaultsPageRequestAllOf
 */
export interface StateEntityNonFungibleResourceVaultsPageRequestAllOf {
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof StateEntityNonFungibleResourceVaultsPageRequestAllOf
     */
    address: string;
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof StateEntityNonFungibleResourceVaultsPageRequestAllOf
     */
    resource_address: string;
    /**
     * 
     * @type {StateEntityNonFungibleResourceVaultsPageOptIns}
     * @memberof StateEntityNonFungibleResourceVaultsPageRequestAllOf
     */
    opt_ins?: StateEntityNonFungibleResourceVaultsPageOptIns;
}

/**
 * Check if a given object implements the StateEntityNonFungibleResourceVaultsPageRequestAllOf interface.
 */
export function instanceOfStateEntityNonFungibleResourceVaultsPageRequestAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "address" in value;
    isInstance = isInstance && "resource_address" in value;

    return isInstance;
}

export function StateEntityNonFungibleResourceVaultsPageRequestAllOfFromJSON(json: any): StateEntityNonFungibleResourceVaultsPageRequestAllOf {
    return StateEntityNonFungibleResourceVaultsPageRequestAllOfFromJSONTyped(json, false);
}

export function StateEntityNonFungibleResourceVaultsPageRequestAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityNonFungibleResourceVaultsPageRequestAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'address': json['address'],
        'resource_address': json['resource_address'],
        'opt_ins': !exists(json, 'opt_ins') ? undefined : StateEntityNonFungibleResourceVaultsPageOptInsFromJSON(json['opt_ins']),
    };
}

export function StateEntityNonFungibleResourceVaultsPageRequestAllOfToJSON(value?: StateEntityNonFungibleResourceVaultsPageRequestAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'address': value.address,
        'resource_address': value.resource_address,
        'opt_ins': StateEntityNonFungibleResourceVaultsPageOptInsToJSON(value.opt_ins),
    };
}

