<!-- Generated file — do not edit; regenerated with the SDK. -->

# Decisions — operations

Accessor: `client.Decisions` · Source: `Api/Decisions.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteDecisionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteDecisionsId(DeleteDecisionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DecisionsResponseResult`
- **Error**: `ApiException<DeleteDecisionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDecisionsIdRequest` | `Requests/Decisions/DeleteDecisionsIdRequest.cs` |
| `DecisionsResponseResult` | `Models/DecisionsResponseResult.cs` |
| `DeleteDecisionsIdError` | `Errors/DeleteDecisionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDecisions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDecisions(GetDecisionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `DecisionsResponseResult`
- **Error**: `ApiException<GetDecisionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDecisionsRequest` | `Requests/Decisions/GetDecisionsRequest.cs` |
| `DecisionsResponseResult` | `Models/DecisionsResponseResult.cs` |
| `GetDecisionsError` | `Errors/GetDecisionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDecisionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDecisionsId(GetDecisionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `DecisionsResponseResult`
- **Error**: `ApiException<GetDecisionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDecisionsIdRequest` | `Requests/Decisions/GetDecisionsIdRequest.cs` |
| `DecisionsResponseResult` | `Models/DecisionsResponseResult.cs` |
| `GetDecisionsIdError` | `Errors/GetDecisionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostDecisions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostDecisions(PostDecisionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DecisionsResponseResult`
- **Error**: `ApiException<PostDecisionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDecisionsRequest` | `Requests/Decisions/PostDecisionsRequest.cs` |
| `DecisionsPostRequest` | `Models/DecisionsPostRequest.cs` |
| `DecisionsResponseResult` | `Models/DecisionsResponseResult.cs` |
| `PostDecisionsError` | `Errors/PostDecisionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutDecisionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutDecisionsId(PutDecisionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `DecisionsResponseResult`
- **Error**: `ApiException<PutDecisionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutDecisionsIdRequest` | `Requests/Decisions/PutDecisionsIdRequest.cs` |
| `DecisionsPutRequest` | `Models/DecisionsPutRequest.cs` |
| `DecisionsResponseResult` | `Models/DecisionsResponseResult.cs` |
| `PutDecisionsIdError` | `Errors/PutDecisionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

