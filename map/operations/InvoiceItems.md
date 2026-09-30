<!-- Generated file — do not edit; regenerated with the SDK. -->

# InvoiceItems — operations

Accessor: `client.InvoiceItems` · Source: `Api/InvoiceItems.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteInvoiceItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteInvoiceItemsId(DeleteInvoiceItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `InvoiceItemsResponseResult`
- **Error**: `ApiException<DeleteInvoiceItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteInvoiceItemsIdRequest` | `Requests/InvoiceItems/DeleteInvoiceItemsIdRequest.cs` |
| `InvoiceItemsResponseResult` | `Models/InvoiceItemsResponseResult.cs` |
| `DeleteInvoiceItemsIdError` | `Errors/DeleteInvoiceItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoiceItems

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceItems(GetInvoiceItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `InvoiceItemsResponseResult`
- **Error**: `ApiException<GetInvoiceItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceItemsRequest` | `Requests/InvoiceItems/GetInvoiceItemsRequest.cs` |
| `InvoiceItemsResponseResult` | `Models/InvoiceItemsResponseResult.cs` |
| `GetInvoiceItemsError` | `Errors/GetInvoiceItemsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoiceItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceItemsId(GetInvoiceItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `InvoiceItemsResponseResult`
- **Error**: `ApiException<GetInvoiceItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceItemsIdRequest` | `Requests/InvoiceItems/GetInvoiceItemsIdRequest.cs` |
| `InvoiceItemsResponseResult` | `Models/InvoiceItemsResponseResult.cs` |
| `GetInvoiceItemsIdError` | `Errors/GetInvoiceItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostInvoiceItems

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostInvoiceItems(PostInvoiceItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvoiceItemsResponseResult`
- **Error**: `ApiException<PostInvoiceItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostInvoiceItemsRequest` | `Requests/InvoiceItems/PostInvoiceItemsRequest.cs` |
| `InvoiceItemsPostRequest` | `Models/InvoiceItemsPostRequest.cs` |
| `InvoiceItemsResponseResult` | `Models/InvoiceItemsResponseResult.cs` |
| `PostInvoiceItemsError` | `Errors/PostInvoiceItemsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutInvoiceItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutInvoiceItemsId(PutInvoiceItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `InvoiceItemsResponseResult`
- **Error**: `ApiException<PutInvoiceItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutInvoiceItemsIdRequest` | `Requests/InvoiceItems/PutInvoiceItemsIdRequest.cs` |
| `InvoiceItemsPutRequest` | `Models/InvoiceItemsPutRequest.cs` |
| `InvoiceItemsResponseResult` | `Models/InvoiceItemsResponseResult.cs` |
| `PutInvoiceItemsIdError` | `Errors/PutInvoiceItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

