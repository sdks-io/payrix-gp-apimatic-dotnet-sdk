<!-- Generated file — do not edit; regenerated with the SDK. -->

# Disbursements — operations

Accessor: `client.Disbursements` · Source: `Api/Disbursements.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDisbursements

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDisbursements(GetDisbursementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `DisbursementsResponseResult`
- **Error**: `ApiException<GetDisbursementsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisbursementsRequest` | `Requests/Disbursements/GetDisbursementsRequest.cs` |
| `DisbursementsResponseResult` | `Models/DisbursementsResponseResult.cs` |
| `GetDisbursementsError` | `Errors/GetDisbursementsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDisbursementsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDisbursementsId(GetDisbursementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `DisbursementsResponseResult`
- **Error**: `ApiException<GetDisbursementsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisbursementsIdRequest` | `Requests/Disbursements/GetDisbursementsIdRequest.cs` |
| `DisbursementsResponseResult` | `Models/DisbursementsResponseResult.cs` |
| `GetDisbursementsIdError` | `Errors/GetDisbursementsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

