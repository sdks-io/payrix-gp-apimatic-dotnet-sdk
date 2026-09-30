<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalTransactionResults — operations

Accessor: `client.TerminalTransactionResults` · Source: `Api/TerminalTransactionResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTerminalTxnResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxnResults(GetTerminalTxnResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TerminalTxnResultsResponseResult`
- **Error**: `ApiException<GetTerminalTxnResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnResultsRequest` | `Requests/TerminalTransactionResults/GetTerminalTxnResultsRequest.cs` |
| `TerminalTxnResultsResponseResult` | `Models/TerminalTxnResultsResponseResult.cs` |
| `GetTerminalTxnResultsError` | `Errors/GetTerminalTxnResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTerminalTxnResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTerminalTxnResultsId(GetTerminalTxnResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TerminalTxnResultsResponseResult`
- **Error**: `ApiException<GetTerminalTxnResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalTxnResultsIdRequest` | `Requests/TerminalTransactionResults/GetTerminalTxnResultsIdRequest.cs` |
| `TerminalTxnResultsResponseResult` | `Models/TerminalTxnResultsResponseResult.cs` |
| `GetTerminalTxnResultsIdError` | `Errors/GetTerminalTxnResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

