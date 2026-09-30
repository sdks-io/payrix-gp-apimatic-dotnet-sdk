<!-- Generated file — do not edit; regenerated with the SDK. -->

# BatchesSettlements — operations

Accessor: `client.BatchesSettlements` · Source: `Api/BatchesSettlements.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetBatches

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetBatches(GetBatchesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `BatchesResponseResult`
- **Error**: `ApiException<GetBatchesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBatchesRequest` | `Requests/BatchesSettlements/GetBatchesRequest.cs` |
| `BatchesResponseResult` | `Models/BatchesResponseResult.cs` |
| `GetBatchesError` | `Errors/GetBatchesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetBatchesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetBatchesId(GetBatchesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `BatchesResponseResult`
- **Error**: `ApiException<GetBatchesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBatchesIdRequest` | `Requests/BatchesSettlements/GetBatchesIdRequest.cs` |
| `BatchesResponseResult` | `Models/BatchesResponseResult.cs` |
| `GetBatchesIdError` | `Errors/GetBatchesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostBatches

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostBatches(PostBatchesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchesResponseResult`
- **Error**: `ApiException<PostBatchesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBatchesRequest` | `Requests/BatchesSettlements/PostBatchesRequest.cs` |
| `BatchesPostRequest` | `Models/BatchesPostRequest.cs` |
| `BatchesResponseResult` | `Models/BatchesResponseResult.cs` |
| `PostBatchesError` | `Errors/PostBatchesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutBatchesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutBatchesId(PutBatchesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `BatchesResponseResult`
- **Error**: `ApiException<PutBatchesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutBatchesIdRequest` | `Requests/BatchesSettlements/PutBatchesIdRequest.cs` |
| `BatchesPutRequest` | `Models/BatchesPutRequest.cs` |
| `BatchesResponseResult` | `Models/BatchesResponseResult.cs` |
| `PutBatchesIdError` | `Errors/PutBatchesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

