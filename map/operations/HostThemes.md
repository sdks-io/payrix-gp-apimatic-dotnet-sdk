<!-- Generated file — do not edit; regenerated with the SDK. -->

# HostThemes — operations

Accessor: `client.HostThemes` · Source: `Api/HostThemes.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetHostThemes

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetHostThemes(GetHostThemesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `HostThemesResponseResult`
- **Error**: `ApiException<GetHostThemesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetHostThemesRequest` | `Requests/HostThemes/GetHostThemesRequest.cs` |
| `HostThemesResponseResult` | `Models/HostThemesResponseResult.cs` |
| `GetHostThemesError` | `Errors/GetHostThemesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetHostThemesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetHostThemesId(GetHostThemesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `HostThemesResponseResult`
- **Error**: `ApiException<GetHostThemesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetHostThemesIdRequest` | `Requests/HostThemes/GetHostThemesIdRequest.cs` |
| `HostThemesResponseResult` | `Models/HostThemesResponseResult.cs` |
| `GetHostThemesIdError` | `Errors/GetHostThemesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

