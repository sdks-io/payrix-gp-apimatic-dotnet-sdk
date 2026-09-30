<!-- Generated file — do not edit; regenerated with the SDK. -->

# PinlessDebitConversions — operations

Accessor: `client.PinlessDebitConversions` · Source: `Api/PinlessDebitConversions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPinlessDebitConversions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPinlessDebitConversions(GetPinlessDebitConversionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `PinlessDebitConversionsResponseResult`
- **Error**: `ApiException<GetPinlessDebitConversionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPinlessDebitConversionsRequest` | `Requests/PinlessDebitConversions/GetPinlessDebitConversionsRequest.cs` |
| `PinlessDebitConversionsResponseResult` | `Models/PinlessDebitConversionsResponseResult.cs` |
| `GetPinlessDebitConversionsError` | `Errors/GetPinlessDebitConversionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPinlessDebitConversionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPinlessDebitConversionsId(GetPinlessDebitConversionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `PinlessDebitConversionsResponseResult`
- **Error**: `ApiException<GetPinlessDebitConversionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPinlessDebitConversionsIdRequest` | `Requests/PinlessDebitConversions/GetPinlessDebitConversionsIdRequest.cs` |
| `PinlessDebitConversionsResponseResult` | `Models/PinlessDebitConversionsResponseResult.cs` |
| `GetPinlessDebitConversionsIdError` | `Errors/GetPinlessDebitConversionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

