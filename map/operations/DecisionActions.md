<!-- Generated file — do not edit; regenerated with the SDK. -->

# DecisionActions — operations

Accessor: `client.DecisionActions` · Source: `Api/DecisionActions.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteDecisionActionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteDecisionActionsId(DeleteDecisionActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DecisionActionsResponseResult`
- **Error**: `ApiException<DeleteDecisionActionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDecisionActionsIdRequest` | `Requests/DecisionActions/DeleteDecisionActionsIdRequest.cs` |
| `DecisionActionsResponseResult` | `Models/DecisionActionsResponseResult.cs` |
| `DeleteDecisionActionsIdError` | `Errors/DeleteDecisionActionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDecisionActions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDecisionActions(GetDecisionActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `DecisionActionsResponseResult`
- **Error**: `ApiException<GetDecisionActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDecisionActionsRequest` | `Requests/DecisionActions/GetDecisionActionsRequest.cs` |
| `DecisionActionsResponseResult` | `Models/DecisionActionsResponseResult.cs` |
| `GetDecisionActionsError` | `Errors/GetDecisionActionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDecisionActionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDecisionActionsId(GetDecisionActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `DecisionActionsResponseResult`
- **Error**: `ApiException<GetDecisionActionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDecisionActionsIdRequest` | `Requests/DecisionActions/GetDecisionActionsIdRequest.cs` |
| `DecisionActionsResponseResult` | `Models/DecisionActionsResponseResult.cs` |
| `GetDecisionActionsIdError` | `Errors/GetDecisionActionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostDecisionActions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostDecisionActions(PostDecisionActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DecisionActionsResponseResult`
- **Error**: `ApiException<PostDecisionActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDecisionActionsRequest` | `Requests/DecisionActions/PostDecisionActionsRequest.cs` |
| `DecisionActionsPostRequest` | `Models/DecisionActionsPostRequest.cs` |
| `DecisionActionsResponseResult` | `Models/DecisionActionsResponseResult.cs` |
| `PostDecisionActionsError` | `Errors/PostDecisionActionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutDecisionActionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutDecisionActionsId(PutDecisionActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `DecisionActionsResponseResult`
- **Error**: `ApiException<PutDecisionActionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutDecisionActionsIdRequest` | `Requests/DecisionActions/PutDecisionActionsIdRequest.cs` |
| `DecisionActionsPutRequest` | `Models/DecisionActionsPutRequest.cs` |
| `DecisionActionsResponseResult` | `Models/DecisionActionsResponseResult.cs` |
| `PutDecisionActionsIdError` | `Errors/PutDecisionActionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

