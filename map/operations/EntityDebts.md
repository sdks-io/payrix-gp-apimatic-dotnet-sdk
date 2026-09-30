<!-- Generated file — do not edit; regenerated with the SDK. -->

# EntityDebts — operations

Accessor: `client.EntityDebts` · Source: `Api/EntityDebts.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEntityDebts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityDebts(GetEntityDebtsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntityDebtsResponseResult`
- **Error**: `ApiException<GetEntityDebtsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityDebtsRequest` | `Requests/EntityDebts/GetEntityDebtsRequest.cs` |
| `EntityDebtsResponseResult` | `Models/EntityDebtsResponseResult.cs` |
| `GetEntityDebtsError` | `Errors/GetEntityDebtsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntityDebtsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityDebtsId(GetEntityDebtsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntityDebtsResponseResult`
- **Error**: `ApiException<GetEntityDebtsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityDebtsIdRequest` | `Requests/EntityDebts/GetEntityDebtsIdRequest.cs` |
| `EntityDebtsResponseResult` | `Models/EntityDebtsResponseResult.cs` |
| `GetEntityDebtsIdError` | `Errors/GetEntityDebtsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

