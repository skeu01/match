# Acme.App.MastercardApi.Client.Model.DriversLicense

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | The drivers license number of a principal owner. Required when Drivers License Country is provided. Should not be provided if Drivers License Country is not provided. | [optional] 
**CountrySubdivision** | **string** | The abbreviated state or province code for a merchant location (only supported for US and Canada merchants).  Required when Drivers License Country is &#39;USA&#39; . Should not be provided for non-US Drivers License Country. | [optional] 
**Country** | **string** | The three digit country code of the principal owner. Valid values are Three digit alpha country codes as defined in ISO 3166-1. Required when Drivers License Number is provided. Should not be provided if Drivers License Number is not provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

