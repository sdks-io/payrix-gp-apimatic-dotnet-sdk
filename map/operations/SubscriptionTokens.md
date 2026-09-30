<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionTokens — operations

Accessor: `client.SubscriptionTokens` · Source: `Api/SubscriptionTokens.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteSubscriptionTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteSubscriptionTokensId(DeleteSubscriptionTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SubscriptionTokensResponseResult`
- **Error**: `ApiException<DeleteSubscriptionTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSubscriptionTokensIdRequest` | `Requests/SubscriptionTokens/DeleteSubscriptionTokensIdRequest.cs` |
| `SubscriptionTokensResponseResult` | `Models/SubscriptionTokensResponseResult.cs` |
| `DeleteSubscriptionTokensIdError` | `Errors/DeleteSubscriptionTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSubscriptionTokens

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSubscriptionTokens(GetSubscriptionTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `SubscriptionTokensResponseResult`
- **Error**: `ApiException<GetSubscriptionTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionTokensRequest` | `Requests/SubscriptionTokens/GetSubscriptionTokensRequest.cs` |
| `SubscriptionTokensResponseResult` | `Models/SubscriptionTokensResponseResult.cs` |
| `GetSubscriptionTokensError` | `Errors/GetSubscriptionTokensError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSubscriptionTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSubscriptionTokensId(GetSubscriptionTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `SubscriptionTokensResponseResult`
- **Error**: `ApiException<GetSubscriptionTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionTokensIdRequest` | `Requests/SubscriptionTokens/GetSubscriptionTokensIdRequest.cs` |
| `SubscriptionTokensResponseResult` | `Models/SubscriptionTokensResponseResult.cs` |
| `GetSubscriptionTokensIdError` | `Errors/GetSubscriptionTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostSubscriptionTokens

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostSubscriptionTokens(PostSubscriptionTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SubscriptionTokensResponseResult`
- **Error**: `ApiException<PostSubscriptionTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSubscriptionTokensRequest` | `Requests/SubscriptionTokens/PostSubscriptionTokensRequest.cs` |
| `SubscriptionTokensPostRequest` | `Models/SubscriptionTokensPostRequest.cs` |
| `SubscriptionTokensResponseResult` | `Models/SubscriptionTokensResponseResult.cs` |
| `PostSubscriptionTokensError` | `Errors/PostSubscriptionTokensError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutSubscriptionTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutSubscriptionTokensId(PutSubscriptionTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `SubscriptionTokensResponseResult`
- **Error**: `ApiException<PutSubscriptionTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutSubscriptionTokensIdRequest` | `Requests/SubscriptionTokens/PutSubscriptionTokensIdRequest.cs` |
| `SubscriptionTokensPutRequest` | `Models/SubscriptionTokensPutRequest.cs` |
| `SubscriptionTokensResponseResult` | `Models/SubscriptionTokensResponseResult.cs` |
| `PutSubscriptionTokensIdError` | `Errors/PutSubscriptionTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

