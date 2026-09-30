<!-- Generated file — do not edit; regenerated with the SDK. -->

# AggregationResultGroups — operations

Accessor: `client.AggregationResultGroups` · Source: `Api/AggregationResultGroups.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAggregationResultGroupsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAggregationResultGroupsId(DeleteAggregationResultGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AggregationResultsGroupsResponseResult`
- **Error**: `ApiException<DeleteAggregationResultGroupsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAggregationResultGroupsIdRequest` | `Requests/AggregationResultGroups/DeleteAggregationResultGroupsIdRequest.cs` |
| `AggregationResultsGroupsResponseResult` | `Models/AggregationResultsGroupsResponseResult.cs` |
| `DeleteAggregationResultGroupsIdError` | `Errors/DeleteAggregationResultGroupsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAggregationResultGroups

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAggregationResultGroups(GetAggregationResultGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AggregationResultsGroupsResponseResult`
- **Error**: `ApiException<GetAggregationResultGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAggregationResultGroupsRequest` | `Requests/AggregationResultGroups/GetAggregationResultGroupsRequest.cs` |
| `AggregationResultsGroupsResponseResult` | `Models/AggregationResultsGroupsResponseResult.cs` |
| `GetAggregationResultGroupsError` | `Errors/GetAggregationResultGroupsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAggregationResultGroupsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAggregationResultGroupsId(GetAggregationResultGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AggregationResultsGroupsResponseResult`
- **Error**: `ApiException<GetAggregationResultGroupsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAggregationResultGroupsIdRequest` | `Requests/AggregationResultGroups/GetAggregationResultGroupsIdRequest.cs` |
| `AggregationResultsGroupsResponseResult` | `Models/AggregationResultsGroupsResponseResult.cs` |
| `GetAggregationResultGroupsIdError` | `Errors/GetAggregationResultGroupsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

