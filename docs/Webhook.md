
# org.egoi.client.api.Model.Webhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebhookId** | **int** |  | [optional] [readonly] 
**ListId** | **int** |  | 
**Url** | **string** | Url to send the webhook &lt;a href&#x3D;&#39;/usecases/webhooks/&#39; target&#x3D;&#39;_blank&#39;&gt;[Go to webhooks documentation]&lt;/a&gt;:  *       Note: Only &#39;http&#39; or &#39;https&#39; protocols are supported. | 
**Actions** | [**List&lt;WebhookActionSchema&gt;**](WebhookActionSchema.md) | Action that will trigger the webhook | 
**Fields** | **List&lt;string&gt;** | Array of contact field IDs to be displayed in the webhook | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

