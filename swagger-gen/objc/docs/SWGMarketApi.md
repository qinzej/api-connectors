# SWGMarketApi

All URIs are relative to *https://api-testnet.bybit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**marketOrderbook**](SWGMarketApi.md#marketorderbook) | **GET** /v2/public/orderBook/L2 | Get the orderbook.
[**marketSymbolInfo**](SWGMarketApi.md#marketsymbolinfo) | **GET** /v2/public/tickers | Get the latest information for symbol.


# **marketOrderbook**
```objc
-(NSURLSessionTask*) marketOrderbookWithSymbol: (NSString*) symbol
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

Get the orderbook.

### Example 
```objc

NSString* symbol = @"symbol_example"; // Contract type.

SWGMarketApi*apiInstance = [[SWGMarketApi alloc] init];

// Get the orderbook.
[apiInstance marketOrderbookWithSymbol:symbol
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGMarketApi->marketOrderbook: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **NSString***| Contract type. | 

### Return type

**NSObject***

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **marketSymbolInfo**
```objc
-(NSURLSessionTask*) marketSymbolInfoWithSymbol: (NSString*) symbol
        completionHandler: (void (^)(NSObject* output, NSError* error)) handler;
```

Get the latest information for symbol.

### Example 
```objc

NSString* symbol = @"symbol_example"; // Contract type. (optional)

SWGMarketApi*apiInstance = [[SWGMarketApi alloc] init];

// Get the latest information for symbol.
[apiInstance marketSymbolInfoWithSymbol:symbol
          completionHandler: ^(NSObject* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGMarketApi->marketSymbolInfo: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **NSString***| Contract type. | [optional] 

### Return type

**NSObject***

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

