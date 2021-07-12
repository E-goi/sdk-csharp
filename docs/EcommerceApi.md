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


<a name="createcart"></a>
# **CreateCart**
> AcceptedResponse CreateCart (string domain, Cart cart)

Create cart

Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we'll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list's unique fields**). This same logic is also applied to the **product_identifier**.

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateCartExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var domain = domain_example;  // string | Domain
            var cart = new Cart(); // Cart | Parameters for the Carts

            try
            {
                // Create cart
                AcceptedResponse result = apiInstance.CreateCart(domain, cart);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateCart: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcatalog"></a>
# **CreateCatalog**
> Catalog CreateCatalog (CatalogPostRequest catalogPostRequest)

Create new catalog

Creates a new catalog

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateCatalogExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogPostRequest = new CatalogPostRequest(); // CatalogPostRequest | Parameters for the Catalog

            try
            {
                // Create new catalog
                Catalog result = apiInstance.CreateCatalog(catalogPostRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateCatalog: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorder"></a>
# **CreateOrder**
> AcceptedResponse CreateOrder (string domain, CreateOrder createOrder)

Create order

Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we'll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list's unique fields***). This same logic is also applied to the **product_identifier**.

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var domain = domain_example;  // string | Domain
            var createOrder = new CreateOrder(); // CreateOrder | Parameters for the Orders

            try
            {
                // Create order
                AcceptedResponse result = apiInstance.CreateOrder(domain, createOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateOrder: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproduct"></a>
# **CreateProduct**
> Product CreateProduct (int? catalogId, ProductPostRequest productPostRequest)

Create new product

Creates a new product

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateProductExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogId = 56;  // int? | ID of the Catalog
            var productPostRequest = new ProductPostRequest(); // ProductPostRequest | Parameters for the Product

            try
            {
                // Create new product
                Product result = apiInstance.CreateProduct(catalogId, productPostRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int?**| ID of the Catalog | 
 **productPostRequest** | [**ProductPostRequest**](ProductPostRequest.md)| Parameters for the Product | 

### Return type

[**Product**](Product.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecatalog"></a>
# **DeleteCatalog**
> void DeleteCatalog (int? catalogId)

Remove catalog

Remove catalog information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteCatalogExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogId = 56;  // int? | ID of the Catalog

            try
            {
                // Remove catalog
                apiInstance.DeleteCatalog(catalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.DeleteCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int?**| ID of the Catalog | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproduct"></a>
# **DeleteProduct**
> void DeleteProduct (int? catalogId, string productIdentifier)

Remove product

Remove product information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteProductExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogId = 56;  // int? | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | ID of the Product

            try
            {
                // Remove product
                apiInstance.DeleteProduct(catalogId, productIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.DeleteProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int?**| ID of the Catalog | 
 **productIdentifier** | **string**| ID of the Product | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcatalogs"></a>
# **GetAllCatalogs**
> CatalogCollection GetAllCatalogs ()

Get all catalogs

Returns all catalogs

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllCatalogsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();

            try
            {
                // Get all catalogs
                CatalogCollection result = apiInstance.GetAllCatalogs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetAllCatalogs: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallproducts"></a>
# **GetAllProducts**
> ProductCollection GetAllProducts (int? catalogId, string productIdentifier = null, int? offset = null, int? limit = null)

Get all products

Returns all products for the given catalog

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllProductsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogId = 56;  // int? | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | Product ID in your store (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)

            try
            {
                // Get all products
                ProductCollection result = apiInstance.GetAllProducts(catalogId, productIdentifier, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetAllProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int?**| ID of the Catalog | 
 **productIdentifier** | **string**| Product ID in your store | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]

### Return type

[**ProductCollection**](ProductCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproduct"></a>
# **GetProduct**
> Product GetProduct (int? catalogId, string productIdentifier)

Get product

Returns product information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetProductExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogId = 56;  // int? | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | ID of the Product

            try
            {
                // Get product
                Product result = apiInstance.GetProduct(catalogId, productIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int?**| ID of the Catalog | 
 **productIdentifier** | **string**| ID of the Product | 

### Return type

[**Product**](Product.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importproducts"></a>
# **ImportProducts**
> AcceptedResponse ImportProducts (int? catalogId, ProductBulkRequest productBulkRequest)

Import products

Imports a collection of products</br>      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits 'Stream Limits')

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ImportProductsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogId = 56;  // int? | ID of the Catalog
            var productBulkRequest = new ProductBulkRequest(); // ProductBulkRequest | Parameters for the Product

            try
            {
                // Import products
                AcceptedResponse result = apiInstance.ImportProducts(catalogId, productBulkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.ImportProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int?**| ID of the Catalog | 
 **productBulkRequest** | [**ProductBulkRequest**](ProductBulkRequest.md)| Parameters for the Product | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproduct"></a>
# **UpdateProduct**
> Product UpdateProduct (int? catalogId, string productIdentifier, ProductPatchRequest productPatchRequest)

Update product

Updates a product

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class UpdateProductExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EcommerceApi();
            var catalogId = 56;  // int? | ID of the Catalog
            var productIdentifier = productIdentifier_example;  // string | ID of the Product
            var productPatchRequest = new ProductPatchRequest(); // ProductPatchRequest | Parameters for the product

            try
            {
                // Update product
                Product result = apiInstance.UpdateProduct(catalogId, productIdentifier, productPatchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.UpdateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogId** | **int?**| ID of the Catalog | 
 **productIdentifier** | **string**| ID of the Product | 
 **productPatchRequest** | [**ProductPatchRequest**](ProductPatchRequest.md)| Parameters for the product | 

### Return type

[**Product**](Product.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

