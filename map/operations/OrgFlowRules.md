<!-- Generated file — do not edit; regenerated with the SDK. -->

# OrgFlowRules — operations

Accessor: `client.OrgFlowRules` · Source: `Api/OrgFlowRules.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteOrgFlowRulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `DeleteOrgFlowRulesId(DeleteOrgFlowRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `OrgFlowRulesResponseResult`
- **Error**: `ApiException<DeleteOrgFlowRulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrgFlowRulesIdRequest` | `Requests/OrgFlowRules/DeleteOrgFlowRulesIdRequest.cs` |
| `OrgFlowRulesResponseResult` | `Models/OrgFlowRulesResponseResult.cs` |
| `DeleteOrgFlowRulesIdError` | `Errors/DeleteOrgFlowRulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOrgFlowRules

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgFlowRules(GetOrgFlowRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page[number]` ← `PageNumber`, `page[limit]` ← `PageLimit`, `embed` ← `Embed`
- **Returns**: `OrgFlowRulesResponseResult`
- **Error**: `ApiException<GetOrgFlowRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgFlowRulesRequest` | `Requests/OrgFlowRules/GetOrgFlowRulesRequest.cs` |
| `OrgFlowRulesResponseResult` | `Models/OrgFlowRulesResponseResult.cs` |
| `GetOrgFlowRulesError` | `Errors/GetOrgFlowRulesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### GetOrgFlowRulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `GetOrgFlowRulesId(GetOrgFlowRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `embed` ← `Embed`
- **Returns**: `OrgFlowRulesResponseResult`
- **Error**: `ApiException<GetOrgFlowRulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrgFlowRulesIdRequest` | `Requests/OrgFlowRules/GetOrgFlowRulesIdRequest.cs` |
| `OrgFlowRulesResponseResult` | `Models/OrgFlowRulesResponseResult.cs` |
| `GetOrgFlowRulesIdError` | `Errors/GetOrgFlowRulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PostOrgFlowRules

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PostOrgFlowRules(PostOrgFlowRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OrgFlowRulesResponseResult`
- **Error**: `ApiException<PostOrgFlowRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOrgFlowRulesRequest` | `Requests/OrgFlowRules/PostOrgFlowRulesRequest.cs` |
| `OrgFlowRulesPostRequest` | `Models/OrgFlowRulesPostRequest.cs` |
| `OrgFlowRulesResponseResult` | `Models/OrgFlowRulesResponseResult.cs` |
| `PostOrgFlowRulesError` | `Errors/PostOrgFlowRulesError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

### PutOrgFlowRulesId

- **Auth**: `options.ApiKey` OR `options.SessionKey` OR `options.TxnSessionKey`
- **Signature**: `PutOrgFlowRulesId(PutOrgFlowRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `OrgFlowRulesResponseResult`
- **Error**: `ApiException<PutOrgFlowRulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorFourHundred1(out ErrorFourHundred1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PutOrgFlowRulesIdRequest` | `Requests/OrgFlowRules/PutOrgFlowRulesIdRequest.cs` |
| `OrgFlowRulesPutRequest` | `Models/OrgFlowRulesPutRequest.cs` |
| `OrgFlowRulesResponseResult` | `Models/OrgFlowRulesResponseResult.cs` |
| `PutOrgFlowRulesIdError` | `Errors/PutOrgFlowRulesIdError.cs` |
| `ErrorFourHundred1` | `Models/ErrorFourHundred1.cs` |

