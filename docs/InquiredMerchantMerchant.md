# Acme.App.MastercardApi.Client.Model.InquiredMerchantMerchant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the Business which has been terminated. | [optional] 
**DoingBusinessAsName** | **string** | The name used by a merchant that could be different from the legal name of the business. Such as Bait R Us instead of the legal name, The Bait Shop | [optional] 
**AddedByAcquirerID** | **string** | The Member ICA that has added the merchant to the MATCH system | [optional] 
**AddedOnDate** | **string** | The date on which the merchant was added to the MATCH system. Format MM/DD/YYYY | [optional] 
**PhoneNumber** | **string** | The Business or Merchant&#39;s phone number. | [optional] 
**AltPhoneNumber** | **string** | The Business or Merchant&#39;s alternate phone number. | [optional] 
**Address** | [**Address**](Address.md) |  | [optional] 
**CountrySubdivisionTaxId** | **string** | The Merchant&#39;s state tax ID; for the U.S region only. Return value will be hidden. | [optional] 
**NationalTaxId** | **string** | The National tax ID or business registration number. Return value will be hidden. | [optional] 
**ServiceProvLegal** | **string** | The name of the service provider associated with the merchant listed in the MATCH. | [optional] 
**ServiceProvDBA** | **string** | The name of the service provider associated with the merchant listed in the MATCH. | [optional] 
**TerminationReasonCode** | **string** | A two digit numeric code indication why a particular merchant was terminated.  01   Account Data Compromise, 02   Common Points of Purchase, 03   Laundering, 04   Excessive Chargebacks, 05   Excessive Fraud, 06   Reserved for Future Use, 07   Fraud Conviction, 08   MasterCard Questionable Merchant Audit Program, 09   Bankruptcy/Liquidation/Insolvency, 10   Violation of MasterCard Standards, 11   Merchant collusion, 12   PCI Data Security Standard, Noncompliance, 13   Illegal Transactions, 14   Identity Theft | [optional] 
**UrlGroup** | [**List&lt;UrlGroup&gt;**](UrlGroup.md) |  | [optional] 
**Url** | [**List&lt;Url&gt;**](Url.md) |  | [optional] 
**Principal** | [**List&lt;Principal&gt;**](Principal.md) |  | [optional] 
**SearchCriteria** | [**SearchCriteria**](SearchCriteria.md) |  | [optional] 
**MerchantMatch** | [**MerchantMatch**](MerchantMatch.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

