<!-- Generated file — do not edit; regenerated with the SDK. -->

# TeamLogins — operations

Accessor: `client.TeamLogins` · Source: `Api/TeamLogins.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTeamLoginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteTeamLoginsId(DeleteTeamLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TeamLoginResponseResult`
- **Error**: `ApiException<DeleteTeamLoginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTeamLoginsIdRequest` | `Requests/TeamLogins/DeleteTeamLoginsIdRequest.cs` |
| `TeamLoginResponseResult` | `Models/TeamLoginResponseResult.cs` |
| `DeleteTeamLoginsIdError` | `Errors/DeleteTeamLoginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTeamLogins

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTeamLogins(GetTeamLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TeamLoginResponseResult`
- **Error**: `ApiException<GetTeamLoginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTeamLoginsRequest` | `Requests/TeamLogins/GetTeamLoginsRequest.cs` |
| `TeamLoginResponseResult` | `Models/TeamLoginResponseResult.cs` |
| `GetTeamLoginsError` | `Errors/GetTeamLoginsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTeamLoginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTeamLoginsId(GetTeamLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TeamLoginResponseResult`
- **Error**: `ApiException<GetTeamLoginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTeamLoginsIdRequest` | `Requests/TeamLogins/GetTeamLoginsIdRequest.cs` |
| `TeamLoginResponseResult` | `Models/TeamLoginResponseResult.cs` |
| `GetTeamLoginsIdError` | `Errors/GetTeamLoginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTeamLogins

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTeamLogins(PostTeamLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TeamLoginResponseResult`
- **Error**: `ApiException<PostTeamLoginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTeamLoginsRequest` | `Requests/TeamLogins/PostTeamLoginsRequest.cs` |
| `TeamLoginPostRequest` | `Models/TeamLoginPostRequest.cs` |
| `TeamLoginResponseResult` | `Models/TeamLoginResponseResult.cs` |
| `PostTeamLoginsError` | `Errors/PostTeamLoginsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutTeamLoginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutTeamLoginsId(PutTeamLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TeamLoginResponseResult`
- **Error**: `ApiException<PutTeamLoginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutTeamLoginsIdRequest` | `Requests/TeamLogins/PutTeamLoginsIdRequest.cs` |
| `TeamLoginPutRequest` | `Models/TeamLoginPutRequest.cs` |
| `TeamLoginResponseResult` | `Models/TeamLoginResponseResult.cs` |
| `PutTeamLoginsIdError` | `Errors/PutTeamLoginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

