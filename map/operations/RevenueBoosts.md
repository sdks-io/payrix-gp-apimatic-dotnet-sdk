<!-- Generated file — do not edit; regenerated with the SDK. -->

# RevenueBoosts — operations

Accessor: `client.RevenueBoosts` · Source: `Api/RevenueBoosts.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetRevenueBoosts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetRevenueBoosts(GetRevenueBoostsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `RevenueBoostsResponseResult`
- **Error**: `ApiException<GetRevenueBoostsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRevenueBoostsRequest` | `Requests/RevenueBoosts/GetRevenueBoostsRequest.cs` |
| `RevenueBoostsResponseResult` | `Models/RevenueBoostsResponseResult.cs` |
| `GetRevenueBoostsError` | `Errors/GetRevenueBoostsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetRevenueBoostsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetRevenueBoostsId(GetRevenueBoostsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `RevenueBoostsResponseResult`
- **Error**: `ApiException<GetRevenueBoostsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRevenueBoostsIdRequest` | `Requests/RevenueBoosts/GetRevenueBoostsIdRequest.cs` |
| `RevenueBoostsResponseResult` | `Models/RevenueBoostsResponseResult.cs` |
| `GetRevenueBoostsIdError` | `Errors/GetRevenueBoostsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

