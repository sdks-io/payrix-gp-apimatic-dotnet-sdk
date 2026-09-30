<!-- Generated file — do not edit; regenerated with the SDK. -->

# Adjustments — operations

Accessor: `client.Adjustments` · Source: `Api/Adjustments.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAdjustments

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAdjustments(GetAdjustmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AdjustmentsResponseResult`
- **Error**: `ApiException<GetAdjustmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAdjustmentsRequest` | `Requests/Adjustments/GetAdjustmentsRequest.cs` |
| `AdjustmentsResponseResult` | `Models/AdjustmentsResponseResult.cs` |
| `GetAdjustmentsError` | `Errors/GetAdjustmentsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAdjustmentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAdjustmentsId(GetAdjustmentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AdjustmentsResponseResult`
- **Error**: `ApiException<GetAdjustmentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAdjustmentsIdRequest` | `Requests/Adjustments/GetAdjustmentsIdRequest.cs` |
| `AdjustmentsResponseResult` | `Models/AdjustmentsResponseResult.cs` |
| `GetAdjustmentsIdError` | `Errors/GetAdjustmentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

