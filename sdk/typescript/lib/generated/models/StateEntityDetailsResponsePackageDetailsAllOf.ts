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
import type { PackageVmType } from './PackageVmType';
import {
    PackageVmTypeFromJSON,
    PackageVmTypeFromJSONTyped,
    PackageVmTypeToJSON,
} from './PackageVmType';
import type { StateEntityDetailsResponsePackageDetailsBlueprintCollection } from './StateEntityDetailsResponsePackageDetailsBlueprintCollection';
import {
    StateEntityDetailsResponsePackageDetailsBlueprintCollectionFromJSON,
    StateEntityDetailsResponsePackageDetailsBlueprintCollectionFromJSONTyped,
    StateEntityDetailsResponsePackageDetailsBlueprintCollectionToJSON,
} from './StateEntityDetailsResponsePackageDetailsBlueprintCollection';
import type { StateEntityDetailsResponsePackageDetailsSchemaCollection } from './StateEntityDetailsResponsePackageDetailsSchemaCollection';
import {
    StateEntityDetailsResponsePackageDetailsSchemaCollectionFromJSON,
    StateEntityDetailsResponsePackageDetailsSchemaCollectionFromJSONTyped,
    StateEntityDetailsResponsePackageDetailsSchemaCollectionToJSON,
} from './StateEntityDetailsResponsePackageDetailsSchemaCollection';

/**
 * 
 * @export
 * @interface StateEntityDetailsResponsePackageDetailsAllOf
 */
export interface StateEntityDetailsResponsePackageDetailsAllOf {
    /**
     * 
     * @type {PackageVmType}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    vm_type: PackageVmType;
    /**
     * Hex-encoded binary blob.
     * @type {string}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    code_hash_hex: string;
    /**
     * Hex-encoded binary blob.
     * @type {string}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    code_hex: string;
    /**
     * String-encoded decimal representing the amount of a related fungible resource.
     * @type {string}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    royalty_vault_balance?: string;
    /**
     * 
     * @type {StateEntityDetailsResponsePackageDetailsBlueprintCollection}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    blueprints?: StateEntityDetailsResponsePackageDetailsBlueprintCollection;
    /**
     * 
     * @type {StateEntityDetailsResponsePackageDetailsSchemaCollection}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    schemas?: StateEntityDetailsResponsePackageDetailsSchemaCollection;
    /**
     * 
     * @type {string}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    type?: StateEntityDetailsResponsePackageDetailsAllOfTypeEnum;
}


/**
 * @export
 */
export const StateEntityDetailsResponsePackageDetailsAllOfTypeEnum = {
    Package: 'Package'
} as const;
export type StateEntityDetailsResponsePackageDetailsAllOfTypeEnum = typeof StateEntityDetailsResponsePackageDetailsAllOfTypeEnum[keyof typeof StateEntityDetailsResponsePackageDetailsAllOfTypeEnum];


/**
 * Check if a given object implements the StateEntityDetailsResponsePackageDetailsAllOf interface.
 */
export function instanceOfStateEntityDetailsResponsePackageDetailsAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "vm_type" in value;
    isInstance = isInstance && "code_hash_hex" in value;
    isInstance = isInstance && "code_hex" in value;

    return isInstance;
}

export function StateEntityDetailsResponsePackageDetailsAllOfFromJSON(json: any): StateEntityDetailsResponsePackageDetailsAllOf {
    return StateEntityDetailsResponsePackageDetailsAllOfFromJSONTyped(json, false);
}

export function StateEntityDetailsResponsePackageDetailsAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsResponsePackageDetailsAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'vm_type': PackageVmTypeFromJSON(json['vm_type']),
        'code_hash_hex': json['code_hash_hex'],
        'code_hex': json['code_hex'],
        'royalty_vault_balance': !exists(json, 'royalty_vault_balance') ? undefined : json['royalty_vault_balance'],
        'blueprints': !exists(json, 'blueprints') ? undefined : StateEntityDetailsResponsePackageDetailsBlueprintCollectionFromJSON(json['blueprints']),
        'schemas': !exists(json, 'schemas') ? undefined : StateEntityDetailsResponsePackageDetailsSchemaCollectionFromJSON(json['schemas']),
        'type': !exists(json, 'type') ? undefined : json['type'],
    };
}

export function StateEntityDetailsResponsePackageDetailsAllOfToJSON(value?: StateEntityDetailsResponsePackageDetailsAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'vm_type': PackageVmTypeToJSON(value.vm_type),
        'code_hash_hex': value.code_hash_hex,
        'code_hex': value.code_hex,
        'royalty_vault_balance': value.royalty_vault_balance,
        'blueprints': StateEntityDetailsResponsePackageDetailsBlueprintCollectionToJSON(value.blueprints),
        'schemas': StateEntityDetailsResponsePackageDetailsSchemaCollectionToJSON(value.schemas),
        'type': value.type,
    };
}
