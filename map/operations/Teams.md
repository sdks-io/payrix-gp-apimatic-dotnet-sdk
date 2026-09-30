<!-- Generated file — do not edit; regenerated with the SDK. -->

# Teams — operations

Accessor: `client.Teams` · Source: `Api/Teams.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTeamsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteTeamsId(DeleteTeamsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TeamsResponseResult`
- **Error**: `ApiException<DeleteTeamsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTeamsIdRequest` | `Requests/Teams/DeleteTeamsIdRequest.cs` |
| `TeamsResponseResult` | `Models/TeamsResponseResult.cs` |
| `DeleteTeamsIdError` | `Errors/DeleteTeamsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTeams

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTeams(GetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TeamsResponseResult`
- **Error**: `ApiException<GetTeamsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTeamsRequest` | `Requests/Teams/GetTeamsRequest.cs` |
| `TeamsResponseResult` | `Models/TeamsResponseResult.cs` |
| `GetTeamsError` | `Errors/GetTeamsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTeamsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTeamsId(GetTeamsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TeamsResponseResult`
- **Error**: `ApiException<GetTeamsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTeamsIdRequest` | `Requests/Teams/GetTeamsIdRequest.cs` |
| `TeamsResponseResult` | `Models/TeamsResponseResult.cs` |
| `GetTeamsIdError` | `Errors/GetTeamsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTeams

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTeams(PostTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TeamsResponseResult`
- **Error**: `ApiException<PostTeamsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTeamsRequest` | `Requests/Teams/PostTeamsRequest.cs` |
| `TeamsPostRequest` | `Models/TeamsPostRequest.cs` |
| `TeamsResponseResult` | `Models/TeamsResponseResult.cs` |
| `PostTeamsError` | `Errors/PostTeamsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutTeamsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutTeamsId(PutTeamsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TeamsResponseResult`
- **Error**: `ApiException<PutTeamsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutTeamsIdRequest` | `Requests/Teams/PutTeamsIdRequest.cs` |
| `TeamsPutRequest` | `Models/TeamsPutRequest.cs` |
| `TeamsResponseResult` | `Models/TeamsResponseResult.cs` |
| `PutTeamsIdError` | `Errors/PutTeamsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

