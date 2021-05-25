using System;
using Mastercard.Developer.OAuth1Signer.RestSharpV2.Signers;
using System.Security.Cryptography;
using RestSharp;
using Mastercard.Developer.ClientEncryption.RestSharpV2.Interceptors;

namespace Acme.App.MastercardApi.Client.Client
{
    partial class ApiClient
    {
        private Uri BasePath { get; }
        private RestSharpSigner Signer { get; }
        /// <summary>
        /// 
        /// </summary>
        public RestSharpFieldLevelEncryptionInterceptor EncryptionInterceptor { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signingKey"></param>
        /// <param name="basePath"></param>
        /// <param name="consumerKey"></param>
        public ApiClient(RSA signingKey, string basePath, string consumerKey)
        {
            this._baseUrl = basePath;
            this.BasePath = new Uri(basePath);
            this.Signer = new RestSharpSigner(consumerKey, signingKey);
        }

        partial void InterceptRequest(IRestRequest request)
        {
            EncryptionInterceptor.InterceptRequest(request);
            Signer.Sign(this.BasePath, request);
        }
    }
}
