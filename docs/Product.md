
# org.egoi.client.api.Model.Product

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Categories** | **List&lt;string&gt;** | Array of product categories, using the character &#39;&gt;&#39; as delimiter for the breadcrumb                                 syntax | [optional] 
**RelatedProducts** | **List&lt;string&gt;** | Related products, array of &#39;product_identifier&#39; | [optional] 
**CustomAttributes** | [**List&lt;ProductCustomAttributes&gt;**](ProductCustomAttributes.md) | Custom attributes | [optional] 
**ProductIdentifier** | **string** | The ID of the product in your store | [optional] 
**CatalogId** | **int** |  | [optional] [readonly] 
**Name** | **string** | Name of the product | [optional] 
**Description** | **string** | Description of the product | [optional] 
**Sku** | **string** | Stock Keeping Unit | [optional] 
**Upc** | **string** | Universal Product Code | [optional] 
**Ean** | **string** | European Article Numbering | [optional] 
**Gtin** | **string** | Global Trade Item Number | [optional] 
**Mpn** | **string** | Manufacturer Part Number | [optional] 
**Link** | **string** | Link for the product | [optional] 
**ImageLink** | **string** | Link for the product image | [optional] 
**Price** | **double** | Price of the product | [optional] [default to 0D]
**SalePrice** | **double** | Sale price of the product | [optional] [default to 0D]
**Brand** | **string** | Brand of the product | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

