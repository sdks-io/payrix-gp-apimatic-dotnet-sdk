<!-- Generated file — do not edit; regenerated with the SDK. -->

# FraudSightResults — operations

Accessor: `client.FraudSightResults` · Source: `Api/FraudSightResults.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFraudSightResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFraudSightResults(GetFraudSightResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `FraudSightResultsResponseResult`
- **Error**: `ApiException<GetFraudSightResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFraudSightResultsRequest` | `Requests/FraudSightResults/GetFraudSightResultsRequest.cs` |
| `FraudSightResultsResponseResult` | `Models/FraudSightResultsResponseResult.cs` |
| `GetFraudSightResultsError` | `Errors/GetFraudSightResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetFraudSightResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFraudSightResultsId(GetFraudSightResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `FraudSightResultsResponseResult`
- **Error**: `ApiException<GetFraudSightResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFraudSightResultsIdRequest` | `Requests/FraudSightResults/GetFraudSightResultsIdRequest.cs` |
| `FraudSightResultsResponseResult` | `Models/FraudSightResultsResponseResult.cs` |
| `GetFraudSightResultsIdError` | `Errors/GetFraudSightResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

