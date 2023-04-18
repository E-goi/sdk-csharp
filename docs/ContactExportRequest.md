
# org.egoi.client.api.Model.ContactExportRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | File extension to export contacts | 
**CallbackUrl** | **string** | Url to receive the callback &lt;a href&#x3D;&#39;/usecases/callbacks/#exports-a-list-of-contacts&#39; target&#x3D;&#39;_blank&#39;&gt;[Go to callback documentation]&lt;/a&gt; | [optional] 
**Segments** | **List&lt;string&gt;** | Array of segment IDs to filter contacts to export. ***Note:*** segments of type ***auto*** and  ***tag*** are not yet supported but they are expected to be supported soon! | [optional] 
**Fields** | **List&lt;string&gt;** | Array of field IDs to be displayed in the exported file | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

