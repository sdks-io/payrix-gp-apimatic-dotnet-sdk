<!-- Generated file — do not edit; regenerated with the SDK. -->

# Statements — operations

Accessor: `client.Statements` · Source: `Api/Statements.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetStatements

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetStatements(GetStatementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `StatementsResponseResult`
- **Error**: `ApiException<GetStatementsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStatementsRequest` | `Requests/Statements/GetStatementsRequest.cs` |
| `StatementsResponseResult` | `Models/StatementsResponseResult.cs` |
| `GetStatementsError` | `Errors/GetStatementsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetStatementsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetStatementsId(GetStatementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `StatementsResponseResult`
- **Error**: `ApiException<GetStatementsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStatementsIdRequest` | `Requests/Statements/GetStatementsIdRequest.cs` |
| `StatementsResponseResult` | `Models/StatementsResponseResult.cs` |
| `GetStatementsIdError` | `Errors/GetStatementsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

