<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChargebackMessages — operations

Accessor: `client.ChargebackMessages` · Source: `Api/ChargebackMessages.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetChargebackMessages

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackMessages(GetChargebackMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `ChargebackMessagesResponseResult`
- **Error**: `ApiException<GetChargebackMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackMessagesRequest` | `Requests/ChargebackMessages/GetChargebackMessagesRequest.cs` |
| `ChargebackMessagesResponseResult` | `Models/ChargebackMessagesResponseResult.cs` |
| `GetChargebackMessagesError` | `Errors/GetChargebackMessagesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetChargebackMessagesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetChargebackMessagesId(GetChargebackMessagesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `ChargebackMessagesResponseResult`
- **Error**: `ApiException<GetChargebackMessagesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetChargebackMessagesIdRequest` | `Requests/ChargebackMessages/GetChargebackMessagesIdRequest.cs` |
| `ChargebackMessagesResponseResult` | `Models/ChargebackMessagesResponseResult.cs` |
| `GetChargebackMessagesIdError` | `Errors/GetChargebackMessagesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostChargebackMessages

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostChargebackMessages(PostChargebackMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ChargebackMessagesResponseResult`
- **Error**: `ApiException<PostChargebackMessagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostChargebackMessagesRequest` | `Requests/ChargebackMessages/PostChargebackMessagesRequest.cs` |
| `ChargebackMessagePostRequest` | `Models/ChargebackMessagePostRequest.cs` |
| `ChargebackMessagesResponseResult` | `Models/ChargebackMessagesResponseResult.cs` |
| `PostChargebackMessagesError` | `Errors/PostChargebackMessagesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

