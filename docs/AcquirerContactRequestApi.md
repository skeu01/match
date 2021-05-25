# Acme.App.MastercardApi.Client.Api.AcquirerContactRequestApi

All URIs are relative to *https://api.mastercard.com/fraud/merchant/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommonContactDetailsPost**](AcquirerContactRequestApi.md#commoncontactdetailspost) | **POST** /common/contact-details | ##### Retrieve contact information of another acquirer.


<a name="commoncontactdetailspost"></a>
# **CommonContactDetailsPost**
> ContactResponseSchema CommonContactDetailsPost (string format, ContactRequestSchema contactRequestSchema)

##### Retrieve contact information of another acquirer.

Returns the contact information for the acquirer id requested. When MATCH returns a possible merchant match, this resource assists users by retrieving the contact information associated with the Acquirer ID/ICA that added the merchant to MATCH. For further details refer the documentation on [Use Cases.](/match/documentation/use-cases)  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class CommonContactDetailsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/fraud/merchant/v3";
            var apiInstance = new AcquirerContactRequestApi(config);
            var format = JSON;  // string | Describes format of the response you wants to serverd, response can be delevired either as XML or JSON.
            var contactRequestSchema = new ContactRequestSchema(); // ContactRequestSchema | The contact request object

            try
            {
                // ##### Retrieve contact information of another acquirer.
                ContactResponseSchema result = apiInstance.CommonContactDetailsPost(format, contactRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AcquirerContactRequestApi.CommonContactDetailsPost: " + e.Message );
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
 **contactRequestSchema** | [**ContactRequestSchema**](ContactRequestSchema.md)| The contact request object | 

### Return type

[**ContactResponseSchema**](ContactResponseSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The acquirer contact response object. |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

