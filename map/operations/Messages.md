<!-- Generated file — do not edit; regenerated with the SDK. -->

# Messages — operations

Accessor: `client.Messages` · Source: `Api/Messages.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMessages

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMessages(GetMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `MessagesResponseResult`
- **Error**: `ApiException<GetMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMessagesRequest` | `Requests/Messages/GetMessagesRequest.cs` |
| `MessagesResponseResult` | `Models/MessagesResponseResult.cs` |
| `GetMessagesError` | `Errors/GetMessagesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMessagesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMessagesId(GetMessagesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `MessagesResponseResult`
- **Error**: `ApiException<GetMessagesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMessagesIdRequest` | `Requests/Messages/GetMessagesIdRequest.cs` |
| `MessagesResponseResult` | `Models/MessagesResponseResult.cs` |
| `GetMessagesIdError` | `Errors/GetMessagesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostMessages

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostMessages(PostMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `MessagesPostResponseResult`
- **Error**: `ApiException<PostMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMessagesRequest` | `Requests/Messages/PostMessagesRequest.cs` |
| `MessagesPostRequest` | `Models/MessagesPostRequest.cs` |
| `MessagesPostResponseResult` | `Models/MessagesPostResponseResult.cs` |
| `PostMessagesError` | `Errors/PostMessagesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutMessagesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutMessagesId(PutMessagesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `MessagesResponseResult`
- **Error**: `ApiException<PutMessagesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutMessagesIdRequest` | `Requests/Messages/PutMessagesIdRequest.cs` |
| `MessagesPutRequest` | `Models/MessagesPutRequest.cs` |
| `MessagesResponseResult` | `Models/MessagesResponseResult.cs` |
| `PutMessagesIdError` | `Errors/PutMessagesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

