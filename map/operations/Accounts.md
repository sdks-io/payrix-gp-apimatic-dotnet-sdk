<!-- Generated file — do not edit; regenerated with the SDK. -->

# Accounts — operations

Accessor: `client.Accounts` · Source: `Api/Accounts.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAccountsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteAccountsId(DeleteAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AccountsResponseResult`
- **Error**: `ApiException<DeleteAccountsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAccountsIdRequest` | `Requests/Accounts/DeleteAccountsIdRequest.cs` |
| `AccountsResponseResult` | `Models/AccountsResponseResult.cs` |
| `DeleteAccountsIdError` | `Errors/DeleteAccountsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAccounts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAccounts(GetAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AccountsResponseResult`
- **Error**: `ApiException<GetAccountsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountsRequest` | `Requests/Accounts/GetAccountsRequest.cs` |
| `AccountsResponseResult` | `Models/AccountsResponseResult.cs` |
| `GetAccountsError` | `Errors/GetAccountsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAccountsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAccountsId(GetAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AccountsResponseResult`
- **Error**: `ApiException<GetAccountsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountsIdRequest` | `Requests/Accounts/GetAccountsIdRequest.cs` |
| `AccountsResponseResult` | `Models/AccountsResponseResult.cs` |
| `GetAccountsIdError` | `Errors/GetAccountsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostAccounts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostAccounts(PostAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountsResponseResult`
- **Error**: `ApiException<PostAccountsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAccountsRequest` | `Requests/Accounts/PostAccountsRequest.cs` |
| `AccountsRequest1` | `Models/AccountsRequest1.cs` |
| `AccountsResponseResult` | `Models/AccountsResponseResult.cs` |
| `PostAccountsError` | `Errors/PostAccountsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutAccountsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutAccountsId(PutAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `AccountsResponseResult`
- **Error**: `ApiException<PutAccountsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutAccountsIdRequest` | `Requests/Accounts/PutAccountsIdRequest.cs` |
| `AccountsPutRequest` | `Models/AccountsPutRequest.cs` |
| `AccountsResponseResult` | `Models/AccountsResponseResult.cs` |
| `PutAccountsIdError` | `Errors/PutAccountsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

