using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;

using Mastercard.Developer.OAuth1Signer.Core.Utils;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Mastercard.Developer.ClientEncryption.Core.Encryption;
using Mastercard.Developer.ClientEncryption.Core.Utils;
using static Mastercard.Developer.ClientEncryption.Core.Encryption.FieldLevelEncryptionConfig;
using Mastercard.Developer.ClientEncryption.RestSharpV2.Interceptors;
using Acme.App.MastercardApi.Client.Model;
using System.Collections.Generic;
using System;

namespace restapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchController : ControllerBase
    {


        [HttpGet]
        public async Task<string> GetAll()
        {
            try
            {
                const string basePath = "https://sandbox.api.mastercard.com/fraud/merchant/v3";
                const string consumerKey = "SzEgt0H8GjUQLU3Of6Lvvk3Z0yQKnlIRpHE3cmGZ70d34e17!eba69350a15543c78e5d75b3845015cb0000000000000000";

                int pageOffset = 0;
                int pageLength = 10;
                string format = "JSON";

                Merchant merchant = new Merchant(
                    name: "THE BAIT SHOP",
                    doingBusinessAsName: "BAIT R US",
                    phoneNumber: "3165557625",
                    altPhoneNumber: "3165557625",
                    nationalTaxId: "888596927",
                    countrySubdivisionTaxId: "492321030",
                    serviceProvLegal: "XYZ FINANCIAL SERVICE INCORPORATED",
                    serviceProvDBA: "XYZ FINANCIAL SERVICE",
                    url: new List<string> { "www.testmerchant.com" }
                );

                merchant.Address = new Address(

                    line1: "42 ELM AVENUE",
                    line2: "SUITE 201",
                    city: "DALLAS",
                    countrySubdivision: "IL",
                    province: "US",
                    postalCode: "66579",
                    country: "USA"
                );

                merchant.Principal = new List<Principal>
            {
                new Principal(

                    firstName: "DAVID",
                    middleInitial: "P",
                    lastName: "SMITH",
                    address: new Address
                    (
                        line1: "42 ELM AVENUE",
                        line2: "SUITE 201",
                        city: "DALLAS",
                        countrySubdivision: "IL",
                        province: "US",
                        postalCode: "66579",
                        country: "USA"
                    ),
                    phoneNumber: "3165557625",
                    altPhoneNumber: "3165557625",
                    nationalId: "541022104",
                    driversLicense: new DriversLicense
                    (
                        number: "M15698025",
                        countrySubdivision: "IL",
                        country: "USA"
                    )
                )
            };


                TerminationInquiryRequest terminationInquiryRequest = new TerminationInquiryRequest("1996", merchant);

                TerminationInquiryRequestSchema terminationInquiryRequestSchema = new TerminationInquiryRequestSchema(terminationInquiryRequest);
                //terminationInquiryRequestSchema.TerminationInquiryRequest = new TerminationInquiryRequest("1996", merchant);

                var signingKey = AuthenticationUtils.LoadSigningKey("Match_Test-sandbox.p12",
                   "keyalias",
                   "keystorepassword",
                   X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable
               );

                var client = new ApiClient(signingKey, basePath, consumerKey);
                TerminationInquiryRequestApi instance = new TerminationInquiryRequestApi(new Configuration { });


                var fieldLevelEncryptionConfig = FieldLevelEncryptionConfigBuilder
                    .AFieldLevelEncryptionConfig()
                    .WithOaepPaddingDigestAlgorithm("SHA-256")
                    .WithIvFieldName("iv")
                    .WithEncryptedValueFieldName("encryptedValue")
                    .WithEncryptedKeyFieldName("encryptedKey")
                    .Build();

                client.EncryptionInterceptor = new RestSharpFieldLevelEncryptionInterceptor(fieldLevelEncryptionConfig);

                instance.Client = client;

                var response = await instance.TerminationInquiryPostAsync(pageOffset, pageLength, format, terminationInquiryRequestSchema);
                return response.TerminationInquiry.ToJson();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
