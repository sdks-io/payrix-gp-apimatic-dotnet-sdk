<!-- Generated file — do not edit; regenerated with the SDK. -->

# StatementEntry — operations

Accessor: `client.StatementEntry` · Source: `Api/StatementEntry.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetStatementEntries

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetStatementEntries(GetStatementEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `StatementEntriesResponseResult`
- **Error**: `ApiException<GetStatementEntriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStatementEntriesRequest` | `Requests/StatementEntry/GetStatementEntriesRequest.cs` |
| `StatementEntriesResponseResult` | `Models/StatementEntriesResponseResult.cs` |
| `GetStatementEntriesError` | `Errors/GetStatementEntriesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetStatementEntriesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetStatementEntriesId(GetStatementEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `StatementEntriesResponseResult`
- **Error**: `ApiException<GetStatementEntriesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStatementEntriesIdRequest` | `Requests/StatementEntry/GetStatementEntriesIdRequest.cs` |
| `StatementEntriesResponseResult` | `Models/StatementEntriesResponseResult.cs` |
| `GetStatementEntriesIdError` | `Errors/GetStatementEntriesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

