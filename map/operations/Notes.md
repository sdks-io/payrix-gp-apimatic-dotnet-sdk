<!-- Generated file — do not edit; regenerated with the SDK. -->

# Notes — operations

Accessor: `client.Notes` · Source: `Api/Notes.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteNotesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteNotesId(DeleteNotesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `NotesResponseResult`
- **Error**: `ApiException<DeleteNotesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteNotesIdRequest` | `Requests/Notes/DeleteNotesIdRequest.cs` |
| `NotesResponseResult` | `Models/NotesResponseResult.cs` |
| `DeleteNotesIdError` | `Errors/DeleteNotesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetNotes

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetNotes(GetNotesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `NotesResponseResult`
- **Error**: `ApiException<GetNotesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNotesRequest` | `Requests/Notes/GetNotesRequest.cs` |
| `NotesResponseResult` | `Models/NotesResponseResult.cs` |
| `GetNotesError` | `Errors/GetNotesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetNotesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetNotesId(GetNotesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `NotesResponseResult`
- **Error**: `ApiException<GetNotesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNotesIdRequest` | `Requests/Notes/GetNotesIdRequest.cs` |
| `NotesResponseResult` | `Models/NotesResponseResult.cs` |
| `GetNotesIdError` | `Errors/GetNotesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostNotes

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostNotes(PostNotesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `NotesResponseResult`
- **Error**: `ApiException<PostNotesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostNotesRequest` | `Requests/Notes/PostNotesRequest.cs` |
| `NotesPostRequest` | `Models/NotesPostRequest.cs` |
| `NotesResponseResult` | `Models/NotesResponseResult.cs` |
| `PostNotesError` | `Errors/PostNotesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutNotesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutNotesId(PutNotesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `NotesResponseResult`
- **Error**: `ApiException<PutNotesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutNotesIdRequest` | `Requests/Notes/PutNotesIdRequest.cs` |
| `NotesPutRequest` | `Models/NotesPutRequest.cs` |
| `NotesResponseResult` | `Models/NotesResponseResult.cs` |
| `PutNotesIdError` | `Errors/PutNotesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

