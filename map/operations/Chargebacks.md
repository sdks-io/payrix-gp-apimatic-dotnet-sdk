<!-- Generated file — do not edit; regenerated with the SDK. -->

# Chargebacks — operations

Accessor: `client.Chargebacks` · Source: `Api/Chargebacks.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetChargebacks

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebacks(GetChargebacksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ChargebacksResponseResult`
- **Error**: `ApiException<GetChargebacksError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebacksRequest` | `Requests/Chargebacks/GetChargebacksRequest.cs` |
| `ChargebacksResponseResult` | `Models/ChargebacksResponseResult.cs` |
| `GetChargebacksError` | `Errors/GetChargebacksError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChargebacksId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebacksId(GetChargebacksIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ChargebacksResponseResult`
- **Error**: `ApiException<GetChargebacksIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebacksIdRequest` | `Requests/Chargebacks/GetChargebacksIdRequest.cs` |
| `ChargebacksResponseResult` | `Models/ChargebacksResponseResult.cs` |
| `GetChargebacksIdError` | `Errors/GetChargebacksIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

