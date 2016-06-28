/* 
 * Vericred API
 *
 * Vericred's API allows you to search for Health Plans that a specific doctor
accepts.

## Getting Started

Visit our [Developer Portal](https://vericred.3scale.net) to
create an account.

Once you have created an account, you can create one Application for
Production and another for our Sandbox (select the appropriate Plan when
you create the Application).

## Authentication

To authenticate, pass the API Key you created in the Developer Portal as
a `Vericred-Api-Key` header.

`curl -H 'Vericred-Api-Key: YOUR_KEY' "https://api.vericred.com/providers?search_term=Foo&zip_code=11215"`

## Versioning

Vericred's API default to the latest version.  However, if you need a specific
version, you can request it with an `Accept-Version` header.

The current version is `v3`.  Previous versions are `v1` and `v2`.

`curl -H 'Vericred-Api-Key: YOUR_KEY' -H 'Accept-Version: v2' "https://api.vericred.com/providers?search_term=Foo&zip_code=11215"`

## Pagination

Endpoints that accept `page` and `per_page` parameters are paginated. They expose
four additional fields that contain data about your position in the response,
namely `Total`, `Per-Page`, `Link`, and `Page` as described in [RFC-5988](https://tools.ietf.org/html/rfc5988).

For example, to display 5 results per page and view the second page of a
`GET` to `/networks`, your final request would be `GET /networks?....page=2&per_page=5`.

## Sideloading

When we return multiple levels of an object graph (e.g. `Provider`s and their `State`s
we sideload the associated data.  In this example, we would provide an Array of
`State`s and a `state_id` for each provider.  This is done primarily to reduce the
payload size since many of the `Provider`s will share a `State`

```
{
  providers: [{ id: 1, state_id: 1}, { id: 2, state_id: 1 }],
  states: [{ id: 1, code: 'NY' }]
}
```

If you need the second level of the object graph, you can just match the
corresponding id.

## Selecting specific data

All endpoints allow you to specify which fields you would like to return.
This allows you to limit the response to contain only the data you need.

For example, let's take a request that returns the following JSON by default

```
{
  provider: {
    id: 1,
    name: 'John',
    phone: '1234567890',
    field_we_dont_care_about: 'value_we_dont_care_about'
  },
  states: [{
    id: 1,
    name: 'New York',
    code: 'NY',
    field_we_dont_care_about: 'value_we_dont_care_about'
  }]
}
```

To limit our results to only return the fields we care about, we specify the
`select` query string parameter for the corresponding fields in the JSON
document.

In this case, we want to select `name` and `phone` from the `provider` key,
so we would add the parameters `select=provider.name,provider.phone`.
We also want the `name` and `code` from the `states` key, so we would
add the parameters `select=states.name,staes.code`.  The id field of
each document is always returned whether or not it is requested.

Our final request would be `GET /providers/12345?select=provider.name,provider.phone,states.name,states.code`

The response would be

```
{
  provider: {
    id: 1,
    name: 'John',
    phone: '1234567890'
  },
  states: [{
    id: 1,
    name: 'New York',
    code: 'NY'
  }]
}
```


 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Vericred.Client;
using IO.Vericred.Model;

namespace IO.Vericred.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INetworksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Networks
        /// </summary>
        /// <remarks>
        /// A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>NetworkSearchResponse</returns>
        NetworkSearchResponse ListNetworks (string carrierId, int? page = null, int? perPage = null);

        /// <summary>
        /// Networks
        /// </summary>
        /// <remarks>
        /// A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>ApiResponse of NetworkSearchResponse</returns>
        ApiResponse<NetworkSearchResponse> ListNetworksWithHttpInfo (string carrierId, int? page = null, int? perPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Networks
        /// </summary>
        /// <remarks>
        /// A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>Task of NetworkSearchResponse</returns>
        System.Threading.Tasks.Task<NetworkSearchResponse> ListNetworksAsync (string carrierId, int? page = null, int? perPage = null);

        /// <summary>
        /// Networks
        /// </summary>
        /// <remarks>
        /// A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </remarks>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>Task of ApiResponse (NetworkSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<NetworkSearchResponse>> ListNetworksAsyncWithHttpInfo (string carrierId, int? page = null, int? perPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NetworksApi : INetworksApi
    {
        private IO.Vericred.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NetworksApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Vericred.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NetworksApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Vericred.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Vericred.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Networks A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>NetworkSearchResponse</returns>
        public NetworkSearchResponse ListNetworks (string carrierId, int? page = null, int? perPage = null)
        {
             ApiResponse<NetworkSearchResponse> localVarResponse = ListNetworksWithHttpInfo(carrierId, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Networks A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>ApiResponse of NetworkSearchResponse</returns>
        public ApiResponse< NetworkSearchResponse > ListNetworksWithHttpInfo (string carrierId, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null)
                throw new ApiException(400, "Missing required parameter 'carrierId' when calling NetworksApi->ListNetworks");

            var localVarPath = "/networks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (carrierId != null) localVarQueryParams.Add("carrier_id", Configuration.ApiClient.ParameterToString(carrierId)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter

            // authentication (Vericred-Api-Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Vericred-Api-Key")))
            {
                localVarHeaderParams["Vericred-Api-Key"] = Configuration.GetApiKeyWithPrefix("Vericred-Api-Key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListNetworks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NetworkSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NetworkSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NetworkSearchResponse)));
            
        }

        /// <summary>
        /// Networks A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>Task of NetworkSearchResponse</returns>
        public async System.Threading.Tasks.Task<NetworkSearchResponse> ListNetworksAsync (string carrierId, int? page = null, int? perPage = null)
        {
             ApiResponse<NetworkSearchResponse> localVarResponse = await ListNetworksAsyncWithHttpInfo(carrierId, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Networks A network is a list of the doctors, other health care providers, and hospitals that a plan has contracted with to provide medical care to its members. This endpoint is paginated.
        /// </summary>
        /// <exception cref="IO.Vericred.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId">Carrier HIOS Issuer ID</param>
        /// <param name="page">Page of paginated response (optional)</param>
        /// <param name="perPage">Responses per page (optional)</param>
        /// <returns>Task of ApiResponse (NetworkSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NetworkSearchResponse>> ListNetworksAsyncWithHttpInfo (string carrierId, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null)
                throw new ApiException(400, "Missing required parameter 'carrierId' when calling NetworksApi->ListNetworks");

            var localVarPath = "/networks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (carrierId != null) localVarQueryParams.Add("carrier_id", Configuration.ApiClient.ParameterToString(carrierId)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter

            // authentication (Vericred-Api-Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Vericred-Api-Key")))
            {
                localVarHeaderParams["Vericred-Api-Key"] = Configuration.GetApiKeyWithPrefix("Vericred-Api-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListNetworks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NetworkSearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NetworkSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NetworkSearchResponse)));
            
        }

    }
}