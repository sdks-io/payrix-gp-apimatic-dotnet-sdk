<!-- Generated file — do not edit; regenerated with the SDK. -->

# EntitiesCustomFields — operations

Accessor: `client.EntitiesCustomFields` · Source: `Api/EntitiesCustomFields.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteEntityCustomFieldsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteEntityCustomFieldsId(DeleteEntityCustomFieldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `EntityCustomFieldsResponseResult`
- **Error**: `ApiException<DeleteEntityCustomFieldsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteEntityCustomFieldsIdRequest` | `Requests/EntitiesCustomFields/DeleteEntityCustomFieldsIdRequest.cs` |
| `EntityCustomFieldsResponseResult` | `Models/EntityCustomFieldsResponseResult.cs` |
| `DeleteEntityCustomFieldsIdError` | `Errors/DeleteEntityCustomFieldsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntityCustomFields

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityCustomFields(GetEntityCustomFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntityCustomFieldsResponseResult`
- **Error**: `ApiException<GetEntityCustomFieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityCustomFieldsRequest` | `Requests/EntitiesCustomFields/GetEntityCustomFieldsRequest.cs` |
| `EntityCustomFieldsResponseResult` | `Models/EntityCustomFieldsResponseResult.cs` |
| `GetEntityCustomFieldsError` | `Errors/GetEntityCustomFieldsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntityCustomFieldsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityCustomFieldsId(GetEntityCustomFieldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntityCustomFieldsResponseResult`
- **Error**: `ApiException<GetEntityCustomFieldsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityCustomFieldsIdRequest` | `Requests/EntitiesCustomFields/GetEntityCustomFieldsIdRequest.cs` |
| `EntityCustomFieldsResponseResult` | `Models/EntityCustomFieldsResponseResult.cs` |
| `GetEntityCustomFieldsIdError` | `Errors/GetEntityCustomFieldsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostEntityCustomFields

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostEntityCustomFields(PostEntityCustomFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EntityCustomFieldsResponseResult`
- **Error**: `ApiException<PostEntityCustomFieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostEntityCustomFieldsRequest` | `Requests/EntitiesCustomFields/PostEntityCustomFieldsRequest.cs` |
| `EntityCustomFieldsPostRequest` | `Models/EntityCustomFieldsPostRequest.cs` |
| `EntityCustomFieldsResponseResult` | `Models/EntityCustomFieldsResponseResult.cs` |
| `PostEntityCustomFieldsError` | `Errors/PostEntityCustomFieldsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutEntityCustomFieldsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutEntityCustomFieldsId(PutEntityCustomFieldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `EntityCustomFieldsResponseResult`
- **Error**: `ApiException<PutEntityCustomFieldsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutEntityCustomFieldsIdRequest` | `Requests/EntitiesCustomFields/PutEntityCustomFieldsIdRequest.cs` |
| `EntityCustomFieldsPutRequest` | `Models/EntityCustomFieldsPutRequest.cs` |
| `EntityCustomFieldsResponseResult` | `Models/EntityCustomFieldsResponseResult.cs` |
| `PutEntityCustomFieldsIdError` | `Errors/PutEntityCustomFieldsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

