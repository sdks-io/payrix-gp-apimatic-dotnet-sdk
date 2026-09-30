<!-- Generated file — do not edit; regenerated with the SDK. -->

# Tokens — operations

Accessor: `client.Tokens` · Source: `Api/Tokens.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteTokensId(DeleteTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TokensResponseResult`
- **Error**: `ApiException<DeleteTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTokensIdRequest` | `Requests/Tokens/DeleteTokensIdRequest.cs` |
| `TokensResponseResult` | `Models/TokensResponseResult.cs` |
| `DeleteTokensIdError` | `Errors/DeleteTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTokens

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTokens(GetTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TokensResponseResult`
- **Error**: `ApiException<GetTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTokensRequest` | `Requests/Tokens/GetTokensRequest.cs` |
| `TokensResponseResult` | `Models/TokensResponseResult.cs` |
| `GetTokensError` | `Errors/GetTokensError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTokensId(GetTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TokensResponseResult`
- **Error**: `ApiException<GetTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTokensIdRequest` | `Requests/Tokens/GetTokensIdRequest.cs` |
| `TokensResponseResult` | `Models/TokensResponseResult.cs` |
| `GetTokensIdError` | `Errors/GetTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTokens

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTokens(PostTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TokensResponseResult`
- **Error**: `ApiException<PostTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTokensRequest` | `Requests/Tokens/PostTokensRequest.cs` |
| `TokenPostRequest` | `Models/TokenPostRequest.cs` |
| `TokensResponseResult` | `Models/TokensResponseResult.cs` |
| `PostTokensError` | `Errors/PostTokensError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutTokensId(PutTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TokensResponseResult`
- **Error**: `ApiException<PutTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutTokensIdRequest` | `Requests/Tokens/PutTokensIdRequest.cs` |
| `TokenPutRequest` | `Models/TokenPutRequest.cs` |
| `TokensResponseResult` | `Models/TokensResponseResult.cs` |
| `PutTokensIdError` | `Errors/PutTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

