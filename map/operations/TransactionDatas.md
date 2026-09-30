<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionDatas — operations

Accessor: `client.TransactionDatas` · Source: `Api/TransactionDatas.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTxnDatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnDatas(GetTxnDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TxnDatasResponseResult`
- **Error**: `ApiException<GetTxnDatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnDatasRequest` | `Requests/TransactionDatas/GetTxnDatasRequest.cs` |
| `TxnDatasResponseResult` | `Models/TxnDatasResponseResult.cs` |
| `GetTxnDatasError` | `Errors/GetTxnDatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTxnDatasId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnDatasId(GetTxnDatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TxnDatasResponseResult`
- **Error**: `ApiException<GetTxnDatasIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnDatasIdRequest` | `Requests/TransactionDatas/GetTxnDatasIdRequest.cs` |
| `TxnDatasResponseResult` | `Models/TxnDatasResponseResult.cs` |
| `GetTxnDatasIdError` | `Errors/GetTxnDatasIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostTxnDatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostTxnDatas(PostTxnDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TxnDatasResponseResult`
- **Error**: `ApiException<PostTxnDatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTxnDatasRequest` | `Requests/TransactionDatas/PostTxnDatasRequest.cs` |
| `TxnDatasPostRequest` | `Models/TxnDatasPostRequest.cs` |
| `TxnDatasResponseResult` | `Models/TxnDatasResponseResult.cs` |
| `PostTxnDatasError` | `Errors/PostTxnDatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

