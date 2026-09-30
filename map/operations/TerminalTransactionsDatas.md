<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalTransactionsDatas — operations

Accessor: `client.TerminalTransactionsDatas` · Source: `Api/TerminalTransactionsDatas.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTerminalTxnsDatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxnsDatas(GetTerminalTxnsDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TerminalTxnDatasResponseResult`
- **Error**: `ApiException<GetTerminalTxnsDatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnsDatasRequest` | `Requests/TerminalTransactionsDatas/GetTerminalTxnsDatasRequest.cs` |
| `TerminalTxnDatasResponseResult` | `Models/TerminalTxnDatasResponseResult.cs` |
| `GetTerminalTxnsDatasError` | `Errors/GetTerminalTxnsDatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTerminalTxnsDatasId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxnsDatasId(GetTerminalTxnsDatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TerminalTxnDatasResponseResult`
- **Error**: `ApiException<GetTerminalTxnsDatasIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnsDatasIdRequest` | `Requests/TerminalTransactionsDatas/GetTerminalTxnsDatasIdRequest.cs` |
| `TerminalTxnDatasResponseResult` | `Models/TerminalTxnDatasResponseResult.cs` |
| `GetTerminalTxnsDatasIdError` | `Errors/GetTerminalTxnsDatasIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTerminalTxnsDatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTerminalTxnsDatas(PostTerminalTxnsDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TerminalTxnDatasResponseResult`
- **Error**: `ApiException<PostTerminalTxnsDatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTerminalTxnsDatasRequest` | `Requests/TerminalTransactionsDatas/PostTerminalTxnsDatasRequest.cs` |
| `TerminalTxnsDatasPostRequest` | `Models/TerminalTxnsDatasPostRequest.cs` |
| `TerminalTxnDatasResponseResult` | `Models/TerminalTxnDatasResponseResult.cs` |
| `PostTerminalTxnsDatasError` | `Errors/PostTerminalTxnsDatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

