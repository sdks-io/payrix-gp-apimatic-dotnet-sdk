<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChargebackStatuses — operations

Accessor: `client.ChargebackStatuses` · Source: `Api/ChargebackStatuses.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetChargebackStatuses

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackStatuses(GetChargebackStatusesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ChargebackStatusesResponseResult`
- **Error**: `ApiException<GetChargebackStatusesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackStatusesRequest` | `Requests/ChargebackStatuses/GetChargebackStatusesRequest.cs` |
| `ChargebackStatusesResponseResult` | `Models/ChargebackStatusesResponseResult.cs` |
| `GetChargebackStatusesError` | `Errors/GetChargebackStatusesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChargebackStatusesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackStatusesId(GetChargebackStatusesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ChargebackStatusesResponseResult`
- **Error**: `ApiException<GetChargebackStatusesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackStatusesIdRequest` | `Requests/ChargebackStatuses/GetChargebackStatusesIdRequest.cs` |
| `ChargebackStatusesResponseResult` | `Models/ChargebackStatusesResponseResult.cs` |
| `GetChargebackStatusesIdError` | `Errors/GetChargebackStatusesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

