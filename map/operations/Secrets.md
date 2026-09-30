<!-- Generated file — do not edit; regenerated with the SDK. -->

# Secrets — operations

Accessor: `client.Secrets` · Source: `Api/Secrets.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteSecretsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteSecretsId(DeleteSecretsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SecretsResponseResult`
- **Error**: `ApiException<DeleteSecretsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSecretsIdRequest` | `Requests/Secrets/DeleteSecretsIdRequest.cs` |
| `SecretsResponseResult` | `Models/SecretsResponseResult.cs` |
| `DeleteSecretsIdError` | `Errors/DeleteSecretsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSecrets

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSecrets(GetSecretsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `SecretsResponseResult`
- **Error**: `ApiException<GetSecretsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSecretsRequest` | `Requests/Secrets/GetSecretsRequest.cs` |
| `SecretsResponseResult` | `Models/SecretsResponseResult.cs` |
| `GetSecretsError` | `Errors/GetSecretsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSecretsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSecretsId(GetSecretsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `SecretsResponseResult`
- **Error**: `ApiException<GetSecretsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSecretsIdRequest` | `Requests/Secrets/GetSecretsIdRequest.cs` |
| `SecretsResponseResult` | `Models/SecretsResponseResult.cs` |
| `GetSecretsIdError` | `Errors/GetSecretsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostSecrets

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostSecrets(PostSecretsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SecretsResponseResult`
- **Error**: `ApiException<PostSecretsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSecretsRequest` | `Requests/Secrets/PostSecretsRequest.cs` |
| `SecretsPostRequest` | `Models/SecretsPostRequest.cs` |
| `SecretsResponseResult` | `Models/SecretsResponseResult.cs` |
| `PostSecretsError` | `Errors/PostSecretsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutSecretsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutSecretsId(PutSecretsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `SecretsResponseResult`
- **Error**: `ApiException<PutSecretsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutSecretsIdRequest` | `Requests/Secrets/PutSecretsIdRequest.cs` |
| `SecretsPutRequest` | `Models/SecretsPutRequest.cs` |
| `SecretsResponseResult` | `Models/SecretsResponseResult.cs` |
| `PutSecretsIdError` | `Errors/PutSecretsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

