<!-- Generated file — do not edit; regenerated with the SDK. -->

# Alerts — operations

Accessor: `client.Alerts` · Source: `Api/Alerts.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAlertsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAlertsId(DeleteAlertsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AlertsResponseResult`
- **Error**: `ApiException<DeleteAlertsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAlertsIdRequest` | `Requests/Alerts/DeleteAlertsIdRequest.cs` |
| `AlertsResponseResult` | `Models/AlertsResponseResult.cs` |
| `DeleteAlertsIdError` | `Errors/DeleteAlertsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAlerts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAlerts(GetAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AlertsResponseResult`
- **Error**: `ApiException<GetAlertsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAlertsRequest` | `Requests/Alerts/GetAlertsRequest.cs` |
| `AlertsResponseResult` | `Models/AlertsResponseResult.cs` |
| `GetAlertsError` | `Errors/GetAlertsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAlertsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAlertsId(GetAlertsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AlertsResponseResult`
- **Error**: `ApiException<GetAlertsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAlertsIdRequest` | `Requests/Alerts/GetAlertsIdRequest.cs` |
| `AlertsResponseResult` | `Models/AlertsResponseResult.cs` |
| `GetAlertsIdError` | `Errors/GetAlertsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostAlerts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostAlerts(PostAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AlertsResponseResult`
- **Error**: `ApiException<PostAlertsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAlertsRequest` | `Requests/Alerts/PostAlertsRequest.cs` |
| `AlertsPostRequest` | `Models/AlertsPostRequest.cs` |
| `AlertsResponseResult` | `Models/AlertsResponseResult.cs` |
| `PostAlertsError` | `Errors/PostAlertsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutAlertsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutAlertsId(PutAlertsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AlertsResponseResult`
- **Error**: `ApiException<PutAlertsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutAlertsIdRequest` | `Requests/Alerts/PutAlertsIdRequest.cs` |
| `AlertsPutRequest` | `Models/AlertsPutRequest.cs` |
| `AlertsResponseResult` | `Models/AlertsResponseResult.cs` |
| `PutAlertsIdError` | `Errors/PutAlertsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

