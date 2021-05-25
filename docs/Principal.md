# Acme.App.MastercardApi.Client.Model.Principal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The first name of the principal owner of the business. | 
**MiddleInitial** | **string** | THe middle initial of the name of the principal owner of the business. | [optional] 
**LastName** | **string** | The last name of the principal owner of the business. | 
**Address** | [**Address**](Address.md) |  | [optional] 
**PhoneNumber** | **string** | The Business or Merchant&#39;s phone number, including the area code. Within the USA, phone numbers have a length of 10, and for outside the US, it can be any length with a maximum of 12 digits. Within the U.S. phone numbers can not start with 0 or 1. If the number is outside the U.S. region; do not include the country code. The phone number must be digits only, with no format characters such as parenthesis or dashes. | [optional] 
**AltPhoneNumber** | **string** | The Business or Merchant&#39;s alternate phone number, including the area code. Within the USA, phone numbers have a length of 10, and for out outside the US, a max length of 25. Within the U.S. phone numbers can not start with 0 or 1. If the number is outside the U.S. region; do not include the country code. The number must be digits only, with no format characters such as parenthesis or dashes. | [optional] 
**NationalId** | **string** | The Social Security number of a principal owner. If the principal owner is not from the U.S. Region, then use their national ID card number. | [optional] 
**DriversLicense** | [**DriversLicense**](DriversLicense.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

