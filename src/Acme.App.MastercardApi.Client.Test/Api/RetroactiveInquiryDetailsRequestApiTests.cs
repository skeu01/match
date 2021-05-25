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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Api;
// uncomment below to import models
//using Acme.App.MastercardApi.Client.Model;

namespace Acme.App.MastercardApi.Client.Test.Api
{
    /// <summary>
    ///  Class for testing RetroactiveInquiryDetailsRequestApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RetroactiveInquiryDetailsRequestApiTests : IDisposable
    {
        private RetroactiveInquiryDetailsRequestApi instance;

        public RetroactiveInquiryDetailsRequestApiTests()
        {
            instance = new RetroactiveInquiryDetailsRequestApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RetroactiveInquiryDetailsRequestApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RetroactiveInquiryDetailsRequestApi
            //Assert.IsType<RetroactiveInquiryDetailsRequestApi>(instance);
        }

        /// <summary>
        /// Test RetroRetroInquiryDetailsPost
        /// </summary>
        [Fact]
        public void RetroRetroInquiryDetailsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string format = null;
            //string acquirerId = null;
            //RetroInquiryRequestSchema retroInquiryRequestSchema = null;
            //var response = instance.RetroRetroInquiryDetailsPost(format, acquirerId, retroInquiryRequestSchema);
            //Assert.IsType<RetroInquiryResponseSchema>(response);
        }
    }
}