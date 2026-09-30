<!-- Generated file — do not edit; regenerated with the SDK. -->

# RevShareStatements — operations

Accessor: `client.RevShareStatements` · Source: `Api/RevShareStatements.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetRevShareStatements

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetRevShareStatements(GetRevShareStatementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `RevShareStatementsResponseResult`
- **Error**: `ApiException<GetRevShareStatementsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRevShareStatementsRequest` | `Requests/RevShareStatements/GetRevShareStatementsRequest.cs` |
| `RevShareStatementsResponseResult` | `Models/RevShareStatementsResponseResult.cs` |
| `GetRevShareStatementsError` | `Errors/GetRevShareStatementsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetRevShareStatementsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetRevShareStatementsId(GetRevShareStatementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `RevShareStatementsResponseResult`
- **Error**: `ApiException<GetRevShareStatementsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRevShareStatementsIdRequest` | `Requests/RevShareStatements/GetRevShareStatementsIdRequest.cs` |
| `RevShareStatementsResponseResult` | `Models/RevShareStatementsResponseResult.cs` |
| `GetRevShareStatementsIdError` | `Errors/GetRevShareStatementsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

