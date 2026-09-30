<!-- Generated file — do not edit; regenerated with the SDK. -->

# Plans — operations

Accessor: `client.Plans` · Source: `Api/Plans.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeletePlansId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeletePlansId(DeletePlansIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PlansResponseResult`
- **Error**: `ApiException<DeletePlansIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePlansIdRequest` | `Requests/Plans/DeletePlansIdRequest.cs` |
| `PlansResponseResult` | `Models/PlansResponseResult.cs` |
| `DeletePlansIdError` | `Errors/DeletePlansIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPlans

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPlans(GetPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `PlansResponseResult`
- **Error**: `ApiException<GetPlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPlansRequest` | `Requests/Plans/GetPlansRequest.cs` |
| `PlansResponseResult` | `Models/PlansResponseResult.cs` |
| `GetPlansError` | `Errors/GetPlansError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetPlansId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetPlansId(GetPlansIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `PlansResponseResult`
- **Error**: `ApiException<GetPlansIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPlansIdRequest` | `Requests/Plans/GetPlansIdRequest.cs` |
| `PlansResponseResult` | `Models/PlansResponseResult.cs` |
| `GetPlansIdError` | `Errors/GetPlansIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostPlans

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostPlans(PostPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PlansResponseResult`
- **Error**: `ApiException<PostPlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPlansRequest` | `Requests/Plans/PostPlansRequest.cs` |
| `PlansPostRequest` | `Models/PlansPostRequest.cs` |
| `PlansResponseResult` | `Models/PlansResponseResult.cs` |
| `PostPlansError` | `Errors/PostPlansError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutPlansId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutPlansId(PutPlansIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `PlansResponseResult`
- **Error**: `ApiException<PutPlansIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutPlansIdRequest` | `Requests/Plans/PutPlansIdRequest.cs` |
| `PlansPutRequest` | `Models/PlansPutRequest.cs` |
| `PlansResponseResult` | `Models/PlansResponseResult.cs` |
| `PutPlansIdError` | `Errors/PutPlansIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

