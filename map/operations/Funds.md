<!-- Generated file — do not edit; regenerated with the SDK. -->

# Funds — operations

Accessor: `client.Funds` · Source: `Api/Funds.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFunds

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFunds(GetFundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `FundsResponseResult`
- **Error**: `ApiException<GetFundsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFundsRequest` | `Requests/Funds/GetFundsRequest.cs` |
| `FundsResponseResult` | `Models/FundsResponseResult.cs` |
| `GetFundsError` | `Errors/GetFundsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetFundsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFundsId(GetFundsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `FundsResponseResult`
- **Error**: `ApiException<GetFundsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFundsIdRequest` | `Requests/Funds/GetFundsIdRequest.cs` |
| `FundsResponseResult` | `Models/FundsResponseResult.cs` |
| `GetFundsIdError` | `Errors/GetFundsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

