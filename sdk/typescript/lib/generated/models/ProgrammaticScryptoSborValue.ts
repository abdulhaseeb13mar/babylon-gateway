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
    ProgrammaticScryptoSborValueArray,
    instanceOfProgrammaticScryptoSborValueArray,
    ProgrammaticScryptoSborValueArrayFromJSON,
    ProgrammaticScryptoSborValueArrayFromJSONTyped,
    ProgrammaticScryptoSborValueArrayToJSON,
} from './ProgrammaticScryptoSborValueArray';
import {
    ProgrammaticScryptoSborValueBool,
    instanceOfProgrammaticScryptoSborValueBool,
    ProgrammaticScryptoSborValueBoolFromJSON,
    ProgrammaticScryptoSborValueBoolFromJSONTyped,
    ProgrammaticScryptoSborValueBoolToJSON,
} from './ProgrammaticScryptoSborValueBool';
import {
    ProgrammaticScryptoSborValueBytes,
    instanceOfProgrammaticScryptoSborValueBytes,
    ProgrammaticScryptoSborValueBytesFromJSON,
    ProgrammaticScryptoSborValueBytesFromJSONTyped,
    ProgrammaticScryptoSborValueBytesToJSON,
} from './ProgrammaticScryptoSborValueBytes';
import {
    ProgrammaticScryptoSborValueDecimal,
    instanceOfProgrammaticScryptoSborValueDecimal,
    ProgrammaticScryptoSborValueDecimalFromJSON,
    ProgrammaticScryptoSborValueDecimalFromJSONTyped,
    ProgrammaticScryptoSborValueDecimalToJSON,
} from './ProgrammaticScryptoSborValueDecimal';
import {
    ProgrammaticScryptoSborValueEnum,
    instanceOfProgrammaticScryptoSborValueEnum,
    ProgrammaticScryptoSborValueEnumFromJSON,
    ProgrammaticScryptoSborValueEnumFromJSONTyped,
    ProgrammaticScryptoSborValueEnumToJSON,
} from './ProgrammaticScryptoSborValueEnum';
import {
    ProgrammaticScryptoSborValueI128,
    instanceOfProgrammaticScryptoSborValueI128,
    ProgrammaticScryptoSborValueI128FromJSON,
    ProgrammaticScryptoSborValueI128FromJSONTyped,
    ProgrammaticScryptoSborValueI128ToJSON,
} from './ProgrammaticScryptoSborValueI128';
import {
    ProgrammaticScryptoSborValueI16,
    instanceOfProgrammaticScryptoSborValueI16,
    ProgrammaticScryptoSborValueI16FromJSON,
    ProgrammaticScryptoSborValueI16FromJSONTyped,
    ProgrammaticScryptoSborValueI16ToJSON,
} from './ProgrammaticScryptoSborValueI16';
import {
    ProgrammaticScryptoSborValueI32,
    instanceOfProgrammaticScryptoSborValueI32,
    ProgrammaticScryptoSborValueI32FromJSON,
    ProgrammaticScryptoSborValueI32FromJSONTyped,
    ProgrammaticScryptoSborValueI32ToJSON,
} from './ProgrammaticScryptoSborValueI32';
import {
    ProgrammaticScryptoSborValueI64,
    instanceOfProgrammaticScryptoSborValueI64,
    ProgrammaticScryptoSborValueI64FromJSON,
    ProgrammaticScryptoSborValueI64FromJSONTyped,
    ProgrammaticScryptoSborValueI64ToJSON,
} from './ProgrammaticScryptoSborValueI64';
import {
    ProgrammaticScryptoSborValueI8,
    instanceOfProgrammaticScryptoSborValueI8,
    ProgrammaticScryptoSborValueI8FromJSON,
    ProgrammaticScryptoSborValueI8FromJSONTyped,
    ProgrammaticScryptoSborValueI8ToJSON,
} from './ProgrammaticScryptoSborValueI8';
import {
    ProgrammaticScryptoSborValueMap,
    instanceOfProgrammaticScryptoSborValueMap,
    ProgrammaticScryptoSborValueMapFromJSON,
    ProgrammaticScryptoSborValueMapFromJSONTyped,
    ProgrammaticScryptoSborValueMapToJSON,
} from './ProgrammaticScryptoSborValueMap';
import {
    ProgrammaticScryptoSborValueNonFungibleLocalId,
    instanceOfProgrammaticScryptoSborValueNonFungibleLocalId,
    ProgrammaticScryptoSborValueNonFungibleLocalIdFromJSON,
    ProgrammaticScryptoSborValueNonFungibleLocalIdFromJSONTyped,
    ProgrammaticScryptoSborValueNonFungibleLocalIdToJSON,
} from './ProgrammaticScryptoSborValueNonFungibleLocalId';
import {
    ProgrammaticScryptoSborValueOwn,
    instanceOfProgrammaticScryptoSborValueOwn,
    ProgrammaticScryptoSborValueOwnFromJSON,
    ProgrammaticScryptoSborValueOwnFromJSONTyped,
    ProgrammaticScryptoSborValueOwnToJSON,
} from './ProgrammaticScryptoSborValueOwn';
import {
    ProgrammaticScryptoSborValuePreciseDecimal,
    instanceOfProgrammaticScryptoSborValuePreciseDecimal,
    ProgrammaticScryptoSborValuePreciseDecimalFromJSON,
    ProgrammaticScryptoSborValuePreciseDecimalFromJSONTyped,
    ProgrammaticScryptoSborValuePreciseDecimalToJSON,
} from './ProgrammaticScryptoSborValuePreciseDecimal';
import {
    ProgrammaticScryptoSborValueReference,
    instanceOfProgrammaticScryptoSborValueReference,
    ProgrammaticScryptoSborValueReferenceFromJSON,
    ProgrammaticScryptoSborValueReferenceFromJSONTyped,
    ProgrammaticScryptoSborValueReferenceToJSON,
} from './ProgrammaticScryptoSborValueReference';
import {
    ProgrammaticScryptoSborValueString,
    instanceOfProgrammaticScryptoSborValueString,
    ProgrammaticScryptoSborValueStringFromJSON,
    ProgrammaticScryptoSborValueStringFromJSONTyped,
    ProgrammaticScryptoSborValueStringToJSON,
} from './ProgrammaticScryptoSborValueString';
import {
    ProgrammaticScryptoSborValueTuple,
    instanceOfProgrammaticScryptoSborValueTuple,
    ProgrammaticScryptoSborValueTupleFromJSON,
    ProgrammaticScryptoSborValueTupleFromJSONTyped,
    ProgrammaticScryptoSborValueTupleToJSON,
} from './ProgrammaticScryptoSborValueTuple';
import {
    ProgrammaticScryptoSborValueU128,
    instanceOfProgrammaticScryptoSborValueU128,
    ProgrammaticScryptoSborValueU128FromJSON,
    ProgrammaticScryptoSborValueU128FromJSONTyped,
    ProgrammaticScryptoSborValueU128ToJSON,
} from './ProgrammaticScryptoSborValueU128';
import {
    ProgrammaticScryptoSborValueU16,
    instanceOfProgrammaticScryptoSborValueU16,
    ProgrammaticScryptoSborValueU16FromJSON,
    ProgrammaticScryptoSborValueU16FromJSONTyped,
    ProgrammaticScryptoSborValueU16ToJSON,
} from './ProgrammaticScryptoSborValueU16';
import {
    ProgrammaticScryptoSborValueU32,
    instanceOfProgrammaticScryptoSborValueU32,
    ProgrammaticScryptoSborValueU32FromJSON,
    ProgrammaticScryptoSborValueU32FromJSONTyped,
    ProgrammaticScryptoSborValueU32ToJSON,
} from './ProgrammaticScryptoSborValueU32';
import {
    ProgrammaticScryptoSborValueU64,
    instanceOfProgrammaticScryptoSborValueU64,
    ProgrammaticScryptoSborValueU64FromJSON,
    ProgrammaticScryptoSborValueU64FromJSONTyped,
    ProgrammaticScryptoSborValueU64ToJSON,
} from './ProgrammaticScryptoSborValueU64';
import {
    ProgrammaticScryptoSborValueU8,
    instanceOfProgrammaticScryptoSborValueU8,
    ProgrammaticScryptoSborValueU8FromJSON,
    ProgrammaticScryptoSborValueU8FromJSONTyped,
    ProgrammaticScryptoSborValueU8ToJSON,
} from './ProgrammaticScryptoSborValueU8';

