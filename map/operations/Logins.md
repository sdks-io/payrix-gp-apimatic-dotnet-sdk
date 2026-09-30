<!-- Generated file — do not edit; regenerated with the SDK. -->

# Logins — operations

Accessor: `client.Logins` · Source: `Api/Logins.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteLoginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteLoginsId(DeleteLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `LoginsResponseResult`
- **Error**: `ApiException<DeleteLoginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLoginsIdRequest` | `Requests/Logins/DeleteLoginsIdRequest.cs` |
| `LoginsResponseResult` | `Models/LoginsResponseResult.cs` |
| `DeleteLoginsIdError` | `Errors/DeleteLoginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetLogins

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetLogins(GetLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `LoginsResponseResult`
- **Error**: `ApiException<GetLoginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoginsRequest` | `Requests/Logins/GetLoginsRequest.cs` |
| `LoginsResponseResult` | `Models/LoginsResponseResult.cs` |
| `GetLoginsError` | `Errors/GetLoginsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetLoginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetLoginsId(GetLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `LoginsResponseResult`
- **Error**: `ApiException<GetLoginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoginsIdRequest` | `Requests/Logins/GetLoginsIdRequest.cs` |
| `LoginsResponseResult` | `Models/LoginsResponseResult.cs` |
| `GetLoginsIdError` | `Errors/GetLoginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostLogins

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostLogins(PostLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LoginsResponseResult`
- **Error**: `ApiException<PostLoginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostLoginsRequest` | `Requests/Logins/PostLoginsRequest.cs` |
| `LoginsPostRequest` | `Models/LoginsPostRequest.cs` |
| `LoginsResponseResult` | `Models/LoginsResponseResult.cs` |
| `PostLoginsError` | `Errors/PostLoginsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutLoginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutLoginsId(PutLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `LoginsResponseResult`
- **Error**: `ApiException<PutLoginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutLoginsIdRequest` | `Requests/Logins/PutLoginsIdRequest.cs` |
| `LoginsPutRequest` | `Models/LoginsPutRequest.cs` |
| `LoginsResponseResult` | `Models/LoginsResponseResult.cs` |
| `PutLoginsIdError` | `Errors/PutLoginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

