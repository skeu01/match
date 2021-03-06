/*
 * MATCH API
 *
 * Helps acquirers identify potentially high-risk merchants before entering to a merchant agreement.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Acme.App.MastercardApi.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddTerminatedMerchantApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// ##### Adds a new terminated merchant to MATCH system.
        /// </summary>
        /// <remarks>
        /// Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <returns>AddTerminatedMerchantResponseSchema</returns>
        AddTerminatedMerchantResponseSchema AddMerchantPost(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema);

        /// <summary>
        /// ##### Adds a new terminated merchant to MATCH system.
        /// </summary>
        /// <remarks>
        /// Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <returns>ApiResponse of AddTerminatedMerchantResponseSchema</returns>
        ApiResponse<AddTerminatedMerchantResponseSchema> AddMerchantPostWithHttpInfo(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddTerminatedMerchantApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// ##### Adds a new terminated merchant to MATCH system.
        /// </summary>
        /// <remarks>
        /// Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddTerminatedMerchantResponseSchema</returns>
        System.Threading.Tasks.Task<AddTerminatedMerchantResponseSchema> AddMerchantPostAsync(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// ##### Adds a new terminated merchant to MATCH system.
        /// </summary>
        /// <remarks>
        /// Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </remarks>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddTerminatedMerchantResponseSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddTerminatedMerchantResponseSchema>> AddMerchantPostWithHttpInfoAsync(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddTerminatedMerchantApi : IAddTerminatedMerchantApiSync, IAddTerminatedMerchantApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddTerminatedMerchantApi : IAddTerminatedMerchantApi
    {
        private Acme.App.MastercardApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTerminatedMerchantApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddTerminatedMerchantApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTerminatedMerchantApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddTerminatedMerchantApi(String basePath)
        {
            this.Configuration = Acme.App.MastercardApi.Client.Client.Configuration.MergeConfigurations(
                Acme.App.MastercardApi.Client.Client.GlobalConfiguration.Instance,
                new Acme.App.MastercardApi.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Acme.App.MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Acme.App.MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Acme.App.MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTerminatedMerchantApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddTerminatedMerchantApi(Acme.App.MastercardApi.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Acme.App.MastercardApi.Client.Client.Configuration.MergeConfigurations(
                Acme.App.MastercardApi.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Acme.App.MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Acme.App.MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Acme.App.MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTerminatedMerchantApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AddTerminatedMerchantApi(Acme.App.MastercardApi.Client.Client.ISynchronousClient client, Acme.App.MastercardApi.Client.Client.IAsynchronousClient asyncClient, Acme.App.MastercardApi.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Acme.App.MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Acme.App.MastercardApi.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Acme.App.MastercardApi.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Acme.App.MastercardApi.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Acme.App.MastercardApi.Client.Client.ExceptionFactory ExceptionFactory
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
        /// ##### Adds a new terminated merchant to MATCH system. Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <returns>AddTerminatedMerchantResponseSchema</returns>
        public AddTerminatedMerchantResponseSchema AddMerchantPost(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema)
        {
            Acme.App.MastercardApi.Client.Client.ApiResponse<AddTerminatedMerchantResponseSchema> localVarResponse = AddMerchantPostWithHttpInfo(format, addTerminatedMerchantRequestSchema);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ##### Adds a new terminated merchant to MATCH system. Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <returns>ApiResponse of AddTerminatedMerchantResponseSchema</returns>
        public Acme.App.MastercardApi.Client.Client.ApiResponse<AddTerminatedMerchantResponseSchema> AddMerchantPostWithHttpInfo(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema)
        {
            // verify the required parameter 'format' is set
            if (format == null)
                throw new Acme.App.MastercardApi.Client.Client.ApiException(400, "Missing required parameter 'format' when calling AddTerminatedMerchantApi->AddMerchantPost");

            // verify the required parameter 'addTerminatedMerchantRequestSchema' is set
            if (addTerminatedMerchantRequestSchema == null)
                throw new Acme.App.MastercardApi.Client.Client.ApiException(400, "Missing required parameter 'addTerminatedMerchantRequestSchema' when calling AddTerminatedMerchantApi->AddMerchantPost");

            Acme.App.MastercardApi.Client.Client.RequestOptions localVarRequestOptions = new Acme.App.MastercardApi.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Acme.App.MastercardApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Acme.App.MastercardApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Acme.App.MastercardApi.Client.Client.ClientUtils.ParameterToMultiMap("", "Format", format));
            localVarRequestOptions.Data = addTerminatedMerchantRequestSchema;


            // make the HTTP request
            var localVarResponse = this.Client.Post<AddTerminatedMerchantResponseSchema>("/add-merchant", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddMerchantPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// ##### Adds a new terminated merchant to MATCH system. Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddTerminatedMerchantResponseSchema</returns>
        public async System.Threading.Tasks.Task<AddTerminatedMerchantResponseSchema> AddMerchantPostAsync(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Acme.App.MastercardApi.Client.Client.ApiResponse<AddTerminatedMerchantResponseSchema> localVarResponse = await AddMerchantPostWithHttpInfoAsync(format, addTerminatedMerchantRequestSchema, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// ##### Adds a new terminated merchant to MATCH system. Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 
        /// </summary>
        /// <exception cref="Acme.App.MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.</param>
        /// <param name="addTerminatedMerchantRequestSchema">Body of the Add Terminated Merchant Request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddTerminatedMerchantResponseSchema)</returns>
        public async System.Threading.Tasks.Task<Acme.App.MastercardApi.Client.Client.ApiResponse<AddTerminatedMerchantResponseSchema>> AddMerchantPostWithHttpInfoAsync(string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'format' is set
            if (format == null)
                throw new Acme.App.MastercardApi.Client.Client.ApiException(400, "Missing required parameter 'format' when calling AddTerminatedMerchantApi->AddMerchantPost");

            // verify the required parameter 'addTerminatedMerchantRequestSchema' is set
            if (addTerminatedMerchantRequestSchema == null)
                throw new Acme.App.MastercardApi.Client.Client.ApiException(400, "Missing required parameter 'addTerminatedMerchantRequestSchema' when calling AddTerminatedMerchantApi->AddMerchantPost");


            Acme.App.MastercardApi.Client.Client.RequestOptions localVarRequestOptions = new Acme.App.MastercardApi.Client.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Acme.App.MastercardApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Acme.App.MastercardApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Acme.App.MastercardApi.Client.Client.ClientUtils.ParameterToMultiMap("", "Format", format));
            localVarRequestOptions.Data = addTerminatedMerchantRequestSchema;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AddTerminatedMerchantResponseSchema>("/add-merchant", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddMerchantPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
