/* tslint:disable */
/* eslint-disable */
/**
 * Radix Gateway API - Babylon
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers, and for light queries from front-end dApps. For exchange/asset integrations, back-end dApp integrations, or simple use cases, you should consider using the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Migration guide  Please see [the latest release notes](https://github.com/radixdlt/babylon-gateway/releases).  ## Integration and forward compatibility guarantees  All responses may have additional fields added at any release, so clients are advised to use JSON parsers which ignore unknown fields on JSON objects.  When the Radix protocol is updated, new functionality may be added, and so discriminated unions returned by the API may need to be updated to have new variants added, corresponding to the updated data. Clients may need to update in advance to be able to handle these new variants when a protocol update comes out.  On the very rare occasions we need to make breaking changes to the API, these will be warned in advance with deprecation notices on previous versions. These deprecation notices will include a safe migration path. Deprecation notes or breaking changes will be flagged clearly in release notes for new versions of the Gateway.  The Gateway DB schema is not subject to any compatibility guarantees, and may be changed at any release. DB changes will be flagged in the release notes so clients doing custom DB integrations can prepare. 
 *
 * The version of the OpenAPI document: v1.7.2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


import * as runtime from '../runtime';
import type {
  ErrorResponse,
  ResourceHoldersRequest,
  ResourceHoldersResponse,
} from '../models';
import {
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    ResourceHoldersRequestFromJSON,
    ResourceHoldersRequestToJSON,
    ResourceHoldersResponseFromJSON,
    ResourceHoldersResponseToJSON,
} from '../models';

export interface ResourceHoldersPageRequest {
    resourceHoldersRequest: ResourceHoldersRequest;
}

/**
 * 
 */
export class ExtensionsApi extends runtime.BaseAPI {

    /**
     * A paginated endpoint to discover which global entities hold the most of a given resource. More specifically, it returns a page of global entities which hold the given resource, ordered descending by the total fungible balance / total count of non-fungibles stored in vaults in the state tree of that entity (excluding unclaimed royalty balances). This endpoint operates only at the **current state version**, it is not possible to browse historical data. Because of that, it is not possible to offer stable pagination as data constantly changes. Balances might change between pages being read, which might result in gaps or some entries being returned twice. Under default Gateway configuration, up to 100 entries are returned per response. This can be increased up to 1000 entries per page with the `limit_per_page` parameter. 
     * Get Resource Holders Page
     */
    async resourceHoldersPageRaw(requestParameters: ResourceHoldersPageRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<ResourceHoldersResponse>> {
        if (requestParameters.resourceHoldersRequest === null || requestParameters.resourceHoldersRequest === undefined) {
            throw new runtime.RequiredError('resourceHoldersRequest','Required parameter requestParameters.resourceHoldersRequest was null or undefined when calling resourceHoldersPage.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        const response = await this.request({
            path: `/extensions/resource-holders/page`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: ResourceHoldersRequestToJSON(requestParameters.resourceHoldersRequest),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => ResourceHoldersResponseFromJSON(jsonValue));
    }

    /**
     * A paginated endpoint to discover which global entities hold the most of a given resource. More specifically, it returns a page of global entities which hold the given resource, ordered descending by the total fungible balance / total count of non-fungibles stored in vaults in the state tree of that entity (excluding unclaimed royalty balances). This endpoint operates only at the **current state version**, it is not possible to browse historical data. Because of that, it is not possible to offer stable pagination as data constantly changes. Balances might change between pages being read, which might result in gaps or some entries being returned twice. Under default Gateway configuration, up to 100 entries are returned per response. This can be increased up to 1000 entries per page with the `limit_per_page` parameter. 
     * Get Resource Holders Page
     */
    async resourceHoldersPage(requestParameters: ResourceHoldersPageRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<ResourceHoldersResponse> {
        const response = await this.resourceHoldersPageRaw(requestParameters, initOverrides);
        return await response.value();
    }

}