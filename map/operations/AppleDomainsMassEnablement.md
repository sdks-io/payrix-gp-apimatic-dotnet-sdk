<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppleDomainsMassEnablement — operations

Accessor: `client.AppleDomainsMassEnablement` · Source: `Api/AppleDomainsMassEnablement.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostApplePayForCsv

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostApplePayForCsv(PostApplePayForCsvRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `ContentType`
- **Returns**: `AppleDomainsMassEnablementCsvResponseResult`
- **Error**: `ApiException<PostApplePayForCsvError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostApplePayForCsvRequest` | `Requests/AppleDomainsMassEnablement/PostApplePayForCsvRequest.cs` |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AppleDomainsMassEnablementCsvResponseResult` | `Models/AppleDomainsMassEnablementCsvResponseResult.cs` |
| `PostApplePayForCsvError` | `Errors/PostApplePayForCsvError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostApplePayForMerchantList

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostApplePayForMerchantList(PostApplePayForMerchantListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AppleDomainsMassEnablementForMerchantList`
- **Error**: `ApiException<PostApplePayForMerchantListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostApplePayForMerchantListRequest` | `Requests/AppleDomainsMassEnablement/PostApplePayForMerchantListRequest.cs` |
| `ApplePayForMerchantListPostRequest` | `Models/ApplePayForMerchantListPostRequest.cs` |
| `AppleDomainsMassEnablementForMerchantList` | `Models/AppleDomainsMassEnablementForMerchantList.cs` |
| `PostApplePayForMerchantListError` | `Errors/PostApplePayForMerchantListError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostApplePayForMerchantListDisable

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostApplePayForMerchantListDisable(PostApplePayForMerchantListDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AppleDomainsMassEnablementForMerchantList`
- **Error**: `ApiException<PostApplePayForMerchantListDisableError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostApplePayForMerchantListDisableRequest` | `Requests/AppleDomainsMassEnablement/PostApplePayForMerchantListDisableRequest.cs` |
| `ApplePayForMerchantListPostRequest` | `Models/ApplePayForMerchantListPostRequest.cs` |
| `AppleDomainsMassEnablementForMerchantList` | `Models/AppleDomainsMassEnablementForMerchantList.cs` |
| `PostApplePayForMerchantListDisableError` | `Errors/PostApplePayForMerchantListDisableError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostUpdateApplePayDomain

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostUpdateApplePayDomain(PostUpdateApplePayDomainRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `UpdateApplePayDomainResponseResult`
- **Error**: `ApiException<PostUpdateApplePayDomainError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostUpdateApplePayDomainRequest` | `Requests/AppleDomainsMassEnablement/PostUpdateApplePayDomainRequest.cs` |
| `UpdateApplePayDomainPostRequest` | `Models/UpdateApplePayDomainPostRequest.cs` |
| `UpdateApplePayDomainResponseResult` | `Models/UpdateApplePayDomainResponseResult.cs` |
| `PostUpdateApplePayDomainError` | `Errors/PostUpdateApplePayDomainError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

