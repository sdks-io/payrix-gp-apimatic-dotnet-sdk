<!-- Generated file — do not edit; regenerated with the SDK. -->

# MerchantResults — operations

Accessor: `client.MerchantResults` · Source: `Api/MerchantResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMerchantResults(GetMerchantResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `MerchantResultsResponseResult`
- **Error**: `ApiException<GetMerchantResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantResultsRequest` | `Requests/MerchantResults/GetMerchantResultsRequest.cs` |
| `MerchantResultsResponseResult` | `Models/MerchantResultsResponseResult.cs` |
| `GetMerchantResultsError` | `Errors/GetMerchantResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMerchantResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMerchantResultsId(GetMerchantResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `MerchantResultsResponseResult`
- **Error**: `ApiException<GetMerchantResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantResultsIdRequest` | `Requests/MerchantResults/GetMerchantResultsIdRequest.cs` |
| `MerchantResultsResponseResult` | `Models/MerchantResultsResponseResult.cs` |
| `GetMerchantResultsIdError` | `Errors/GetMerchantResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

