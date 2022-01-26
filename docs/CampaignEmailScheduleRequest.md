
# org.egoi.client.api.Model.CampaignEmailScheduleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleDate** | **DateTime** | The date and time | [optional] 
**ListId** | **int** |  | 
**Segments** | [**EmailSendSegment**](EmailSendSegment.md) |  | 
**Notify** | **List&lt;int&gt;** | Array of IDs of the users to notify | [optional] 
**DestinationField** | **string** | Destination field of this campaign, which must be an email field (email or extra field id).                         If not sent, defaults to the general email field | [optional] 
**UniqueContactsOnly** | **bool** | True to send the campaign only to unique contacts | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

