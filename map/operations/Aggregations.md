<!-- Generated file — do not edit; regenerated with the SDK. -->

# Aggregations — operations

Accessor: `client.Aggregations` · Source: `Api/Aggregations.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAggregationsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAggregationsId(DeleteAggregationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AggregationsResponseResult`
- **Error**: `ApiException<DeleteAggregationsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAggregationsIdRequest` | `Requests/Aggregations/DeleteAggregationsIdRequest.cs` |
| `AggregationsResponseResult` | `Models/AggregationsResponseResult.cs` |
| `DeleteAggregationsIdError` | `Errors/DeleteAggregationsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAggregations

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAggregations(GetAggregationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AggregationsResponseResult`
- **Error**: `ApiException<GetAggregationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAggregationsRequest` | `Requests/Aggregations/GetAggregationsRequest.cs` |
| `AggregationsResponseResult` | `Models/AggregationsResponseResult.cs` |
| `GetAggregationsError` | `Errors/GetAggregationsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAggregationsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAggregationsId(GetAggregationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AggregationsResponseResult`
- **Error**: `ApiException<GetAggregationsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAggregationsIdRequest` | `Requests/Aggregations/GetAggregationsIdRequest.cs` |
| `AggregationsResponseResult` | `Models/AggregationsResponseResult.cs` |
| `GetAggregationsIdError` | `Errors/GetAggregationsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostAggregations

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostAggregations(PostAggregationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AggregationsResponseResult`
- **Error**: `ApiException<PostAggregationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAggregationsRequest` | `Requests/Aggregations/PostAggregationsRequest.cs` |
| `AggregationsPostRequest` | `Models/AggregationsPostRequest.cs` |
| `AggregationsResponseResult` | `Models/AggregationsResponseResult.cs` |
| `PostAggregationsError` | `Errors/PostAggregationsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutAggregationsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutAggregationsId(PutAggregationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AggregationsResponseResult`
- **Error**: `ApiException<PutAggregationsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutAggregationsIdRequest` | `Requests/Aggregations/PutAggregationsIdRequest.cs` |
| `AggregationsPutRequest` | `Models/AggregationsPutRequest.cs` |
| `AggregationsResponseResult` | `Models/AggregationsResponseResult.cs` |
| `PutAggregationsIdError` | `Errors/PutAggregationsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

