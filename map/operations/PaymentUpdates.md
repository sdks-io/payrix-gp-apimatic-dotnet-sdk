<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentUpdates — operations

Accessor: `client.PaymentUpdates` · Source: `Api/PaymentUpdates.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentUpdates

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPaymentUpdates(GetPaymentUpdatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `PaymentUpdatesResponseResult`
- **Error**: `ApiException<GetPaymentUpdatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentUpdatesRequest` | `Requests/PaymentUpdates/GetPaymentUpdatesRequest.cs` |
| `PaymentUpdatesResponseResult` | `Models/PaymentUpdatesResponseResult.cs` |
| `GetPaymentUpdatesError` | `Errors/GetPaymentUpdatesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPaymentUpdatesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPaymentUpdatesId(GetPaymentUpdatesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `PaymentUpdatesResponseResult`
- **Error**: `ApiException<GetPaymentUpdatesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentUpdatesIdRequest` | `Requests/PaymentUpdates/GetPaymentUpdatesIdRequest.cs` |
| `PaymentUpdatesResponseResult` | `Models/PaymentUpdatesResponseResult.cs` |
| `GetPaymentUpdatesIdError` | `Errors/GetPaymentUpdatesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

