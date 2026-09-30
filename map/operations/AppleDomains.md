<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppleDomains — operations

Accessor: `client.AppleDomains` · Source: `Api/AppleDomains.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAppleDomains

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAppleDomains(GetAppleDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `AppleDomainsResponseResult`
- **Error**: `ApiException<GetAppleDomainsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAppleDomainsRequest` | `Requests/AppleDomains/GetAppleDomainsRequest.cs` |
| `AppleDomainsResponseResult` | `Models/AppleDomainsResponseResult.cs` |
| `GetAppleDomainsError` | `Errors/GetAppleDomainsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetAppleDomainsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetAppleDomainsId(GetAppleDomainsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `AppleDomainsResponseResult`
- **Error**: `ApiException<GetAppleDomainsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAppleDomainsIdRequest` | `Requests/AppleDomains/GetAppleDomainsIdRequest.cs` |
| `AppleDomainsResponseResult` | `Models/AppleDomainsResponseResult.cs` |
| `GetAppleDomainsIdError` | `Errors/GetAppleDomainsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

