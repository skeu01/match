# Acme.App.MastercardApi.Client.Api.RetroactiveInquiryDetailsRequestApi

All URIs are relative to *https://api.mastercard.com/fraud/merchant/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetroRetroInquiryDetailsPost**](RetroactiveInquiryDetailsRequestApi.md#retroretroinquirydetailspost) | **POST** /retro/retro-inquiry-details | ##### Retrieve retro inquiry search results


<a name="retroretroinquirydetailspost"></a>
# **RetroRetroInquiryDetailsPost**
> RetroInquiryResponseSchema RetroRetroInquiryDetailsPost (string format, string acquirerId, RetroInquiryRequestSchema retroInquiryRequestSchema)

##### Retrieve retro inquiry search results

The acquirer uses the Retroactive Inquiry API to retrieve a list of Retroactive Inquiry Reference Numbers which matched the acquirer’s previous termination inquiries. The acquirer then uses Retroactive Inquiry Details API to fetch details of the matches for each from previous inquiries. Details about merchant match includes information, such as, if a Merchant has been terminated by another acquirer after an inquiry was made, the reason for termination, and the history of fraudulent or risky business practices that led to that termination. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class RetroRetroInquiryDetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/fraud/merchant/v3";
            var apiInstance = new RetroactiveInquiryDetailsRequestApi(config);
            var format = JSON;  // string | Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.
            var acquirerId = 1996;  // string | The Member ICA number which is used to validate that the application has permission to hit the MATCH database. This number must be obtained from a participating MATCH acquiring bank or entity before a developer can access the MATCH resource.
            var retroInquiryRequestSchema = new RetroInquiryRequestSchema(); // RetroInquiryRequestSchema | The retro inquiry request object

            try
            {
                // ##### Retrieve retro inquiry search results
                RetroInquiryResponseSchema result = apiInstance.RetroRetroInquiryDetailsPost(format, acquirerId, retroInquiryRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetroactiveInquiryDetailsRequestApi.RetroRetroInquiryDetailsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Describes format of the response you wants to serverd, response can be delevired either as XML or JSON. | 
 **acquirerId** | **string**| The Member ICA number which is used to validate that the application has permission to hit the MATCH database. This number must be obtained from a participating MATCH acquiring bank or entity before a developer can access the MATCH resource. | 
 **retroInquiryRequestSchema** | [**RetroInquiryRequestSchema**](RetroInquiryRequestSchema.md)| The retro inquiry request object | 

### Return type

[**RetroInquiryResponseSchema**](RetroInquiryResponseSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The retroactive inquiry response object. |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

