<!-- Generated file — do not edit; regenerated with the SDK. -->

# Contacts — operations

Accessor: `client.Contacts` · Source: `Api/Contacts.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteContactsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteContactsId(DeleteContactsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ContactsResponseResult`
- **Error**: `ApiException<DeleteContactsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteContactsIdRequest` | `Requests/Contacts/DeleteContactsIdRequest.cs` |
| `ContactsResponseResult` | `Models/ContactsResponseResult.cs` |
| `DeleteContactsIdError` | `Errors/DeleteContactsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetContacts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetContacts(GetContactsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ContactsResponseResult`
- **Error**: `ApiException<GetContactsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetContactsRequest` | `Requests/Contacts/GetContactsRequest.cs` |
| `ContactsResponseResult` | `Models/ContactsResponseResult.cs` |
| `GetContactsError` | `Errors/GetContactsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetContactsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetContactsId(GetContactsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ContactsResponseResult`
- **Error**: `ApiException<GetContactsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetContactsIdRequest` | `Requests/Contacts/GetContactsIdRequest.cs` |
| `ContactsResponseResult` | `Models/ContactsResponseResult.cs` |
| `GetContactsIdError` | `Errors/GetContactsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostContacts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostContacts(PostContactsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ContactsResponseResult`
- **Error**: `ApiException<PostContactsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostContactsRequest` | `Requests/Contacts/PostContactsRequest.cs` |
| `ContactsPostRequest` | `Models/ContactsPostRequest.cs` |
| `ContactsResponseResult` | `Models/ContactsResponseResult.cs` |
| `PostContactsError` | `Errors/PostContactsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutContactsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutContactsId(PutContactsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `ContactsResponseResult`
- **Error**: `ApiException<PutContactsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutContactsIdRequest` | `Requests/Contacts/PutContactsIdRequest.cs` |
| `ContactsPutRequest` | `Models/ContactsPutRequest.cs` |
| `ContactsResponseResult` | `Models/ContactsResponseResult.cs` |
| `PutContactsIdError` | `Errors/PutContactsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

