# org.egoi.client.api.Api.EcommerceApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCart**](EcommerceApi.md#createcart) | **POST** /{domain}/carts | Create cart
[**CreateCatalog**](EcommerceApi.md#createcatalog) | **POST** /catalogs | Create new catalog
[**CreateOrder**](EcommerceApi.md#createorder) | **POST** /{domain}/orders | Create order
[**CreateProduct**](EcommerceApi.md#createproduct) | **POST** /catalogs/{catalog_id}/products | Create new product
[**DeleteCatalog**](EcommerceApi.md#deletecatalog) | **DELETE** /catalogs/{catalog_id} | Remove catalog
[**DeleteProduct**](EcommerceApi.md#deleteproduct) | **DELETE** /catalogs/{catalog_id}/products/{product_identifier} | Remove product
[**GetAllCatalogs**](EcommerceApi.md#getallcatalogs) | **GET** /catalogs | Get all catalogs
[**GetAllProducts**](EcommerceApi.md#getallproducts) | **GET** /catalogs/{catalog_id}/products | Get all products
[**GetProduct**](EcommerceApi.md#getproduct) | **GET** /catalogs/{catalog_id}/products/{product_identifier} | Get product
[**ImportProducts**](EcommerceApi.md#importproducts) | **POST** /catalogs/{catalog_id}/products/actions/import | Import products
[**UpdateProduct**](EcommerceApi.md#updateproduct) | **PATCH** /catalogs/{catalog_id}/products/{product_identifier} | Update product



## CreateCart

> AcceptedResponse CreateCart (string domain, Cart cart)

Create cart

Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we'll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list's unique fields**). This same logic is also applied to the **product_identifier**.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateCartExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var domain = domain_example;  // string | Domain
            var cart = new Cart(); // Cart | Parameters for the Carts

            try
            {
                // Create cart
                AcceptedResponse result = apiInstance.CreateCart(domain, cart);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateCart: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| Domain | 
 **cart** | [**Cart**](Cart.md)| Parameters for the Carts | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateCatalog

> Catalog CreateCatalog (CatalogPostRequest catalogPostRequest)

Create new catalog

Creates a new catalog

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateCatalogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogPostRequest = new CatalogPostRequest(); // CatalogPostRequest | Parameters for the Catalog

            try
            {
                // Create new catalog
                Catalog result = apiInstance.CreateCatalog(catalogPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateCatalog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogPostRequest** | [**CatalogPostRequest**](CatalogPostRequest.md)| Parameters for the Catalog | 

### Return type

[**Catalog**](Catalog.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateOrder

> AcceptedResponse CreateOrder (string domain, CreateOrder createOrder)

Create order

Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we'll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list's unique fields***). This same logic is also applied to the **product_identifier**.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var domain = domain_example;  // string | Domain
            var createOrder = new CreateOrder(); // CreateOrder | Parameters for the Orders

            try
            {
                // Create order
                AcceptedResponse result = apiInstance.CreateOrder(domain, createOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateOrder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| Domain | 
 **createOrder** | [**CreateOrder**](CreateOrder.md)| Parameters for the Orders | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateProduct

> Product CreateProduct (int catalogId, ProductPostRequest productPostRequest)

Create new product

Creates a new product

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateProductExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogId = 56;  // int | ID of the Catalog
            var productPostRequest = new ProductPostRequest(); // ProductPostRequest | Parameters for the Product

            try
            {
                // Create new product
                Product result = apiInstance.CreateProduct(catalogId, productPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateProduct: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| ID of the Catalog | 
 **productPostRequest** | [**ProductPostRequest**](ProductPostRequest.md)| Parameters for the Product | 

### Return type

[**Product**](Product.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCatalog

> void DeleteCatalog (int catalogId)

Remove catalog

Remove catalog information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteCatalogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogId = 56;  // int | ID of the Catalog

            try
            {
                // Remove catalog
                apiInstance.DeleteCatalog(catalogId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.DeleteCatalog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| ID of the Catalog | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteProduct

> void DeleteProduct (int catalogId, string productIdentifier)

Remove product

Remove product information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteProductExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogId = 56;  // int | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | ID of the Product

            try
            {
                // Remove product
                apiInstance.DeleteProduct(catalogId, productIdentifier);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.DeleteProduct: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| ID of the Catalog | 
 **productIdentifier** | **string**| ID of the Product | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllCatalogs

> CatalogCollection GetAllCatalogs ()

Get all catalogs

Returns all catalogs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllCatalogsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);

            try
            {
                // Get all catalogs
                CatalogCollection result = apiInstance.GetAllCatalogs();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetAllCatalogs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**CatalogCollection**](CatalogCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **408** | Request Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllProducts

> ProductCollection GetAllProducts (int catalogId, string productIdentifier = null, string name = null, string description = null, string sku = null, string upc = null, string ean = null, string gtin = null, string mpn = null, decimal? price = null, decimal? salePrice = null, string brand = null, CustomAttributes customAttributes = null, int? offset = null, int? limit = null)

Get all products

Returns all products for the given catalog

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllProductsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogId = 56;  // int | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | Filter by product ID in your store (optional) 
            var name = name_example;  // string | Filter by name of the product (optional) 
            var description = description_example;  // string | Filter by description of the product (optional) 
            var sku = sku_example;  // string | Filter by Stock Keeping Unit (optional) 
            var upc = upc_example;  // string | Filter by Universal Product Code (optional) 
            var ean = ean_example;  // string | Filter by European Article Numbering (optional) 
            var gtin = gtin_example;  // string | Filter by Global Trade Item Number (optional) 
            var mpn = mpn_example;  // string | Filter by Manufacturer Part Number (optional) 
            var price = 8.14;  // decimal? | Filter by price of the product (optional) 
            var salePrice = 8.14;  // decimal? | Filter by sale price of the product (optional) 
            var brand = brand_example;  // string | Filter by brand of the product (optional) 
            var customAttributes = new CustomAttributes(); // CustomAttributes | Filter by custom attributes of products<div><span class='sc-cJSrbW cWGDGi'> Example: </span> <span class='sc-uJMKN cTkJKI'> 'custom_attributes[alias]=value' </span></div> (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)

            try
            {
                // Get all products
                ProductCollection result = apiInstance.GetAllProducts(catalogId, productIdentifier, name, description, sku, upc, ean, gtin, mpn, price, salePrice, brand, customAttributes, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetAllProducts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| ID of the Catalog | 
 **productIdentifier** | **string**| Filter by product ID in your store | [optional] 
 **name** | **string**| Filter by name of the product | [optional] 
 **description** | **string**| Filter by description of the product | [optional] 
 **sku** | **string**| Filter by Stock Keeping Unit | [optional] 
 **upc** | **string**| Filter by Universal Product Code | [optional] 
 **ean** | **string**| Filter by European Article Numbering | [optional] 
 **gtin** | **string**| Filter by Global Trade Item Number | [optional] 
 **mpn** | **string**| Filter by Manufacturer Part Number | [optional] 
 **price** | **decimal?**| Filter by price of the product | [optional] 
 **salePrice** | **decimal?**| Filter by sale price of the product | [optional] 
 **brand** | **string**| Filter by brand of the product | [optional] 
 **customAttributes** | [**CustomAttributes**](CustomAttributes.md)| Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]

### Return type

[**ProductCollection**](ProductCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProduct

> Product GetProduct (int catalogId, string productIdentifier)

Get product

Returns product information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetProductExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogId = 56;  // int | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | ID of the Product

            try
            {
                // Get product
                Product result = apiInstance.GetProduct(catalogId, productIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetProduct: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| ID of the Catalog | 
 **productIdentifier** | **string**| ID of the Product | 

### Return type

[**Product**](Product.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportProducts

> AcceptedResponse ImportProducts (int catalogId, ProductBulkRequest productBulkRequest)

Import products

Imports a collection of products</br>      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits 'Stream Limits')

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ImportProductsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogId = 56;  // int | ID of the Catalog
            var productBulkRequest = new ProductBulkRequest(); // ProductBulkRequest | Parameters for the Product

            try
            {
                // Import products
                AcceptedResponse result = apiInstance.ImportProducts(catalogId, productBulkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.ImportProducts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| ID of the Catalog | 
 **productBulkRequest** | [**ProductBulkRequest**](ProductBulkRequest.md)| Parameters for the Product | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateProduct

> Product UpdateProduct (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest)

Update product

Updates a product

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class UpdateProductExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi(Configuration.Default);
            var catalogId = 56;  // int | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | ID of the Product
            var productPatchRequest = new ProductPatchRequest(); // ProductPatchRequest | Parameters for the product

            try
            {
                // Update product
                Product result = apiInstance.UpdateProduct(catalogId, productIdentifier, productPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcommerceApi.UpdateProduct: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int**| ID of the Catalog | 
 **productIdentifier** | **string**| ID of the Product | 
 **productPatchRequest** | [**ProductPatchRequest**](ProductPatchRequest.md)| Parameters for the product | 

### Return type

[**Product**](Product.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

