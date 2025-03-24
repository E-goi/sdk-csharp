
# org.egoi.client.api.Model.ImportBulkRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Add new contacts only (&#39;add&#39;), add and replace existing ones (&#39;update&#39;) or only replace existing ones (&#39;update_only&#39;) | 
**CompareField** | **string** | Field ID which will be mapped for comparison to prevent duplicates. Field must be set as unique in E-goi. | 
**Contacts** | [**List&lt;ContactBulk&gt;**](ContactBulk.md) | Array of contacts to import | 
**ForceEmpty** | **bool** | If &#39;true&#39; accepts empty values and erases those fields | [optional] [default to false]
**Notify** | **List&lt;int&gt;** | Array of IDs of the users to notify | [optional] 
**CallbackUrl** | **string** | Url to receive the report &lt;a href&#x3D;&#39;/usecases/callbacks/#import-collection-of-contacts&#39; target&#x3D;&#39;_blank&#39;&gt;[Go to callback documentation]&lt;/a&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

