<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionsResults — operations

Accessor: `client.TransactionsResults` · Source: `Api/TransactionsResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTxnResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnResults(GetTxnResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TxnResultsResponseResult`
- **Error**: `ApiException<GetTxnResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnResultsRequest` | `Requests/TransactionsResults/GetTxnResultsRequest.cs` |
| `TxnResultsResponseResult` | `Models/TxnResultsResponseResult.cs` |
| `GetTxnResultsError` | `Errors/GetTxnResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTxnResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnResultsId(GetTxnResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TxnResultsResponseResult`
- **Error**: `ApiException<GetTxnResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnResultsIdRequest` | `Requests/TransactionsResults/GetTxnResultsIdRequest.cs` |
| `TxnResultsResponseResult` | `Models/TxnResultsResponseResult.cs` |
| `GetTxnResultsIdError` | `Errors/GetTxnResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