/**
 * @type ProgrammaticScryptoSborValue
 * 
 * @export
 */
export type ProgrammaticScryptoSborValue = { kind: 'Array' } & ProgrammaticScryptoSborValueArray | { kind: 'Bool' } & ProgrammaticScryptoSborValueBool | { kind: 'Bytes' } & ProgrammaticScryptoSborValueBytes | { kind: 'Decimal' } & ProgrammaticScryptoSborValueDecimal | { kind: 'Enum' } & ProgrammaticScryptoSborValueEnum | { kind: 'I128' } & ProgrammaticScryptoSborValueI128 | { kind: 'I16' } & ProgrammaticScryptoSborValueI16 | { kind: 'I32' } & ProgrammaticScryptoSborValueI32 | { kind: 'I64' } & ProgrammaticScryptoSborValueI64 | { kind: 'I8' } & ProgrammaticScryptoSborValueI8 | { kind: 'Map' } & ProgrammaticScryptoSborValueMap | { kind: 'NonFungibleLocalId' } & ProgrammaticScryptoSborValueNonFungibleLocalId | { kind: 'Own' } & ProgrammaticScryptoSborValueOwn | { kind: 'PreciseDecimal' } & ProgrammaticScryptoSborValuePreciseDecimal | { kind: 'Reference' } & ProgrammaticScryptoSborValueReference | { kind: 'String' } & ProgrammaticScryptoSborValueString | { kind: 'Tuple' } & ProgrammaticScryptoSborValueTuple | { kind: 'U128' } & ProgrammaticScryptoSborValueU128 | { kind: 'U16' } & ProgrammaticScryptoSborValueU16 | { kind: 'U32' } & ProgrammaticScryptoSborValueU32 | { kind: 'U64' } & ProgrammaticScryptoSborValueU64 | { kind: 'U8' } & ProgrammaticScryptoSborValueU8;

