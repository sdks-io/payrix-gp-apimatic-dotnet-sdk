<!-- Generated file — do not edit; regenerated with the SDK. -->

# EmbeddedFinance — operations

Accessor: `client.EmbeddedFinance` · Source: `Api/EmbeddedFinance.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEmbeddedFinance

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEmbeddedFinance(GetEmbeddedFinanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EmbeddedFinanceResponseResult`
- **Error**: `ApiException<GetEmbeddedFinanceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEmbeddedFinanceRequest` | `Requests/EmbeddedFinance/GetEmbeddedFinanceRequest.cs` |
| `EmbeddedFinanceResponseResult` | `Models/EmbeddedFinanceResponseResult.cs` |
| `GetEmbeddedFinanceError` | `Errors/GetEmbeddedFinanceError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEmbeddedFinanceId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEmbeddedFinanceId(GetEmbeddedFinanceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EmbeddedFinanceResponseResult`
- **Error**: `ApiException<GetEmbeddedFinanceIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEmbeddedFinanceIdRequest` | `Requests/EmbeddedFinance/GetEmbeddedFinanceIdRequest.cs` |
| `EmbeddedFinanceResponseResult` | `Models/EmbeddedFinanceResponseResult.cs` |
| `GetEmbeddedFinanceIdError` | `Errors/GetEmbeddedFinanceIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

