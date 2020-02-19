# org.egoi.client.api.Model.ContactInsideBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactId** | **string** |  | [optional] 
**Status** | **string** | Status of the contact | [optional] [default to StatusEnum.Active]
**Consent** | **string** | Contact consent | [optional] [default to ConsentEnum.Consent]
**ConsentDate** | **DateTime?** | Date and hour of the contact consent | [optional] 
**SubscriptionMethod** | **string** | Contact subscription method | [optional] 
**SubscriptionDate** | **DateTime?** | Date and hour of the contact subscription | [optional] 
**SubscriptionForm** | **int?** | Contact subscription form | [optional] 
**UnsubscriptionMethod** | **string** | Contact unsubscription method | [optional] 
**UnsubscriptionReason** | **string** | Contact unsubscription reason | [optional] 
**UnsubscriptionObservation** | **string** | Contact unsubscription observation | [optional] 
**UnsubscriptionDate** | **DateTime?** | Contact unsubscription date | [optional] 
**ChangeDate** | **DateTime?** | Last modification date of the contact | [optional] 
**FirstName** | **string** | First name of the contact | [optional] 
**LastName** | **string** | Last name of the contact | [optional] 
**BirthDate** | **DateTime?** | Birth date of the contact | [optional] 
**Language** | [**Language**](Language.md) |  | [optional] 
**Email** | **string** | Email of the contact | [optional] 
**EmailStatus** | **string** | Email channel status | [optional] [default to EmailStatusEnum.Active]
**Cellphone** | **string** | Cellphone of the contact | [optional] 
**CellphoneStatus** | **string** | Cellphone channel status | [optional] [default to CellphoneStatusEnum.Active]
**Phone** | **string** | Phone of the contact | [optional] 
**PhoneStatus** | **string** | Phone channel status | [optional] [default to PhoneStatusEnum.Active]
**PushTokenAndroid** | [**List&lt;ContactBaseWithStatusFieldsSchemaBasePushTokenAndroid&gt;**](ContactBaseWithStatusFieldsSchemaBasePushTokenAndroid.md) | Android push token of the contact | [optional] 
**PushTokenIos** | [**List&lt;ContactBaseWithStatusFieldsSchemaBasePushTokenIos&gt;**](ContactBaseWithStatusFieldsSchemaBasePushTokenIos.md) | IOS push token of the contact | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

