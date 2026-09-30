<!-- Generated file — do not edit; regenerated with the SDK. -->

# FraudSightEnablements — operations

Accessor: `client.FraudSightEnablements` · Source: `Api/FraudSightEnablements.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFraudSightEnablements

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFraudSightEnablements(GetFraudSightEnablementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `FraudSightEnablementsResponseResult`
- **Error**: `ApiException<GetFraudSightEnablementsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFraudSightEnablementsRequest` | `Requests/FraudSightEnablements/GetFraudSightEnablementsRequest.cs` |
| `FraudSightEnablementsResponseResult` | `Models/FraudSightEnablementsResponseResult.cs` |
| `GetFraudSightEnablementsError` | `Errors/GetFraudSightEnablementsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetFraudSightEnablementsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetFraudSightEnablementsId(GetFraudSightEnablementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `FraudSightEnablementsResponseResult`
- **Error**: `ApiException<GetFraudSightEnablementsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFraudSightEnablementsIdRequest` | `Requests/FraudSightEnablements/GetFraudSightEnablementsIdRequest.cs` |
| `FraudSightEnablementsResponseResult` | `Models/FraudSightEnablementsResponseResult.cs` |
| `GetFraudSightEnablementsIdError` | `Errors/GetFraudSightEnablementsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

