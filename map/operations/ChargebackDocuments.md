<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChargebackDocuments — operations

Accessor: `client.ChargebackDocuments` · Source: `Api/ChargebackDocuments.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteChargebackDocumentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteChargebackDocumentsId(DeleteChargebackDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ChargebackDocumentsResponseResult`
- **Error**: `ApiException<DeleteChargebackDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteChargebackDocumentsIdRequest` | `Requests/ChargebackDocuments/DeleteChargebackDocumentsIdRequest.cs` |
| `ChargebackDocumentsResponseResult` | `Models/ChargebackDocumentsResponseResult.cs` |
| `DeleteChargebackDocumentsIdError` | `Errors/DeleteChargebackDocumentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChargebackDocuments

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackDocuments(GetChargebackDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ChargebackDocumentsResponseResult`
- **Error**: `ApiException<GetChargebackDocumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackDocumentsRequest` | `Requests/ChargebackDocuments/GetChargebackDocumentsRequest.cs` |
| `ChargebackDocumentsResponseResult` | `Models/ChargebackDocumentsResponseResult.cs` |
| `GetChargebackDocumentsError` | `Errors/GetChargebackDocumentsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChargebackDocumentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackDocumentsId(GetChargebackDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ChargebackDocumentsResponseResult`
- **Error**: `ApiException<GetChargebackDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackDocumentsIdRequest` | `Requests/ChargebackDocuments/GetChargebackDocumentsIdRequest.cs` |
| `ChargebackDocumentsResponseResult` | `Models/ChargebackDocumentsResponseResult.cs` |
| `GetChargebackDocumentsIdError` | `Errors/GetChargebackDocumentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostChargebackDocuments

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostChargebackDocuments(PostChargebackDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ChargebackDocumentsResponseResult`
- **Error**: `ApiException<PostChargebackDocumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostChargebackDocumentsRequest` | `Requests/ChargebackDocuments/PostChargebackDocumentsRequest.cs` |
| `ChargebackDocumentsPostRequest` | `Models/ChargebackDocumentsPostRequest.cs` |
| `ChargebackDocumentsResponseResult` | `Models/ChargebackDocumentsResponseResult.cs` |
| `PostChargebackDocumentsError` | `Errors/PostChargebackDocumentsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutChargebackDocumentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutChargebackDocumentsId(PutChargebackDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `ChargebackDocumentsResponseResult`
- **Error**: `ApiException<PutChargebackDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutChargebackDocumentsIdRequest` | `Requests/ChargebackDocuments/PutChargebackDocumentsIdRequest.cs` |
| `ChargebacksDocumentsPutRequest` | `Models/ChargebacksDocumentsPutRequest.cs` |
| `ChargebackDocumentsResponseResult` | `Models/ChargebackDocumentsResponseResult.cs` |
| `PutChargebackDocumentsIdError` | `Errors/PutChargebackDocumentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

