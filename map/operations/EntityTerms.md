<!-- Generated file — do not edit; regenerated with the SDK. -->

# EntityTerms — operations

Accessor: `client.EntityTerms` · Source: `Api/EntityTerms.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEntityTerms

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityTerms(GetEntityTermsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntityTermsResponseResult`
- **Error**: `ApiException<GetEntityTermsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityTermsRequest` | `Requests/EntityTerms/GetEntityTermsRequest.cs` |
| `EntityTermsResponseResult` | `Models/EntityTermsResponseResult.cs` |
| `GetEntityTermsError` | `Errors/GetEntityTermsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntityTermsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityTermsId(GetEntityTermsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntityTermsResponseResult`
- **Error**: `ApiException<GetEntityTermsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityTermsIdRequest` | `Requests/EntityTerms/GetEntityTermsIdRequest.cs` |
| `EntityTermsResponseResult` | `Models/EntityTermsResponseResult.cs` |
| `GetEntityTermsIdError` | `Errors/GetEntityTermsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostEntityTerms

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostEntityTerms(PostEntityTermsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EntityTermsResponseResult`
- **Error**: `ApiException<PostEntityTermsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostEntityTermsRequest` | `Requests/EntityTerms/PostEntityTermsRequest.cs` |
| `EntityTermsPostRequest` | `Models/EntityTermsPostRequest.cs` |
| `EntityTermsResponseResult` | `Models/EntityTermsResponseResult.cs` |
| `PostEntityTermsError` | `Errors/PostEntityTermsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

