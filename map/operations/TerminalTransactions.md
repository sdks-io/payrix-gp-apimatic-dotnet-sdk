<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalTransactions — operations

Accessor: `client.TerminalTransactions` · Source: `Api/TerminalTransactions.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTerminalTxnsById

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteTerminalTxnsById(DeleteTerminalTxnsByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TerminalTxnsResponseResult`
- **Error**: `ApiException<DeleteTerminalTxnsByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTerminalTxnsByIdRequest` | `Requests/TerminalTransactions/DeleteTerminalTxnsByIdRequest.cs` |
| `TerminalTxnsResponseResult` | `Models/TerminalTxnsResponseResult.cs` |
| `DeleteTerminalTxnsByIdError` | `Errors/DeleteTerminalTxnsByIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTerminalTxns

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxns(GetTerminalTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TerminalTxnsResponseResult`
- **Error**: `ApiException<GetTerminalTxnsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnsRequest` | `Requests/TerminalTransactions/GetTerminalTxnsRequest.cs` |
| `TerminalTxnsResponseResult` | `Models/TerminalTxnsResponseResult.cs` |
| `GetTerminalTxnsError` | `Errors/GetTerminalTxnsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTerminalTxnsById

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxnsById(GetTerminalTxnsByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TerminalTxnsResponseResult`
- **Error**: `ApiException<GetTerminalTxnsByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnsByIdRequest` | `Requests/TerminalTransactions/GetTerminalTxnsByIdRequest.cs` |
| `TerminalTxnsResponseResult` | `Models/TerminalTxnsResponseResult.cs` |
| `GetTerminalTxnsByIdError` | `Errors/GetTerminalTxnsByIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTerminalTxns

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTerminalTxns(PostTerminalTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TerminalTxnsResponseResult`
- **Error**: `ApiException<PostTerminalTxnsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTerminalTxnsRequest` | `Requests/TerminalTransactions/PostTerminalTxnsRequest.cs` |
| `TerminalTxnsPostRequest` | `Models/TerminalTxnsPostRequest.cs` |
| `TerminalTxnsResponseResult` | `Models/TerminalTxnsResponseResult.cs` |
| `PostTerminalTxnsError` | `Errors/PostTerminalTxnsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### UpdateTerminalTxnsById

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `UpdateTerminalTxnsById(UpdateTerminalTxnsByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TerminalTxnsResponseResult`
- **Error**: `ApiException<UpdateTerminalTxnsByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateTerminalTxnsByIdRequest` | `Requests/TerminalTransactions/UpdateTerminalTxnsByIdRequest.cs` |
| `TerminalTxnsPutRequest` | `Models/TerminalTxnsPutRequest.cs` |
| `TerminalTxnsResponseResult` | `Models/TerminalTxnsResponseResult.cs` |
| `UpdateTerminalTxnsByIdError` | `Errors/UpdateTerminalTxnsByIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

