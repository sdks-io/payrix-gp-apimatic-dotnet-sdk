<!-- Generated file — do not edit; regenerated with the SDK. -->

# Credentials — operations

Accessor: `client.Credentials` · Source: `Api/Credentials.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCredentialsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteCredentialsId(DeleteCredentialsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CredentialsResponseResult`
- **Error**: `ApiException<DeleteCredentialsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCredentialsIdRequest` | `Requests/Credentials/DeleteCredentialsIdRequest.cs` |
| `CredentialsResponseResult` | `Models/CredentialsResponseResult.cs` |
| `DeleteCredentialsIdError` | `Errors/DeleteCredentialsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetCredentials

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetCredentials(GetCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `CredentialsResponseResult`
- **Error**: `ApiException<GetCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCredentialsRequest` | `Requests/Credentials/GetCredentialsRequest.cs` |
| `CredentialsResponseResult` | `Models/CredentialsResponseResult.cs` |
| `GetCredentialsError` | `Errors/GetCredentialsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetCredentialsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetCredentialsId(GetCredentialsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `CredentialsResponseResult`
- **Error**: `ApiException<GetCredentialsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCredentialsIdRequest` | `Requests/Credentials/GetCredentialsIdRequest.cs` |
| `CredentialsResponseResult` | `Models/CredentialsResponseResult.cs` |
| `GetCredentialsIdError` | `Errors/GetCredentialsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostCredentials

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostCredentials(PostCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CredentialsResponseResult`
- **Error**: `ApiException<PostCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCredentialsRequest` | `Requests/Credentials/PostCredentialsRequest.cs` |
| `CredentialsPostRequest` | `Models/CredentialsPostRequest.cs` |
| `CredentialsResponseResult` | `Models/CredentialsResponseResult.cs` |
| `PostCredentialsError` | `Errors/PostCredentialsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutCredentialsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutCredentialsId(PutCredentialsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `CredentialsResponseResult`
- **Error**: `ApiException<PutCredentialsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutCredentialsIdRequest` | `Requests/Credentials/PutCredentialsIdRequest.cs` |
| `CredentialsPutRequest` | `Models/CredentialsPutRequest.cs` |
| `CredentialsResponseResult` | `Models/CredentialsResponseResult.cs` |
| `PutCredentialsIdError` | `Errors/PutCredentialsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

