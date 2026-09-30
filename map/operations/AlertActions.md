<!-- Generated file — do not edit; regenerated with the SDK. -->

# AlertActions — operations

Accessor: `client.AlertActions` · Source: `Api/AlertActions.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAlertActionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAlertActionsId(DeleteAlertActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AlertActionsResponseResult`
- **Error**: `ApiException<DeleteAlertActionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAlertActionsIdRequest` | `Requests/AlertActions/DeleteAlertActionsIdRequest.cs` |
| `AlertActionsResponseResult` | `Models/AlertActionsResponseResult.cs` |
| `DeleteAlertActionsIdError` | `Errors/DeleteAlertActionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAlertActions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAlertActions(GetAlertActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AlertActionsResponseResult`
- **Error**: `ApiException<GetAlertActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAlertActionsRequest` | `Requests/AlertActions/GetAlertActionsRequest.cs` |
| `AlertActionsResponseResult` | `Models/AlertActionsResponseResult.cs` |
| `GetAlertActionsError` | `Errors/GetAlertActionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAlertActionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAlertActionsId(GetAlertActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AlertActionsResponseResult`
- **Error**: `ApiException<GetAlertActionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAlertActionsIdRequest` | `Requests/AlertActions/GetAlertActionsIdRequest.cs` |
| `AlertActionsResponseResult` | `Models/AlertActionsResponseResult.cs` |
| `GetAlertActionsIdError` | `Errors/GetAlertActionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostAlertActions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostAlertActions(PostAlertActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AlertActionsResponseResult`
- **Error**: `ApiException<PostAlertActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAlertActionsRequest` | `Requests/AlertActions/PostAlertActionsRequest.cs` |
| `AlertActionsPostRequest` | `Models/AlertActionsPostRequest.cs` |
| `AlertActionsResponseResult` | `Models/AlertActionsResponseResult.cs` |
| `PostAlertActionsError` | `Errors/PostAlertActionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutAlertActionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutAlertActionsId(PutAlertActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AlertActionsResponseResult`
- **Error**: `ApiException<PutAlertActionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutAlertActionsIdRequest` | `Requests/AlertActions/PutAlertActionsIdRequest.cs` |
| `AlertActionsPutRequest` | `Models/AlertActionsPutRequest.cs` |
| `AlertActionsResponseResult` | `Models/AlertActionsResponseResult.cs` |
| `PutAlertActionsIdError` | `Errors/PutAlertActionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

