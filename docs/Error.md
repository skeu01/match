# Acme.App.MastercardApi.Client.Model.Error

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | This is the unique identifier that attempts to define the field in error when available.  If a specific field cant be identified System will be returned. | [optional] 
**ReasonCode** | **string** | This will identify the reason for the error. | [optional] 
**Description** | **string** | This is the text description of the error. This is optional and will only be displayed if more information is available than is stored in the data identifier and reason code. | [optional] 
**Recoverable** | **bool** | This is a true/false presentation to explain if the transaction was submitted again would it be successful or not. | [optional] 
**Details** | **string** | Details description of the issue | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

