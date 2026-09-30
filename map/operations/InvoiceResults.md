<!-- Generated file — do not edit; regenerated with the SDK. -->

# InvoiceResults — operations

Accessor: `client.InvoiceResults` · Source: `Api/InvoiceResults.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetInvoiceResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceResults(GetInvoiceResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `InvoiceResultsResponseResult`
- **Error**: `ApiException<GetInvoiceResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceResultsRequest` | `Requests/InvoiceResults/GetInvoiceResultsRequest.cs` |
| `InvoiceResultsResponseResult` | `Models/InvoiceResultsResponseResult.cs` |
| `GetInvoiceResultsError` | `Errors/GetInvoiceResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoiceResultsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceResultsId(GetInvoiceResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `InvoiceResultsResponseResult`
- **Error**: `ApiException<GetInvoiceResultsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceResultsIdRequest` | `Requests/InvoiceResults/GetInvoiceResultsIdRequest.cs` |
| `InvoiceResultsResponseResult` | `Models/InvoiceResultsResponseResult.cs` |
| `GetInvoiceResultsIdError` | `Errors/GetInvoiceResultsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostInvoiceResults

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostInvoiceResults(PostInvoiceResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvoiceResultsResponseResult`
- **Error**: `ApiException<PostInvoiceResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostInvoiceResultsRequest` | `Requests/InvoiceResults/PostInvoiceResultsRequest.cs` |
| `InvoiceResultPostRequest` | `Models/InvoiceResultPostRequest.cs` |
| `InvoiceResultsResponseResult` | `Models/InvoiceResultsResponseResult.cs` |
| `PostInvoiceResultsError` | `Errors/PostInvoiceResultsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

