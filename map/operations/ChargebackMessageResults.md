<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChargebackMessageResults — operations

Accessor: `client.ChargebackMessageResults` · Source: `Api/ChargebackMessageResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetChargebackMessageResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackMessageResults(GetChargebackMessageResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ChargebackMessageResultsResponseResult`
- **Error**: `ApiException<GetChargebackMessageResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackMessageResultsRequest` | `Requests/ChargebackMessageResults/GetChargebackMessageResultsRequest.cs` |
| `ChargebackMessageResultsResponseResult` | `Models/ChargebackMessageResultsResponseResult.cs` |
| `GetChargebackMessageResultsError` | `Errors/GetChargebackMessageResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChargebackMessageResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackMessageResultsId(GetChargebackMessageResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ChargebackMessageResultsResponseResult`
- **Error**: `ApiException<GetChargebackMessageResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackMessageResultsIdRequest` | `Requests/ChargebackMessageResults/GetChargebackMessageResultsIdRequest.cs` |
| `ChargebackMessageResultsResponseResult` | `Models/ChargebackMessageResultsResponseResult.cs` |
| `GetChargebackMessageResultsIdError` | `Errors/GetChargebackMessageResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

