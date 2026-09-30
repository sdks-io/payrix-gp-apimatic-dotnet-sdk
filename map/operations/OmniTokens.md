<!-- Generated file — do not edit; regenerated with the SDK. -->

# OmniTokens — operations

Accessor: `client.OmniTokens` · Source: `Api/OmniTokens.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetOmniTokens

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOmniTokens(GetOmniTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `OmniTokensResponseResult`
- **Error**: `ApiException<GetOmniTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOmniTokensRequest` | `Requests/OmniTokens/GetOmniTokensRequest.cs` |
| `OmniTokensResponseResult` | `Models/OmniTokensResponseResult.cs` |
| `GetOmniTokensError` | `Errors/GetOmniTokensError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOmniTokensId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOmniTokensId(GetOmniTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `OmniTokensResponseResult`
- **Error**: `ApiException<GetOmniTokensIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOmniTokensIdRequest` | `Requests/OmniTokens/GetOmniTokensIdRequest.cs` |
| `OmniTokensResponseResult` | `Models/OmniTokensResponseResult.cs` |
| `GetOmniTokensIdError` | `Errors/GetOmniTokensIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

