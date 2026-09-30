<!-- Generated file — do not edit; regenerated with the SDK. -->

# OrgsVasRevenueBoosts — operations

Accessor: `client.OrgsVasRevenueBoosts` · Source: `Api/OrgsVasRevenueBoosts.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetOrgsVasRevenueBoosts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgsVasRevenueBoosts(GetOrgsVasRevenueBoostsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `OrgsVasRevenueBoostsResponseResult`
- **Error**: `ApiException<GetOrgsVasRevenueBoostsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgsVasRevenueBoostsRequest` | `Requests/OrgsVasRevenueBoosts/GetOrgsVasRevenueBoostsRequest.cs` |
| `OrgsVasRevenueBoostsResponseResult` | `Models/OrgsVasRevenueBoostsResponseResult.cs` |
| `GetOrgsVasRevenueBoostsError` | `Errors/GetOrgsVasRevenueBoostsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOrgsVasRevenueBoostsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgsVasRevenueBoostsId(GetOrgsVasRevenueBoostsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `OrgsVasRevenueBoostsResponseResult`
- **Error**: `ApiException<GetOrgsVasRevenueBoostsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgsVasRevenueBoostsIdRequest` | `Requests/OrgsVasRevenueBoosts/GetOrgsVasRevenueBoostsIdRequest.cs` |
| `OrgsVasRevenueBoostsResponseResult` | `Models/OrgsVasRevenueBoostsResponseResult.cs` |
| `GetOrgsVasRevenueBoostsIdError` | `Errors/GetOrgsVasRevenueBoostsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

