<!-- Generated file — do not edit; regenerated with the SDK. -->

# OptOuts — operations

Accessor: `client.OptOuts` · Source: `Api/OptOuts.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostOptouts

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostOptouts(PostOptoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Service`, `Target`, `TargetId`, `Body`
- **Returns**: `VasOptOutResponseResult`
- **Error**: `ApiException<PostOptoutsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOptoutsRequest` | `Requests/OptOuts/PostOptoutsRequest.cs` |
| `VasOptOutService1` | `Models/Enums/VasOptOutService1.cs` |
| `VasOptOutTargetType1` | `Models/Enums/VasOptOutTargetType1.cs` |
| `VasOptOutPostRequestModel` | `Models/VasOptOutPostRequestModel.cs` |
| `VasOptOutResponseResult` | `Models/VasOptOutResponseResult.cs` |
| `PostOptoutsError` | `Errors/PostOptoutsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

