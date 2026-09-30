<!-- Generated file — do not edit; regenerated with the SDK. -->

# AlertTriggers — operations

Accessor: `client.AlertTriggers` · Source: `Api/AlertTriggers.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAlertTriggersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAlertTriggersId(DeleteAlertTriggersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AlertTriggersResponseResult`
- **Error**: `ApiException<DeleteAlertTriggersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAlertTriggersIdRequest` | `Requests/AlertTriggers/DeleteAlertTriggersIdRequest.cs` |
| `AlertTriggersResponseResult` | `Models/AlertTriggersResponseResult.cs` |
| `DeleteAlertTriggersIdError` | `Errors/DeleteAlertTriggersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAlertTriggers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAlertTriggers(GetAlertTriggersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AlertTriggersResponseResult`
- **Error**: `ApiException<GetAlertTriggersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAlertTriggersRequest` | `Requests/AlertTriggers/GetAlertTriggersRequest.cs` |
| `AlertTriggersResponseResult` | `Models/AlertTriggersResponseResult.cs` |
| `GetAlertTriggersError` | `Errors/GetAlertTriggersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAlertTriggersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAlertTriggersId(GetAlertTriggersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AlertTriggersResponseResult`
- **Error**: `ApiException<GetAlertTriggersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAlertTriggersIdRequest` | `Requests/AlertTriggers/GetAlertTriggersIdRequest.cs` |
| `AlertTriggersResponseResult` | `Models/AlertTriggersResponseResult.cs` |
| `GetAlertTriggersIdError` | `Errors/GetAlertTriggersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostAlertTriggers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostAlertTriggers(PostAlertTriggersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AlertTriggersResponseResult`
- **Error**: `ApiException<PostAlertTriggersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAlertTriggersRequest` | `Requests/AlertTriggers/PostAlertTriggersRequest.cs` |
| `AlertTriggersPostRequest` | `Models/AlertTriggersPostRequest.cs` |
| `AlertTriggersResponseResult` | `Models/AlertTriggersResponseResult.cs` |
| `PostAlertTriggersError` | `Errors/PostAlertTriggersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutAlertTriggersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutAlertTriggersId(PutAlertTriggersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AlertTriggersResponseResult`
- **Error**: `ApiException<PutAlertTriggersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutAlertTriggersIdRequest` | `Requests/AlertTriggers/PutAlertTriggersIdRequest.cs` |
| `AlertTriggersPutRequest` | `Models/AlertTriggersPutRequest.cs` |
| `AlertTriggersResponseResult` | `Models/AlertTriggersResponseResult.cs` |
| `PutAlertTriggersIdError` | `Errors/PutAlertTriggersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

