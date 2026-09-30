<!-- Generated file — do not edit; regenerated with the SDK. -->

# Customers — operations

Accessor: `client.Customers` · Source: `Api/Customers.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCustomersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteCustomersId(DeleteCustomersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CustomersResponseResult`
- **Error**: `ApiException<DeleteCustomersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCustomersIdRequest` | `Requests/Customers/DeleteCustomersIdRequest.cs` |
| `CustomersResponseResult` | `Models/CustomersResponseResult.cs` |
| `DeleteCustomersIdError` | `Errors/DeleteCustomersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetCustomers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetCustomers(GetCustomersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `CustomersResponseResult`
- **Error**: `ApiException<GetCustomersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCustomersRequest` | `Requests/Customers/GetCustomersRequest.cs` |
| `CustomersResponseResult` | `Models/CustomersResponseResult.cs` |
| `GetCustomersError` | `Errors/GetCustomersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetCustomersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetCustomersId(GetCustomersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `CustomersResponseResult`
- **Error**: `ApiException<GetCustomersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCustomersIdRequest` | `Requests/Customers/GetCustomersIdRequest.cs` |
| `CustomersResponseResult` | `Models/CustomersResponseResult.cs` |
| `GetCustomersIdError` | `Errors/GetCustomersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostCustomers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostCustomers(PostCustomersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CustomersResponseResult`
- **Error**: `ApiException<PostCustomersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCustomersRequest` | `Requests/Customers/PostCustomersRequest.cs` |
| `CustomersPostRequest` | `Models/CustomersPostRequest.cs` |
| `CustomersResponseResult` | `Models/CustomersResponseResult.cs` |
| `PostCustomersError` | `Errors/PostCustomersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutCustomersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutCustomersId(PutCustomersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `CustomersResponseResult`
- **Error**: `ApiException<PutCustomersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutCustomersIdRequest` | `Requests/Customers/PutCustomersIdRequest.cs` |
| `CustomersPutRequest` | `Models/CustomersPutRequest.cs` |
| `CustomersResponseResult` | `Models/CustomersResponseResult.cs` |
| `PutCustomersIdError` | `Errors/PutCustomersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

