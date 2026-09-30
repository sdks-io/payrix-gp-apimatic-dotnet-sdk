<!-- Generated file — do not edit; regenerated with the SDK. -->

# MerchantPlatformStatuses — operations

Accessor: `client.MerchantPlatformStatuses` · Source: `Api/MerchantPlatformStatuses.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantPlatformStatuses

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMerchantPlatformStatuses(GetMerchantPlatformStatusesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `MerchantPlatformStatusesResponseResult`
- **Error**: `ApiException<GetMerchantPlatformStatusesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantPlatformStatusesRequest` | `Requests/MerchantPlatformStatuses/GetMerchantPlatformStatusesRequest.cs` |
| `MerchantPlatformStatusesResponseResult` | `Models/MerchantPlatformStatusesResponseResult.cs` |
| `GetMerchantPlatformStatusesError` | `Errors/GetMerchantPlatformStatusesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMerchantPlatformStatusesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMerchantPlatformStatusesId(GetMerchantPlatformStatusesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `MerchantPlatformStatusesResponseResult`
- **Error**: `ApiException<GetMerchantPlatformStatusesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantPlatformStatusesIdRequest` | `Requests/MerchantPlatformStatuses/GetMerchantPlatformStatusesIdRequest.cs` |
| `MerchantPlatformStatusesResponseResult` | `Models/MerchantPlatformStatusesResponseResult.cs` |
| `GetMerchantPlatformStatusesIdError` | `Errors/GetMerchantPlatformStatusesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

