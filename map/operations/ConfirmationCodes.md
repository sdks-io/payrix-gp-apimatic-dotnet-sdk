<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConfirmationCodes — operations

Accessor: `client.ConfirmationCodes` · Source: `Api/ConfirmationCodes.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteConfirmCodesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteConfirmCodesId(DeleteConfirmCodesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ConfirmCodesResponseResult`
- **Error**: `ApiException<DeleteConfirmCodesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteConfirmCodesIdRequest` | `Requests/ConfirmationCodes/DeleteConfirmCodesIdRequest.cs` |
| `ConfirmCodesResponseResult` | `Models/ConfirmCodesResponseResult.cs` |
| `DeleteConfirmCodesIdError` | `Errors/DeleteConfirmCodesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetConfirmCodes

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetConfirmCodes(GetConfirmCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ConfirmCodesResponseResult`
- **Error**: `ApiException<GetConfirmCodesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetConfirmCodesRequest` | `Requests/ConfirmationCodes/GetConfirmCodesRequest.cs` |
| `ConfirmCodesResponseResult` | `Models/ConfirmCodesResponseResult.cs` |
| `GetConfirmCodesError` | `Errors/GetConfirmCodesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetConfirmCodesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetConfirmCodesId(GetConfirmCodesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ConfirmCodesResponseResult`
- **Error**: `ApiException<GetConfirmCodesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetConfirmCodesIdRequest` | `Requests/ConfirmationCodes/GetConfirmCodesIdRequest.cs` |
| `ConfirmCodesResponseResult` | `Models/ConfirmCodesResponseResult.cs` |
| `GetConfirmCodesIdError` | `Errors/GetConfirmCodesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostConfirmCodes

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostConfirmCodes(PostConfirmCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ConfirmCodesResponseResult`
- **Error**: `ApiException<PostConfirmCodesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostConfirmCodesRequest` | `Requests/ConfirmationCodes/PostConfirmCodesRequest.cs` |
| `ConfirmCodesPostRequest` | `Models/ConfirmCodesPostRequest.cs` |
| `ConfirmCodesResponseResult` | `Models/ConfirmCodesResponseResult.cs` |
| `PostConfirmCodesError` | `Errors/PostConfirmCodesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

