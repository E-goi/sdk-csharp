# org.egoi.client.api.Model.ImportOrdersBulkBulkRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Ecommerce order id | 
**ContactId** | **string** | Contact ID is any non-empty unique string identifying the user (such as an email address or e-goi uid) | [optional] 
**Revenue** | **decimal?** | Ecommerce order revenue | 
**StoreUrl** | **string** | Ecommerce store url | 
**Date** | **DateTime?** | Ecommerce order date (For technical reasons, all orders synchronized will have the date of synchronization.) | 
**Items** | [**List&lt;ImportOrdersBulkBulkRequestItems&gt;**](ImportOrdersBulkBulkRequestItems.md) | Array of ordered products | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

