<!-- Generated file — do not edit; regenerated with the SDK. -->

# EntityData — operations

Accessor: `client.EntityData` · Source: `Api/EntityData.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEntityDatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityDatas(GetEntityDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntityDatasResponseResult`
- **Error**: `ApiException<GetEntityDatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityDatasRequest` | `Requests/EntityData/GetEntityDatasRequest.cs` |
| `EntityDatasResponseResult` | `Models/EntityDatasResponseResult.cs` |
| `GetEntityDatasError` | `Errors/GetEntityDatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntityDatasId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityDatasId(GetEntityDatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntityDatasResponseResult`
- **Error**: `ApiException<GetEntityDatasIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityDatasIdRequest` | `Requests/EntityData/GetEntityDatasIdRequest.cs` |
| `EntityDatasResponseResult` | `Models/EntityDatasResponseResult.cs` |
| `GetEntityDatasIdError` | `Errors/GetEntityDatasIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostEntityDatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostEntityDatas(PostEntityDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EntityDatasResponseResult`
- **Error**: `ApiException<PostEntityDatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostEntityDatasRequest` | `Requests/EntityData/PostEntityDatasRequest.cs` |
| `EntityDataPostRequest` | `Models/EntityDataPostRequest.cs` |
| `EntityDatasResponseResult` | `Models/EntityDatasResponseResult.cs` |
| `PostEntityDatasError` | `Errors/PostEntityDatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

