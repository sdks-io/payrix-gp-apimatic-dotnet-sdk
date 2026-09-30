<!-- Generated file — do not edit; regenerated with the SDK. -->

# Members — operations

Accessor: `client.Members` · Source: `Api/Members.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMembersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteMembersId(DeleteMembersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `MembersResponseResult`
- **Error**: `ApiException<DeleteMembersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMembersIdRequest` | `Requests/Members/DeleteMembersIdRequest.cs` |
| `MembersResponseResult` | `Models/MembersResponseResult.cs` |
| `DeleteMembersIdError` | `Errors/DeleteMembersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMembers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMembers(GetMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `MembersResponseResult`
- **Error**: `ApiException<GetMembersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMembersRequest` | `Requests/Members/GetMembersRequest.cs` |
| `MembersResponseResult` | `Models/MembersResponseResult.cs` |
| `GetMembersError` | `Errors/GetMembersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMembersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMembersId(GetMembersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `MembersResponseResult`
- **Error**: `ApiException<GetMembersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMembersIdRequest` | `Requests/Members/GetMembersIdRequest.cs` |
| `MembersResponseResult` | `Models/MembersResponseResult.cs` |
| `GetMembersIdError` | `Errors/GetMembersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostMembers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostMembers(PostMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `MembersResponseResult`
- **Error**: `ApiException<PostMembersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMembersRequest` | `Requests/Members/PostMembersRequest.cs` |
| `MembersPostRequest` | `Models/MembersPostRequest.cs` |
| `MembersResponseResult` | `Models/MembersResponseResult.cs` |
| `PostMembersError` | `Errors/PostMembersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutMembersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutMembersId(PutMembersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `MembersResponseResult`
- **Error**: `ApiException<PutMembersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutMembersIdRequest` | `Requests/Members/PutMembersIdRequest.cs` |
| `MembersPutRequest` | `Models/MembersPutRequest.cs` |
| `MembersResponseResult` | `Models/MembersResponseResult.cs` |
| `PutMembersIdError` | `Errors/PutMembersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

