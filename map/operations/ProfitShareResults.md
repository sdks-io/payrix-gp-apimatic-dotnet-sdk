<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProfitShareResults — operations

Accessor: `client.ProfitShareResults` · Source: `Api/ProfitShareResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetProfitShareResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetProfitShareResults(GetProfitShareResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ProfitShareResultsResponseResult`
- **Error**: `ApiException<GetProfitShareResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProfitShareResultsRequest` | `Requests/ProfitShareResults/GetProfitShareResultsRequest.cs` |
| `ProfitShareResultsResponseResult` | `Models/ProfitShareResultsResponseResult.cs` |
| `GetProfitShareResultsError` | `Errors/GetProfitShareResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetProfitShareResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetProfitShareResultsId(GetProfitShareResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ProfitShareResultsResponseResult`
- **Error**: `ApiException<GetProfitShareResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetProfitShareResultsIdRequest` | `Requests/ProfitShareResults/GetProfitShareResultsIdRequest.cs` |
| `ProfitShareResultsResponseResult` | `Models/ProfitShareResultsResponseResult.cs` |
| `GetProfitShareResultsIdError` | `Errors/GetProfitShareResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

