<!-- Generated file — do not edit; regenerated with the SDK. -->

# DisbursementResults — operations

Accessor: `client.DisbursementResults` · Source: `Api/DisbursementResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDisbursementResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDisbursementResults(GetDisbursementResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `DisbursementResultsResponseResult`
- **Error**: `ApiException<GetDisbursementResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisbursementResultsRequest` | `Requests/DisbursementResults/GetDisbursementResultsRequest.cs` |
| `DisbursementResultsResponseResult` | `Models/DisbursementResultsResponseResult.cs` |
| `GetDisbursementResultsError` | `Errors/GetDisbursementResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDisbursementResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDisbursementResultsId(GetDisbursementResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `DisbursementResultsResponseResult`
- **Error**: `ApiException<GetDisbursementResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisbursementResultsIdRequest` | `Requests/DisbursementResults/GetDisbursementResultsIdRequest.cs` |
| `DisbursementResultsResponseResult` | `Models/DisbursementResultsResponseResult.cs` |
| `GetDisbursementResultsIdError` | `Errors/GetDisbursementResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

