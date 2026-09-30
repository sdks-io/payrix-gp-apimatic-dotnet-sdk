<!-- Generated file — do not edit; regenerated with the SDK. -->

# Sessions — operations

Accessor: `client.Sessions` · Source: `Api/Sessions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteSessionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteSessionsId(DeleteSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SessionsResponseResult`
- **Error**: `ApiException<DeleteSessionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSessionsIdRequest` | `Requests/Sessions/DeleteSessionsIdRequest.cs` |
| `SessionsResponseResult` | `Models/SessionsResponseResult.cs` |
| `DeleteSessionsIdError` | `Errors/DeleteSessionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSessions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSessions(GetSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `SessionsPostResponseResult`
- **Error**: `ApiException<GetSessionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSessionsRequest` | `Requests/Sessions/GetSessionsRequest.cs` |
| `SessionsPostResponseResult` | `Models/SessionsPostResponseResult.cs` |
| `GetSessionsError` | `Errors/GetSessionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSessionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSessionsId(GetSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `SessionsResponseResult`
- **Error**: `ApiException<GetSessionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSessionsIdRequest` | `Requests/Sessions/GetSessionsIdRequest.cs` |
| `SessionsResponseResult` | `Models/SessionsResponseResult.cs` |
| `GetSessionsIdError` | `Errors/GetSessionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostSessions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey` OR (`options.Username` AND `options.Password`)
- **Signature**: `PostSessions(PostSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SessionsResponseResult`
- **Error**: `ApiException<PostSessionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSessionsRequest` | `Requests/Sessions/PostSessionsRequest.cs` |
| `SessionsPostRequest` | `Models/SessionsPostRequest.cs` |
| `SessionsResponseResult` | `Models/SessionsResponseResult.cs` |
| `PostSessionsError` | `Errors/PostSessionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