export function ProgrammaticScryptoSborValueFromJSON(json: any): ProgrammaticScryptoSborValue {
    return ProgrammaticScryptoSborValueFromJSONTyped(json, false);
}

export function ProgrammaticScryptoSborValueFromJSONTyped(json: any, ignoreDiscriminator: boolean): ProgrammaticScryptoSborValue {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    switch (json['kind']) {
        case 'Array':
            return {...ProgrammaticScryptoSborValueArrayFromJSONTyped(json, true), kind: 'Array'};
        case 'Bool':
            return {...ProgrammaticScryptoSborValueBoolFromJSONTyped(json, true), kind: 'Bool'};
        case 'Bytes':
            return {...ProgrammaticScryptoSborValueBytesFromJSONTyped(json, true), kind: 'Bytes'};
        case 'Decimal':
            return {...ProgrammaticScryptoSborValueDecimalFromJSONTyped(json, true), kind: 'Decimal'};
        case 'Enum':
            return {...ProgrammaticScryptoSborValueEnumFromJSONTyped(json, true), kind: 'Enum'};
        case 'I128':
            return {...ProgrammaticScryptoSborValueI128FromJSONTyped(json, true), kind: 'I128'};
        case 'I16':
            return {...ProgrammaticScryptoSborValueI16FromJSONTyped(json, true), kind: 'I16'};
        case 'I32':
            return {...ProgrammaticScryptoSborValueI32FromJSONTyped(json, true), kind: 'I32'};
        case 'I64':
            return {...ProgrammaticScryptoSborValueI64FromJSONTyped(json, true), kind: 'I64'};
        case 'I8':
            return {...ProgrammaticScryptoSborValueI8FromJSONTyped(json, true), kind: 'I8'};
        case 'Map':
            return {...ProgrammaticScryptoSborValueMapFromJSONTyped(json, true), kind: 'Map'};
        case 'NonFungibleLocalId':
            return {...ProgrammaticScryptoSborValueNonFungibleLocalIdFromJSONTyped(json, true), kind: 'NonFungibleLocalId'};
        case 'Own':
            return {...ProgrammaticScryptoSborValueOwnFromJSONTyped(json, true), kind: 'Own'};
        case 'PreciseDecimal':
            return {...ProgrammaticScryptoSborValuePreciseDecimalFromJSONTyped(json, true), kind: 'PreciseDecimal'};
        case 'Reference':
            return {...ProgrammaticScryptoSborValueReferenceFromJSONTyped(json, true), kind: 'Reference'};
        case 'String':
            return {...ProgrammaticScryptoSborValueStringFromJSONTyped(json, true), kind: 'String'};
        case 'Tuple':
            return {...ProgrammaticScryptoSborValueTupleFromJSONTyped(json, true), kind: 'Tuple'};
        case 'U128':
            return {...ProgrammaticScryptoSborValueU128FromJSONTyped(json, true), kind: 'U128'};
        case 'U16':
            return {...ProgrammaticScryptoSborValueU16FromJSONTyped(json, true), kind: 'U16'};
        case 'U32':
            return {...ProgrammaticScryptoSborValueU32FromJSONTyped(json, true), kind: 'U32'};
        case 'U64':
            return {...ProgrammaticScryptoSborValueU64FromJSONTyped(json, true), kind: 'U64'};
        case 'U8':
            return {...ProgrammaticScryptoSborValueU8FromJSONTyped(json, true), kind: 'U8'};
        default:
            throw new Error(`No variant of ProgrammaticScryptoSborValue exists with 'kind=${json['kind']}'`);
    }
}

