<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountsVerifications — operations

Accessor: `client.AccountsVerifications` · Source: `Api/AccountsVerifications.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountVerifications

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAccountVerifications(GetAccountVerificationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AccountVerificationsResponseResult`
- **Error**: `ApiException<GetAccountVerificationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountVerificationsRequest` | `Requests/AccountsVerifications/GetAccountVerificationsRequest.cs` |
| `AccountVerificationsResponseResult` | `Models/AccountVerificationsResponseResult.cs` |
| `GetAccountVerificationsError` | `Errors/GetAccountVerificationsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAccountVerificationsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAccountVerificationsId(GetAccountVerificationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AccountVerificationsResponseResult`
- **Error**: `ApiException<GetAccountVerificationsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountVerificationsIdRequest` | `Requests/AccountsVerifications/GetAccountVerificationsIdRequest.cs` |
| `AccountVerificationsResponseResult` | `Models/AccountVerificationsResponseResult.cs` |
| `GetAccountVerificationsIdError` | `Errors/GetAccountVerificationsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

