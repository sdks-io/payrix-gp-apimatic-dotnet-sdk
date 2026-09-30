<!-- Generated file — do not edit; regenerated with the SDK. -->

# ValueAddedServices — operations

Accessor: `client.ValueAddedServices` · Source: `Api/ValueAddedServices.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetValueAddedServicesEnablementStatusTargetId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetValueAddedServicesEnablementStatusTargetId(GetValueAddedServicesEnablementStatusTargetIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Service`, `Target`, `TargetId`
- **Returns**: `VasEnablementStatusResponseResult`
- **Error**: `ApiException<GetValueAddedServicesEnablementStatusTargetIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetValueAddedServicesEnablementStatusTargetIdRequest` | `Requests/ValueAddedServices/GetValueAddedServicesEnablementStatusTargetIdRequest.cs` |
| `VasEnablementStatusService1` | `Models/Enums/VasEnablementStatusService1.cs` |
| `VasEnablementStatusTargetType1` | `Models/Enums/VasEnablementStatusTargetType1.cs` |
| `VasEnablementStatusResponseResult` | `Models/VasEnablementStatusResponseResult.cs` |
| `GetValueAddedServicesEnablementStatusTargetIdError` | `Errors/GetValueAddedServicesEnablementStatusTargetIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

