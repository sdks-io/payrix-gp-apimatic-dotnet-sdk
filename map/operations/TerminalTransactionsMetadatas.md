<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalTransactionsMetadatas — operations

Accessor: `client.TerminalTransactionsMetadatas` · Source: `Api/TerminalTransactionsMetadatas.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTerminalTxnsMetadatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxnsMetadatas(GetTerminalTxnsMetadatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TerminalTxnMetadatasResponseResult`
- **Error**: `ApiException<GetTerminalTxnsMetadatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnsMetadatasRequest` | `Requests/TerminalTransactionsMetadatas/GetTerminalTxnsMetadatasRequest.cs` |
| `TerminalTxnMetadatasResponseResult` | `Models/TerminalTxnMetadatasResponseResult.cs` |
| `GetTerminalTxnsMetadatasError` | `Errors/GetTerminalTxnsMetadatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTerminalTxnsMetadatasId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxnsMetadatasId(GetTerminalTxnsMetadatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TerminalTxnMetadatasResponseResult`
- **Error**: `ApiException<GetTerminalTxnsMetadatasIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnsMetadatasIdRequest` | `Requests/TerminalTransactionsMetadatas/GetTerminalTxnsMetadatasIdRequest.cs` |
| `TerminalTxnMetadatasResponseResult` | `Models/TerminalTxnMetadatasResponseResult.cs` |
| `GetTerminalTxnsMetadatasIdError` | `Errors/GetTerminalTxnsMetadatasIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTerminalTxnsMetadatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTerminalTxnsMetadatas(PostTerminalTxnsMetadatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TerminalTxnMetadatasResponseResult`
- **Error**: `ApiException<PostTerminalTxnsMetadatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTerminalTxnsMetadatasRequest` | `Requests/TerminalTransactionsMetadatas/PostTerminalTxnsMetadatasRequest.cs` |
| `TerminalTxnsMetadatasPostRequest` | `Models/TerminalTxnsMetadatasPostRequest.cs` |
| `TerminalTxnMetadatasResponseResult` | `Models/TerminalTxnMetadatasResponseResult.cs` |
| `PostTerminalTxnsMetadatasError` | `Errors/PostTerminalTxnsMetadatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

