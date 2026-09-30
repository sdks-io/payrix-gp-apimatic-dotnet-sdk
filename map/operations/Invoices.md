<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invoices — operations

Accessor: `client.Invoices` · Source: `Api/Invoices.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteInvoicesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteInvoicesId(DeleteInvoicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `InvoicesResponseResult`
- **Error**: `ApiException<DeleteInvoicesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteInvoicesIdRequest` | `Requests/Invoices/DeleteInvoicesIdRequest.cs` |
| `InvoicesResponseResult` | `Models/InvoicesResponseResult.cs` |
| `DeleteInvoicesIdError` | `Errors/DeleteInvoicesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoices

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoices(GetInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `InvoicesResponseResult`
- **Error**: `ApiException<GetInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoicesRequest` | `Requests/Invoices/GetInvoicesRequest.cs` |
| `InvoicesResponseResult` | `Models/InvoicesResponseResult.cs` |
| `GetInvoicesError` | `Errors/GetInvoicesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoicesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoicesId(GetInvoicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `InvoicesResponseResult`
- **Error**: `ApiException<GetInvoicesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoicesIdRequest` | `Requests/Invoices/GetInvoicesIdRequest.cs` |
| `InvoicesResponseResult` | `Models/InvoicesResponseResult.cs` |
| `GetInvoicesIdError` | `Errors/GetInvoicesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostInvoices

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostInvoices(PostInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvoicesResponseResult`
- **Error**: `ApiException<PostInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostInvoicesRequest` | `Requests/Invoices/PostInvoicesRequest.cs` |
| `InvoicesPostRequest` | `Models/InvoicesPostRequest.cs` |
| `InvoicesResponseResult` | `Models/InvoicesResponseResult.cs` |
| `PostInvoicesError` | `Errors/PostInvoicesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutInvoicesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutInvoicesId(PutInvoicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `InvoicesResponseResult`
- **Error**: `ApiException<PutInvoicesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutInvoicesIdRequest` | `Requests/Invoices/PutInvoicesIdRequest.cs` |
| `InvoicesPutRequest` | `Models/InvoicesPutRequest.cs` |
| `InvoicesResponseResult` | `Models/InvoicesResponseResult.cs` |
| `PutInvoicesIdError` | `Errors/PutInvoicesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

