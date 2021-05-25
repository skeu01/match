# Acme.App.MastercardApi.Client.Api.TerminationInquiryRequestApi

All URIs are relative to *https://api.mastercard.com/fraud/merchant/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TerminationInquiryPost**](TerminationInquiryRequestApi.md#terminationinquirypost) | **POST** /termination-inquiry | ##### Retrieves terminated merchant information based on the criteria defined in the API request.


<a name="terminationinquirypost"></a>
# **TerminationInquiryPost**
> TerminationInquirySchema TerminationInquiryPost (int pageOffset, int pageLength, string format, TerminationInquiryRequestSchema terminationInquiryRequestSchema)

##### Retrieves terminated merchant information based on the criteria defined in the API request.

Returns information on merchants that have been terminated and merchants which have been inquired upon. MATCH can provide the acquiring bank with information if a Merchant has been terminated by another acquirer already, the reason for termination, the history of fraudulent or risky business practices that led to that termination and the inquiry that was made already on the Merchant or individual by own or another acquiring bank. The response also includes an inquiry reference number to be used for future reference in Termination Inquiry History Request API. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class TerminationInquiryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/fraud/merchant/v3";
            var apiInstance = new TerminationInquiryRequestApi(config);
            var pageOffset = 0;  // int | The zero-based offset to start at. The actual start position is this value +1. An offset of 10 starts at item 11. Combined with the PageLength option this allows pagination to be supported through the service requests.
            var pageLength = 10;  // int | The maximum number of items to retrieve within the current \"page\" of results.
            var format = JSON;  // string | Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.
            var terminationInquiryRequestSchema = new TerminationInquiryRequestSchema(); // TerminationInquiryRequestSchema | Body of the Termination Inquiry Request

            try
            {
                // ##### Retrieves terminated merchant information based on the criteria defined in the API request.
                TerminationInquirySchema result = apiInstance.TerminationInquiryPost(pageOffset, pageLength, format, terminationInquiryRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TerminationInquiryRequestApi.TerminationInquiryPost: " + e.Message );
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
 **pageOffset** | **int**| The zero-based offset to start at. The actual start position is this value +1. An offset of 10 starts at item 11. Combined with the PageLength option this allows pagination to be supported through the service requests. | 
 **pageLength** | **int**| The maximum number of items to retrieve within the current \&quot;page\&quot; of results. | 
 **format** | **string**| Describes format of the response you wants to serverd, response can be delevired either as XML or JSON. | 
 **terminationInquiryRequestSchema** | [**TerminationInquiryRequestSchema**](TerminationInquiryRequestSchema.md)| Body of the Termination Inquiry Request | 

### Return type

[**TerminationInquirySchema**](TerminationInquirySchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The termination inquiry response object. |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

