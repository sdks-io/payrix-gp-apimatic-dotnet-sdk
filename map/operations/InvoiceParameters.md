<!-- Generated file — do not edit; regenerated with the SDK. -->

# InvoiceParameters — operations

Accessor: `client.InvoiceParameters` · Source: `Api/InvoiceParameters.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteInvoiceParametersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteInvoiceParametersId(DeleteInvoiceParametersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `InvoiceParametersResponseResult`
- **Error**: `ApiException<DeleteInvoiceParametersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteInvoiceParametersIdRequest` | `Requests/InvoiceParameters/DeleteInvoiceParametersIdRequest.cs` |
| `InvoiceParametersResponseResult` | `Models/InvoiceParametersResponseResult.cs` |
| `DeleteInvoiceParametersIdError` | `Errors/DeleteInvoiceParametersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoiceParameters

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceParameters(GetInvoiceParametersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `InvoiceParametersResponseResult`
- **Error**: `ApiException<GetInvoiceParametersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceParametersRequest` | `Requests/InvoiceParameters/GetInvoiceParametersRequest.cs` |
| `InvoiceParametersResponseResult` | `Models/InvoiceParametersResponseResult.cs` |
| `GetInvoiceParametersError` | `Errors/GetInvoiceParametersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetInvoiceParametersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetInvoiceParametersId(GetInvoiceParametersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `InvoiceParametersResponseResult`
- **Error**: `ApiException<GetInvoiceParametersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInvoiceParametersIdRequest` | `Requests/InvoiceParameters/GetInvoiceParametersIdRequest.cs` |
| `InvoiceParametersResponseResult` | `Models/InvoiceParametersResponseResult.cs` |
| `GetInvoiceParametersIdError` | `Errors/GetInvoiceParametersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostInvoiceParameters

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostInvoiceParameters(PostInvoiceParametersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvoiceParametersResponseResult`
- **Error**: `ApiException<PostInvoiceParametersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostInvoiceParametersRequest` | `Requests/InvoiceParameters/PostInvoiceParametersRequest.cs` |
| `InvoiceParametersPostRequest` | `Models/InvoiceParametersPostRequest.cs` |
| `InvoiceParametersResponseResult` | `Models/InvoiceParametersResponseResult.cs` |
| `PostInvoiceParametersError` | `Errors/PostInvoiceParametersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutInvoiceParametersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutInvoiceParametersId(PutInvoiceParametersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `InvoiceParametersResponseResult`
- **Error**: `ApiException<PutInvoiceParametersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutInvoiceParametersIdRequest` | `Requests/InvoiceParameters/PutInvoiceParametersIdRequest.cs` |
| `InvoiceParametersPutRequest` | `Models/InvoiceParametersPutRequest.cs` |
| `InvoiceParametersResponseResult` | `Models/InvoiceParametersResponseResult.cs` |
| `PutInvoiceParametersIdError` | `Errors/PutInvoiceParametersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

