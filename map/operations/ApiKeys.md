<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiKeys — operations

Accessor: `client.ApiKeys` · Source: `Api/ApiKeys.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteApikeysId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteApikeysId(DeleteApikeysIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ApikeysResponseResult`
- **Error**: `ApiException<DeleteApikeysIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteApikeysIdRequest` | `Requests/ApiKeys/DeleteApikeysIdRequest.cs` |
| `ApikeysResponseResult` | `Models/ApikeysResponseResult.cs` |
| `DeleteApikeysIdError` | `Errors/DeleteApikeysIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetApikeys

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetApikeys(GetApikeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ApikeysResponseResult`
- **Error**: `ApiException<GetApikeysError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetApikeysRequest` | `Requests/ApiKeys/GetApikeysRequest.cs` |
| `ApikeysResponseResult` | `Models/ApikeysResponseResult.cs` |
| `GetApikeysError` | `Errors/GetApikeysError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetApikeysId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetApikeysId(GetApikeysIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ApikeysResponseResult`
- **Error**: `ApiException<GetApikeysIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetApikeysIdRequest` | `Requests/ApiKeys/GetApikeysIdRequest.cs` |
| `ApikeysResponseResult` | `Models/ApikeysResponseResult.cs` |
| `GetApikeysIdError` | `Errors/GetApikeysIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostApikeys

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey` OR (`options.Username` AND `options.Password`)
- **Signature**: `PostApikeys(PostApikeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ApikeysResponseResult`
- **Error**: `ApiException<PostApikeysError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostApikeysRequest` | `Requests/ApiKeys/PostApikeysRequest.cs` |
| `ApiKeysPostRequest` | `Models/ApiKeysPostRequest.cs` |
| `ApikeysResponseResult` | `Models/ApikeysResponseResult.cs` |
| `PostApikeysError` | `Errors/PostApikeysError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutApikeysId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutApikeysId(PutApikeysIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `ApikeysResponseResult`
- **Error**: `ApiException<PutApikeysIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutApikeysIdRequest` | `Requests/ApiKeys/PutApikeysIdRequest.cs` |
| `ApiKeysPutRequest` | `Models/ApiKeysPutRequest.cs` |
| `ApikeysResponseResult` | `Models/ApikeysResponseResult.cs` |
| `PutApikeysIdError` | `Errors/PutApikeysIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

