<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentUpdateGroups — operations

Accessor: `client.PaymentUpdateGroups` · Source: `Api/PaymentUpdateGroups.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentUpdateGroups

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPaymentUpdateGroups(GetPaymentUpdateGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `PaymentUpdateGroupsResponseResult`
- **Error**: `ApiException<GetPaymentUpdateGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentUpdateGroupsRequest` | `Requests/PaymentUpdateGroups/GetPaymentUpdateGroupsRequest.cs` |
| `PaymentUpdateGroupsResponseResult` | `Models/PaymentUpdateGroupsResponseResult.cs` |
| `GetPaymentUpdateGroupsError` | `Errors/GetPaymentUpdateGroupsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPaymentUpdateGroupsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPaymentUpdateGroupsId(GetPaymentUpdateGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `PaymentUpdateGroupsResponseResult`
- **Error**: `ApiException<GetPaymentUpdateGroupsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentUpdateGroupsIdRequest` | `Requests/PaymentUpdateGroups/GetPaymentUpdateGroupsIdRequest.cs` |
| `PaymentUpdateGroupsResponseResult` | `Models/PaymentUpdateGroupsResponseResult.cs` |
| `GetPaymentUpdateGroupsIdError` | `Errors/GetPaymentUpdateGroupsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

