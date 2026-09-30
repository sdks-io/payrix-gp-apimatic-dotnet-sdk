<!-- Generated file — do not edit; regenerated with the SDK. -->

# AggregationResults — operations

Accessor: `client.AggregationResults` · Source: `Api/AggregationResults.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAggregationResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAggregationResultsId(DeleteAggregationResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AggregationResultsResponseResult`
- **Error**: `ApiException<DeleteAggregationResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAggregationResultsIdRequest` | `Requests/AggregationResults/DeleteAggregationResultsIdRequest.cs` |
| `AggregationResultsResponseResult` | `Models/AggregationResultsResponseResult.cs` |
| `DeleteAggregationResultsIdError` | `Errors/DeleteAggregationResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAggregationResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAggregationResults(GetAggregationResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AggregationResultsResponseResult`
- **Error**: `ApiException<GetAggregationResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAggregationResultsRequest` | `Requests/AggregationResults/GetAggregationResultsRequest.cs` |
| `AggregationResultsResponseResult` | `Models/AggregationResultsResponseResult.cs` |
| `GetAggregationResultsError` | `Errors/GetAggregationResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAggregationResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAggregationResultsId(GetAggregationResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AggregationResultsResponseResult`
- **Error**: `ApiException<GetAggregationResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAggregationResultsIdRequest` | `Requests/AggregationResults/GetAggregationResultsIdRequest.cs` |
| `AggregationResultsResponseResult` | `Models/AggregationResultsResponseResult.cs` |
| `GetAggregationResultsIdError` | `Errors/GetAggregationResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

