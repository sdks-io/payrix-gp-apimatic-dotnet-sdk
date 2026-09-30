<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `Api/Subscriptions.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteSubscriptionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteSubscriptionsId(DeleteSubscriptionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SubscriptionResponseResult`
- **Error**: `ApiException<DeleteSubscriptionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSubscriptionsIdRequest` | `Requests/Subscriptions/DeleteSubscriptionsIdRequest.cs` |
| `SubscriptionResponseResult` | `Models/SubscriptionResponseResult.cs` |
| `DeleteSubscriptionsIdError` | `Errors/DeleteSubscriptionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSubscriptions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSubscriptions(GetSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `SubscriptionResponseResult`
- **Error**: `ApiException<GetSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionsRequest` | `Requests/Subscriptions/GetSubscriptionsRequest.cs` |
| `SubscriptionResponseResult` | `Models/SubscriptionResponseResult.cs` |
| `GetSubscriptionsError` | `Errors/GetSubscriptionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetSubscriptionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetSubscriptionsId(GetSubscriptionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `SubscriptionResponseResult`
- **Error**: `ApiException<GetSubscriptionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionsIdRequest` | `Requests/Subscriptions/GetSubscriptionsIdRequest.cs` |
| `SubscriptionResponseResult` | `Models/SubscriptionResponseResult.cs` |
| `GetSubscriptionsIdError` | `Errors/GetSubscriptionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostSubscriptions

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostSubscriptions(PostSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SubscriptionResponseResult`
- **Error**: `ApiException<PostSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSubscriptionsRequest` | `Requests/Subscriptions/PostSubscriptionsRequest.cs` |
| `SubscriptionsPostRequest` | `Models/SubscriptionsPostRequest.cs` |
| `SubscriptionResponseResult` | `Models/SubscriptionResponseResult.cs` |
| `PostSubscriptionsError` | `Errors/PostSubscriptionsError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutSubscriptionsId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutSubscriptionsId(PutSubscriptionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `SubscriptionResponseResult`
- **Error**: `ApiException<PutSubscriptionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutSubscriptionsIdRequest` | `Requests/Subscriptions/PutSubscriptionsIdRequest.cs` |
| `SubscriptionsPutRequest` | `Models/SubscriptionsPutRequest.cs` |
| `SubscriptionResponseResult` | `Models/SubscriptionResponseResult.cs` |
| `PutSubscriptionsIdError` | `Errors/PutSubscriptionsIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

