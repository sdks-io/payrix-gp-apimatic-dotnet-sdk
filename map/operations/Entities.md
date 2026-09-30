<!-- Generated file — do not edit; regenerated with the SDK. -->

# Entities — operations

Accessor: `client.Entities` · Source: `Api/Entities.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteEntitiesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteEntitiesId(DeleteEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `EntitiesResponseResult`
- **Error**: `ApiException<DeleteEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteEntitiesIdRequest` | `Requests/Entities/DeleteEntitiesIdRequest.cs` |
| `EntitiesResponseResult` | `Models/EntitiesResponseResult.cs` |
| `DeleteEntitiesIdError` | `Errors/DeleteEntitiesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntities

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntities(GetEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntitiesResponseResult`
- **Error**: `ApiException<GetEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntitiesRequest` | `Requests/Entities/GetEntitiesRequest.cs` |
| `EntitiesResponseResult` | `Models/EntitiesResponseResult.cs` |
| `GetEntitiesError` | `Errors/GetEntitiesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntitiesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntitiesId(GetEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntitiesResponseResult`
- **Error**: `ApiException<GetEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntitiesIdRequest` | `Requests/Entities/GetEntitiesIdRequest.cs` |
| `EntitiesResponseResult` | `Models/EntitiesResponseResult.cs` |
| `GetEntitiesIdError` | `Errors/GetEntitiesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntitiesIdNextPayout

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntitiesIdNextPayout(GetEntitiesIdNextPayoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `excludeSingle` ← `ExcludeSingle`
- **Returns**: `EntityNextPayoutResponseResult`
- **Error**: `ApiException<GetEntitiesIdNextPayoutError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntitiesIdNextPayoutRequest` | `Requests/Entities/GetEntitiesIdNextPayoutRequest.cs` |
| `ExcludeSingle1` | `Models/Enums/ExcludeSingle1.cs` |
| `EntityNextPayoutResponseResult` | `Models/EntityNextPayoutResponseResult.cs` |
| `GetEntitiesIdNextPayoutError` | `Errors/GetEntitiesIdNextPayoutError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostEntities

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostEntities(PostEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EntitiesResponseResult`
- **Error**: `ApiException<PostEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostEntitiesRequest` | `Requests/Entities/PostEntitiesRequest.cs` |
| `EntitiesPostRequest` | `Models/EntitiesPostRequest.cs` |
| `EntitiesResponseResult` | `Models/EntitiesResponseResult.cs` |
| `PostEntitiesError` | `Errors/PostEntitiesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutEntitiesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutEntitiesId(PutEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `EntitiesResponseResult`
- **Error**: `ApiException<PutEntitiesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutEntitiesIdRequest` | `Requests/Entities/PutEntitiesIdRequest.cs` |
| `EntitiesPutRequest` | `Models/EntitiesPutRequest.cs` |
| `EntitiesResponseResult` | `Models/EntitiesResponseResult.cs` |
| `PutEntitiesIdError` | `Errors/PutEntitiesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

