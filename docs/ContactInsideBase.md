
# org.egoi.client.api.Model.ContactInsideBase

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactId** | **string** |  | [optional] [readonly] 
**Status** | **string** | Status of the contact | [optional] [default to StatusEnum.Active]
**Consent** | **string** | Contact consent | [optional] [readonly] [default to ConsentEnum.Consent]
**ConsentDate** | **string** | Date and hour of the contact consent | [optional] [readonly] 
**SubscriptionMethod** | **string** | Contact subscription method | [optional] [readonly] 
**SubscriptionDate** | **string** | Date and hour of the contact subscription | [optional] [readonly] 
**SubscriptionForm** | **int** | Contact subscription form | [optional] [readonly] 
**UnsubscriptionMethod** | **string** | Contact unsubscription method | [optional] [readonly] 
**UnsubscriptionReason** | **string** | Contact unsubscription reason | [optional] [readonly] 
**UnsubscriptionObservation** | **string** | Contact unsubscription observation | [optional] [readonly] 
**UnsubscriptionDate** | **string** | Contact unsubscription date | [optional] [readonly] 
**ChangeDate** | **DateTime** | Last modification date of the contact | [optional] [readonly] 
**FirstName** | **string** | First name of the contact | [optional] 
**LastName** | **string** | Last name of the contact | [optional] 
**BirthDate** | **DateTime** | Birth date of the contact | [optional] 
**Language** | [**Language**](Language.md) |  | [optional] 
**Email** | **string** | Email of the contact | [optional] 
**EmailStatus** | **string** | Email channel status | [optional] [readonly] [default to EmailStatusEnum.Active]
**Cellphone** | **string** | Cellphone of the contact | [optional] 
**CellphoneStatus** | **string** | Cellphone channel status | [optional] [readonly] [default to CellphoneStatusEnum.Active]
**Phone** | **string** | Phone of the contact | [optional] 
**PhoneStatus** | **string** | Phone channel status | [optional] [readonly] [default to PhoneStatusEnum.Active]
**PushTokenAndroid** | [**List&lt;ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid&gt;**](ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid.md) | Android push token of the contact | [optional] 
**PushTokenIos** | [**List&lt;ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos&gt;**](ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos.md) | IOS push token of the contact | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

