<!-- Generated file — do not edit; regenerated with the SDK. -->

# Bins — operations

Accessor: `client.Bins` · Source: `Api/Bins.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetBins

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetBins(GetBinsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `BinsResponseResult`
- **Error**: `ApiException<GetBinsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBinsRequest` | `Requests/Bins/GetBinsRequest.cs` |
| `BinsResponseResult` | `Models/BinsResponseResult.cs` |
| `GetBinsError` | `Errors/GetBinsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetBinsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetBinsId(GetBinsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `BinsResponseResult`
- **Error**: `ApiException<GetBinsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBinsIdRequest` | `Requests/Bins/GetBinsIdRequest.cs` |
| `BinsResponseResult` | `Models/BinsResponseResult.cs` |
| `GetBinsIdError` | `Errors/GetBinsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

