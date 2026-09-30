<!-- Generated file — do not edit; regenerated with the SDK. -->

# IpAddressLists — operations

Accessor: `client.IpAddressLists` · Source: `Api/IpAddressLists.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteIplistsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteIplistsId(DeleteIplistsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `IplistsResponseResult`
- **Error**: `ApiException<DeleteIplistsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteIplistsIdRequest` | `Requests/IpAddressLists/DeleteIplistsIdRequest.cs` |
| `IplistsResponseResult` | `Models/IplistsResponseResult.cs` |
| `DeleteIplistsIdError` | `Errors/DeleteIplistsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetIplists

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetIplists(GetIplistsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `IplistsResponseResult`
- **Error**: `ApiException<GetIplistsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetIplistsRequest` | `Requests/IpAddressLists/GetIplistsRequest.cs` |
| `IplistsResponseResult` | `Models/IplistsResponseResult.cs` |
| `GetIplistsError` | `Errors/GetIplistsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetIplistsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetIplistsId(GetIplistsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `IplistsResponseResult`
- **Error**: `ApiException<GetIplistsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetIplistsIdRequest` | `Requests/IpAddressLists/GetIplistsIdRequest.cs` |
| `IplistsResponseResult` | `Models/IplistsResponseResult.cs` |
| `GetIplistsIdError` | `Errors/GetIplistsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostIplists

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostIplists(PostIplistsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IplistsResponseResult`
- **Error**: `ApiException<PostIplistsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostIplistsRequest` | `Requests/IpAddressLists/PostIplistsRequest.cs` |
| `IplistsPostRequest` | `Models/IplistsPostRequest.cs` |
| `IplistsResponseResult` | `Models/IplistsResponseResult.cs` |
| `PostIplistsError` | `Errors/PostIplistsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutIplistsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutIplistsId(PutIplistsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `IplistsResponseResult`
- **Error**: `ApiException<PutIplistsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutIplistsIdRequest` | `Requests/IpAddressLists/PutIplistsIdRequest.cs` |
| `IplistsPutRequest` | `Models/IplistsPutRequest.cs` |
| `IplistsResponseResult` | `Models/IplistsResponseResult.cs` |
| `PutIplistsIdError` | `Errors/PutIplistsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

