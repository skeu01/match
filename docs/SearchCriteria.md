# Acme.App.MastercardApi.Client.Model.SearchCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchAll** | **string** | Determines if the inquiry is worldwide or not.  The Inquiry request can be either worldwide or Regions and/or Countries based. It cannot be both.  If it is not worldwide search (SearchAll &#x3D; N) and if both  Region and Country are not specified, then search will happen for USA | 
**Region** | **List&lt;string&gt;** |  | [optional] 
**Country** | **List&lt;string&gt;** |  | [optional] 
**MinPossibleMatchCount** | **string** | Determines how many minimum matches present for a merchant or inquiry to appear in the results. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

