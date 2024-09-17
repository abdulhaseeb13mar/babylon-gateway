/* tslint:disable */
/* eslint-disable */
/**
 * Radix Gateway API - Babylon
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers, and for light queries from front-end dApps. For exchange/asset integrations, back-end dApp integrations, or simple use cases, you should consider using the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  All responses may have additional fields added at any release, so clients are advised to use JSON parsers which ignore unknown fields on JSON objects.  When the Radix protocol is updated, new functionality may be added, and so discriminated unions returned by the API may need to be updated to have new variants added, corresponding to the updated data. Clients may need to update in advance to be able to handle these new variants when a protocol update comes out.  On the very rare occasions we need to make breaking changes to the API, these will be warned in advance with deprecation notices on previous versions. These deprecation notices will include a safe migration path. Deprecation notes or breaking changes will be flagged clearly in release notes for new versions of the Gateway.  The Gateway DB schema is not subject to any compatibility guarantees, and may be changed at any release. DB changes will be flagged in the release notes so clients doing custom DB integrations can prepare. 
 *
 * The version of the OpenAPI document: v1.7.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import {
    NativeResourceAccessControllerRecoveryBadgeValue,
    instanceOfNativeResourceAccessControllerRecoveryBadgeValue,
    NativeResourceAccessControllerRecoveryBadgeValueFromJSON,
    NativeResourceAccessControllerRecoveryBadgeValueFromJSONTyped,
    NativeResourceAccessControllerRecoveryBadgeValueToJSON,
} from './NativeResourceAccessControllerRecoveryBadgeValue';
import {
    NativeResourceAccountOwnerBadgeValue,
    instanceOfNativeResourceAccountOwnerBadgeValue,
    NativeResourceAccountOwnerBadgeValueFromJSON,
    NativeResourceAccountOwnerBadgeValueFromJSONTyped,
    NativeResourceAccountOwnerBadgeValueToJSON,
} from './NativeResourceAccountOwnerBadgeValue';
import {
    NativeResourceEd25519SignatureResourceValue,
    instanceOfNativeResourceEd25519SignatureResourceValue,
    NativeResourceEd25519SignatureResourceValueFromJSON,
    NativeResourceEd25519SignatureResourceValueFromJSONTyped,
    NativeResourceEd25519SignatureResourceValueToJSON,
} from './NativeResourceEd25519SignatureResourceValue';
import {
    NativeResourceGlobalCallerResourceValue,
    instanceOfNativeResourceGlobalCallerResourceValue,
    NativeResourceGlobalCallerResourceValueFromJSON,
    NativeResourceGlobalCallerResourceValueFromJSONTyped,
    NativeResourceGlobalCallerResourceValueToJSON,
} from './NativeResourceGlobalCallerResourceValue';
import {
    NativeResourceIdentityOwnerBadgeValue,
    instanceOfNativeResourceIdentityOwnerBadgeValue,
    NativeResourceIdentityOwnerBadgeValueFromJSON,
    NativeResourceIdentityOwnerBadgeValueFromJSONTyped,
    NativeResourceIdentityOwnerBadgeValueToJSON,
} from './NativeResourceIdentityOwnerBadgeValue';
import {
    NativeResourceMultiResourcePoolUnitValue,
    instanceOfNativeResourceMultiResourcePoolUnitValue,
    NativeResourceMultiResourcePoolUnitValueFromJSON,
    NativeResourceMultiResourcePoolUnitValueFromJSONTyped,
    NativeResourceMultiResourcePoolUnitValueToJSON,
} from './NativeResourceMultiResourcePoolUnitValue';
import {
    NativeResourceOneResourcePoolUnitValue,
    instanceOfNativeResourceOneResourcePoolUnitValue,
    NativeResourceOneResourcePoolUnitValueFromJSON,
    NativeResourceOneResourcePoolUnitValueFromJSONTyped,
    NativeResourceOneResourcePoolUnitValueToJSON,
} from './NativeResourceOneResourcePoolUnitValue';
import {
    NativeResourcePackageOfDirectCallerResourceValue,
    instanceOfNativeResourcePackageOfDirectCallerResourceValue,
    NativeResourcePackageOfDirectCallerResourceValueFromJSON,
    NativeResourcePackageOfDirectCallerResourceValueFromJSONTyped,
    NativeResourcePackageOfDirectCallerResourceValueToJSON,
} from './NativeResourcePackageOfDirectCallerResourceValue';
import {
    NativeResourcePackageOwnerBadgeValue,
    instanceOfNativeResourcePackageOwnerBadgeValue,
    NativeResourcePackageOwnerBadgeValueFromJSON,
    NativeResourcePackageOwnerBadgeValueFromJSONTyped,
    NativeResourcePackageOwnerBadgeValueToJSON,
} from './NativeResourcePackageOwnerBadgeValue';
import {
    NativeResourceSecp256k1SignatureResourceValue,
    instanceOfNativeResourceSecp256k1SignatureResourceValue,
    NativeResourceSecp256k1SignatureResourceValueFromJSON,
    NativeResourceSecp256k1SignatureResourceValueFromJSONTyped,
    NativeResourceSecp256k1SignatureResourceValueToJSON,
} from './NativeResourceSecp256k1SignatureResourceValue';
import {
    NativeResourceSystemExecutionResourceValue,
    instanceOfNativeResourceSystemExecutionResourceValue,
    NativeResourceSystemExecutionResourceValueFromJSON,
    NativeResourceSystemExecutionResourceValueFromJSONTyped,
    NativeResourceSystemExecutionResourceValueToJSON,
} from './NativeResourceSystemExecutionResourceValue';
import {
    NativeResourceTwoResourcePoolUnitValue,
    instanceOfNativeResourceTwoResourcePoolUnitValue,
    NativeResourceTwoResourcePoolUnitValueFromJSON,
    NativeResourceTwoResourcePoolUnitValueFromJSONTyped,
    NativeResourceTwoResourcePoolUnitValueToJSON,
} from './NativeResourceTwoResourcePoolUnitValue';
import {
    NativeResourceValidatorClaimNftValue,
    instanceOfNativeResourceValidatorClaimNftValue,
    NativeResourceValidatorClaimNftValueFromJSON,
    NativeResourceValidatorClaimNftValueFromJSONTyped,
    NativeResourceValidatorClaimNftValueToJSON,
} from './NativeResourceValidatorClaimNftValue';
import {
    NativeResourceValidatorLiquidStakeUnitValue,
    instanceOfNativeResourceValidatorLiquidStakeUnitValue,
    NativeResourceValidatorLiquidStakeUnitValueFromJSON,
    NativeResourceValidatorLiquidStakeUnitValueFromJSONTyped,
    NativeResourceValidatorLiquidStakeUnitValueToJSON,
} from './NativeResourceValidatorLiquidStakeUnitValue';
import {
    NativeResourceValidatorOwnerBadgeValue,
    instanceOfNativeResourceValidatorOwnerBadgeValue,
    NativeResourceValidatorOwnerBadgeValueFromJSON,
    NativeResourceValidatorOwnerBadgeValueFromJSONTyped,
    NativeResourceValidatorOwnerBadgeValueToJSON,
} from './NativeResourceValidatorOwnerBadgeValue';
import {
    NativeResourceXrdValue,
    instanceOfNativeResourceXrdValue,
    NativeResourceXrdValueFromJSON,
    NativeResourceXrdValueFromJSONTyped,
    NativeResourceXrdValueToJSON,
} from './NativeResourceXrdValue';

/**
 * @type NativeResourceDetails
 * 
 * @export
 */
