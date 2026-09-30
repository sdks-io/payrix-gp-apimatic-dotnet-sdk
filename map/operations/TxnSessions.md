<!-- Generated file — do not edit; regenerated with the SDK. -->

# TxnSessions — operations

Accessor: `client.TxnSessions` · Source: `Api/TxnSessions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTxnSessionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteTxnSessionsId(DeleteTxnSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TxnSessionsResponseResult`
- **Error**: `ApiException<DeleteTxnSessionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTxnSessionsIdRequest` | `Requests/TxnSessions/DeleteTxnSessionsIdRequest.cs` |
| `TxnSessionsResponseResult` | `Models/TxnSessionsResponseResult.cs` |
| `DeleteTxnSessionsIdError` | `Errors/DeleteTxnSessionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTxnSessions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnSessions(GetTxnSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TxnSessionsResponseResult`
- **Error**: `ApiException<GetTxnSessionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnSessionsRequest` | `Requests/TxnSessions/GetTxnSessionsRequest.cs` |
| `TxnSessionsResponseResult` | `Models/TxnSessionsResponseResult.cs` |
| `GetTxnSessionsError` | `Errors/GetTxnSessionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTxnSessionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnSessionsId(GetTxnSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TxnSessionsResponseResult`
- **Error**: `ApiException<GetTxnSessionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnSessionsIdRequest` | `Requests/TxnSessions/GetTxnSessionsIdRequest.cs` |
| `TxnSessionsResponseResult` | `Models/TxnSessionsResponseResult.cs` |
| `GetTxnSessionsIdError` | `Errors/GetTxnSessionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTxnSessions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTxnSessions(PostTxnSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TxnSessionsResponseResult`
- **Error**: `ApiException<PostTxnSessionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTxnSessionsRequest` | `Requests/TxnSessions/PostTxnSessionsRequest.cs` |
| `TxnSessionsPostRequest` | `Models/TxnSessionsPostRequest.cs` |
| `TxnSessionsResponseResult` | `Models/TxnSessionsResponseResult.cs` |
| `PostTxnSessionsError` | `Errors/PostTxnSessionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

