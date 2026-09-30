<!-- Generated file — do not edit; regenerated with the SDK. -->

# Terminals — operations

Accessor: `client.Terminals` · Source: `Api/Terminals.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTerminalsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteTerminalsId(DeleteTerminalsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TerminalsResponseResult`
- **Error**: `ApiException<DeleteTerminalsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTerminalsIdRequest` | `Requests/Terminals/DeleteTerminalsIdRequest.cs` |
| `TerminalsResponseResult` | `Models/TerminalsResponseResult.cs` |
| `DeleteTerminalsIdError` | `Errors/DeleteTerminalsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTerminals

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminals(GetTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TerminalsResponseResult`
- **Error**: `ApiException<GetTerminalsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalsRequest` | `Requests/Terminals/GetTerminalsRequest.cs` |
| `TerminalsResponseResult` | `Models/TerminalsResponseResult.cs` |
| `GetTerminalsError` | `Errors/GetTerminalsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTerminalsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalsId(GetTerminalsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TerminalsResponseResult`
- **Error**: `ApiException<GetTerminalsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalsIdRequest` | `Requests/Terminals/GetTerminalsIdRequest.cs` |
| `TerminalsResponseResult` | `Models/TerminalsResponseResult.cs` |
| `GetTerminalsIdError` | `Errors/GetTerminalsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTerminals

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTerminals(PostTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TerminalsResponseResult`
- **Error**: `ApiException<PostTerminalsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTerminalsRequest` | `Requests/Terminals/PostTerminalsRequest.cs` |
| `TerminalsPostRequest` | `Models/TerminalsPostRequest.cs` |
| `TerminalsResponseResult` | `Models/TerminalsResponseResult.cs` |
| `PostTerminalsError` | `Errors/PostTerminalsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutTerminalsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutTerminalsId(PutTerminalsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TerminalsResponseResult`
- **Error**: `ApiException<PutTerminalsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutTerminalsIdRequest` | `Requests/Terminals/PutTerminalsIdRequest.cs` |
| `TerminalsPutRequest` | `Models/TerminalsPutRequest.cs` |
| `TerminalsResponseResult` | `Models/TerminalsResponseResult.cs` |
| `PutTerminalsIdError` | `Errors/PutTerminalsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