export type NativeResourceDetails = { kind: 'AccessControllerRecoveryBadge' } & NativeResourceAccessControllerRecoveryBadgeValue | { kind: 'AccountOwnerBadge' } & NativeResourceAccountOwnerBadgeValue | { kind: 'Ed25519SignatureResource' } & NativeResourceEd25519SignatureResourceValue | { kind: 'GlobalCallerResource' } & NativeResourceGlobalCallerResourceValue | { kind: 'IdentityOwnerBadge' } & NativeResourceIdentityOwnerBadgeValue | { kind: 'MultiResourcePoolUnit' } & NativeResourceMultiResourcePoolUnitValue | { kind: 'OneResourcePoolUnit' } & NativeResourceOneResourcePoolUnitValue | { kind: 'PackageOfDirectCallerResource' } & NativeResourcePackageOfDirectCallerResourceValue | { kind: 'PackageOwnerBadge' } & NativeResourcePackageOwnerBadgeValue | { kind: 'Secp256k1SignatureResource' } & NativeResourceSecp256k1SignatureResourceValue | { kind: 'SystemExecutionResource' } & NativeResourceSystemExecutionResourceValue | { kind: 'TwoResourcePoolUnit' } & NativeResourceTwoResourcePoolUnitValue | { kind: 'ValidatorClaimNft' } & NativeResourceValidatorClaimNftValue | { kind: 'ValidatorLiquidStakeUnit' } & NativeResourceValidatorLiquidStakeUnitValue | { kind: 'ValidatorOwnerBadge' } & NativeResourceValidatorOwnerBadgeValue | { kind: 'Xrd' } & NativeResourceXrdValue;

export function NativeResourceDetailsFromJSON(json: any): NativeResourceDetails {
    return NativeResourceDetailsFromJSONTyped(json, false);
}

