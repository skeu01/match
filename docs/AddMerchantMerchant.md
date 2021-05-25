# Acme.App.MastercardApi.Client.Model.AddMerchantMerchant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the Business which has been terminated. | 
**DoingBusinessAsName** | **string** | The name used by a merchant that could be different from the legal name of the business. Such as Bait R Us instead of the legal name, The Bait Shop | [optional] 
**MerchantId** | **string** | The identifier assigned to a merchant by an Acquirer. An Acquirer Id and Merchant Id combination must be unique and Merchant Id should be less than 15 characters. | 
**MerchantCategory** | **string** | A classification code used in authorization, clearing, and other transactions or reports to identify the type of merchant. | 
**Address** | [**Address**](Address.md) |  | [optional] 
**PhoneNumber** | **string** | The Business or Merchant&#39;s phone number. | 
**AltPhoneNumber** | **string** | The Business or Merchant&#39;s alternate phone number. | [optional] 
**NationalTaxId** | **string** | The National tax ID or business registration number. Return value will be hidden. | [optional] 
**CountrySubdivisionTaxId** | **string** | The Merchant&#39;s state tax ID; for the U.S region only. Return value will be hidden. | [optional] 
**CATFlag** | **string** | Cardholder-activated terminal indicator. | 
**DateOpened** | **string** | Date the merchant entered into agreement with the acquirer | 
**DateClosed** | **string** | Date the agreement was terminated with the merchant | 
**ServiceProvLegal** | **string** | The name of the service provider associated with the merchant listed in the MATCH. | [optional] 
**ServiceProvDBA** | **string** | The name of the service provider associated with the merchant listed in the MATCH. | [optional] 
**Url** | **List&lt;string&gt;** | Website address of the merchant. A request may include multiple URLs . The total cumulative size of the URLs cannot exceed 20000 bytes. | [optional] 
**Principal** | [**List&lt;Principal&gt;**](Principal.md) |  | [optional] 
**ReasonCode** | **string** | A two digit numeric code indication why a particular merchant was terminated.  01   Account Data Compromise, 02   Common Points of Purchase, 03   Laundering, 04   Excessive Chargebacks, 05   Excessive Fraud, 06   Reserved for Future Use, 07   Fraud Conviction, 08   MasterCard Questionable Merchant Audit Program, 09   Bankruptcy/Liquidation/Insolvency, 10   Violation of MasterCard Standards, 11   Merchant collusion, 12   PCI Data Security Standard, Noncompliance, 13   Illegal Transactions, 14   Identity Theft | 
**Comments** | **string** | Brief comments on why Merchant is added | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

