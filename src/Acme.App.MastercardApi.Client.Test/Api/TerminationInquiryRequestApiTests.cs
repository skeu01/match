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
    ///  Class for testing TerminationInquiryRequestApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TerminationInquiryRequestApiTests : IDisposable
    {
        private TerminationInquiryRequestApi instance;

        public TerminationInquiryRequestApiTests()
        {
            instance = new TerminationInquiryRequestApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TerminationInquiryRequestApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TerminationInquiryRequestApi
            //Assert.IsType<TerminationInquiryRequestApi>(instance);
        }

        /// <summary>
        /// Test TerminationInquiryPost
        /// </summary>
        [Fact]
        public void TerminationInquiryPostTest()
        {
            //TODO uncomment below to test the method and replace null with proper value
            //int pageOffset = null;
            //int pageLength = null;
            //string format = null;
            //TerminationInquiryRequestSchema terminationInquiryRequestSchema = null;
            //var response = instance.TerminationInquiryPost(pageOffset, pageLength, format, terminationInquiryRequestSchema);
            //Assert.IsType<TerminationInquirySchema>(response);
        }
    }
}