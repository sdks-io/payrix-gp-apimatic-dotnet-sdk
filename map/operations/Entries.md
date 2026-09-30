<!-- Generated file — do not edit; regenerated with the SDK. -->

# Entries — operations

Accessor: `client.Entries` · Source: `Api/Entries.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEntries

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntries(GetEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntriesResponseResult`
- **Error**: `ApiException<GetEntriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntriesRequest` | `Requests/Entries/GetEntriesRequest.cs` |
| `EntriesResponseResult` | `Models/EntriesResponseResult.cs` |
| `GetEntriesError` | `Errors/GetEntriesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntriesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntriesId(GetEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntriesResponseResult`
- **Error**: `ApiException<GetEntriesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntriesIdRequest` | `Requests/Entries/GetEntriesIdRequest.cs` |
| `EntriesResponseResult` | `Models/EntriesResponseResult.cs` |
| `GetEntriesIdError` | `Errors/GetEntriesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

