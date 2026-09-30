<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payouts — operations

Accessor: `client.Payouts` · Source: `Api/Payouts.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeletePayoutsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeletePayoutsId(DeletePayoutsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PayoutsResponseResult`
- **Error**: `ApiException<DeletePayoutsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePayoutsIdRequest` | `Requests/Payouts/DeletePayoutsIdRequest.cs` |
| `PayoutsResponseResult` | `Models/PayoutsResponseResult.cs` |
| `DeletePayoutsIdError` | `Errors/DeletePayoutsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPayouts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPayouts(GetPayoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `PayoutsResponseResult`
- **Error**: `ApiException<GetPayoutsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPayoutsRequest` | `Requests/Payouts/GetPayoutsRequest.cs` |
| `PayoutsResponseResult` | `Models/PayoutsResponseResult.cs` |
| `GetPayoutsError` | `Errors/GetPayoutsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPayoutsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPayoutsId(GetPayoutsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `PayoutsResponseResult`
- **Error**: `ApiException<GetPayoutsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPayoutsIdRequest` | `Requests/Payouts/GetPayoutsIdRequest.cs` |
| `PayoutsResponseResult` | `Models/PayoutsResponseResult.cs` |
| `GetPayoutsIdError` | `Errors/GetPayoutsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostPayouts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostPayouts(PostPayoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PayoutsResponseResult`
- **Error**: `ApiException<PostPayoutsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPayoutsRequest` | `Requests/Payouts/PostPayoutsRequest.cs` |
| `PayoutPostRequest` | `Models/PayoutPostRequest.cs` |
| `PayoutsResponseResult` | `Models/PayoutsResponseResult.cs` |
| `PostPayoutsError` | `Errors/PostPayoutsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutPayoutsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutPayoutsId(PutPayoutsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `PayoutsResponseResult`
- **Error**: `ApiException<PutPayoutsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutPayoutsIdRequest` | `Requests/Payouts/PutPayoutsIdRequest.cs` |
| `PayoutPutRequest` | `Models/PayoutPutRequest.cs` |
| `PayoutsResponseResult` | `Models/PayoutsResponseResult.cs` |
| `PutPayoutsIdError` | `Errors/PutPayoutsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

