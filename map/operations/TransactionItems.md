<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionItems — operations

Accessor: `client.TransactionItems` · Source: `Api/TransactionItems.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteItemsId(DeleteItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ItemsResponseResult`
- **Error**: `ApiException<DeleteItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteItemsIdRequest` | `Requests/TransactionItems/DeleteItemsIdRequest.cs` |
| `ItemsResponseResult` | `Models/ItemsResponseResult.cs` |
| `DeleteItemsIdError` | `Errors/DeleteItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetItems

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetItems(GetItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ItemsResponseResult`
- **Error**: `ApiException<GetItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetItemsRequest` | `Requests/TransactionItems/GetItemsRequest.cs` |
| `ItemsResponseResult` | `Models/ItemsResponseResult.cs` |
| `GetItemsError` | `Errors/GetItemsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetItemsId(GetItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ItemsResponseResult`
- **Error**: `ApiException<GetItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetItemsIdRequest` | `Requests/TransactionItems/GetItemsIdRequest.cs` |
| `ItemsResponseResult` | `Models/ItemsResponseResult.cs` |
| `GetItemsIdError` | `Errors/GetItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostItems

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostItems(PostItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemsResponseResult`
- **Error**: `ApiException<PostItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostItemsRequest` | `Requests/TransactionItems/PostItemsRequest.cs` |
| `ItemsPostRequest` | `Models/ItemsPostRequest.cs` |
| `ItemsResponseResult` | `Models/ItemsResponseResult.cs` |
| `PostItemsError` | `Errors/PostItemsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutItemsId(PutItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `ItemsResponseResult`
- **Error**: `ApiException<PutItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutItemsIdRequest` | `Requests/TransactionItems/PutItemsIdRequest.cs` |
| `ItemsPutRequest` | `Models/ItemsPutRequest.cs` |
| `ItemsResponseResult` | `Models/ItemsResponseResult.cs` |
| `PutItemsIdError` | `Errors/PutItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

