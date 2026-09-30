<!-- Generated file — do not edit; regenerated with the SDK. -->

# Mappings — operations

Accessor: `client.Mappings` · Source: `Api/Mappings.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMappingsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteMappingsId(DeleteMappingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `MappingsResponseResult`
- **Error**: `ApiException<DeleteMappingsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMappingsIdRequest` | `Requests/Mappings/DeleteMappingsIdRequest.cs` |
| `MappingsResponseResult` | `Models/MappingsResponseResult.cs` |
| `DeleteMappingsIdError` | `Errors/DeleteMappingsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMappings

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMappings(GetMappingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `MappingsResponseResult`
- **Error**: `ApiException<GetMappingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMappingsRequest` | `Requests/Mappings/GetMappingsRequest.cs` |
| `MappingsResponseResult` | `Models/MappingsResponseResult.cs` |
| `GetMappingsError` | `Errors/GetMappingsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMappingsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMappingsId(GetMappingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `MappingsResponseResult`
- **Error**: `ApiException<GetMappingsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMappingsIdRequest` | `Requests/Mappings/GetMappingsIdRequest.cs` |
| `MappingsResponseResult` | `Models/MappingsResponseResult.cs` |
| `GetMappingsIdError` | `Errors/GetMappingsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostMappings

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostMappings(PostMappingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `MappingsResponseResult`
- **Error**: `ApiException<PostMappingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMappingsRequest` | `Requests/Mappings/PostMappingsRequest.cs` |
| `MappingsPostRequest` | `Models/MappingsPostRequest.cs` |
| `MappingsResponseResult` | `Models/MappingsResponseResult.cs` |
| `PostMappingsError` | `Errors/PostMappingsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutMappingsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutMappingsId(PutMappingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `MappingsResponseResult`
- **Error**: `ApiException<PutMappingsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutMappingsIdRequest` | `Requests/Mappings/PutMappingsIdRequest.cs` |
| `MappingsPutRequest` | `Models/MappingsPutRequest.cs` |
| `MappingsResponseResult` | `Models/MappingsResponseResult.cs` |
| `PutMappingsIdError` | `Errors/PutMappingsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

