
# org.egoi.client.api.Model.CampaignVoiceSendRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListId** | **int** |  | 
**DestinationField** | **string** | Destination field of this campaign | 
**UniqueContactsOnly** | **bool** | True to send the campaign only to unique contacts | [optional] [default to false]
**Segments** | [**OSegmentsActionSend**](OSegmentsActionSend.md) |  | 
**Notify** | **List&lt;int&gt;** | Array of IDs of the users to notify | [optional] 
**LimitContacts** | [**OLimitContactsActionSend**](OLimitContactsActionSend.md) |  | [optional] 
**LimitHour** | [**LimitHourActionSendLimitHour**](LimitHourActionSendLimitHour.md) |  | [optional] 
**LimitSpeed** | **int** | Speed limit to send the campaign | [optional] 
**ScheduleDate** | **DateTime** | The date and time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

