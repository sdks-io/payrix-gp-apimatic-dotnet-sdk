<!-- Generated file — do not edit; regenerated with the SDK. -->

# PendingEntryApi — operations

Accessor: `client.PendingEntryApi` · Source: `Api/PendingEntryApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPendingEntries

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPendingEntries(GetPendingEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `PendingEntriesResponseResult`
- **Error**: `ApiException<GetPendingEntriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPendingEntriesRequest` | `Requests/PendingEntryApi/GetPendingEntriesRequest.cs` |
| `PendingEntriesResponseResult` | `Models/PendingEntriesResponseResult.cs` |
| `GetPendingEntriesError` | `Errors/GetPendingEntriesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPendingEntriesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPendingEntriesId(GetPendingEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `PendingEntriesResponseResult`
- **Error**: `ApiException<GetPendingEntriesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPendingEntriesIdRequest` | `Requests/PendingEntryApi/GetPendingEntriesIdRequest.cs` |
| `PendingEntriesResponseResult` | `Models/PendingEntriesResponseResult.cs` |
| `GetPendingEntriesIdError` | `Errors/GetPendingEntriesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

