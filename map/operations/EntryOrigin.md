<!-- Generated file — do not edit; regenerated with the SDK. -->

# EntryOrigin — operations

Accessor: `client.EntryOrigin` · Source: `Api/EntryOrigin.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEntryOrigins

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntryOrigins(GetEntryOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntryOriginsResponseResult`
- **Error**: `ApiException<GetEntryOriginsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntryOriginsRequest` | `Requests/EntryOrigin/GetEntryOriginsRequest.cs` |
| `EntryOriginsResponseResult` | `Models/EntryOriginsResponseResult.cs` |
| `GetEntryOriginsError` | `Errors/GetEntryOriginsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntryOriginsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntryOriginsId(GetEntryOriginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntryOriginsResponseResult`
- **Error**: `ApiException<GetEntryOriginsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntryOriginsIdRequest` | `Requests/EntryOrigin/GetEntryOriginsIdRequest.cs` |
| `EntryOriginsResponseResult` | `Models/EntryOriginsResponseResult.cs` |
| `GetEntryOriginsIdError` | `Errors/GetEntryOriginsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

