<!-- Generated file — do not edit; regenerated with the SDK. -->

# TaxFormRequests — operations

Accessor: `client.TaxFormRequests` · Source: `Api/TaxFormRequests.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTaxFormRequests

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTaxFormRequests(GetTaxFormRequestsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TaxFormRequestsResponseResult`
- **Error**: `ApiException<GetTaxFormRequestsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTaxFormRequestsRequest` | `Requests/TaxFormRequests/GetTaxFormRequestsRequest.cs` |
| `TaxFormRequestsResponseResult` | `Models/TaxFormRequestsResponseResult.cs` |
| `GetTaxFormRequestsError` | `Errors/GetTaxFormRequestsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTaxFormRequestsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTaxFormRequestsId(GetTaxFormRequestsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TaxFormRequestsResponseResult`
- **Error**: `ApiException<GetTaxFormRequestsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTaxFormRequestsIdRequest` | `Requests/TaxFormRequests/GetTaxFormRequestsIdRequest.cs` |
| `TaxFormRequestsResponseResult` | `Models/TaxFormRequestsResponseResult.cs` |
| `GetTaxFormRequestsIdError` | `Errors/GetTaxFormRequestsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTaxFormRequests

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTaxFormRequests(PostTaxFormRequestsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TaxFormRequestsResponseResult`
- **Error**: `ApiException<PostTaxFormRequestsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTaxFormRequestsRequest` | `Requests/TaxFormRequests/PostTaxFormRequestsRequest.cs` |
| `TaxFormRequestsPostRequest` | `Models/TaxFormRequestsPostRequest.cs` |
| `TaxFormRequestsResponseResult` | `Models/TaxFormRequestsResponseResult.cs` |
| `PostTaxFormRequestsError` | `Errors/PostTaxFormRequestsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

