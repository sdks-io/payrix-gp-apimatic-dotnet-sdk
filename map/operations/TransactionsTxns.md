<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionsTxns — operations

Accessor: `client.TransactionsTxns` · Source: `Api/TransactionsTxns.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTxns

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxns(GetTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TxnsResponseResult`
- **Error**: `ApiException<GetTxnsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnsRequest` | `Requests/TransactionsTxns/GetTxnsRequest.cs` |
| `TxnsResponseResult` | `Models/TxnsResponseResult.cs` |
| `GetTxnsError` | `Errors/GetTxnsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTxnsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnsId(GetTxnsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TxnsResponseResult`
- **Error**: `ApiException<GetTxnsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnsIdRequest` | `Requests/TransactionsTxns/GetTxnsIdRequest.cs` |
| `TxnsResponseResult` | `Models/TxnsResponseResult.cs` |
| `GetTxnsIdError` | `Errors/GetTxnsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTxns

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTxns(PostTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TxnsPostResponseResult`
- **Error**: `ApiException<PostTxnsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTxnsRequest` | `Requests/TransactionsTxns/PostTxnsRequest.cs` |
| `TxnsPostRequest` | `Models/TxnsPostRequest.cs` |
| `TxnsPostResponseResult` | `Models/TxnsPostResponseResult.cs` |
| `PostTxnsError` | `Errors/PostTxnsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutTxnsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutTxnsId(PutTxnsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TxnsResponseResult`
- **Error**: `ApiException<PutTxnsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutTxnsIdRequest` | `Requests/TransactionsTxns/PutTxnsIdRequest.cs` |
| `TxnsPutRequest` | `Models/TxnsPutRequest.cs` |
| `TxnsResponseResult` | `Models/TxnsResponseResult.cs` |
| `PutTxnsIdError` | `Errors/PutTxnsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