export function NativeResourceDetailsFromJSONTyped(json: any, ignoreDiscriminator: boolean): NativeResourceDetails {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    switch (json['kind']) {
        case 'AccessControllerRecoveryBadge':
            return {...NativeResourceAccessControllerRecoveryBadgeValueFromJSONTyped(json, true), kind: 'AccessControllerRecoveryBadge'};
        case 'AccountOwnerBadge':
            return {...NativeResourceAccountOwnerBadgeValueFromJSONTyped(json, true), kind: 'AccountOwnerBadge'};
        case 'Ed25519SignatureResource':
            return {...NativeResourceEd25519SignatureResourceValueFromJSONTyped(json, true), kind: 'Ed25519SignatureResource'};
        case 'GlobalCallerResource':
            return {...NativeResourceGlobalCallerResourceValueFromJSONTyped(json, true), kind: 'GlobalCallerResource'};
        case 'IdentityOwnerBadge':
            return {...NativeResourceIdentityOwnerBadgeValueFromJSONTyped(json, true), kind: 'IdentityOwnerBadge'};
        case 'MultiResourcePoolUnit':
            return {...NativeResourceMultiResourcePoolUnitValueFromJSONTyped(json, true), kind: 'MultiResourcePoolUnit'};
        case 'OneResourcePoolUnit':
            return {...NativeResourceOneResourcePoolUnitValueFromJSONTyped(json, true), kind: 'OneResourcePoolUnit'};
        case 'PackageOfDirectCallerResource':
            return {...NativeResourcePackageOfDirectCallerResourceValueFromJSONTyped(json, true), kind: 'PackageOfDirectCallerResource'};
        case 'PackageOwnerBadge':
            return {...NativeResourcePackageOwnerBadgeValueFromJSONTyped(json, true), kind: 'PackageOwnerBadge'};
        case 'Secp256k1SignatureResource':
            return {...NativeResourceSecp256k1SignatureResourceValueFromJSONTyped(json, true), kind: 'Secp256k1SignatureResource'};
        case 'SystemExecutionResource':
            return {...NativeResourceSystemExecutionResourceValueFromJSONTyped(json, true), kind: 'SystemExecutionResource'};
        case 'TwoResourcePoolUnit':
            return {...NativeResourceTwoResourcePoolUnitValueFromJSONTyped(json, true), kind: 'TwoResourcePoolUnit'};
        case 'ValidatorClaimNft':
            return {...NativeResourceValidatorClaimNftValueFromJSONTyped(json, true), kind: 'ValidatorClaimNft'};
        case 'ValidatorLiquidStakeUnit':
            return {...NativeResourceValidatorLiquidStakeUnitValueFromJSONTyped(json, true), kind: 'ValidatorLiquidStakeUnit'};
        case 'ValidatorOwnerBadge':
            return {...NativeResourceValidatorOwnerBadgeValueFromJSONTyped(json, true), kind: 'ValidatorOwnerBadge'};
        case 'Xrd':
            return {...NativeResourceXrdValueFromJSONTyped(json, true), kind: 'Xrd'};
        default:
            throw new Error(`No variant of NativeResourceDetails exists with 'kind=${json['kind']}'`);
    }
}

export function NativeResourceDetailsToJSON(value?: NativeResourceDetails | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    switch (value['kind']) {
        case 'AccessControllerRecoveryBadge':
            return NativeResourceAccessControllerRecoveryBadgeValueToJSON(value);
        case 'AccountOwnerBadge':
            return NativeResourceAccountOwnerBadgeValueToJSON(value);
        case 'Ed25519SignatureResource':
            return NativeResourceEd25519SignatureResourceValueToJSON(value);
        case 'GlobalCallerResource':
            return NativeResourceGlobalCallerResourceValueToJSON(value);
        case 'IdentityOwnerBadge':
            return NativeResourceIdentityOwnerBadgeValueToJSON(value);
        case 'MultiResourcePoolUnit':
            return NativeResourceMultiResourcePoolUnitValueToJSON(value);
        case 'OneResourcePoolUnit':
            return NativeResourceOneResourcePoolUnitValueToJSON(value);
        case 'PackageOfDirectCallerResource':
            return NativeResourcePackageOfDirectCallerResourceValueToJSON(value);
        case 'PackageOwnerBadge':
            return NativeResourcePackageOwnerBadgeValueToJSON(value);
        case 'Secp256k1SignatureResource':
            return NativeResourceSecp256k1SignatureResourceValueToJSON(value);
        case 'SystemExecutionResource':
            return NativeResourceSystemExecutionResourceValueToJSON(value);
        case 'TwoResourcePoolUnit':
            return NativeResourceTwoResourcePoolUnitValueToJSON(value);
        case 'ValidatorClaimNft':
            return NativeResourceValidatorClaimNftValueToJSON(value);
        case 'ValidatorLiquidStakeUnit':
            return NativeResourceValidatorLiquidStakeUnitValueToJSON(value);
        case 'ValidatorOwnerBadge':
            return NativeResourceValidatorOwnerBadgeValueToJSON(value);
        case 'Xrd':
            return NativeResourceXrdValueToJSON(value);
        default:
            throw new Error(`No variant of NativeResourceDetails exists with 'kind=${value['kind']}'`);
    }

}

