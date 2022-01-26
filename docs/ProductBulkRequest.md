
# org.egoi.client.api.Model.ProductBulkRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Products** | [**List&lt;Product&gt;**](Product.md) | Collection of products to import. Products having an incorrect format will be ignored | 
**Mode** | **string** | How the import will be processed:  *                      &#39;rewrite&#39; - catalog content will be erased and then the imported products will be added  *                      &#39;add&#39; - adds imported products to the catalog without replacing any content. Duplicates will                         not be added  *                      &#39;update&#39; - adds imported products to the catalog and updates any duplicates found | [optional] [default to ModeEnum.Update]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

