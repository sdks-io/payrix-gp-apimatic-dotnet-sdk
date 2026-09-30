<!-- Generated file — do not edit; regenerated with the SDK. -->

# DisbursementEntries — operations

Accessor: `client.DisbursementEntries` · Source: `Api/DisbursementEntries.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDisbursementEntries

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDisbursementEntries(GetDisbursementEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `DisbursementEntriesResponseResult`
- **Error**: `ApiException<GetDisbursementEntriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisbursementEntriesRequest` | `Requests/DisbursementEntries/GetDisbursementEntriesRequest.cs` |
| `DisbursementEntriesResponseResult` | `Models/DisbursementEntriesResponseResult.cs` |
| `GetDisbursementEntriesError` | `Errors/GetDisbursementEntriesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDisbursementEntriesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDisbursementEntriesId(GetDisbursementEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `DisbursementEntriesResponseResult`
- **Error**: `ApiException<GetDisbursementEntriesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisbursementEntriesIdRequest` | `Requests/DisbursementEntries/GetDisbursementEntriesIdRequest.cs` |
| `DisbursementEntriesResponseResult` | `Models/DisbursementEntriesResponseResult.cs` |
| `GetDisbursementEntriesIdError` | `Errors/GetDisbursementEntriesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

