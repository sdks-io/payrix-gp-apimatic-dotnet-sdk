<!-- Generated file — do not edit; regenerated with the SDK. -->

# VasEfeOffers — operations

Accessor: `client.VasEfeOffers` · Source: `Api/VasEfeOffers.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetVasEfeOffers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetVasEfeOffers(GetVasEfeOffersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `VasEfeOffersResponseResult`
- **Error**: `ApiException<GetVasEfeOffersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetVasEfeOffersRequest` | `Requests/VasEfeOffers/GetVasEfeOffersRequest.cs` |
| `VasEfeOffersResponseResult` | `Models/VasEfeOffersResponseResult.cs` |
| `GetVasEfeOffersError` | `Errors/GetVasEfeOffersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetVasEfeOffersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetVasEfeOffersId(GetVasEfeOffersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `VasEfeOffersResponseResult`
- **Error**: `ApiException<GetVasEfeOffersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetVasEfeOffersIdRequest` | `Requests/VasEfeOffers/GetVasEfeOffersIdRequest.cs` |
| `VasEfeOffersResponseResult` | `Models/VasEfeOffersResponseResult.cs` |
| `GetVasEfeOffersIdError` | `Errors/GetVasEfeOffersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

