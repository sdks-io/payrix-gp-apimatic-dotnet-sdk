<!-- Generated file — do not edit; regenerated with the SDK. -->

# MessageThreads — operations

Accessor: `client.MessageThreads` · Source: `Api/MessageThreads.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMessageThreads

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMessageThreads(GetMessageThreadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `MessageThreadsResponseResult`
- **Error**: `ApiException<GetMessageThreadsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMessageThreadsRequest` | `Requests/MessageThreads/GetMessageThreadsRequest.cs` |
| `MessageThreadsResponseResult` | `Models/MessageThreadsResponseResult.cs` |
| `GetMessageThreadsError` | `Errors/GetMessageThreadsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMessageThreadsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMessageThreadsId(GetMessageThreadsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `MessageThreadsResponseResult`
- **Error**: `ApiException<GetMessageThreadsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMessageThreadsIdRequest` | `Requests/MessageThreads/GetMessageThreadsIdRequest.cs` |
| `MessageThreadsResponseResult` | `Models/MessageThreadsResponseResult.cs` |
| `GetMessageThreadsIdError` | `Errors/GetMessageThreadsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutMessageThreadsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutMessageThreadsId(PutMessageThreadsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `MessageThreadsResponseResult`
- **Error**: `ApiException<PutMessageThreadsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutMessageThreadsIdRequest` | `Requests/MessageThreads/PutMessageThreadsIdRequest.cs` |
| `MessageThreadsPutRequest` | `Models/MessageThreadsPutRequest.cs` |
| `MessageThreadsResponseResult` | `Models/MessageThreadsResponseResult.cs` |
| `PutMessageThreadsIdError` | `Errors/PutMessageThreadsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

