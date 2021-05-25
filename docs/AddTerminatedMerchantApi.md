# Acme.App.MastercardApi.Client.Api.AddTerminatedMerchantApi

All URIs are relative to *https://api.mastercard.com/fraud/merchant/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMerchantPost**](AddTerminatedMerchantApi.md#addmerchantpost) | **POST** /add-merchant | ##### Adds a new terminated merchant to MATCH system.


<a name="addmerchantpost"></a>
# **AddMerchantPost**
> AddTerminatedMerchantResponseSchema AddMerchantPost (string format, AddTerminatedMerchantRequestSchema addTerminatedMerchantRequestSchema)

##### Adds a new terminated merchant to MATCH system.

Used by Acquirers to add a terminated a merchant in the MATCH system. Merchant information, and up to five principal owners per merchant, can be provided by an acquiring bank as part of the listing. For adding a terminated merchant,  Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class AddMerchantPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/fraud/merchant/v3";
            var apiInstance = new AddTerminatedMerchantApi(config);
            var format = JSON;  // string | Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.
            var addTerminatedMerchantRequestSchema = new AddTerminatedMerchantRequestSchema(); // AddTerminatedMerchantRequestSchema | Body of the Add Terminated Merchant Request

            try
            {
                // ##### Adds a new terminated merchant to MATCH system.
                AddTerminatedMerchantResponseSchema result = apiInstance.AddMerchantPost(format, addTerminatedMerchantRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddTerminatedMerchantApi.AddMerchantPost: " + e.Message );
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
 **addTerminatedMerchantRequestSchema** | [**AddTerminatedMerchantRequestSchema**](AddTerminatedMerchantRequestSchema.md)| Body of the Add Terminated Merchant Request | 

### Return type

[**AddTerminatedMerchantResponseSchema**](AddTerminatedMerchantResponseSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The add terminated merchant response object. |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

