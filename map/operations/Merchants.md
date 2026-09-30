<!-- Generated file — do not edit; regenerated with the SDK. -->

# Merchants — operations

Accessor: `client.Merchants` · Source: `Api/Merchants.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchants

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMerchants(GetMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `MerchantsResponseResult`
- **Error**: `ApiException<GetMerchantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsRequest` | `Requests/Merchants/GetMerchantsRequest.cs` |
| `MerchantsResponseResult` | `Models/MerchantsResponseResult.cs` |
| `GetMerchantsError` | `Errors/GetMerchantsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetMerchantsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetMerchantsId(GetMerchantsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `MerchantsResponseResult`
- **Error**: `ApiException<GetMerchantsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsIdRequest` | `Requests/Merchants/GetMerchantsIdRequest.cs` |
| `MerchantsResponseResult` | `Models/MerchantsResponseResult.cs` |
| `GetMerchantsIdError` | `Errors/GetMerchantsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutMerchantsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutMerchantsId(PutMerchantsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `MerchantsResponseResult`
- **Error**: `ApiException<PutMerchantsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutMerchantsIdRequest` | `Requests/Merchants/PutMerchantsIdRequest.cs` |
| `MerchantsPutRequest` | `Models/MerchantsPutRequest.cs` |
| `MerchantsResponseResult` | `Models/MerchantsResponseResult.cs` |
| `PutMerchantsIdError` | `Errors/PutMerchantsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