export function ProgrammaticScryptoSborValueToJSON(value?: ProgrammaticScryptoSborValue | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    switch (value['kind']) {
        case 'Array':
            return ProgrammaticScryptoSborValueArrayToJSON(value);
        case 'Bool':
            return ProgrammaticScryptoSborValueBoolToJSON(value);
        case 'Bytes':
            return ProgrammaticScryptoSborValueBytesToJSON(value);
        case 'Decimal':
            return ProgrammaticScryptoSborValueDecimalToJSON(value);
        case 'Enum':
            return ProgrammaticScryptoSborValueEnumToJSON(value);
        case 'I128':
            return ProgrammaticScryptoSborValueI128ToJSON(value);
        case 'I16':
            return ProgrammaticScryptoSborValueI16ToJSON(value);
        case 'I32':
            return ProgrammaticScryptoSborValueI32ToJSON(value);
        case 'I64':
            return ProgrammaticScryptoSborValueI64ToJSON(value);
        case 'I8':
            return ProgrammaticScryptoSborValueI8ToJSON(value);
        case 'Map':
            return ProgrammaticScryptoSborValueMapToJSON(value);
        case 'NonFungibleLocalId':
            return ProgrammaticScryptoSborValueNonFungibleLocalIdToJSON(value);
        case 'Own':
            return ProgrammaticScryptoSborValueOwnToJSON(value);
        case 'PreciseDecimal':
            return ProgrammaticScryptoSborValuePreciseDecimalToJSON(value);
        case 'Reference':
            return ProgrammaticScryptoSborValueReferenceToJSON(value);
        case 'String':
            return ProgrammaticScryptoSborValueStringToJSON(value);
        case 'Tuple':
            return ProgrammaticScryptoSborValueTupleToJSON(value);
        case 'U128':
            return ProgrammaticScryptoSborValueU128ToJSON(value);
        case 'U16':
            return ProgrammaticScryptoSborValueU16ToJSON(value);
        case 'U32':
            return ProgrammaticScryptoSborValueU32ToJSON(value);
        case 'U64':
            return ProgrammaticScryptoSborValueU64ToJSON(value);
        case 'U8':
            return ProgrammaticScryptoSborValueU8ToJSON(value);
        default:
            throw new Error(`No variant of ProgrammaticScryptoSborValue exists with 'kind=${value['kind']}'`);
    }

}

