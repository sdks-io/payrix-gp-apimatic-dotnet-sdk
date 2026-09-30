<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orgs — operations

Accessor: `client.Orgs` · Source: `Api/Orgs.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteOrgsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteOrgsId(DeleteOrgsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `OrgsResponseResult`
- **Error**: `ApiException<DeleteOrgsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrgsIdRequest` | `Requests/Orgs/DeleteOrgsIdRequest.cs` |
| `OrgsResponseResult` | `Models/OrgsResponseResult.cs` |
| `DeleteOrgsIdError` | `Errors/DeleteOrgsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOrgs

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgs(GetOrgsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `OrgsResponseResult`
- **Error**: `ApiException<GetOrgsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgsRequest` | `Requests/Orgs/GetOrgsRequest.cs` |
| `OrgsResponseResult` | `Models/OrgsResponseResult.cs` |
| `GetOrgsError` | `Errors/GetOrgsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOrgsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgsId(GetOrgsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `OrgsResponseResult`
- **Error**: `ApiException<GetOrgsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgsIdRequest` | `Requests/Orgs/GetOrgsIdRequest.cs` |
| `OrgsResponseResult` | `Models/OrgsResponseResult.cs` |
| `GetOrgsIdError` | `Errors/GetOrgsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostOrgs

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostOrgs(PostOrgsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OrgsResponseResult`
- **Error**: `ApiException<PostOrgsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOrgsRequest` | `Requests/Orgs/PostOrgsRequest.cs` |
| `OrgsPostRequest` | `Models/OrgsPostRequest.cs` |
| `OrgsResponseResult` | `Models/OrgsResponseResult.cs` |
| `PostOrgsError` | `Errors/PostOrgsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutOrgsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutOrgsId(PutOrgsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `OrgsResponseResult`
- **Error**: `ApiException<PutOrgsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutOrgsIdRequest` | `Requests/Orgs/PutOrgsIdRequest.cs` |
| `OrgsPutRequest` | `Models/OrgsPutRequest.cs` |
| `OrgsResponseResult` | `Models/OrgsResponseResult.cs` |
| `PutOrgsIdError` | `Errors/PutOrgsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

