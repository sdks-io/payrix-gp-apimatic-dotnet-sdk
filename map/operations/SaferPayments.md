<!-- Generated file — do not edit; regenerated with the SDK. -->

# SaferPayments — operations

Accessor: `client.SaferPayments` · Source: `Api/SaferPayments.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetSaferPayments

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSaferPayments(GetSaferPaymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `SaferPaymentsResponseResult`
- **Error**: `ApiException<GetSaferPaymentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSaferPaymentsRequest` | `Requests/SaferPayments/GetSaferPaymentsRequest.cs` |
| `SaferPaymentsResponseResult` | `Models/SaferPaymentsResponseResult.cs` |
| `GetSaferPaymentsError` | `Errors/GetSaferPaymentsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSaferPaymentsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSaferPaymentsId(GetSaferPaymentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `SaferPaymentsResponseResult`
- **Error**: `ApiException<GetSaferPaymentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSaferPaymentsIdRequest` | `Requests/SaferPayments/GetSaferPaymentsIdRequest.cs` |
| `SaferPaymentsResponseResult` | `Models/SaferPaymentsResponseResult.cs` |
| `GetSaferPaymentsIdError` | `Errors/GetSaferPaymentsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

