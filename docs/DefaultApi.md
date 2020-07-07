# template.api.httpclient.Api.DefaultApi

All URIs are relative to *http://localhost:3000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppControllerGet**](DefaultApi.md#appcontrollerget) | **GET** /api | 
[**AppControllerGetVersion**](DefaultApi.md#appcontrollergetversion) | **GET** /api/version | 



## AppControllerGet

> PackageJson AppControllerGet ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using template.api.httpclient.Api;
using template.api.httpclient.Client;
using template.api.httpclient.Model;

namespace Example
{
    public class AppControllerGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:3000";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                PackageJson result = apiInstance.AppControllerGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerGet: " + e.Message );
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

[**PackageJson**](PackageJson.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppControllerGetVersion

> string AppControllerGetVersion ()



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using template.api.httpclient.Api;
using template.api.httpclient.Client;
using template.api.httpclient.Model;

namespace Example
{
    public class AppControllerGetVersionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:3000";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                string result = apiInstance.AppControllerGetVersion();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.AppControllerGetVersion: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

