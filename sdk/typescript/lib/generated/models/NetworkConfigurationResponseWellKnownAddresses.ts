/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V2
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.4.0
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
 * @interface NetworkConfigurationResponseWellKnownAddresses
 */
export interface NetworkConfigurationResponseWellKnownAddresses {
    /**
     * Bech32m-encoded human readable version of the component (normal, account, system) global address or hex-encoded id.
     * @type {string}
     * @memberof NetworkConfigurationResponseWellKnownAddresses
     */
    faucet: string;
    /**
     * Bech32m-encoded human readable version of the entity's global address or hex-encoded id.
     * @type {string}
     * @memberof NetworkConfigurationResponseWellKnownAddresses
     */
    epoch_manager: string;
    /**
     * Bech32m-encoded human readable version of the entity's global address or hex-encoded id.
     * @type {string}
     * @memberof NetworkConfigurationResponseWellKnownAddresses
     */
    clock: string;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address or hex-encoded id.
     * @type {string}
     * @memberof NetworkConfigurationResponseWellKnownAddresses
     */
    ecdsa_secp256k1: string;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address or hex-encoded id.
     * @type {string}
     * @memberof NetworkConfigurationResponseWellKnownAddresses
     */
    eddsa_ed25519: string;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address or hex-encoded id.
     * @type {string}
     * @memberof NetworkConfigurationResponseWellKnownAddresses
     */
    xrd: string;
}

/**
 * Check if a given object implements the NetworkConfigurationResponseWellKnownAddresses interface.
 */
export function instanceOfNetworkConfigurationResponseWellKnownAddresses(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "faucet" in value;
    isInstance = isInstance && "epoch_manager" in value;
    isInstance = isInstance && "clock" in value;
    isInstance = isInstance && "ecdsa_secp256k1" in value;
    isInstance = isInstance && "eddsa_ed25519" in value;
    isInstance = isInstance && "xrd" in value;

    return isInstance;
}

export function NetworkConfigurationResponseWellKnownAddressesFromJSON(json: any): NetworkConfigurationResponseWellKnownAddresses {
    return NetworkConfigurationResponseWellKnownAddressesFromJSONTyped(json, false);
}

export function NetworkConfigurationResponseWellKnownAddressesFromJSONTyped(json: any, ignoreDiscriminator: boolean): NetworkConfigurationResponseWellKnownAddresses {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'faucet': json['faucet'],
        'epoch_manager': json['epoch_manager'],
        'clock': json['clock'],
        'ecdsa_secp256k1': json['ecdsa_secp256k1'],
        'eddsa_ed25519': json['eddsa_ed25519'],
        'xrd': json['xrd'],
    };
}

export function NetworkConfigurationResponseWellKnownAddressesToJSON(value?: NetworkConfigurationResponseWellKnownAddresses | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'faucet': value.faucet,
        'epoch_manager': value.epoch_manager,
        'clock': value.clock,
        'ecdsa_secp256k1': value.ecdsa_secp256k1,
        'eddsa_ed25519': value.eddsa_ed25519,
        'xrd': value.xrd,
    };
}

