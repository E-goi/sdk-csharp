
# org.egoi.client.api.Model.ContactBaseWithStatusFieldsSchemaBase

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactId** | **string** |  | [optional] [readonly] 
**Status** | **string** | Status of the contact | [optional] [default to StatusEnum.Active]
**Consent** | **string** | Contact consent | [optional] 
**FirstName** | **string** | First name of the contact | [optional] 
**LastName** | **string** | Last name of the contact | [optional] 
**BirthDate** | **DateTime** | Birth date of the contact | [optional] 
**Language** | [**Language**](Language.md) |  | [optional] 
**Email** | **string** | Email of the contact | [optional] 
**EmailStatus** | **string** | Email channel status | [optional] 
**Cellphone** | **string** | Cellphone of the contact | [optional] 
**CellphoneStatus** | **string** | Cellphone channel status | [optional] 
**Phone** | **string** | Phone of the contact | [optional] 
**PhoneStatus** | **string** | Phone channel status | [optional] 
**PushTokenAndroid** | [**List&lt;ContactBaseWithStatusFieldsSchemaBasePushTokenAndroid&gt;**](ContactBaseWithStatusFieldsSchemaBasePushTokenAndroid.md) | Android push token of the contact | [optional] 
**PushTokenIos** | [**List&lt;ContactBaseWithStatusFieldsSchemaBasePushTokenIos&gt;**](ContactBaseWithStatusFieldsSchemaBasePushTokenIos.md) | IOS push token of the contact | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

