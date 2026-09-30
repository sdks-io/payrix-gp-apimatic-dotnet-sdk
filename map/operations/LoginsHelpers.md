<!-- Generated file — do not edit; regenerated with the SDK. -->

# LoginsHelpers — operations

Accessor: `client.LoginsHelpers` · Source: `Api/LoginsHelpers.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLoginsHelpers

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetLoginsHelpers(GetLoginsHelpersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `LoginsHelpersResponseResult`
- **Error**: `ApiException<GetLoginsHelpersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoginsHelpersRequest` | `Requests/LoginsHelpers/GetLoginsHelpersRequest.cs` |
| `LoginsHelpersResponseResult` | `Models/LoginsHelpersResponseResult.cs` |
| `GetLoginsHelpersError` | `Errors/GetLoginsHelpersError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetLoginsHelpersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetLoginsHelpersId(GetLoginsHelpersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `LoginsHelpersResponseResult`
- **Error**: `ApiException<GetLoginsHelpersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLoginsHelpersIdRequest` | `Requests/LoginsHelpers/GetLoginsHelpersIdRequest.cs` |
| `LoginsHelpersResponseResult` | `Models/LoginsHelpersResponseResult.cs` |
| `GetLoginsHelpersIdError` | `Errors/GetLoginsHelpersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutLoginsHelpersId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutLoginsHelpersId(PutLoginsHelpersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `LoginsHelpersResponseResult`
- **Error**: `ApiException<PutLoginsHelpersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutLoginsHelpersIdRequest` | `Requests/LoginsHelpers/PutLoginsHelpersIdRequest.cs` |
| `LoginsHelpersPutRequest` | `Models/LoginsHelpersPutRequest.cs` |
| `LoginsHelpersResponseResult` | `Models/LoginsHelpersResponseResult.cs` |
| `PutLoginsHelpersIdError` | `Errors/PutLoginsHelpersIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

