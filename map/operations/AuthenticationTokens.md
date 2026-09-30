<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthenticationTokens — operations

Accessor: `client.AuthenticationTokens` · Source: `Api/AuthenticationTokens.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAuthTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAuthTokensId(DeleteAuthTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AuthTokensResponseResult`
- **Error**: `ApiException<DeleteAuthTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAuthTokensIdRequest` | `Requests/AuthenticationTokens/DeleteAuthTokensIdRequest.cs` |
| `AuthTokensResponseResult` | `Models/AuthTokensResponseResult.cs` |
| `DeleteAuthTokensIdError` | `Errors/DeleteAuthTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAuthTokens

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAuthTokens(GetAuthTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AuthTokensResponseResult`
- **Error**: `ApiException<GetAuthTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAuthTokensRequest` | `Requests/AuthenticationTokens/GetAuthTokensRequest.cs` |
| `AuthTokensResponseResult` | `Models/AuthTokensResponseResult.cs` |
| `GetAuthTokensError` | `Errors/GetAuthTokensError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAuthTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAuthTokensId(GetAuthTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AuthTokensResponseResult`
- **Error**: `ApiException<GetAuthTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAuthTokensIdRequest` | `Requests/AuthenticationTokens/GetAuthTokensIdRequest.cs` |
| `AuthTokensResponseResult` | `Models/AuthTokensResponseResult.cs` |
| `GetAuthTokensIdError` | `Errors/GetAuthTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostAuthTokens

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostAuthTokens(PostAuthTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AuthTokensResponseResult`
- **Error**: `ApiException<PostAuthTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAuthTokensRequest` | `Requests/AuthenticationTokens/PostAuthTokensRequest.cs` |
| `AuthTokensPostRequest` | `Models/AuthTokensPostRequest.cs` |
| `AuthTokensResponseResult` | `Models/AuthTokensResponseResult.cs` |
| `PostAuthTokensError` | `Errors/PostAuthTokensError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutAuthTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutAuthTokensId(PutAuthTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AuthTokensResponseResult`
- **Error**: `ApiException<PutAuthTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutAuthTokensIdRequest` | `Requests/AuthenticationTokens/PutAuthTokensIdRequest.cs` |
| `AuthTokensPutRequest` | `Models/AuthTokensPutRequest.cs` |
| `AuthTokensResponseResult` | `Models/AuthTokensResponseResult.cs` |
| `PutAuthTokensIdError` | `Errors/PutAuthTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

