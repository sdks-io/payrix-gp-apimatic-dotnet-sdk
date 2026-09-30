<!-- Generated file — do not edit; regenerated with the SDK. -->

# FundOrigins — operations

Accessor: `client.FundOrigins` · Source: `Api/FundOrigins.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFundOrigins

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFundOrigins(GetFundOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `FundOriginsResponseResult`
- **Error**: `ApiException<GetFundOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFundOriginsRequest` | `Requests/FundOrigins/GetFundOriginsRequest.cs` |
| `FundOriginsResponseResult` | `Models/FundOriginsResponseResult.cs` |
| `GetFundOriginsError` | `Errors/GetFundOriginsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetFundOriginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFundOriginsId(GetFundOriginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `FundOriginsResponseResult`
- **Error**: `ApiException<GetFundOriginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFundOriginsIdRequest` | `Requests/FundOrigins/GetFundOriginsIdRequest.cs` |
| `FundOriginsResponseResult` | `Models/FundOriginsResponseResult.cs` |
| `GetFundOriginsIdError` | `Errors/GetFundOriginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

