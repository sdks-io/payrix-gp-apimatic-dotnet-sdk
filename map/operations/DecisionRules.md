<!-- Generated file — do not edit; regenerated with the SDK. -->

# DecisionRules — operations

Accessor: `client.DecisionRules` · Source: `Api/DecisionRules.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteDecisionRulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteDecisionRulesId(DeleteDecisionRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DecisionRulesResponseResult`
- **Error**: `ApiException<DeleteDecisionRulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDecisionRulesIdRequest` | `Requests/DecisionRules/DeleteDecisionRulesIdRequest.cs` |
| `DecisionRulesResponseResult` | `Models/DecisionRulesResponseResult.cs` |
| `DeleteDecisionRulesIdError` | `Errors/DeleteDecisionRulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDecisionRules

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDecisionRules(GetDecisionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `DecisionRulesResponseResult`
- **Error**: `ApiException<GetDecisionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDecisionRulesRequest` | `Requests/DecisionRules/GetDecisionRulesRequest.cs` |
| `DecisionRulesResponseResult` | `Models/DecisionRulesResponseResult.cs` |
| `GetDecisionRulesError` | `Errors/GetDecisionRulesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetDecisionRulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetDecisionRulesId(GetDecisionRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `DecisionRulesResponseResult`
- **Error**: `ApiException<GetDecisionRulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDecisionRulesIdRequest` | `Requests/DecisionRules/GetDecisionRulesIdRequest.cs` |
| `DecisionRulesResponseResult` | `Models/DecisionRulesResponseResult.cs` |
| `GetDecisionRulesIdError` | `Errors/GetDecisionRulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostDecisionRules

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostDecisionRules(PostDecisionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DecisionRulesResponseResult`
- **Error**: `ApiException<PostDecisionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDecisionRulesRequest` | `Requests/DecisionRules/PostDecisionRulesRequest.cs` |
| `DecisionRulesPostRequest` | `Models/DecisionRulesPostRequest.cs` |
| `DecisionRulesResponseResult` | `Models/DecisionRulesResponseResult.cs` |
| `PostDecisionRulesError` | `Errors/PostDecisionRulesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutDecisionRulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutDecisionRulesId(PutDecisionRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `DecisionRulesResponseResult`
- **Error**: `ApiException<PutDecisionRulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutDecisionRulesIdRequest` | `Requests/DecisionRules/PutDecisionRulesIdRequest.cs` |
| `DecisionRulesPutRequest` | `Models/DecisionRulesPutRequest.cs` |
| `DecisionRulesResponseResult` | `Models/DecisionRulesResponseResult.cs` |
| `PutDecisionRulesIdError` | `Errors/PutDecisionRulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

