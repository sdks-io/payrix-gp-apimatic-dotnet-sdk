<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChangeRequests — operations

Accessor: `client.ChangeRequests` · Source: `Api/ChangeRequests.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteChangeRequestsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteChangeRequestsId(DeleteChangeRequestsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ChangeRequestsResponseResult`
- **Error**: `ApiException<DeleteChangeRequestsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteChangeRequestsIdRequest` | `Requests/ChangeRequests/DeleteChangeRequestsIdRequest.cs` |
| `ChangeRequestsResponseResult` | `Models/ChangeRequestsResponseResult.cs` |
| `DeleteChangeRequestsIdError` | `Errors/DeleteChangeRequestsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChangeRequests

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChangeRequests(GetChangeRequestsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ChangeRequestsResponseResult`
- **Error**: `ApiException<GetChangeRequestsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChangeRequestsRequest` | `Requests/ChangeRequests/GetChangeRequestsRequest.cs` |
| `ChangeRequestsResponseResult` | `Models/ChangeRequestsResponseResult.cs` |
| `GetChangeRequestsError` | `Errors/GetChangeRequestsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChangeRequestsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChangeRequestsId(GetChangeRequestsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ChangeRequestsResponseResult`
- **Error**: `ApiException<GetChangeRequestsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChangeRequestsIdRequest` | `Requests/ChangeRequests/GetChangeRequestsIdRequest.cs` |
| `ChangeRequestsResponseResult` | `Models/ChangeRequestsResponseResult.cs` |
| `GetChangeRequestsIdError` | `Errors/GetChangeRequestsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

