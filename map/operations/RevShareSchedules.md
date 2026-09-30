<!-- Generated file — do not edit; regenerated with the SDK. -->

# RevShareSchedules — operations

Accessor: `client.RevShareSchedules` · Source: `Api/RevShareSchedules.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteRevShareSchedulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteRevShareSchedulesId(DeleteRevShareSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RevShareSchedulesResponseResult`
- **Error**: `ApiException<DeleteRevShareSchedulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteRevShareSchedulesIdRequest` | `Requests/RevShareSchedules/DeleteRevShareSchedulesIdRequest.cs` |
| `RevShareSchedulesResponseResult` | `Models/RevShareSchedulesResponseResult.cs` |
| `DeleteRevShareSchedulesIdError` | `Errors/DeleteRevShareSchedulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetRevShareSchedules

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetRevShareSchedules(GetRevShareSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `RevShareSchedulesResponseResult`
- **Error**: `ApiException<GetRevShareSchedulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRevShareSchedulesRequest` | `Requests/RevShareSchedules/GetRevShareSchedulesRequest.cs` |
| `RevShareSchedulesResponseResult` | `Models/RevShareSchedulesResponseResult.cs` |
| `GetRevShareSchedulesError` | `Errors/GetRevShareSchedulesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetRevShareSchedulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetRevShareSchedulesId(GetRevShareSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `RevShareSchedulesResponseResult`
- **Error**: `ApiException<GetRevShareSchedulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRevShareSchedulesIdRequest` | `Requests/RevShareSchedules/GetRevShareSchedulesIdRequest.cs` |
| `RevShareSchedulesResponseResult` | `Models/RevShareSchedulesResponseResult.cs` |
| `GetRevShareSchedulesIdError` | `Errors/GetRevShareSchedulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostRevShareSchedules

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostRevShareSchedules(PostRevShareSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RevShareSchedulesResponseResult`
- **Error**: `ApiException<PostRevShareSchedulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRevShareSchedulesRequest` | `Requests/RevShareSchedules/PostRevShareSchedulesRequest.cs` |
| `RevShareSchedulesPostRequest` | `Models/RevShareSchedulesPostRequest.cs` |
| `RevShareSchedulesResponseResult` | `Models/RevShareSchedulesResponseResult.cs` |
| `PostRevShareSchedulesError` | `Errors/PostRevShareSchedulesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutRevShareSchedulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutRevShareSchedulesId(PutRevShareSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `RevShareSchedulesResponseResult`
- **Error**: `ApiException<PutRevShareSchedulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutRevShareSchedulesIdRequest` | `Requests/RevShareSchedules/PutRevShareSchedulesIdRequest.cs` |
| `RevShareSchedulesPutRequest` | `Models/RevShareSchedulesPutRequest.cs` |
| `RevShareSchedulesResponseResult` | `Models/RevShareSchedulesResponseResult.cs` |
| `PutRevShareSchedulesIdError` | `Errors/PutRevShareSchedulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

