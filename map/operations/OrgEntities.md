<!-- Generated file — do not edit; regenerated with the SDK. -->

# OrgEntities — operations

Accessor: `client.OrgEntities` · Source: `Api/OrgEntities.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteOrgEntitiesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteOrgEntitiesId(DeleteOrgEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `OrgEntitiesResponseResult`
- **Error**: `ApiException<DeleteOrgEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrgEntitiesIdRequest` | `Requests/OrgEntities/DeleteOrgEntitiesIdRequest.cs` |
| `OrgEntitiesResponseResult` | `Models/OrgEntitiesResponseResult.cs` |
| `DeleteOrgEntitiesIdError` | `Errors/DeleteOrgEntitiesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOrgEntities

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgEntities(GetOrgEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `OrgEntitiesResponseResult`
- **Error**: `ApiException<GetOrgEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgEntitiesRequest` | `Requests/OrgEntities/GetOrgEntitiesRequest.cs` |
| `OrgEntitiesResponseResult` | `Models/OrgEntitiesResponseResult.cs` |
| `GetOrgEntitiesError` | `Errors/GetOrgEntitiesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOrgEntitiesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgEntitiesId(GetOrgEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `OrgEntitiesResponseResult`
- **Error**: `ApiException<GetOrgEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgEntitiesIdRequest` | `Requests/OrgEntities/GetOrgEntitiesIdRequest.cs` |
| `OrgEntitiesResponseResult` | `Models/OrgEntitiesResponseResult.cs` |
| `GetOrgEntitiesIdError` | `Errors/GetOrgEntitiesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostOrgEntities

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostOrgEntities(PostOrgEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OrgEntitiesResponseResult`
- **Error**: `ApiException<PostOrgEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOrgEntitiesRequest` | `Requests/OrgEntities/PostOrgEntitiesRequest.cs` |
| `OrgEntitiesPostRequest` | `Models/OrgEntitiesPostRequest.cs` |
| `OrgEntitiesResponseResult` | `Models/OrgEntitiesResponseResult.cs` |
| `PostOrgEntitiesError` | `Errors/PostOrgEntitiesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutOrgEntitiesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutOrgEntitiesId(PutOrgEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `OrgEntitiesResponseResult`
- **Error**: `ApiException<PutOrgEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutOrgEntitiesIdRequest` | `Requests/OrgEntities/PutOrgEntitiesIdRequest.cs` |
| `OrgEntitiesPutRequest` | `Models/OrgEntitiesPutRequest.cs` |
| `OrgEntitiesResponseResult` | `Models/OrgEntitiesResponseResult.cs` |
| `PutOrgEntitiesIdError` | `Errors/PutOrgEntitiesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

