
# org.egoi.client.api.Model.CampaignSmartSmsSendRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListId** | **int** |  | 
**DestinationField** | **string** | Smart SMS campaign destination field. Must be &#39;cellphone&#39; or the other field ID of type                                 cellphone | 
**Segments** | [**SmartSmsSegmentsActionSend**](SmartSmsSegmentsActionSend.md) |  | 
**LimitHour** | [**LimitHourActionSendLimitHour**](LimitHourActionSendLimitHour.md) |  | [optional] 
**Notify** | **List&lt;int&gt;** | Array of IDs of the users to notify | [optional] 
**ScheduleDate** | **DateTime** | The date and time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

