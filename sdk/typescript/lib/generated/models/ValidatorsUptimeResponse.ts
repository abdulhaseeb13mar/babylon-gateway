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
import type { LedgerState } from './LedgerState';
import {
    LedgerStateFromJSON,
    LedgerStateFromJSONTyped,
    LedgerStateToJSON,
} from './LedgerState';
import type { ValidatorUptimeCollection } from './ValidatorUptimeCollection';
import {
    ValidatorUptimeCollectionFromJSON,
    ValidatorUptimeCollectionFromJSONTyped,
    ValidatorUptimeCollectionToJSON,
} from './ValidatorUptimeCollection';

/**
 * 
 * @export
 * @interface ValidatorsUptimeResponse
 */
export interface ValidatorsUptimeResponse {
    /**
     * 
     * @type {LedgerState}
     * @memberof ValidatorsUptimeResponse
     */
    ledger_state: LedgerState;
    /**
     * 
     * @type {ValidatorUptimeCollection}
     * @memberof ValidatorsUptimeResponse
     */
    validators: ValidatorUptimeCollection;
}

/**
 * Check if a given object implements the ValidatorsUptimeResponse interface.
 */
export function instanceOfValidatorsUptimeResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "ledger_state" in value;
    isInstance = isInstance && "validators" in value;

    return isInstance;
}

export function ValidatorsUptimeResponseFromJSON(json: any): ValidatorsUptimeResponse {
    return ValidatorsUptimeResponseFromJSONTyped(json, false);
}

export function ValidatorsUptimeResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): ValidatorsUptimeResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ledger_state': LedgerStateFromJSON(json['ledger_state']),
        'validators': ValidatorUptimeCollectionFromJSON(json['validators']),
    };
}

export function ValidatorsUptimeResponseToJSON(value?: ValidatorsUptimeResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ledger_state': LedgerStateToJSON(value.ledger_state),
        'validators': ValidatorUptimeCollectionToJSON(value.validators),
    };
}
