<!-- Generated file — do not edit; regenerated with the SDK. -->

# NoteDocuments — operations

Accessor: `client.NoteDocuments` · Source: `Api/NoteDocuments.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteNoteDocumentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteNoteDocumentsId(DeleteNoteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `NoteDocumentsResponseResult`
- **Error**: `ApiException<DeleteNoteDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteNoteDocumentsIdRequest` | `Requests/NoteDocuments/DeleteNoteDocumentsIdRequest.cs` |
| `NoteDocumentsResponseResult` | `Models/NoteDocumentsResponseResult.cs` |
| `DeleteNoteDocumentsIdError` | `Errors/DeleteNoteDocumentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetNoteDocuments

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetNoteDocuments(GetNoteDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `NoteDocumentsResponseResult`
- **Error**: `ApiException<GetNoteDocumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNoteDocumentsRequest` | `Requests/NoteDocuments/GetNoteDocumentsRequest.cs` |
| `NoteDocumentsResponseResult` | `Models/NoteDocumentsResponseResult.cs` |
| `GetNoteDocumentsError` | `Errors/GetNoteDocumentsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetNoteDocumentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetNoteDocumentsId(GetNoteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `NoteDocumentsResponseResult`
- **Error**: `ApiException<GetNoteDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNoteDocumentsIdRequest` | `Requests/NoteDocuments/GetNoteDocumentsIdRequest.cs` |
| `NoteDocumentsResponseResult` | `Models/NoteDocumentsResponseResult.cs` |
| `GetNoteDocumentsIdError` | `Errors/GetNoteDocumentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostNoteDocuments

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostNoteDocuments(PostNoteDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `NoteDocumentsResponseResult`
- **Error**: `ApiException<PostNoteDocumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostNoteDocumentsRequest` | `Requests/NoteDocuments/PostNoteDocumentsRequest.cs` |
| `NoteDocumentsPostRequest` | `Models/NoteDocumentsPostRequest.cs` |
| `NoteDocumentsResponseResult` | `Models/NoteDocumentsResponseResult.cs` |
| `PostNoteDocumentsError` | `Errors/PostNoteDocumentsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutNoteDocumentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutNoteDocumentsId(PutNoteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `NoteDocumentsResponseResult`
- **Error**: `ApiException<PutNoteDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutNoteDocumentsIdRequest` | `Requests/NoteDocuments/PutNoteDocumentsIdRequest.cs` |
| `NoteDocumentsPutRequest` | `Models/NoteDocumentsPutRequest.cs` |
| `NoteDocumentsResponseResult` | `Models/NoteDocumentsResponseResult.cs` |
| `PutNoteDocumentsIdError` | `Errors/PutNoteDocumentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

