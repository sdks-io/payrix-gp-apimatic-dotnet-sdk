<!-- Generated file — do not edit; regenerated with the SDK. -->

# InvoiceLineItems — operations

Accessor: `client.InvoiceLineItems` · Source: `Api/InvoiceLineItems.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteInvoiceLineItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteInvoiceLineItemsId(DeleteInvoiceLineItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `InvoiceLineItemsResponseResult`
- **Error**: `ApiException<DeleteInvoiceLineItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteInvoiceLineItemsIdRequest` | `Requests/InvoiceLineItems/DeleteInvoiceLineItemsIdRequest.cs` |
| `InvoiceLineItemsResponseResult` | `Models/InvoiceLineItemsResponseResult.cs` |
| `DeleteInvoiceLineItemsIdError` | `Errors/DeleteInvoiceLineItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoiceLineItems

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceLineItems(GetInvoiceLineItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `InvoiceLineItemsResponseResult`
- **Error**: `ApiException<GetInvoiceLineItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceLineItemsRequest` | `Requests/InvoiceLineItems/GetInvoiceLineItemsRequest.cs` |
| `InvoiceLineItemsResponseResult` | `Models/InvoiceLineItemsResponseResult.cs` |
| `GetInvoiceLineItemsError` | `Errors/GetInvoiceLineItemsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoiceLineItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceLineItemsId(GetInvoiceLineItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `InvoiceLineItemsResponseResult`
- **Error**: `ApiException<GetInvoiceLineItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceLineItemsIdRequest` | `Requests/InvoiceLineItems/GetInvoiceLineItemsIdRequest.cs` |
| `InvoiceLineItemsResponseResult` | `Models/InvoiceLineItemsResponseResult.cs` |
| `GetInvoiceLineItemsIdError` | `Errors/GetInvoiceLineItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostInvoiceLineItems

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostInvoiceLineItems(PostInvoiceLineItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvoiceLineItemsResponseResult`
- **Error**: `ApiException<PostInvoiceLineItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostInvoiceLineItemsRequest` | `Requests/InvoiceLineItems/PostInvoiceLineItemsRequest.cs` |
| `InvoiceLineItemsPostRequest` | `Models/InvoiceLineItemsPostRequest.cs` |
| `InvoiceLineItemsResponseResult` | `Models/InvoiceLineItemsResponseResult.cs` |
| `PostInvoiceLineItemsError` | `Errors/PostInvoiceLineItemsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutInvoiceLineItemsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutInvoiceLineItemsId(PutInvoiceLineItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `InvoiceLineItemsResponseResult`
- **Error**: `ApiException<PutInvoiceLineItemsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutInvoiceLineItemsIdRequest` | `Requests/InvoiceLineItems/PutInvoiceLineItemsIdRequest.cs` |
| `InvoiceLineItemsPutRequest` | `Models/InvoiceLineItemsPutRequest.cs` |
| `InvoiceLineItemsResponseResult` | `Models/InvoiceLineItemsResponseResult.cs` |
| `PutInvoiceLineItemsIdError` | `Errors/PutInvoiceLineItemsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

