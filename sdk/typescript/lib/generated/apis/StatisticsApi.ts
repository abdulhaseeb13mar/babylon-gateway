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


import * as runtime from '../runtime';
import type {
  ErrorResponse,
  ValidatorsUptimeRequest,
  ValidatorsUptimeResponse,
} from '../models';
import {
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    ValidatorsUptimeRequestFromJSON,
    ValidatorsUptimeRequestToJSON,
    ValidatorsUptimeResponseFromJSON,
    ValidatorsUptimeResponseToJSON,
} from '../models';

export interface ValidatorsUptimeOperationRequest {
    validatorsUptimeRequest: ValidatorsUptimeRequest;
}

/**
 * 
 */
export class StatisticsApi extends runtime.BaseAPI {

    /**
     * Get Validators Uptime
     */
    async validatorsUptimeRaw(requestParameters: ValidatorsUptimeOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<ValidatorsUptimeResponse>> {
        if (requestParameters.validatorsUptimeRequest === null || requestParameters.validatorsUptimeRequest === undefined) {
            throw new runtime.RequiredError('validatorsUptimeRequest','Required parameter requestParameters.validatorsUptimeRequest was null or undefined when calling validatorsUptime.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        const response = await this.request({
            path: `/statistics/validators/uptime`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ValidatorsUptimeRequestToJSON(requestParameters.validatorsUptimeRequest),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => ValidatorsUptimeResponseFromJSON(jsonValue));
    }

    /**
     * Get Validators Uptime
     */
    async validatorsUptime(requestParameters: ValidatorsUptimeOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<ValidatorsUptimeResponse> {
        const response = await this.validatorsUptimeRaw(requestParameters, initOverrides);
        return await response.value();
    }

}
