<!-- Generated file — do not edit; regenerated with the SDK. -->

# EntityReturns — operations

Accessor: `client.EntityReturns` · Source: `Api/EntityReturns.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEntityReturns

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityReturns(GetEntityReturnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `EntityReturnsResponseResult`
- **Error**: `ApiException<GetEntityReturnsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityReturnsRequest` | `Requests/EntityReturns/GetEntityReturnsRequest.cs` |
| `EntityReturnsResponseResult` | `Models/EntityReturnsResponseResult.cs` |
| `GetEntityReturnsError` | `Errors/GetEntityReturnsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetEntityReturnsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetEntityReturnsId(GetEntityReturnsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `EntityReturnsResponseResult`
- **Error**: `ApiException<GetEntityReturnsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEntityReturnsIdRequest` | `Requests/EntityReturns/GetEntityReturnsIdRequest.cs` |
| `EntityReturnsResponseResult` | `Models/EntityReturnsResponseResult.cs` |
| `GetEntityReturnsIdError` | `Errors/GetEntityReturnsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

