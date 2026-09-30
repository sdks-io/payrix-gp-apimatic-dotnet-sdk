<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionMetadatas — operations

Accessor: `client.TransactionMetadatas` · Source: `Api/TransactionMetadatas.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTxnMetadatas

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnMetadatas(GetTxnMetadatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `TxnMetaDatasResponseResult`
- **Error**: `ApiException<GetTxnMetadatasError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnMetadatasRequest` | `Requests/TransactionMetadatas/GetTxnMetadatasRequest.cs` |
| `TxnMetaDatasResponseResult` | `Models/TxnMetaDatasResponseResult.cs` |
| `GetTxnMetadatasError` | `Errors/GetTxnMetadatasError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetTxnMetadatasId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetTxnMetadatasId(GetTxnMetadatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `TxnMetaDatasResponseResult`
- **Error**: `ApiException<GetTxnMetadatasIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTxnMetadatasIdRequest` | `Requests/TransactionMetadatas/GetTxnMetadatasIdRequest.cs` |
| `TxnMetaDatasResponseResult` | `Models/TxnMetaDatasResponseResult.cs` |
| `GetTxnMetadatasIdError` | `Errors/GetTxnMetadatasIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

