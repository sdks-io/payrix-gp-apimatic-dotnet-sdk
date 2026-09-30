<!-- Generated file — do not edit; regenerated with the SDK. -->

# TokenResults — operations

Accessor: `client.TokenResults` · Source: `Api/TokenResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTokenResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTokenResults(GetTokenResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TokenResultsResponseResult`
- **Error**: `ApiException<GetTokenResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTokenResultsRequest` | `Requests/TokenResults/GetTokenResultsRequest.cs` |
| `TokenResultsResponseResult` | `Models/TokenResultsResponseResult.cs` |
| `GetTokenResultsError` | `Errors/GetTokenResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTokenResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTokenResultsId(GetTokenResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TokenResultsResponseResult`
- **Error**: `ApiException<GetTokenResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTokenResultsIdRequest` | `Requests/TokenResults/GetTokenResultsIdRequest.cs` |
| `TokenResultsResponseResult` | `Models/TokenResultsResponseResult.cs` |
| `GetTokenResultsIdError` | `Errors/GetTokenResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

