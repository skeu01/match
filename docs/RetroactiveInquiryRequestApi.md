# Acme.App.MastercardApi.Client.Api.RetroactiveInquiryRequestApi

All URIs are relative to *https://api.mastercard.com/fraud/merchant/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetroRetroListPost**](RetroactiveInquiryRequestApi.md#retroretrolistpost) | **POST** /retro/retro-list | ##### The retroactive inquiry helps acquirer to retrieve list of termination inquiry matches made within 360 days of inquiry initiation.


<a name="retroretrolistpost"></a>
# **RetroRetroListPost**
> RetroResponseSchema RetroRetroListPost (string format, RetroRequestSchema retroRequestSchema)

##### The retroactive inquiry helps acquirer to retrieve list of termination inquiry matches made within 360 days of inquiry initiation.

Return the summary of Retroactive Inquiry matches for the given Acquirer. Even if initial inquiry (TerminationInquiryRequest) does not result in a possible match, there after it's still possible that the merchant listing could appear sometime in the next 360 days. This may occur when another/same acquirer enters the merchant into the MATCH database. The system will automatically continue to search the MATCH system for 360 days. To view these notifications, acquirers must use the Retroactive Inquiry service. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) <br><br> #### Note: (a)  Each day, MATCH automatically conducts a retroactive Inquiry search on every merchant on which the acquirer has submitted an inquiry. MATCH automatically deletes each retroactive inquiry match after seven days. Therefore, acquirers should view retroactive inquiries every day to be sure that they do not miss a possible match. <br> (b)  When there are no results for RetroActive inquiry, users will get in response HTTP status code of 400 and a response code of “RESPONSE_DATA_NORESULT”. For information around all error codes refer [Code and Formats](/match/documentation/code-and-formats) documentation page <br><br> To understand the working of RetroActive API use case, follow the steps mentioned below: <br> 1.  Acquirer A (AcquirerId = 1996) uses a TerminationInquiryRequest for a merchant “X Inc”  but doesn’t find a match. <br> 2.  Within the next 360 days, same/another Acquirer (use same AcquirerId = 1996, as we have only one acquirer in sandbox) adds a terminated merchant “X Inc”, who matches the search parameters used by Acquirer A.  <br> 3.  After adding the merchant, it takes one day for Match Service to process retroactive inquiry match. <br> 4.  Post processing, within the next 7 days, Acquirer A should use the Retroactive Inquiry API to retrieve a list of retroactive matches.  <br> 5.  This list of retroactive inquiry matches includes an Inquiry reference number, which the Acquirer A can use to get more details of match using RetroActive Inquiry Details API.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class RetroRetroListPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/fraud/merchant/v3";
            var apiInstance = new RetroactiveInquiryRequestApi(config);
            var format = JSON;  // string | Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.
            var retroRequestSchema = new RetroRequestSchema(); // RetroRequestSchema | The retro request object

            try
            {
                // ##### The retroactive inquiry helps acquirer to retrieve list of termination inquiry matches made within 360 days of inquiry initiation.
                RetroResponseSchema result = apiInstance.RetroRetroListPost(format, retroRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetroactiveInquiryRequestApi.RetroRetroListPost: " + e.Message );
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
 **retroRequestSchema** | [**RetroRequestSchema**](RetroRequestSchema.md)| The retro request object | 

### Return type

[**RetroResponseSchema**](RetroResponseSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The retroactive request response object. |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

