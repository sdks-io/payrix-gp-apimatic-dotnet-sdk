<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionHolds — operations

Accessor: `client.TransactionHolds` · Source: `Api/TransactionHolds.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetHolds

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetHolds(GetHoldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `HoldsResponseResult`
- **Error**: `ApiException<GetHoldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetHoldsRequest` | `Requests/TransactionHolds/GetHoldsRequest.cs` |
| `HoldsResponseResult` | `Models/HoldsResponseResult.cs` |
| `GetHoldsError` | `Errors/GetHoldsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetHoldsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetHoldsId(GetHoldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `HoldsResponseResult`
- **Error**: `ApiException<GetHoldsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetHoldsIdRequest` | `Requests/TransactionHolds/GetHoldsIdRequest.cs` |
| `HoldsResponseResult` | `Models/HoldsResponseResult.cs` |
| `GetHoldsIdError` | `Errors/GetHoldsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostHolds

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostHolds(PostHoldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `HoldsResponseResult`
- **Error**: `ApiException<PostHoldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostHoldsRequest` | `Requests/TransactionHolds/PostHoldsRequest.cs` |
| `HoldsPostRequest` | `Models/HoldsPostRequest.cs` |
| `HoldsResponseResult` | `Models/HoldsResponseResult.cs` |
| `PostHoldsError` | `Errors/PostHoldsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutHoldsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutHoldsId(PutHoldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `HoldsResponseResult`
- **Error**: `ApiException<PutHoldsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutHoldsIdRequest` | `Requests/TransactionHolds/PutHoldsIdRequest.cs` |
| `HoldsPutRequest` | `Models/HoldsPutRequest.cs` |
| `HoldsResponseResult` | `Models/HoldsResponseResult.cs` |
| `PutHoldsIdError` | `Errors/PutHoldsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

