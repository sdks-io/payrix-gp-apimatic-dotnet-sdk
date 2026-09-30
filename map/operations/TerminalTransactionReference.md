<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalTransactionReference — operations

Accessor: `client.TerminalTransactionReference` · Source: `Api/TerminalTransactionReference.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostTerminalTxnRefs

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTerminalTxnRefs(PostTerminalTxnRefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TerminalTxnRefResponseResult`
- **Error**: `ApiException<PostTerminalTxnRefsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTerminalTxnRefsRequest` | `Requests/TerminalTransactionReference/PostTerminalTxnRefsRequest.cs` |
| `TerminalTxnRefPostRequest` | `Models/TerminalTxnRefPostRequest.cs` |
| `TerminalTxnRefResponseResult` | `Models/TerminalTxnRefResponseResult.cs` |
| `PostTerminalTxnRefsError` | `Errors/PostTerminalTxnRefsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

