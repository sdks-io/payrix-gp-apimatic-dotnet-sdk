# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [PayrixClient](PayrixClient.cs)

## ApiKeys

> Source: [ApiKeys](Api/ApiKeys.cs)

<details>
<summary><code>Task&lt;ApikeysResponseResult&gt; DeleteApikeysId(DeleteApikeysIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an API key that represents a permanent method of authentication to the API and remains active until marked as inactive or deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.DeleteApikeysId(new DeleteApikeysIdRequest
    {
        Id = "t1_api_676a5353d67a6df2c47b198",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ApikeysResponseResult
}
catch (ApiException<DeleteApikeysIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteApikeysIdRequest](Requests/ApiKeys/DeleteApikeysIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApikeysResponseResult](Models/ApikeysResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteApikeysIdError](Errors/DeleteApikeysIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApikeysResponseResult&gt; GetApikeys(GetApikeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query API keys that each represents a permanent method of authentication to the API and remains active until marked as inactive or deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.GetApikeys(new GetApikeysRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ApikeysResponseResult
}
catch (ApiException<GetApikeysError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetApikeysRequest](Requests/ApiKeys/GetApikeysRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApikeysResponseResult](Models/ApikeysResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetApikeysError](Errors/GetApikeysError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApikeysResponseResult&gt; GetApikeysId(GetApikeysIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an API key that represents a permanent method of authentication to the API, remaining active until marked as inactive or deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.GetApikeysId(new GetApikeysIdRequest
    {
        Id = "t1_api_676a5353d67a6df2c47b198",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ApikeysResponseResult
}
catch (ApiException<GetApikeysIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetApikeysIdRequest](Requests/ApiKeys/GetApikeysIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApikeysResponseResult](Models/ApikeysResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetApikeysIdError](Errors/GetApikeysIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApikeysResponseResult&gt; PostApikeys(PostApikeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an API key that represents a permanent method of authentication to the API. The API key remains active until marked as inactive or deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.PostApikeys(new PostApikeysRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ApiKeysPostRequest { Login = "some example string" },
    });
    // TODO: Handle 'response' of type ApikeysResponseResult
}
catch (ApiException<PostApikeysError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostApikeysRequest](Requests/ApiKeys/PostApikeysRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApikeysResponseResult](Models/ApikeysResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostApikeysError](Errors/PostApikeysError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApikeysResponseResult&gt; PutApikeysId(PutApikeysIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an API key, which represents a permanent method of authentication to the API. Each API key remains active until you mark it as inactive or delete it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.PutApikeysId(new PutApikeysIdRequest
    {
        Id = "t1_api_676a5353d67a6df2c47b198",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ApiKeysPutRequest(),
    });
    // TODO: Handle 'response' of type ApikeysResponseResult
}
catch (ApiException<PutApikeysIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutApikeysIdRequest](Requests/ApiKeys/PutApikeysIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApikeysResponseResult](Models/ApikeysResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutApikeysIdError](Errors/PutApikeysIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Accounts

> Source: [Accounts](Api/Accounts.cs)

<details>
<summary><code>Task&lt;AccountsResponseResult&gt; DeleteAccountsId(DeleteAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Account. An Account represents a bank account associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.DeleteAccountsId(new DeleteAccountsIdRequest
    {
        Id = "t1_act_12a003cde5d6b2ec3d9canb",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AccountsResponseResult
}
catch (ApiException<DeleteAccountsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAccountsIdRequest](Requests/Accounts/DeleteAccountsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsResponseResult](Models/AccountsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAccountsIdError](Errors/DeleteAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountsResponseResult&gt; GetAccounts(GetAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Accounts that each represent a bank account associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.GetAccounts(new GetAccountsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AccountsResponseResult
}
catch (ApiException<GetAccountsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountsRequest](Requests/Accounts/GetAccountsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsResponseResult](Models/AccountsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAccountsError](Errors/GetAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountsResponseResult&gt; GetAccountsId(GetAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Account. An Account represents a bank account associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.GetAccountsId(new GetAccountsIdRequest
    {
        Id = "t1_act_12a003cde5d6b2ec3d9canb",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AccountsResponseResult
}
catch (ApiException<GetAccountsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountsIdRequest](Requests/Accounts/GetAccountsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsResponseResult](Models/AccountsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAccountsIdError](Errors/GetAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountsResponseResult&gt; PostAccounts(PostAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an account, representing a bank account, to associate bank information with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PostAccounts(new PostAccountsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AccountsRequest1 { Entity = "some example string", Account = new Account4(), Currency = currency },
    });
    // TODO: Handle 'response' of type AccountsResponseResult
}
catch (ApiException<PostAccountsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAccountsRequest](Requests/Accounts/PostAccountsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsResponseResult](Models/AccountsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostAccountsError](Errors/PostAccountsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountsResponseResult&gt; PutAccountsId(PutAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing Account representing a bank account associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.PutAccountsId(new PutAccountsIdRequest
    {
        Id = "t1_act_12a003cde5d6b2ec3d9canb",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AccountsPutRequest(),
    });
    // TODO: Handle 'response' of type AccountsResponseResult
}
catch (ApiException<PutAccountsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutAccountsIdRequest](Requests/Accounts/PutAccountsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsResponseResult](Models/AccountsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutAccountsIdError](Errors/PutAccountsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountsVerifications

> Source: [AccountsVerifications](Api/AccountsVerifications.cs)

<details>
<summary><code>Task&lt;AccountVerificationsResponseResult&gt; GetAccountVerifications(GetAccountVerificationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of all account verifications representing attempts to verify the ownership of a particular bank account by verifying a known deposit amount or credential.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountsVerifications.GetAccountVerifications(new GetAccountVerificationsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AccountVerificationsResponseResult
}
catch (ApiException<GetAccountVerificationsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountVerificationsRequest](Requests/AccountsVerifications/GetAccountVerificationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountVerificationsResponseResult](Models/AccountVerificationsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAccountVerificationsError](Errors/GetAccountVerificationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountVerificationsResponseResult&gt; GetAccountVerificationsId(GetAccountVerificationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of all account verifications that query an accountVerifications resource, representing attempts to verify the ownership of a particular bank account by verifying a known deposit amount or credential.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountsVerifications.GetAccountVerificationsId(new GetAccountVerificationsIdRequest
    {
        Id = "t1_acv_99aee642e73d8c8ec629899",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AccountVerificationsResponseResult
}
catch (ApiException<GetAccountVerificationsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountVerificationsIdRequest](Requests/AccountsVerifications/GetAccountVerificationsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountVerificationsResponseResult](Models/AccountVerificationsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAccountVerificationsIdError](Errors/GetAccountVerificationsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Adjustments

> Source: [Adjustments](Api/Adjustments.cs)

<details>
<summary><code>Task&lt;AdjustmentsResponseResult&gt; GetAdjustments(GetAdjustmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Adjustment, which is a way to make monetary adjustments to an entity's funds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Adjustments.GetAdjustments(new GetAdjustmentsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AdjustmentsResponseResult
}
catch (ApiException<GetAdjustmentsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAdjustmentsRequest](Requests/Adjustments/GetAdjustmentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdjustmentsResponseResult](Models/AdjustmentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAdjustmentsError](Errors/GetAdjustmentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdjustmentsResponseResult&gt; GetAdjustmentsId(GetAdjustmentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Adjustment, which is a way to make monetary adjustments to an entity's funds.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Adjustments.GetAdjustmentsId(new GetAdjustmentsIdRequest
    {
        Id = "t1_adm_00073f32d2450f385ec0001",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AdjustmentsResponseResult
}
catch (ApiException<GetAdjustmentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAdjustmentsIdRequest](Requests/Adjustments/GetAdjustmentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdjustmentsResponseResult](Models/AdjustmentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAdjustmentsIdError](Errors/GetAdjustmentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AggregationResultGroups

> Source: [AggregationResultGroups](Api/AggregationResultGroups.cs)

<details>
<summary><code>Task&lt;AggregationResultsGroupsResponseResult&gt; DeleteAggregationResultGroupsId(DeleteAggregationResultGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Aggregation Result Group, which holds data regarding a processed aggregation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AggregationResultGroups.DeleteAggregationResultGroupsId(
        new DeleteAggregationResultGroupsIdRequest
        {
            Id = "t1_arg_66ebb2d6c50b04f8956be00",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
            SearchFilter = "created[equals]=2025-01-01",
        });
    // TODO: Handle 'response' of type AggregationResultsGroupsResponseResult
}
catch (ApiException<DeleteAggregationResultGroupsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAggregationResultGroupsIdRequest](Requests/AggregationResultGroups/DeleteAggregationResultGroupsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationResultsGroupsResponseResult](Models/AggregationResultsGroupsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAggregationResultGroupsIdError](Errors/DeleteAggregationResultGroupsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationResultsGroupsResponseResult&gt; GetAggregationResultGroups(GetAggregationResultGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an AggregationResultGroup resource, which holds data regarding a processed aggregation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AggregationResultGroups.GetAggregationResultGroups(new GetAggregationResultGroupsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AggregationResultsGroupsResponseResult
}
catch (ApiException<GetAggregationResultGroupsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAggregationResultGroupsRequest](Requests/AggregationResultGroups/GetAggregationResultGroupsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationResultsGroupsResponseResult](Models/AggregationResultsGroupsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAggregationResultGroupsError](Errors/GetAggregationResultGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationResultsGroupsResponseResult&gt; GetAggregationResultGroupsId(GetAggregationResultGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an AggregationResultGroup resource, which holds data regarding a processed aggregation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AggregationResultGroups.GetAggregationResultGroupsId(
        new GetAggregationResultGroupsIdRequest
        {
            Id = "t1_arg_66ebb2d6c50b04f8956be00",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
        });
    // TODO: Handle 'response' of type AggregationResultsGroupsResponseResult
}
catch (ApiException<GetAggregationResultGroupsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAggregationResultGroupsIdRequest](Requests/AggregationResultGroups/GetAggregationResultGroupsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationResultsGroupsResponseResult](Models/AggregationResultsGroupsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAggregationResultGroupsIdError](Errors/GetAggregationResultGroupsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AggregationResults

> Source: [AggregationResults](Api/AggregationResults.cs)

<details>
<summary><code>Task&lt;AggregationResultsResponseResult&gt; DeleteAggregationResultsId(DeleteAggregationResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Aggregation Result that holds a field totals calculated when processing an aggregation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AggregationResults.DeleteAggregationResultsId(new DeleteAggregationResultsIdRequest
    {
        Id = "t1_art_66ebb2d6c5b4a0212c1bd00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AggregationResultsResponseResult
}
catch (ApiException<DeleteAggregationResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAggregationResultsIdRequest](Requests/AggregationResults/DeleteAggregationResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationResultsResponseResult](Models/AggregationResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAggregationResultsIdError](Errors/DeleteAggregationResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationResultsResponseResult&gt; GetAggregationResults(GetAggregationResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an AggregationResult resource holding field totals calculated when processing an aggregation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AggregationResults.GetAggregationResults(new GetAggregationResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AggregationResultsResponseResult
}
catch (ApiException<GetAggregationResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAggregationResultsRequest](Requests/AggregationResults/GetAggregationResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationResultsResponseResult](Models/AggregationResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAggregationResultsError](Errors/GetAggregationResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationResultsResponseResult&gt; GetAggregationResultsId(GetAggregationResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an AggregationResult.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AggregationResults.GetAggregationResultsId(new GetAggregationResultsIdRequest
    {
        Id = "t1_art_66ebb2d6c5b4a0212c1bd00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AggregationResultsResponseResult
}
catch (ApiException<GetAggregationResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAggregationResultsIdRequest](Requests/AggregationResults/GetAggregationResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationResultsResponseResult](Models/AggregationResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAggregationResultsIdError](Errors/GetAggregationResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Aggregations

> Source: [Aggregations](Api/Aggregations.cs)

<details>
<summary><code>Task&lt;AggregationsResponseResult&gt; DeleteAggregationsId(DeleteAggregationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Aggregation resource or an Aggregation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Aggregations.DeleteAggregationsId(new DeleteAggregationsIdRequest
    {
        Id = "t1_agg_67b339d00940f0d12b000b7",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        SearchFilter = "created[equals]=2025-01-01",
    });
    // TODO: Handle 'response' of type AggregationsResponseResult
}
catch (ApiException<DeleteAggregationsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAggregationsIdRequest](Requests/Aggregations/DeleteAggregationsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationsResponseResult](Models/AggregationsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAggregationsIdError](Errors/DeleteAggregationsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationsResponseResult&gt; GetAggregations(GetAggregationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Aggregation resource using the search to query for records on the given resource and apply desired calculations (count, sum, min, and/or max) to the specified field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Aggregations.GetAggregations(new GetAggregationsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        SearchFilter = "created[greater]=2024-01-01",
    });
    // TODO: Handle 'response' of type AggregationsResponseResult
}
catch (ApiException<GetAggregationsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAggregationsRequest](Requests/Aggregations/GetAggregationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationsResponseResult](Models/AggregationsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAggregationsError](Errors/GetAggregationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationsResponseResult&gt; GetAggregationsId(GetAggregationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Aggregation resource that uses a search to query for records on the given resource and applies the desired calculations (count, sum, min, and/or max) to the field in question.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Aggregations.GetAggregationsId(new GetAggregationsIdRequest
    {
        Id = "t1_agg_67b339d00940f0d12b000b7",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        SearchFilter = "created[equals]=2025-01-01",
    });
    // TODO: Handle 'response' of type AggregationsResponseResult
}
catch (ApiException<GetAggregationsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAggregationsIdRequest](Requests/Aggregations/GetAggregationsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationsResponseResult](Models/AggregationsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAggregationsIdError](Errors/GetAggregationsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationsResponseResult&gt; PostAggregations(PostAggregationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Aggregation resource that uses the search to query for records on a given resource and applies the desired calculations (count, sum, min, and/or max) to the field in question.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Aggregations.PostAggregations(new PostAggregationsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AggregationsPostRequest
        {
            Login = "some example string",
            Resource = Resource1.Value1,
            Totals = "some example string",
            Schedule = AggregationSchedule1.Hours,
            Start = 1L,
        },
    });
    // TODO: Handle 'response' of type AggregationsResponseResult
}
catch (ApiException<PostAggregationsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAggregationsRequest](Requests/Aggregations/PostAggregationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationsResponseResult](Models/AggregationsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostAggregationsError](Errors/PostAggregationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AggregationsResponseResult&gt; PutAggregationsId(PutAggregationsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Aggregation resource or Update an Aggregation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Aggregations.PutAggregationsId(new PutAggregationsIdRequest
    {
        Id = "t1_agg_67b339d00940f0d12b000b7",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        SearchFilter = "created[equals]=2025-01-01",
        Body = new AggregationsPutRequest(),
    });
    // TODO: Handle 'response' of type AggregationsResponseResult
}
catch (ApiException<PutAggregationsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutAggregationsIdRequest](Requests/Aggregations/PutAggregationsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AggregationsResponseResult](Models/AggregationsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutAggregationsIdError](Errors/PutAggregationsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AlertActions

> Source: [AlertActions](Api/AlertActions.cs)

<details>
<summary><code>Task&lt;AlertActionsResponseResult&gt; DeleteAlertActionsId(DeleteAlertActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an alertAction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertActions.DeleteAlertActionsId(new DeleteAlertActionsIdRequest
    {
        Id = "t1_ala_67d0924f1919ec362341d00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AlertActionsResponseResult
}
catch (ApiException<DeleteAlertActionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAlertActionsIdRequest](Requests/AlertActions/DeleteAlertActionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertActionsResponseResult](Models/AlertActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAlertActionsIdError](Errors/DeleteAlertActionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertActionsResponseResult&gt; GetAlertActions(GetAlertActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an alertAction representing a particular instance of an Alert that is sent out through one particular channel. For example, SMS, mobile application notification, or email, each being associated with an Alert resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertActions.GetAlertActions(new GetAlertActionsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AlertActionsResponseResult
}
catch (ApiException<GetAlertActionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAlertActionsRequest](Requests/AlertActions/GetAlertActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertActionsResponseResult](Models/AlertActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAlertActionsError](Errors/GetAlertActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertActionsResponseResult&gt; GetAlertActionsId(GetAlertActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an alertAction; An alertAction resource represents a particular instance of an Alert that is sent out through one particular channel, for example, SMS, mobile application notification, or email, each alertAction being associated with an Alert resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertActions.GetAlertActionsId(new GetAlertActionsIdRequest
    {
        Id = "t1_ala_67d0924f1919ec362341d00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AlertActionsResponseResult
}
catch (ApiException<GetAlertActionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAlertActionsIdRequest](Requests/AlertActions/GetAlertActionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertActionsResponseResult](Models/AlertActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAlertActionsIdError](Errors/GetAlertActionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertActionsResponseResult&gt; PostAlertActions(PostAlertActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an alertAction, which represents a particular instance of an Alert sent out through one particular channel, such as SMS, mobile application notification, or email, and each alertAction is associated with an Alert resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertActions.PostAlertActions(new PostAlertActionsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AlertActionsPostRequest
        {
            Alert = new AlertsPostRequest { Login = "some example string" },
            Type = AlertActionType1.Email,
            Options = "some example string",
            Value = "some example string",
        },
    });
    // TODO: Handle 'response' of type AlertActionsResponseResult
}
catch (ApiException<PostAlertActionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAlertActionsRequest](Requests/AlertActions/PostAlertActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertActionsResponseResult](Models/AlertActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostAlertActionsError](Errors/PostAlertActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertActionsResponseResult&gt; PutAlertActionsId(PutAlertActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an alertAction representing a particular instance of an Alert that is sent out through one particular channel, for example, SMS, mobile application notification, or email, each being associated with an Alert resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertActions.PutAlertActionsId(new PutAlertActionsIdRequest
    {
        Id = "t1_ala_67d0924f1919ec362341d00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AlertActionsPutRequest(),
    });
    // TODO: Handle 'response' of type AlertActionsResponseResult
}
catch (ApiException<PutAlertActionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutAlertActionsIdRequest](Requests/AlertActions/PutAlertActionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertActionsResponseResult](Models/AlertActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutAlertActionsIdError](Errors/PutAlertActionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AlertTriggers

> Source: [AlertTriggers](Api/AlertTriggers.cs)

<details>
<summary><code>Task&lt;AlertTriggersResponseResult&gt; DeleteAlertTriggersId(DeleteAlertTriggersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an alertTrigger resource that represents a set of triggers causing an Alert to be sent, for example levying a Fee or a Payout occurring, each linked to a particular Alert with the action to take set up in the alertActions resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertTriggers.DeleteAlertTriggersId(new DeleteAlertTriggersIdRequest
    {
        Id = "t1_alr_67d489a76383d013e6295c0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AlertTriggersResponseResult
}
catch (ApiException<DeleteAlertTriggersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAlertTriggersIdRequest](Requests/AlertTriggers/DeleteAlertTriggersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertTriggersResponseResult](Models/AlertTriggersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAlertTriggersIdError](Errors/DeleteAlertTriggersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertTriggersResponseResult&gt; GetAlertTriggers(GetAlertTriggersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an alertTrigger resource that represents a set of triggers that cause an Alert to be sent, where for example this could be the levying of a Fee or a Payout occurring, and each alertTrigger is linked to a particular Alert, with the action to take when an Alert is triggered set up in the alertActions resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertTriggers.GetAlertTriggers(new GetAlertTriggersRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AlertTriggersResponseResult
}
catch (ApiException<GetAlertTriggersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAlertTriggersRequest](Requests/AlertTriggers/GetAlertTriggersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertTriggersResponseResult](Models/AlertTriggersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAlertTriggersError](Errors/GetAlertTriggersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertTriggersResponseResult&gt; GetAlertTriggersId(GetAlertTriggersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an alertTrigger resource that represents a set of triggers causing an Alert to be sent, for example, the levying of a Fee or a Payout occurring, each linked to a particular Alert, with the action to take when triggered set up in the alertActions resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertTriggers.GetAlertTriggersId(new GetAlertTriggersIdRequest
    {
        Id = "t1_alr_67d489a76383d013e6295c0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AlertTriggersResponseResult
}
catch (ApiException<GetAlertTriggersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAlertTriggersIdRequest](Requests/AlertTriggers/GetAlertTriggersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertTriggersResponseResult](Models/AlertTriggersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAlertTriggersIdError](Errors/GetAlertTriggersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertTriggersResponseResult&gt; PostAlertTriggers(PostAlertTriggersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an alertTrigger resource that represents a set of triggers causing an Alert to be sent, such as the levying of a Fee or a Payout occurring, and each alertTrigger is linked to a particular Alert with actions set up in the alertActions resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertTriggers.PostAlertTriggers(new PostAlertTriggersRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AlertTriggersPostRequest
        {
            Alert = new AlertsPostRequest { Login = "some example string" },
            Event = AlertTriggerEvent1.Create,
            Resource = AlertTriggerResource1.Value1,
        },
    });
    // TODO: Handle 'response' of type AlertTriggersResponseResult
}
catch (ApiException<PostAlertTriggersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAlertTriggersRequest](Requests/AlertTriggers/PostAlertTriggersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertTriggersResponseResult](Models/AlertTriggersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostAlertTriggersError](Errors/PostAlertTriggersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertTriggersResponseResult&gt; PutAlertTriggersId(PutAlertTriggersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an alertTrigger resource that represents a set of triggers causing an Alert to be sent, for example levying a Fee or a Payout occurring, with each trigger linked to a particular Alert and the action taken when triggered set up in the alertActions resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AlertTriggers.PutAlertTriggersId(new PutAlertTriggersIdRequest
    {
        Id = "t1_alr_67d489a76383d013e6295c0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AlertTriggersPutRequest(),
    });
    // TODO: Handle 'response' of type AlertTriggersResponseResult
}
catch (ApiException<PutAlertTriggersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutAlertTriggersIdRequest](Requests/AlertTriggers/PutAlertTriggersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertTriggersResponseResult](Models/AlertTriggersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutAlertTriggersIdError](Errors/PutAlertTriggersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Alerts

> Source: [Alerts](Api/Alerts.cs)

<details>
<summary><code>Task&lt;AlertsResponseResult&gt; DeleteAlertsId(DeleteAlertsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Alert resource, which represents a particular event notification delivered to a user, and you can invoke alerts by setting up triggers in an alertTriggers resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Alerts.DeleteAlertsId(new DeleteAlertsIdRequest
    {
        Id = "t1_alt_67d1a66d3af03677cdc7db0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AlertsResponseResult
}
catch (ApiException<DeleteAlertsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAlertsIdRequest](Requests/Alerts/DeleteAlertsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertsResponseResult](Models/AlertsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAlertsIdError](Errors/DeleteAlertsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertsResponseResult&gt; GetAlerts(GetAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Alert resource, which represents a particular event notification delivered to a user; you can invoke alerts by setting up triggers in an alertTriggers resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Alerts.GetAlerts(new GetAlertsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AlertsResponseResult
}
catch (ApiException<GetAlertsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAlertsRequest](Requests/Alerts/GetAlertsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertsResponseResult](Models/AlertsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAlertsError](Errors/GetAlertsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertsResponseResult&gt; GetAlertsId(GetAlertsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Alert resource, which represents a particular event notification delivered to a user, and you can invoke alerts by setting up triggers in an alertTriggers resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Alerts.GetAlertsId(new GetAlertsIdRequest
    {
        Id = "t1_alt_67d1a66d3af03677cdc7db0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AlertsResponseResult
}
catch (ApiException<GetAlertsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAlertsIdRequest](Requests/Alerts/GetAlertsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertsResponseResult](Models/AlertsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAlertsIdError](Errors/GetAlertsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertsResponseResult&gt; PostAlerts(PostAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Alert resource, which represents a particular event notification delivered to a user. You can invoke alerts by setting up triggers in an [AlertTriggers](/api/payrix/alert-triggers/postAlertTriggers) resource and specify the delivery method through an alertActions resource. [Alert Actions](/api/payrix/alert-actions/getAlertActionsId) represent particular instances of an Alert sent out through specific channels, such as SMS, mobile application notifications, or email. Each Alert Action is associated with an Alert resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Alerts.PostAlerts(new PostAlertsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AlertsPostRequest { Login = "some example string" },
    });
    // TODO: Handle 'response' of type AlertsResponseResult
}
catch (ApiException<PostAlertsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAlertsRequest](Requests/Alerts/PostAlertsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertsResponseResult](Models/AlertsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostAlertsError](Errors/PostAlertsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlertsResponseResult&gt; PutAlertsId(PutAlertsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Alert resource, which represents a particular event notification delivered to a user, and you can invoke alerts by setting up triggers in an alertTriggers resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Alerts.PutAlertsId(new PutAlertsIdRequest
    {
        Id = "t1_alt_67d1a66d3af03677cdc7db0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AlertsPutRequest(),
    });
    // TODO: Handle 'response' of type AlertsResponseResult
}
catch (ApiException<PutAlertsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutAlertsIdRequest](Requests/Alerts/PutAlertsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlertsResponseResult](Models/AlertsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutAlertsIdError](Errors/PutAlertsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppleDomains

> Source: [AppleDomains](Api/AppleDomains.cs)

<details>
<summary><code>Task&lt;AppleDomainsResponseResult&gt; GetAppleDomains(GetAppleDomainsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a appleDomains resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppleDomains.GetAppleDomains(new GetAppleDomainsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AppleDomainsResponseResult
}
catch (ApiException<GetAppleDomainsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAppleDomainsRequest](Requests/AppleDomains/GetAppleDomainsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppleDomainsResponseResult](Models/AppleDomainsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAppleDomainsError](Errors/GetAppleDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppleDomainsResponseResult&gt; GetAppleDomainsId(GetAppleDomainsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a appleDomains resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppleDomains.GetAppleDomainsId(new GetAppleDomainsIdRequest
    {
        Id = "t1_apd_18124df82d8ec945359f6bd",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AppleDomainsResponseResult
}
catch (ApiException<GetAppleDomainsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAppleDomainsIdRequest](Requests/AppleDomains/GetAppleDomainsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppleDomainsResponseResult](Models/AppleDomainsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAppleDomainsIdError](Errors/GetAppleDomainsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AppleDomainsMassEnablement

> Source: [AppleDomainsMassEnablement](Api/AppleDomainsMassEnablement.cs)

<details>
<summary><code>Task&lt;AppleDomainsMassEnablementCsvResponseResult&gt; PostApplePayForCsv(PostApplePayForCsvRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

"Registers Apple Pay domains for multiple merchants using a CSV file. The uploaded CSV must include at least two columns: `"domain"` and `"merchant_id"`. All other columns are ignored. The file is parsed using the header row, and any data rows with missing or extra columns are also rejected.

For each merchant-domain pair, the system creates an `appleDomains` record. Domains not already registered are marked as `registering`, and asynchronous processing begins. If verification succeeds, the status updates to `registered`. If verification fails, the status changes to `failed_registration`, with an `errorNote` explaining the reason.

This endpoint is idempotent for previously registered domains, allowing repeated submissions without adverse effects. You can resubmit the same CSV to retry failed registrations after resolving any issues.

Upload the CSV file as a form-data field named files. All domains must be fully qualified domain names (FQDNs) and must host the Apple Pay verification file at:
https://{merchantDomain}/.well-known/apple-developer-merchantid-domain-association

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppleDomainsMassEnablement.PostApplePayForCsv(new PostApplePayForCsvRequest
    {
        Id = "p1_ent_123abc4d567890efg1h2i34",
        ContentType = ContentType.MultipartFormDataBoundaryCalculatedWhenRequestIsSent,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AppleDomainsMassEnablementCsvResponseResult
}
catch (ApiException<PostApplePayForCsvError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostApplePayForCsvRequest](Requests/AppleDomainsMassEnablement/PostApplePayForCsvRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppleDomainsMassEnablementCsvResponseResult](Models/AppleDomainsMassEnablementCsvResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostApplePayForCsvError](Errors/PostApplePayForCsvError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppleDomainsMassEnablementForMerchantList&gt; PostApplePayForMerchantList(PostApplePayForMerchantListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers Apple Pay domains for a list of merchants using a JSON request body. For each merchant-domain pair, the system creates an `appleDomains` record. Domains not already registered update their status to `registering`, and asynchronous verification begins. If verification succeeds, the status updates to `registered`. If verification fails, the status changes to `failed_registration`, with an `errorNote` explaining the reason.

This endpoint is idempotent, allowing repeated submissions of the same request body without adverse effects. Only failed registrations are retried.

All domains must be fully qualified domain names (FQDNs) and must host the Apple Pay verification file at:
https://{merchantDomain}/.well-known/apple-developer-merchantid-domain-association

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppleDomainsMassEnablement.PostApplePayForMerchantList(
        new PostApplePayForMerchantListRequest
        {
            Id = "p1_ent_123abc4d567890efg1h2i34",
            RequestToken = "20250423-yourmerchant-refunds-001",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            Body = new ApplePayForMerchantListPostRequest(),
        });
    // TODO: Handle 'response' of type AppleDomainsMassEnablementForMerchantList
}
catch (ApiException<PostApplePayForMerchantListError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostApplePayForMerchantListRequest](Requests/AppleDomainsMassEnablement/PostApplePayForMerchantListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppleDomainsMassEnablementForMerchantList](Models/AppleDomainsMassEnablementForMerchantList.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostApplePayForMerchantListError](Errors/PostApplePayForMerchantListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AppleDomainsMassEnablementForMerchantList&gt; PostApplePayForMerchantListDisable(PostApplePayForMerchantListDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unregisters Apple Pay domains for a list of merchants using a JSON request body. For each merchant-domain pair, the system updates the corresponding appleDomains record to reflect the `unregistered` status. Domains not yet unregistered are marked as `unregistering`, and asynchronous processing begins. If unregistration succeeds, the status updates to `unregistered`. If unregistration fails, the status reverts back to `registered`, with an `errorNote` explaining the reason.

This endpoint is idempotent, allowing repeated submissions of the same request body without adverse effects. Only failed de-registrations are retried.

All domains must be fully qualified domain names (FQDNs) and must have previously been registered for Apple Pay and verified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppleDomainsMassEnablement.PostApplePayForMerchantListDisable(
        new PostApplePayForMerchantListDisableRequest
        {
            Id = "p1_ent_123abc4d567890efg1h2i34",
            RequestToken = "20250423-yourmerchant-refunds-001",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            Body = new ApplePayForMerchantListPostRequest(),
        });
    // TODO: Handle 'response' of type AppleDomainsMassEnablementForMerchantList
}
catch (ApiException<PostApplePayForMerchantListDisableError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostApplePayForMerchantListDisableRequest](Requests/AppleDomainsMassEnablement/PostApplePayForMerchantListDisableRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AppleDomainsMassEnablementForMerchantList](Models/AppleDomainsMassEnablementForMerchantList.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostApplePayForMerchantListDisableError](Errors/PostApplePayForMerchantListDisableError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateApplePayDomainResponseResult&gt; PostUpdateApplePayDomain(PostUpdateApplePayDomainRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Verifies a remote Apple Pay configuration file. 

The configuration file must be stored on the merchant's or vendor's domain, but accessible to the Payrix systems. 

This endpoint can be used to ensure the configuration file is in the correct location with the correct rights for remote access. 

It is meant to validate one configuration file with the provided Fully Qualified Domain Name (fqdn). 

This endpoint does not do any action towards registration. It only verifies access to the remote file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AppleDomainsMassEnablement.PostUpdateApplePayDomain(new PostUpdateApplePayDomainRequest
    {
        Id = "p1_mer_123abc4d567890efg1h2i34",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        Body = new UpdateApplePayDomainPostRequest(),
    });
    // TODO: Handle 'response' of type UpdateApplePayDomainResponseResult
}
catch (ApiException<PostUpdateApplePayDomainError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostUpdateApplePayDomainRequest](Requests/AppleDomainsMassEnablement/PostUpdateApplePayDomainRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateApplePayDomainResponseResult](Models/UpdateApplePayDomainResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostUpdateApplePayDomainError](Errors/PostUpdateApplePayDomainError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthenticationTokens

> Source: [AuthenticationTokens](Api/AuthenticationTokens.cs)

<details>
<summary><code>Task&lt;AuthTokensResponseResult&gt; DeleteAuthTokensId(DeleteAuthTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an AuthToken, which is an additional layer of authentication security and tracking for Apikeys and Sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationTokens.DeleteAuthTokensId(new DeleteAuthTokensIdRequest
    {
        Id = "t1_atk_67d4721def0c98ba2f417bz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AuthTokensResponseResult
}
catch (ApiException<DeleteAuthTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAuthTokensIdRequest](Requests/AuthenticationTokens/DeleteAuthTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTokensResponseResult](Models/AuthTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAuthTokensIdError](Errors/DeleteAuthTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthTokensResponseResult&gt; GetAuthTokens(GetAuthTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an AuthToken, which is an additional layer of authentication security and tracking for Apikeys and Sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationTokens.GetAuthTokens(new GetAuthTokensRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type AuthTokensResponseResult
}
catch (ApiException<GetAuthTokensError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAuthTokensRequest](Requests/AuthenticationTokens/GetAuthTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTokensResponseResult](Models/AuthTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAuthTokensError](Errors/GetAuthTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthTokensResponseResult&gt; GetAuthTokensId(GetAuthTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an AuthToken, an AuthToken resource is an additional layer of authentication security and tracking for Apikeys and Sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationTokens.GetAuthTokensId(new GetAuthTokensIdRequest
    {
        Id = "t1_atk_67d4721def0c98ba2f417bz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type AuthTokensResponseResult
}
catch (ApiException<GetAuthTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAuthTokensIdRequest](Requests/AuthenticationTokens/GetAuthTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTokensResponseResult](Models/AuthTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAuthTokensIdError](Errors/GetAuthTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthTokensResponseResult&gt; PostAuthTokens(PostAuthTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an AuthToken to add an additional layer of authentication, security, and tracking for Apikeys and Sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationTokens.PostAuthTokens(new PostAuthTokensRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AuthTokensPostRequest
        {
            Login = "some example string",
            Customer = "some example string",
            Token = "some example string",
        },
    });
    // TODO: Handle 'response' of type AuthTokensResponseResult
}
catch (ApiException<PostAuthTokensError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostAuthTokensRequest](Requests/AuthenticationTokens/PostAuthTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTokensResponseResult](Models/AuthTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostAuthTokensError](Errors/PostAuthTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthTokensResponseResult&gt; PutAuthTokensId(PutAuthTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an AuthToken to add an additional layer of authentication security and tracking for Apikeys and Sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationTokens.PutAuthTokensId(new PutAuthTokensIdRequest
    {
        Id = "t1_atk_67d4721def0c98ba2f417bz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new AuthTokensPutRequest(),
    });
    // TODO: Handle 'response' of type AuthTokensResponseResult
}
catch (ApiException<PutAuthTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutAuthTokensIdRequest](Requests/AuthenticationTokens/PutAuthTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthTokensResponseResult](Models/AuthTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutAuthTokensIdError](Errors/PutAuthTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BatchesSettlements

> Source: [BatchesSettlements](Api/BatchesSettlements.cs)

<details>
<summary><code>Task&lt;BatchesResponseResult&gt; GetBatches(GetBatchesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Batch, which represents a group of Transactions that are sent together to the processor to be settled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BatchesSettlements.GetBatches(new GetBatchesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type BatchesResponseResult
}
catch (ApiException<GetBatchesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBatchesRequest](Requests/BatchesSettlements/GetBatchesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchesResponseResult](Models/BatchesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBatchesError](Errors/GetBatchesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchesResponseResult&gt; GetBatchesId(GetBatchesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Batch, a Batch resource represents a group of Transactions that are sent together to the processor to be settled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BatchesSettlements.GetBatchesId(new GetBatchesIdRequest
    {
        Id = "t1_bth_67d91c7aa2aa3800cb2be00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type BatchesResponseResult
}
catch (ApiException<GetBatchesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBatchesIdRequest](Requests/BatchesSettlements/GetBatchesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchesResponseResult](Models/BatchesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBatchesIdError](Errors/GetBatchesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchesResponseResult&gt; PostBatches(PostBatchesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Batch. A Batch resource represents a group of Transactions that are sent together to the processor to be settled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BatchesSettlements.PostBatches(new PostBatchesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new BatchesPostRequest { Merchant = "some example string", Platform = PlatformModel1.Apple },
    });
    // TODO: Handle 'response' of type BatchesResponseResult
}
catch (ApiException<PostBatchesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostBatchesRequest](Requests/BatchesSettlements/PostBatchesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchesResponseResult](Models/BatchesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostBatchesError](Errors/PostBatchesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchesResponseResult&gt; PutBatchesId(PutBatchesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Batch. A Batch resource represents a group of Transactions that are sent together to the processor to be settled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BatchesSettlements.PutBatchesId(new PutBatchesIdRequest
    {
        Id = "t1_bth_67d91c7aa2aa3800cb2be00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new BatchesPutRequest(),
    });
    // TODO: Handle 'response' of type BatchesResponseResult
}
catch (ApiException<PutBatchesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutBatchesIdRequest](Requests/BatchesSettlements/PutBatchesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchesResponseResult](Models/BatchesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutBatchesIdError](Errors/PutBatchesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Bins

> Source: [Bins](Api/Bins.cs)

<details>
<summary><code>Task&lt;BinsResponseResult&gt; GetBins(GetBinsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Querying a BIN resource, which holds information about the issuer of a card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bins.GetBins(new GetBinsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type BinsResponseResult
}
catch (ApiException<GetBinsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBinsRequest](Requests/Bins/GetBinsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BinsResponseResult](Models/BinsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBinsError](Errors/GetBinsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BinsResponseResult&gt; GetBinsId(GetBinsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a BIN, which holds information about the issuer of a card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bins.GetBinsId(new GetBinsIdRequest
    {
        Id = "p1_bin_68cd8d3a20b63e703d73b79",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type BinsResponseResult
}
catch (ApiException<GetBinsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBinsIdRequest](Requests/Bins/GetBinsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BinsResponseResult](Models/BinsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBinsIdError](Errors/GetBinsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChangeRequests

> Source: [ChangeRequests](Api/ChangeRequests.cs)

<details>
<summary><code>Task&lt;ChangeRequestsResponseResult&gt; DeleteChangeRequestsId(DeleteChangeRequestsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Change Request. 
ChangeRequests is a resource that manages changes to a certain resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChangeRequests.DeleteChangeRequestsId(new DeleteChangeRequestsIdRequest
    {
        Id = "t1_chr_67461c21ce3bae674b5500a",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ChangeRequestsResponseResult
}
catch (ApiException<DeleteChangeRequestsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteChangeRequestsIdRequest](Requests/ChangeRequests/DeleteChangeRequestsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangeRequestsResponseResult](Models/ChangeRequestsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteChangeRequestsIdError](Errors/DeleteChangeRequestsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangeRequestsResponseResult&gt; GetChangeRequests(GetChangeRequestsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Change Request. 
ChangeRequests is a resource that manages changes to a certain resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChangeRequests.GetChangeRequests(new GetChangeRequestsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ChangeRequestsResponseResult
}
catch (ApiException<GetChangeRequestsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChangeRequestsRequest](Requests/ChangeRequests/GetChangeRequestsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangeRequestsResponseResult](Models/ChangeRequestsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChangeRequestsError](Errors/GetChangeRequestsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangeRequestsResponseResult&gt; GetChangeRequestsId(GetChangeRequestsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Change Request. 
ChangeRequests is a resource that manages changes to a certain resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChangeRequests.GetChangeRequestsId(new GetChangeRequestsIdRequest
    {
        Id = "t1_chr_67461c21ce3bae674b5500a",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ChangeRequestsResponseResult
}
catch (ApiException<GetChangeRequestsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChangeRequestsIdRequest](Requests/ChangeRequests/GetChangeRequestsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangeRequestsResponseResult](Models/ChangeRequestsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChangeRequestsIdError](Errors/GetChangeRequestsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChargebackDocuments

> Source: [ChargebackDocuments](Api/ChargebackDocuments.cs)

<details>
<summary><code>Task&lt;ChargebackDocumentsResponseResult&gt; DeleteChargebackDocumentsId(DeleteChargebackDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a chargebackDocument. A chargebackDocument resource represents a file related to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackDocuments.DeleteChargebackDocumentsId(new DeleteChargebackDocumentsIdRequest
    {
        Id = "t1_chd_679a4a2ba49405540af4856",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ChargebackDocumentsResponseResult
}
catch (ApiException<DeleteChargebackDocumentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteChargebackDocumentsIdRequest](Requests/ChargebackDocuments/DeleteChargebackDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackDocumentsResponseResult](Models/ChargebackDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteChargebackDocumentsIdError](Errors/DeleteChargebackDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackDocumentsResponseResult&gt; GetChargebackDocuments(GetChargebackDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query chargebackDocuments, each representing a file related to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackDocuments.GetChargebackDocuments(new GetChargebackDocumentsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ChargebackDocumentsResponseResult
}
catch (ApiException<GetChargebackDocumentsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackDocumentsRequest](Requests/ChargebackDocuments/GetChargebackDocumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackDocumentsResponseResult](Models/ChargebackDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackDocumentsError](Errors/GetChargebackDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackDocumentsResponseResult&gt; GetChargebackDocumentsId(GetChargebackDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a chargebackDocument. A chargebackDocument resource represents a file related to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackDocuments.GetChargebackDocumentsId(new GetChargebackDocumentsIdRequest
    {
        Id = "t1_chd_679a4a2ba49405540af4856",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ChargebackDocumentsResponseResult
}
catch (ApiException<GetChargebackDocumentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackDocumentsIdRequest](Requests/ChargebackDocuments/GetChargebackDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackDocumentsResponseResult](Models/ChargebackDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackDocumentsIdError](Errors/GetChargebackDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackDocumentsResponseResult&gt; PostChargebackDocuments(PostChargebackDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a chargebackDocument resource that represents a file related to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackDocuments.PostChargebackDocuments(new PostChargebackDocumentsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ChargebackDocumentsPostRequest { Chargeback = "some example string" },
    });
    // TODO: Handle 'response' of type ChargebackDocumentsResponseResult
}
catch (ApiException<PostChargebackDocumentsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostChargebackDocumentsRequest](Requests/ChargebackDocuments/PostChargebackDocumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackDocumentsResponseResult](Models/ChargebackDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostChargebackDocumentsError](Errors/PostChargebackDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackDocumentsResponseResult&gt; PutChargebackDocumentsId(PutChargebackDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a chargebackDocument. A chargebackDocument resource represents a file related to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackDocuments.PutChargebackDocumentsId(new PutChargebackDocumentsIdRequest
    {
        Id = "t1_chd_679a4a2ba49405540af4856",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ChargebacksDocumentsPutRequest(),
    });
    // TODO: Handle 'response' of type ChargebackDocumentsResponseResult
}
catch (ApiException<PutChargebackDocumentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutChargebackDocumentsIdRequest](Requests/ChargebackDocuments/PutChargebackDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackDocumentsResponseResult](Models/ChargebackDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutChargebackDocumentsIdError](Errors/PutChargebackDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChargebackMessageResults

> Source: [ChargebackMessageResults](Api/ChargebackMessageResults.cs)

<details>
<summary><code>Task&lt;ChargebackMessageResultsResponseResult&gt; GetChargebackMessageResults(GetChargebackMessageResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a chargebackMessageResults resource, which represents a message that is received from the processor in relation to a Chargeback message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackMessageResults.GetChargebackMessageResults(
        new GetChargebackMessageResultsRequest
        {
            PageNumber = 1,
            PageLimit = 50,
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
            Search = "created[greater]=2025-01-01",
            Totals = "count[]=id",
        });
    // TODO: Handle 'response' of type ChargebackMessageResultsResponseResult
}
catch (ApiException<GetChargebackMessageResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackMessageResultsRequest](Requests/ChargebackMessageResults/GetChargebackMessageResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackMessageResultsResponseResult](Models/ChargebackMessageResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackMessageResultsError](Errors/GetChargebackMessageResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackMessageResultsResponseResult&gt; GetChargebackMessageResultsId(GetChargebackMessageResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a chargebackMessageResults resource, which represents a message that is received from the processor in relation to a Chargeback message.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackMessageResults.GetChargebackMessageResultsId(
        new GetChargebackMessageResultsIdRequest
        {
            Id = "t1_cmr_671a55a6a0d0821cc4acf00",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
        });
    // TODO: Handle 'response' of type ChargebackMessageResultsResponseResult
}
catch (ApiException<GetChargebackMessageResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackMessageResultsIdRequest](Requests/ChargebackMessageResults/GetChargebackMessageResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackMessageResultsResponseResult](Models/ChargebackMessageResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackMessageResultsIdError](Errors/GetChargebackMessageResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChargebackMessages

> Source: [ChargebackMessages](Api/ChargebackMessages.cs)

<details>
<summary><code>Task&lt;ChargebackMessagesResponseResult&gt; GetChargebackMessages(GetChargebackMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a chargebackMessage resource, which represents a message that is sent by a Merchant, processor, or bank in relation to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackMessages.GetChargebackMessages(new GetChargebackMessagesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ChargebackMessagesResponseResult
}
catch (ApiException<GetChargebackMessagesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackMessagesRequest](Requests/ChargebackMessages/GetChargebackMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackMessagesResponseResult](Models/ChargebackMessagesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackMessagesError](Errors/GetChargebackMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackMessagesResponseResult&gt; GetChargebackMessagesId(GetChargebackMessagesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a chargebackMessage. A chargebackMessage resource represents a message that is sent by a Merchant, processor, or bank in relation to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackMessages.GetChargebackMessagesId(new GetChargebackMessagesIdRequest
    {
        Id = "t1_chm_fd94438bed7d5e80f0000ea",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
    });
    // TODO: Handle 'response' of type ChargebackMessagesResponseResult
}
catch (ApiException<GetChargebackMessagesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackMessagesIdRequest](Requests/ChargebackMessages/GetChargebackMessagesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackMessagesResponseResult](Models/ChargebackMessagesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackMessagesIdError](Errors/GetChargebackMessagesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackMessagesResponseResult&gt; PostChargebackMessages(PostChargebackMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a chargebackMessage. A chargebackMessage resource represents a message that is sent by a Merchant, processor, or bank in relation to a Chargeback.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackMessages.PostChargebackMessages(new PostChargebackMessagesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ChargebackMessagePostRequest
        {
            Chargeback = "some example string",
            Type = ChargebackMessageType1.Assign,
        },
    });
    // TODO: Handle 'response' of type ChargebackMessagesResponseResult
}
catch (ApiException<PostChargebackMessagesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostChargebackMessagesRequest](Requests/ChargebackMessages/PostChargebackMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackMessagesResponseResult](Models/ChargebackMessagesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostChargebackMessagesError](Errors/PostChargebackMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChargebackStatuses

> Source: [ChargebackStatuses](Api/ChargebackStatuses.cs)

<details>
<summary><code>Task&lt;ChargebackStatusesResponseResult&gt; GetChargebackStatuses(GetChargebackStatusesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query ChargebackStatuses. A ChargebackStatuses is the logged status changes of a Chargeback; The resource for each Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackStatuses.GetChargebackStatuses(new GetChargebackStatusesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ChargebackStatusesResponseResult
}
catch (ApiException<GetChargebackStatusesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackStatusesRequest](Requests/ChargebackStatuses/GetChargebackStatusesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackStatusesResponseResult](Models/ChargebackStatusesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackStatusesError](Errors/GetChargebackStatusesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebackStatusesResponseResult&gt; GetChargebackStatusesId(GetChargebackStatusesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query ChargebackStatuses. A ChargebackStatuses is the logged status changes of a Chargeback, The resource for each Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChargebackStatuses.GetChargebackStatusesId(new GetChargebackStatusesIdRequest
    {
        Id = "p1_chs_00cf194e96237dd16d0c1e4",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ChargebackStatusesResponseResult
}
catch (ApiException<GetChargebackStatusesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebackStatusesIdRequest](Requests/ChargebackStatuses/GetChargebackStatusesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebackStatusesResponseResult](Models/ChargebackStatusesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebackStatusesIdError](Errors/GetChargebackStatusesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Chargebacks

> Source: [Chargebacks](Api/Chargebacks.cs)

<details>
<summary><code>Task&lt;ChargebacksResponseResult&gt; GetChargebacks(GetChargebacksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Chargebacks. A Chargeback is the reversal of a Transaction, meaning that the funds have been returned to their source. The resource for each Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chargebacks.GetChargebacks(new GetChargebacksRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ChargebacksResponseResult
}
catch (ApiException<GetChargebacksError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebacksRequest](Requests/Chargebacks/GetChargebacksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebacksResponseResult](Models/ChargebacksResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebacksError](Errors/GetChargebacksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChargebacksResponseResult&gt; GetChargebacksId(GetChargebacksIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Chargeback. A Chargeback is the reversal of a Transaction and means that the funds have been returned to their source. The resource for a Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chargebacks.GetChargebacksId(new GetChargebacksIdRequest
    {
        Id = "t1_chb_678e573098a7706d87b45c1",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ChargebacksResponseResult
}
catch (ApiException<GetChargebacksIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetChargebacksIdRequest](Requests/Chargebacks/GetChargebacksIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChargebacksResponseResult](Models/ChargebacksResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetChargebacksIdError](Errors/GetChargebacksIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConfirmationCodes

> Source: [ConfirmationCodes](Api/ConfirmationCodes.cs)

<details>
<summary><code>Task&lt;ConfirmCodesResponseResult&gt; DeleteConfirmCodesId(DeleteConfirmCodesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a confirmCode resource. A confirmCode resource represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfirmationCodes.DeleteConfirmCodesId(new DeleteConfirmCodesIdRequest
    {
        Id = "p1_cfc_67dd2714a9a1fc91f994e00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ConfirmCodesResponseResult
}
catch (ApiException<DeleteConfirmCodesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteConfirmCodesIdRequest](Requests/ConfirmationCodes/DeleteConfirmCodesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConfirmCodesResponseResult](Models/ConfirmCodesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteConfirmCodesIdError](Errors/DeleteConfirmCodesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConfirmCodesResponseResult&gt; GetConfirmCodes(GetConfirmCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a confirmCode resource. A confirmCode resource represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfirmationCodes.GetConfirmCodes(new GetConfirmCodesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ConfirmCodesResponseResult
}
catch (ApiException<GetConfirmCodesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetConfirmCodesRequest](Requests/ConfirmationCodes/GetConfirmCodesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConfirmCodesResponseResult](Models/ConfirmCodesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetConfirmCodesError](Errors/GetConfirmCodesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConfirmCodesResponseResult&gt; GetConfirmCodesId(GetConfirmCodesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a confirmCode resource, which represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfirmationCodes.GetConfirmCodesId(new GetConfirmCodesIdRequest
    {
        Id = "p1_cfc_67dd2714a9a1fc91f994e00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
    });
    // TODO: Handle 'response' of type ConfirmCodesResponseResult
}
catch (ApiException<GetConfirmCodesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetConfirmCodesIdRequest](Requests/ConfirmationCodes/GetConfirmCodesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConfirmCodesResponseResult](Models/ConfirmCodesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetConfirmCodesIdError](Errors/GetConfirmCodesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConfirmCodesResponseResult&gt; PostConfirmCodes(PostConfirmCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a confirmCode resource that represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfirmationCodes.PostConfirmCodes(new PostConfirmCodesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ConfirmCodesPostRequest
        {
            Login = "some example string",
            Type = ConfirmCodeType1.Password,
            Key = "some example string",
        },
    });
    // TODO: Handle 'response' of type ConfirmCodesResponseResult
}
catch (ApiException<PostConfirmCodesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostConfirmCodesRequest](Requests/ConfirmationCodes/PostConfirmCodesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConfirmCodesResponseResult](Models/ConfirmCodesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostConfirmCodesError](Errors/PostConfirmCodesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Contacts

> Source: [Contacts](Api/Contacts.cs)

<details>
<summary><code>Task&lt;ContactsResponseResult&gt; DeleteContactsId(DeleteContactsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Contact. A Contact resource represents an individual who is associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contacts.DeleteContactsId(new DeleteContactsIdRequest
    {
        Id = "t1_con_665f696f0d66c3281d00000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ContactsResponseResult
}
catch (ApiException<DeleteContactsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteContactsIdRequest](Requests/Contacts/DeleteContactsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContactsResponseResult](Models/ContactsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteContactsIdError](Errors/DeleteContactsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ContactsResponseResult&gt; GetContacts(GetContactsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Contact, which represents an individual who is associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contacts.GetContacts(new GetContactsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ContactsResponseResult
}
catch (ApiException<GetContactsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetContactsRequest](Requests/Contacts/GetContactsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContactsResponseResult](Models/ContactsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetContactsError](Errors/GetContactsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ContactsResponseResult&gt; GetContactsId(GetContactsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Contact, which represents an individual who is associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contacts.GetContactsId(new GetContactsIdRequest
    {
        Id = "t1_con_665f696f0d66c3281d00000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ContactsResponseResult
}
catch (ApiException<GetContactsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetContactsIdRequest](Requests/Contacts/GetContactsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContactsResponseResult](Models/ContactsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetContactsIdError](Errors/GetContactsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ContactsResponseResult&gt; PostContacts(PostContactsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Contact. 
A Contact resource represents an individual who is associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contacts.PostContacts(new PostContactsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ContactsPostRequest
        {
            Entity = "some example string",
            First = "some example string",
            Last = "some example string",
            Email = "some example string",
        },
    });
    // TODO: Handle 'response' of type ContactsResponseResult
}
catch (ApiException<PostContactsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostContactsRequest](Requests/Contacts/PostContactsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContactsResponseResult](Models/ContactsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostContactsError](Errors/PostContactsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ContactsResponseResult&gt; PutContactsId(PutContactsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Contact, A Contact resource represents an individual who is associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Contacts.PutContactsId(new PutContactsIdRequest
    {
        Id = "t1_con_665f696f0d66c3281d00000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ContactsPutRequest(),
    });
    // TODO: Handle 'response' of type ContactsResponseResult
}
catch (ApiException<PutContactsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutContactsIdRequest](Requests/Contacts/PutContactsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContactsResponseResult](Models/ContactsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutContactsIdError](Errors/PutContactsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Credentials

> Source: [Credentials](Api/Credentials.cs)

<details>
<summary><code>Task&lt;CredentialsResponseResult&gt; DeleteCredentialsId(DeleteCredentialsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Credential resource. A Credential resource represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as delete a Credential resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Credentials.DeleteCredentialsId(new DeleteCredentialsIdRequest
    {
        Id = "t1_cdt_67e152d9f0ef564f9b2c0d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type CredentialsResponseResult
}
catch (ApiException<DeleteCredentialsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCredentialsIdRequest](Requests/Credentials/DeleteCredentialsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CredentialsResponseResult](Models/CredentialsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteCredentialsIdError](Errors/DeleteCredentialsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CredentialsResponseResult&gt; GetCredentials(GetCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Credential resource. A Credential resource represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as send Transactions to the processor, or board a Merchant with the processor

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Credentials.GetCredentials(new GetCredentialsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type CredentialsResponseResult
}
catch (ApiException<GetCredentialsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCredentialsRequest](Requests/Credentials/GetCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CredentialsResponseResult](Models/CredentialsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCredentialsError](Errors/GetCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CredentialsResponseResult&gt; GetCredentialsId(GetCredentialsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Credential resource that represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as send Transactions to the processor, or board a Merchant with the processor.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Credentials.GetCredentialsId(new GetCredentialsIdRequest
    {
        Id = "t1_cdt_67e152d9f0ef564f9b2c0d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type CredentialsResponseResult
}
catch (ApiException<GetCredentialsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCredentialsIdRequest](Requests/Credentials/GetCredentialsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CredentialsResponseResult](Models/CredentialsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCredentialsIdError](Errors/GetCredentialsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CredentialsResponseResult&gt; PostCredentials(PostCredentialsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Credential resource that represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as send Transactions to the processor, or board a Merchant with the processor.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Credentials.PostCredentials(new PostCredentialsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new CredentialsPostRequest
        {
            Entity = "some example string",
            Username = "some example string",
            Integration = CredentialIntegration1.Apple,
            Type = CredentialType1.Transaction,
        },
    });
    // TODO: Handle 'response' of type CredentialsResponseResult
}
catch (ApiException<PostCredentialsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCredentialsRequest](Requests/Credentials/PostCredentialsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CredentialsResponseResult](Models/CredentialsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostCredentialsError](Errors/PostCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CredentialsResponseResult&gt; PutCredentialsId(PutCredentialsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Credential resource represents an authorization that a given Entity has to connect to an integration to perform a particular action.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Credentials.PutCredentialsId(new PutCredentialsIdRequest
    {
        Id = "t1_cdt_67e152d9f0ef564f9b2c0d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new CredentialsPutRequest(),
    });
    // TODO: Handle 'response' of type CredentialsResponseResult
}
catch (ApiException<PutCredentialsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutCredentialsIdRequest](Requests/Credentials/PutCredentialsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CredentialsResponseResult](Models/CredentialsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutCredentialsIdError](Errors/PutCredentialsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Customers

> Source: [Customers](Api/Customers.cs)

<details>
<summary><code>Task&lt;CustomersResponseResult&gt; DeleteCustomersId(DeleteCustomersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Customer. A Customer is a record that is used to store data about a particular customer of a Merchant. You can use it to associate payment data to the Customer, or for use with other API features.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.DeleteCustomersId(new DeleteCustomersIdRequest
    {
        Id = "t1_cus_67a527f32862c3e51bcce51",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type CustomersResponseResult
}
catch (ApiException<DeleteCustomersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCustomersIdRequest](Requests/Customers/DeleteCustomersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomersResponseResult](Models/CustomersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteCustomersIdError](Errors/DeleteCustomersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CustomersResponseResult&gt; GetCustomers(GetCustomersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query customers. Each Customer record stores data about a particular customer of a Merchant and can be used to associate payment data to the Customer and for other API features.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.GetCustomers(new GetCustomersRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type CustomersResponseResult
}
catch (ApiException<GetCustomersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCustomersRequest](Requests/Customers/GetCustomersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomersResponseResult](Models/CustomersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCustomersError](Errors/GetCustomersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CustomersResponseResult&gt; GetCustomersId(GetCustomersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Customer, which is a record that stores data about a particular customer of a Merchant and can be used to associate payment data or with other API features.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.GetCustomersId(new GetCustomersIdRequest
    {
        Id = "t1_cus_67a527f32862c3e51bcce51",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type CustomersResponseResult
}
catch (ApiException<GetCustomersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCustomersIdRequest](Requests/Customers/GetCustomersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomersResponseResult](Models/CustomersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCustomersIdError](Errors/GetCustomersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CustomersResponseResult&gt; PostCustomers(PostCustomersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Customer record to store data about a particular customer of a Merchant, and to associate payment data to the Customer and for other API features.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.PostCustomers(new PostCustomersRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new CustomersPostRequest { Login = "some example string" },
    });
    // TODO: Handle 'response' of type CustomersResponseResult
}
catch (ApiException<PostCustomersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostCustomersRequest](Requests/Customers/PostCustomersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomersResponseResult](Models/CustomersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostCustomersError](Errors/PostCustomersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CustomersResponseResult&gt; PutCustomersId(PutCustomersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Customer. A Customer is a record that is used to store data about a particular customer of a Merchant, which you can use to associate payment data or for use with other API features.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.PutCustomersId(new PutCustomersIdRequest
    {
        Id = "t1_cus_67a527f32862c3e51bcce51",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new CustomersPutRequest(),
    });
    // TODO: Handle 'response' of type CustomersResponseResult
}
catch (ApiException<PutCustomersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutCustomersIdRequest](Requests/Customers/PutCustomersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomersResponseResult](Models/CustomersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutCustomersIdError](Errors/PutCustomersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DecisionActions

> Source: [DecisionActions](Api/DecisionActions.cs)

<details>
<summary><code>Task&lt;DecisionActionsResponseResult&gt; DeleteDecisionActionsId(DeleteDecisionActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Decision Action. A Decision Action is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionActions.DeleteDecisionActionsId(new DeleteDecisionActionsIdRequest
    {
        Id = "t1_dca_67ddc0163f51a4ffd1ea3d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DecisionActionsResponseResult
}
catch (ApiException<DeleteDecisionActionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDecisionActionsIdRequest](Requests/DecisionActions/DeleteDecisionActionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionActionsResponseResult](Models/DecisionActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteDecisionActionsIdError](Errors/DeleteDecisionActionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionActionsResponseResult&gt; GetDecisionActions(GetDecisionActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Decision Action, A Decision Action is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionActions.GetDecisionActions(new GetDecisionActionsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type DecisionActionsResponseResult
}
catch (ApiException<GetDecisionActionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDecisionActionsRequest](Requests/DecisionActions/GetDecisionActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionActionsResponseResult](Models/DecisionActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDecisionActionsError](Errors/GetDecisionActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionActionsResponseResult&gt; GetDecisionActionsId(GetDecisionActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Decision Action, which is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionActions.GetDecisionActionsId(new GetDecisionActionsIdRequest
    {
        Id = "t1_dca_67ddc0163f51a4ffd1ea3d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DecisionActionsResponseResult
}
catch (ApiException<GetDecisionActionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDecisionActionsIdRequest](Requests/DecisionActions/GetDecisionActionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionActionsResponseResult](Models/DecisionActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDecisionActionsIdError](Errors/GetDecisionActionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionActionsResponseResult&gt; PostDecisionActions(PostDecisionActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Decision Action in conjunction with This resource, which is used to further tune the reactions based on conditions defined in the DecisionAction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionActions.PostDecisionActions(new PostDecisionActionsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new DecisionActionsPostRequest { Decision = "some example string" },
    });
    // TODO: Handle 'response' of type DecisionActionsResponseResult
}
catch (ApiException<PostDecisionActionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDecisionActionsRequest](Requests/DecisionActions/PostDecisionActionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionActionsResponseResult](Models/DecisionActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostDecisionActionsError](Errors/PostDecisionActionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionActionsResponseResult&gt; PutDecisionActionsId(PutDecisionActionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Decision Action, which is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionActions.PutDecisionActionsId(new PutDecisionActionsIdRequest
    {
        Id = "t1_dca_67ddc0163f51a4ffd1ea3d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new DecisionActionsPutRequest(),
    });
    // TODO: Handle 'response' of type DecisionActionsResponseResult
}
catch (ApiException<PutDecisionActionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutDecisionActionsIdRequest](Requests/DecisionActions/PutDecisionActionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionActionsResponseResult](Models/DecisionActionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutDecisionActionsIdError](Errors/PutDecisionActionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DecisionRules

> Source: [DecisionRules](Api/DecisionRules.cs)

<details>
<summary><code>Task&lt;DecisionRulesResponseResult&gt; DeleteDecisionRulesId(DeleteDecisionRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Decision Rule that makes a Decision apply only in certain circumstances, for example, applying an administration charge if a payment is under $50.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionRules.DeleteDecisionRulesId(new DeleteDecisionRulesIdRequest
    {
        Id = "t1_drl_67d9836cb20781126c769f0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DecisionRulesResponseResult
}
catch (ApiException<DeleteDecisionRulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDecisionRulesIdRequest](Requests/DecisionRules/DeleteDecisionRulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionRulesResponseResult](Models/DecisionRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteDecisionRulesIdError](Errors/DeleteDecisionRulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionRulesResponseResult&gt; GetDecisionRules(GetDecisionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Decision Rule; A Decision Rule is a piece of conditional logic that makes a Decision apply only in certain circumstances, For example, a Decision Rule could apply an administration charge if a payment is under $50.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionRules.GetDecisionRules(new GetDecisionRulesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type DecisionRulesResponseResult
}
catch (ApiException<GetDecisionRulesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDecisionRulesRequest](Requests/DecisionRules/GetDecisionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionRulesResponseResult](Models/DecisionRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDecisionRulesError](Errors/GetDecisionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionRulesResponseResult&gt; GetDecisionRulesId(GetDecisionRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Decision Rule that makes a Decision apply only in certain circumstances, such as applying an administration charge if a payment is under $50.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionRules.GetDecisionRulesId(new GetDecisionRulesIdRequest
    {
        Id = "t1_drl_67d9836cb20781126c769f0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DecisionRulesResponseResult
}
catch (ApiException<GetDecisionRulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDecisionRulesIdRequest](Requests/DecisionRules/GetDecisionRulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionRulesResponseResult](Models/DecisionRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDecisionRulesIdError](Errors/GetDecisionRulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionRulesResponseResult&gt; PostDecisionRules(PostDecisionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Decision Rule that makes a Decision apply only in certain circumstances, such as applying an administration charge if a payment is under $50.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionRules.PostDecisionRules(new PostDecisionRulesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new DecisionRulesPostRequest
        {
            Decision = "some example string",
            Type = DecisionRuleType1.Less,
            Value = 1,
        },
    });
    // TODO: Handle 'response' of type DecisionRulesResponseResult
}
catch (ApiException<PostDecisionRulesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDecisionRulesRequest](Requests/DecisionRules/PostDecisionRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionRulesResponseResult](Models/DecisionRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostDecisionRulesError](Errors/PostDecisionRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionRulesResponseResult&gt; PutDecisionRulesId(PutDecisionRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Decision Rule that makes a Decision apply only in certain circumstances, for example, applying an administration charge if a payment is under $50.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionRules.PutDecisionRulesId(new PutDecisionRulesIdRequest
    {
        Id = "t1_drl_67d9836cb20781126c769f0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new DecisionRulesPutRequest(),
    });
    // TODO: Handle 'response' of type DecisionRulesResponseResult
}
catch (ApiException<PutDecisionRulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutDecisionRulesIdRequest](Requests/DecisionRules/PutDecisionRulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionRulesResponseResult](Models/DecisionRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutDecisionRulesIdError](Errors/PutDecisionRulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Decisions

> Source: [Decisions](Api/Decisions.cs)

<details>
<summary><code>Task&lt;DecisionsResponseResult&gt; DeleteDecisionsId(DeleteDecisionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Decision's resource, which represents the schedule and rules for a check done on Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Decisions.DeleteDecisionsId(new DeleteDecisionsIdRequest
    {
        Id = "t1_dcs_67ddb8ad653487caf88cc00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DecisionsResponseResult
}
catch (ApiException<DeleteDecisionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDecisionsIdRequest](Requests/Decisions/DeleteDecisionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionsResponseResult](Models/DecisionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteDecisionsIdError](Errors/DeleteDecisionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionsResponseResult&gt; GetDecisions(GetDecisionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Decision's resource. A decisions resource represents the schedule and rules for a check done on Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Decisions.GetDecisions(new GetDecisionsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type DecisionsResponseResult
}
catch (ApiException<GetDecisionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDecisionsRequest](Requests/Decisions/GetDecisionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionsResponseResult](Models/DecisionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDecisionsError](Errors/GetDecisionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionsResponseResult&gt; GetDecisionsId(GetDecisionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Decision's resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Decisions.GetDecisionsId(new GetDecisionsIdRequest
    {
        Id = "t1_dcs_67ddb8ad653487caf88cc00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DecisionsResponseResult
}
catch (ApiException<GetDecisionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDecisionsIdRequest](Requests/Decisions/GetDecisionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionsResponseResult](Models/DecisionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDecisionsIdError](Errors/GetDecisionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionsResponseResult&gt; PostDecisions(PostDecisionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Decisions resource that represents the schedule and rules for a check done on Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Decisions.PostDecisions(new PostDecisionsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new DecisionsPostRequest
        {
            Login = "some example string",
            Application = DecisionActionsApplication1.Account,
            Level = "some example string",
            Type = DecisionType1.MerchantFailureLimit,
            Target = DecisionsTarget1.Activation,
            Action = DescisionAction1.Value0,
            Value = "some example string",
            Period = DecisionsPeriod1.Days,
            PeriodFactor = 1,
            ScheduleFactor = 1,
            Start = 1,
        },
    });
    // TODO: Handle 'response' of type DecisionsResponseResult
}
catch (ApiException<PostDecisionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostDecisionsRequest](Requests/Decisions/PostDecisionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionsResponseResult](Models/DecisionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostDecisionsError](Errors/PostDecisionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DecisionsResponseResult&gt; PutDecisionsId(PutDecisionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Decisions resource, which represents the schedule and rules for a check done on Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Decisions.PutDecisionsId(new PutDecisionsIdRequest
    {
        Id = "t1_dcs_67ddb8ad653487caf88cc00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new DecisionsPutRequest(),
    });
    // TODO: Handle 'response' of type DecisionsResponseResult
}
catch (ApiException<PutDecisionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutDecisionsIdRequest](Requests/Decisions/PutDecisionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DecisionsResponseResult](Models/DecisionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutDecisionsIdError](Errors/PutDecisionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DisbursementEntries

> Source: [DisbursementEntries](Api/DisbursementEntries.cs)

<details>
<summary><code>Task&lt;DisbursementEntriesResponseResult&gt; GetDisbursementEntries(GetDisbursementEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query DisbursementEntries to get records of where each disbursement amount is coming from.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisbursementEntries.GetDisbursementEntries(new GetDisbursementEntriesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type DisbursementEntriesResponseResult
}
catch (ApiException<GetDisbursementEntriesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisbursementEntriesRequest](Requests/DisbursementEntries/GetDisbursementEntriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisbursementEntriesResponseResult](Models/DisbursementEntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDisbursementEntriesError](Errors/GetDisbursementEntriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisbursementEntriesResponseResult&gt; GetDisbursementEntriesId(GetDisbursementEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Disbursement Entry that is a record of where a disbursement amount is coming from.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisbursementEntries.GetDisbursementEntriesId(new GetDisbursementEntriesIdRequest
    {
        Id = "t1_dbe_672ebb36f08a2a1a6ecfdce",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DisbursementEntriesResponseResult
}
catch (ApiException<GetDisbursementEntriesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisbursementEntriesIdRequest](Requests/DisbursementEntries/GetDisbursementEntriesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisbursementEntriesResponseResult](Models/DisbursementEntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDisbursementEntriesIdError](Errors/GetDisbursementEntriesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DisbursementResults

> Source: [DisbursementResults](Api/DisbursementResults.cs)

<details>
<summary><code>Task&lt;DisbursementResultsResponseResult&gt; GetDisbursementResults(GetDisbursementResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Disbursement Result resources, each of which represents a reference code issued by the Payout facilitator when a Disbursement is paid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisbursementResults.GetDisbursementResults(new GetDisbursementResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type DisbursementResultsResponseResult
}
catch (ApiException<GetDisbursementResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisbursementResultsRequest](Requests/DisbursementResults/GetDisbursementResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisbursementResultsResponseResult](Models/DisbursementResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDisbursementResultsError](Errors/GetDisbursementResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisbursementResultsResponseResult&gt; GetDisbursementResultsId(GetDisbursementResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Disbursement Result resource, representing a reference code issued by the Payout facilitator when a Disbursement is paid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DisbursementResults.GetDisbursementResultsId(new GetDisbursementResultsIdRequest
    {
        Id = "t1_drt_33c4e7a864c7e9d52e00000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DisbursementResultsResponseResult
}
catch (ApiException<GetDisbursementResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisbursementResultsIdRequest](Requests/DisbursementResults/GetDisbursementResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisbursementResultsResponseResult](Models/DisbursementResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDisbursementResultsIdError](Errors/GetDisbursementResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Disbursements

> Source: [Disbursements](Api/Disbursements.cs)

<details>
<summary><code>Task&lt;DisbursementsResponseResult&gt; GetDisbursements(GetDisbursementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Disbursements, each of which represents a record of an occasion where money is either paid to a bank account or received from a bank account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disbursements.GetDisbursements(new GetDisbursementsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type DisbursementsResponseResult
}
catch (ApiException<GetDisbursementsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisbursementsRequest](Requests/Disbursements/GetDisbursementsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisbursementsResponseResult](Models/DisbursementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDisbursementsError](Errors/GetDisbursementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisbursementsResponseResult&gt; GetDisbursementsId(GetDisbursementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Disbursement, which represents a record of an occasion where money is either paid to a bank account or received from a bank account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disbursements.GetDisbursementsId(new GetDisbursementsIdRequest
    {
        Id = "t1_dbm_67b7b9b69fca00a9685674f",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type DisbursementsResponseResult
}
catch (ApiException<GetDisbursementsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDisbursementsIdRequest](Requests/Disbursements/GetDisbursementsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisbursementsResponseResult](Models/DisbursementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetDisbursementsIdError](Errors/GetDisbursementsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EmbeddedFinance

> Source: [EmbeddedFinance](Api/EmbeddedFinance.cs)

<details>
<summary><code>Task&lt;EmbeddedFinanceResponseResult&gt; GetEmbeddedFinance(GetEmbeddedFinanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query embeddedFinance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbeddedFinance.GetEmbeddedFinance(new GetEmbeddedFinanceRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EmbeddedFinanceResponseResult
}
catch (ApiException<GetEmbeddedFinanceError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEmbeddedFinanceRequest](Requests/EmbeddedFinance/GetEmbeddedFinanceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmbeddedFinanceResponseResult](Models/EmbeddedFinanceResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEmbeddedFinanceError](Errors/GetEmbeddedFinanceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EmbeddedFinanceResponseResult&gt; GetEmbeddedFinanceId(GetEmbeddedFinanceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a embeddedFinance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbeddedFinance.GetEmbeddedFinanceId(new GetEmbeddedFinanceIdRequest
    {
        Id = "t1_efe_685d2955cc86da261b3bd00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EmbeddedFinanceResponseResult
}
catch (ApiException<GetEmbeddedFinanceIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEmbeddedFinanceIdRequest](Requests/EmbeddedFinance/GetEmbeddedFinanceIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmbeddedFinanceResponseResult](Models/EmbeddedFinanceResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEmbeddedFinanceIdError](Errors/GetEmbeddedFinanceIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Entities

> Source: [Entities](Api/Entities.cs)

<details>
<summary><code>Task&lt;EntitiesResponseResult&gt; DeleteEntitiesId(DeleteEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Entity, which is the top-level resource of a business in the API and describes the details of that business in its fields, including a Merchant, a Partner, or a Facilitator (payment facilitator).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.DeleteEntitiesId(new DeleteEntitiesIdRequest
    {
        Id = "t1_ent_6733015a977c2cdd6277d89",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntitiesResponseResult
}
catch (ApiException<DeleteEntitiesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteEntitiesIdRequest](Requests/Entities/DeleteEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntitiesResponseResult](Models/EntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteEntitiesIdError](Errors/DeleteEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntitiesResponseResult&gt; GetEntities(GetEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query entities. An Entity is the top-level resource of a business in the API, describing the details of that business in its fields. Each entity can describe a Merchant, a Partner, or a Facilitator (payment facilitator).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.GetEntities(new GetEntitiesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntitiesResponseResult
}
catch (ApiException<GetEntitiesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntitiesRequest](Requests/Entities/GetEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntitiesResponseResult](Models/EntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntitiesError](Errors/GetEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntitiesResponseResult&gt; GetEntitiesId(GetEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Entity, which is the top-level resource of a business in the API and describes the details of that business in its fields. An Entity can describe a Merchant, a Partner, or a Facilitator (payment facilitator).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.GetEntitiesId(new GetEntitiesIdRequest
    {
        Id = "t1_ent_6733015a977c2cdd6277d89",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntitiesResponseResult
}
catch (ApiException<GetEntitiesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntitiesIdRequest](Requests/Entities/GetEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntitiesResponseResult](Models/EntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntitiesIdError](Errors/GetEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityNextPayoutResponseResult&gt; GetEntitiesIdNextPayout(GetEntitiesIdNextPayoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the next Payout that is scheduled to process for an Entity, including the date it is due, the amount, and the last 4 digits of the account it is paid to.

If the Entity has no upcoming Payout, the API still returns a 200 response. In that case the response contains an entry in the 'errors' array and no 'data' array.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.GetEntitiesIdNextPayout(new GetEntitiesIdNextPayoutRequest
    {
        Id = "t1_ent_6733015a977c2cdd6277d89",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntityNextPayoutResponseResult
}
catch (ApiException<GetEntitiesIdNextPayoutError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntitiesIdNextPayoutRequest](Requests/Entities/GetEntitiesIdNextPayoutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityNextPayoutResponseResult](Models/EntityNextPayoutResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntitiesIdNextPayoutError](Errors/GetEntitiesIdNextPayoutError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntitiesResponseResult&gt; PostEntities(PostEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Entity, the top-level resource of a business in the API, describing its details through fields. An entity can represent a Merchant, a Partner, or a Facilitator (payment facilitator).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.PostEntities(new PostEntitiesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new EntitiesPostRequest
        {
            ClientIp = "some example string",
            Type = EntityType1.Value0,
            Name = "some example string",
            Address1 = "some example string",
            City = "some example string",
            State = "some example string",
            Zip = "some example string",
            Country = EntityCountry1.Usa,
            Timezone = EntitiesTimezone1.Est,
            Phone = "some example string",
            Email = "some example string",
            Ein = "some example string",
            GlobalBusinessId = "some example string",
        },
    });
    // TODO: Handle 'response' of type EntitiesResponseResult
}
catch (ApiException<PostEntitiesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostEntitiesRequest](Requests/Entities/PostEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntitiesResponseResult](Models/EntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostEntitiesError](Errors/PostEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntitiesResponseResult&gt; PutEntitiesId(PutEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Entity, which is the top-level resource of a business in the API and describes the details of that business in its fields. An Entity can be a Merchant, a Partner, or a Facilitator (payment facilitator).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.PutEntitiesId(new PutEntitiesIdRequest
    {
        Id = "t1_ent_6733015a977c2cdd6277d89",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new EntitiesPutRequest(),
    });
    // TODO: Handle 'response' of type EntitiesResponseResult
}
catch (ApiException<PutEntitiesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutEntitiesIdRequest](Requests/Entities/PutEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntitiesResponseResult](Models/EntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutEntitiesIdError](Errors/PutEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EntitiesCustomFields

> Source: [EntitiesCustomFields](Api/EntitiesCustomFields.cs)

<details>
<summary><code>Task&lt;EntityCustomFieldsResponseResult&gt; DeleteEntityCustomFieldsId(DeleteEntityCustomFieldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Entity Custom Field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntitiesCustomFields.DeleteEntityCustomFieldsId(new DeleteEntityCustomFieldsIdRequest
    {
        Id = "t1_ecf_67d3ab7bc5e308c4815100z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntityCustomFieldsResponseResult
}
catch (ApiException<DeleteEntityCustomFieldsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteEntityCustomFieldsIdRequest](Requests/EntitiesCustomFields/DeleteEntityCustomFieldsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityCustomFieldsResponseResult](Models/EntityCustomFieldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteEntityCustomFieldsIdError](Errors/DeleteEntityCustomFieldsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityCustomFieldsResponseResult&gt; GetEntityCustomFields(GetEntityCustomFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Entity Custom Field. 
Custom Fields can be added to entities associated by the Entity Id. 
An Entity Id can have various fields associated to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntitiesCustomFields.GetEntityCustomFields(new GetEntityCustomFieldsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntityCustomFieldsResponseResult
}
catch (ApiException<GetEntityCustomFieldsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityCustomFieldsRequest](Requests/EntitiesCustomFields/GetEntityCustomFieldsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityCustomFieldsResponseResult](Models/EntityCustomFieldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityCustomFieldsError](Errors/GetEntityCustomFieldsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityCustomFieldsResponseResult&gt; GetEntityCustomFieldsId(GetEntityCustomFieldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Entity Custom Field. 
Custom Fields can be added to entities associated by the Entity Id. 
An Entity Id can have various fields associated to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntitiesCustomFields.GetEntityCustomFieldsId(new GetEntityCustomFieldsIdRequest
    {
        Id = "t1_ecf_67d3ab7bc5e308c4815100z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntityCustomFieldsResponseResult
}
catch (ApiException<GetEntityCustomFieldsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityCustomFieldsIdRequest](Requests/EntitiesCustomFields/GetEntityCustomFieldsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityCustomFieldsResponseResult](Models/EntityCustomFieldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityCustomFieldsIdError](Errors/GetEntityCustomFieldsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityCustomFieldsResponseResult&gt; PostEntityCustomFields(PostEntityCustomFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Entity Custom Field. Custom Fields can be added to entities associated by the Entity Id. An Entity Id can have various fields associated to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntitiesCustomFields.PostEntityCustomFields(new PostEntityCustomFieldsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new EntityCustomFieldsPostRequest(),
    });
    // TODO: Handle 'response' of type EntityCustomFieldsResponseResult
}
catch (ApiException<PostEntityCustomFieldsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostEntityCustomFieldsRequest](Requests/EntitiesCustomFields/PostEntityCustomFieldsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityCustomFieldsResponseResult](Models/EntityCustomFieldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostEntityCustomFieldsError](Errors/PostEntityCustomFieldsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityCustomFieldsResponseResult&gt; PutEntityCustomFieldsId(PutEntityCustomFieldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Entity Custom Field. 
Custom Fields can be added to entities associated by the Entity Id. 
An Entity Id can have various fields associated to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntitiesCustomFields.PutEntityCustomFieldsId(new PutEntityCustomFieldsIdRequest
    {
        Id = "t1_ecf_67d3ab7bc5e308c4815100z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new EntityCustomFieldsPutRequest(),
    });
    // TODO: Handle 'response' of type EntityCustomFieldsResponseResult
}
catch (ApiException<PutEntityCustomFieldsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutEntityCustomFieldsIdRequest](Requests/EntitiesCustomFields/PutEntityCustomFieldsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityCustomFieldsResponseResult](Models/EntityCustomFieldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutEntityCustomFieldsIdError](Errors/PutEntityCustomFieldsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EntityDebts

> Source: [EntityDebts](Api/EntityDebts.cs)

<details>
<summary><code>Task&lt;EntityDebtsResponseResult&gt; GetEntityDebts(GetEntityDebtsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an EntityDebt resource, which represents a record of a debt between entities or an entity and the System.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityDebts.GetEntityDebts(new GetEntityDebtsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntityDebtsResponseResult
}
catch (ApiException<GetEntityDebtsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityDebtsRequest](Requests/EntityDebts/GetEntityDebtsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityDebtsResponseResult](Models/EntityDebtsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityDebtsError](Errors/GetEntityDebtsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityDebtsResponseResult&gt; GetEntityDebtsId(GetEntityDebtsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an EntityDebt resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityDebts.GetEntityDebtsId(new GetEntityDebtsIdRequest
    {
        Id = "t1_edt_67e2f62ae3e7ce229c2526z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntityDebtsResponseResult
}
catch (ApiException<GetEntityDebtsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityDebtsIdRequest](Requests/EntityDebts/GetEntityDebtsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityDebtsResponseResult](Models/EntityDebtsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityDebtsIdError](Errors/GetEntityDebtsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EntityReturns

> Source: [EntityReturns](Api/EntityReturns.cs)

<details>
<summary><code>Task&lt;EntityReturnsResponseResult&gt; GetEntityReturns(GetEntityReturnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an EntityReturn represents an ACH transaction or disbursement that has been rejected. The EntityReturn will block ACH creations or send out related to its entity and payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityReturns.GetEntityReturns(new GetEntityReturnsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntityReturnsResponseResult
}
catch (ApiException<GetEntityReturnsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityReturnsRequest](Requests/EntityReturns/GetEntityReturnsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityReturnsResponseResult](Models/EntityReturnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityReturnsError](Errors/GetEntityReturnsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityReturnsResponseResult&gt; GetEntityReturnsId(GetEntityReturnsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an EntityReturn represents an ACH transaction or disbursement that has been rejected, which will block ACH creations or send out related to its entity and payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityReturns.GetEntityReturnsId(new GetEntityReturnsIdRequest
    {
        Id = "t1_ern_67c9b2996c2944b0ffc9090",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntityReturnsResponseResult
}
catch (ApiException<GetEntityReturnsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityReturnsIdRequest](Requests/EntityReturns/GetEntityReturnsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityReturnsResponseResult](Models/EntityReturnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityReturnsIdError](Errors/GetEntityReturnsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EntityTerms

> Source: [EntityTerms](Api/EntityTerms.cs)

<details>
<summary><code>Task&lt;EntityTermsResponseResult&gt; GetEntityTerms(GetEntityTermsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an entityTerms

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityTerms.GetEntityTerms(new GetEntityTermsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntityTermsResponseResult
}
catch (ApiException<GetEntityTermsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityTermsRequest](Requests/EntityTerms/GetEntityTermsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityTermsResponseResult](Models/EntityTermsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityTermsError](Errors/GetEntityTermsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityTermsResponseResult&gt; GetEntityTermsId(GetEntityTermsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an entityTerms.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityTerms.GetEntityTermsId(new GetEntityTermsIdRequest
    {
        Id = "t1_ett_6866623edadbe8685525ae1",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntityTermsResponseResult
}
catch (ApiException<GetEntityTermsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityTermsIdRequest](Requests/EntityTerms/GetEntityTermsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityTermsResponseResult](Models/EntityTermsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityTermsIdError](Errors/GetEntityTermsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityTermsResponseResult&gt; PostEntityTerms(PostEntityTermsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an entityTerms.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityTerms.PostEntityTerms(new PostEntityTermsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new EntityTermsPostRequest(),
    });
    // TODO: Handle 'response' of type EntityTermsResponseResult
}
catch (ApiException<PostEntityTermsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostEntityTermsRequest](Requests/EntityTerms/PostEntityTermsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityTermsResponseResult](Models/EntityTermsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostEntityTermsError](Errors/PostEntityTermsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EntityData

> Source: [EntityData](Api/EntityData.cs)

<details>
<summary><code>Task&lt;EntityDatasResponseResult&gt; GetEntityDatas(GetEntityDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an EntityDatas, which is the data related to an entity containing information about that entity such as the signature for the terms and conditions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityData.GetEntityDatas(new GetEntityDatasRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntityDatasResponseResult
}
catch (ApiException<GetEntityDatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityDatasRequest](Requests/EntityData/GetEntityDatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityDatasResponseResult](Models/EntityDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityDatasError](Errors/GetEntityDatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityDatasResponseResult&gt; GetEntityDatasId(GetEntityDatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an EntityDatas containing information about that entity, such as the signature for the terms and conditions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityData.GetEntityDatasId(new GetEntityDatasIdRequest
    {
        Id = "t1_eda_643d5b122a77297fd5f0000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntityDatasResponseResult
}
catch (ApiException<GetEntityDatasIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntityDatasIdRequest](Requests/EntityData/GetEntityDatasIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityDatasResponseResult](Models/EntityDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntityDatasIdError](Errors/GetEntityDatasIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntityDatasResponseResult&gt; PostEntityDatas(PostEntityDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an EntityDatas containing the data related to an entity, including information such as the signature for the terms and conditions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntityData.PostEntityDatas(new PostEntityDatasRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new EntityDataPostRequest { Entity = "some example string", TcAcceptSignature = "some example string" },
    });
    // TODO: Handle 'response' of type EntityDatasResponseResult
}
catch (ApiException<PostEntityDatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostEntityDatasRequest](Requests/EntityData/PostEntityDatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntityDatasResponseResult](Models/EntityDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostEntityDatasError](Errors/PostEntityDatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Entries

> Source: [Entries](Api/Entries.cs)

<details>
<summary><code>Task&lt;EntriesResponseResult&gt; GetEntries(GetEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Entry resource. An Entry resource represents a record of amounts moving in or out of the funds held by an Entity. This could be a time-based activity such as a weekly or monthly summary, or an event-based activity such as a Capture, a Payout, or a Fee. In the case of an event-based activity, the Entry contains references to the activity in the appropriate field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entries.GetEntries(new GetEntriesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntriesResponseResult
}
catch (ApiException<GetEntriesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntriesRequest](Requests/Entries/GetEntriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntriesResponseResult](Models/EntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntriesError](Errors/GetEntriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntriesResponseResult&gt; GetEntriesId(GetEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Entry resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entries.GetEntriesId(new GetEntriesIdRequest
    {
        Id = "t1_etr_00bec0c794be4453f0af5b0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntriesResponseResult
}
catch (ApiException<GetEntriesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntriesIdRequest](Requests/Entries/GetEntriesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntriesResponseResult](Models/EntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntriesIdError](Errors/GetEntriesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EntryOrigin

> Source: [EntryOrigin](Api/EntryOrigin.cs)

<details>
<summary><code>Task&lt;EntryOriginsResponseResult&gt; GetEntryOrigins(GetEntryOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query entryOrigins.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntryOrigin.GetEntryOrigins(new GetEntryOriginsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type EntryOriginsResponseResult
}
catch (ApiException<GetEntryOriginsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntryOriginsRequest](Requests/EntryOrigin/GetEntryOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntryOriginsResponseResult](Models/EntryOriginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntryOriginsError](Errors/GetEntryOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EntryOriginsResponseResult&gt; GetEntryOriginsId(GetEntryOriginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Entry Origin.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EntryOrigin.GetEntryOriginsId(new GetEntryOriginsIdRequest
    {
        Id = "t1_eon_67bf03038fd84a4437c37ez",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type EntryOriginsResponseResult
}
catch (ApiException<GetEntryOriginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEntryOriginsIdRequest](Requests/EntryOrigin/GetEntryOriginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EntryOriginsResponseResult](Models/EntryOriginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEntryOriginsIdError](Errors/GetEntryOriginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FraudSightEnablements

> Source: [FraudSightEnablements](Api/FraudSightEnablements.cs)

<details>
<summary><code>Task&lt;FraudSightEnablementsResponseResult&gt; GetFraudSightEnablements(GetFraudSightEnablementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve FraudSight Enablements.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FraudSightEnablements.GetFraudSightEnablements(new GetFraudSightEnablementsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type FraudSightEnablementsResponseResult
}
catch (ApiException<GetFraudSightEnablementsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFraudSightEnablementsRequest](Requests/FraudSightEnablements/GetFraudSightEnablementsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FraudSightEnablementsResponseResult](Models/FraudSightEnablementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFraudSightEnablementsError](Errors/GetFraudSightEnablementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FraudSightEnablementsResponseResult&gt; GetFraudSightEnablementsId(GetFraudSightEnablementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a fraudSightEnablements.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FraudSightEnablements.GetFraudSightEnablementsId(new GetFraudSightEnablementsIdRequest
    {
        Id = "t1_frs_67ea5cb2c4be3c25dbc1zz0",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type FraudSightEnablementsResponseResult
}
catch (ApiException<GetFraudSightEnablementsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFraudSightEnablementsIdRequest](Requests/FraudSightEnablements/GetFraudSightEnablementsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FraudSightEnablementsResponseResult](Models/FraudSightEnablementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFraudSightEnablementsIdError](Errors/GetFraudSightEnablementsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FraudSightResults

> Source: [FraudSightResults](Api/FraudSightResults.cs)

<details>
<summary><code>Task&lt;FraudSightResultsResponseResult&gt; GetFraudSightResults(GetFraudSightResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a fraudSightResults.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FraudSightResults.GetFraudSightResults(new GetFraudSightResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type FraudSightResultsResponseResult
}
catch (ApiException<GetFraudSightResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFraudSightResultsRequest](Requests/FraudSightResults/GetFraudSightResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FraudSightResultsResponseResult](Models/FraudSightResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFraudSightResultsError](Errors/GetFraudSightResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FraudSightResultsResponseResult&gt; GetFraudSightResultsId(GetFraudSightResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a fraudSightResults.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FraudSightResults.GetFraudSightResultsId(new GetFraudSightResultsIdRequest
    {
        Id = "t1_vfr_67ea5cb2c4be3c25dbc1zz0",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type FraudSightResultsResponseResult
}
catch (ApiException<GetFraudSightResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFraudSightResultsIdRequest](Requests/FraudSightResults/GetFraudSightResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FraudSightResultsResponseResult](Models/FraudSightResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFraudSightResultsIdError](Errors/GetFraudSightResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FundOrigins

> Source: [FundOrigins](Api/FundOrigins.cs)

<details>
<summary><code>Task&lt;FundOriginsResponseResult&gt; GetFundOrigins(GetFundOriginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query fundOrigins.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FundOrigins.GetFundOrigins(new GetFundOriginsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type FundOriginsResponseResult
}
catch (ApiException<GetFundOriginsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFundOriginsRequest](Requests/FundOrigins/GetFundOriginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FundOriginsResponseResult](Models/FundOriginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFundOriginsError](Errors/GetFundOriginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FundOriginsResponseResult&gt; GetFundOriginsId(GetFundOriginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Fund Origin.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FundOrigins.GetFundOriginsId(new GetFundOriginsIdRequest
    {
        Id = "t1_fon_67e54d049d19a73f57449b0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type FundOriginsResponseResult
}
catch (ApiException<GetFundOriginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFundOriginsIdRequest](Requests/FundOrigins/GetFundOriginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FundOriginsResponseResult](Models/FundOriginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFundOriginsIdError](Errors/GetFundOriginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Funds

> Source: [Funds](Api/Funds.cs)

<details>
<summary><code>Task&lt;FundsResponseResult&gt; GetFunds(GetFundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Fund that represents a sum of money held by an Entity, some of which can be marked as reserved or available.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Funds.GetFunds(new GetFundsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type FundsResponseResult
}
catch (ApiException<GetFundsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFundsRequest](Requests/Funds/GetFundsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FundsResponseResult](Models/FundsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFundsError](Errors/GetFundsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FundsResponseResult&gt; GetFundsId(GetFundsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Fund, which represents a sum of money held by an Entity, and some of the amount can be marked as reserved or available.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Funds.GetFundsId(new GetFundsIdRequest
    {
        Id = "t1_fun_00b1192141e3b78e110028b",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type FundsResponseResult
}
catch (ApiException<GetFundsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFundsIdRequest](Requests/Funds/GetFundsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FundsResponseResult](Models/FundsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFundsIdError](Errors/GetFundsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HostThemes

> Source: [HostThemes](Api/HostThemes.cs)

<details>
<summary><code>Task&lt;HostThemesResponseResult&gt; GetHostThemes(GetHostThemesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query all Host Themes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostThemes.GetHostThemes(new GetHostThemesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type HostThemesResponseResult
}
catch (ApiException<GetHostThemesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetHostThemesRequest](Requests/HostThemes/GetHostThemesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[HostThemesResponseResult](Models/HostThemesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetHostThemesError](Errors/GetHostThemesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;HostThemesResponseResult&gt; GetHostThemesId(GetHostThemesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Host Theme.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HostThemes.GetHostThemesId(new GetHostThemesIdRequest
    {
        Id = "t1_hth_0000fc11df8e4c00000e00c",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type HostThemesResponseResult
}
catch (ApiException<GetHostThemesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetHostThemesIdRequest](Requests/HostThemes/GetHostThemesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[HostThemesResponseResult](Models/HostThemesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetHostThemesIdError](Errors/GetHostThemesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## IpAddressLists

> Source: [IpAddressLists](Api/IpAddressLists.cs)

<details>
<summary><code>Task&lt;IplistsResponseResult&gt; DeleteIplistsId(DeleteIplistsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an IP lists resource that represents a list of IP addresses, stored as a range between the lowest and highest IP addresses that should be included.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IpAddressLists.DeleteIplistsId(new DeleteIplistsIdRequest
    {
        Id = "t1_ipl_67d42f7567ea0e8f1b43e0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type IplistsResponseResult
}
catch (ApiException<DeleteIplistsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteIplistsIdRequest](Requests/IpAddressLists/DeleteIplistsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IplistsResponseResult](Models/IplistsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteIplistsIdError](Errors/DeleteIplistsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IplistsResponseResult&gt; GetIplists(GetIplistsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an iplist resource representing a list of IP addresses stored as a range between the lowest and highest IP addresses that should be included, which you can use to whitelist or blacklist particular incoming IP addresses for a given Login.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IpAddressLists.GetIplists(new GetIplistsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type IplistsResponseResult
}
catch (ApiException<GetIplistsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetIplistsRequest](Requests/IpAddressLists/GetIplistsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IplistsResponseResult](Models/IplistsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetIplistsError](Errors/GetIplistsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IplistsResponseResult&gt; GetIplistsId(GetIplistsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an iplist resource that represents a list of IP addresses stored as a range between the lowest and highest IP addresses, which can be used to whitelist or blacklist particular incoming IP addresses for a given Login.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IpAddressLists.GetIplistsId(new GetIplistsIdRequest
    {
        Id = "t1_ipl_67d42f7567ea0e8f1b43e0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type IplistsResponseResult
}
catch (ApiException<GetIplistsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetIplistsIdRequest](Requests/IpAddressLists/GetIplistsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IplistsResponseResult](Models/IplistsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetIplistsIdError](Errors/GetIplistsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IplistsResponseResult&gt; PostIplists(PostIplistsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an iplists resource. An IP List represents a list of IP (Internet Protocol) addresses, stored as a range between the lowest and highest IP addresses that should be included. 
You can use an IP List to whitelist (allow) or blacklist (deny) particular incoming IP addresses for a given Login. If you set up a whitelist for a Login, then the only allowed IP addresses are those in the whitelist, minus any blacklisted IP addresses. If you do not set up a whitelist for a Login, then all IP addresses are allowed, except for those explicitly blacklisted. 
You can select whether to store IPv4 or IPv6 addresses in an IP list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IpAddressLists.PostIplists(new PostIplistsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new IplistsPostRequest { Login = "some example string", Start = "some example string" },
    });
    // TODO: Handle 'response' of type IplistsResponseResult
}
catch (ApiException<PostIplistsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostIplistsRequest](Requests/IpAddressLists/PostIplistsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IplistsResponseResult](Models/IplistsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostIplistsError](Errors/PostIplistsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IplistsResponseResult&gt; PutIplistsId(PutIplistsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

_CONFLICT Update an iplist resource that represents a list of IP addresses stored as a range between the lowest and highest IP addresses, which can be used to whitelist or blacklist particular incoming IP addresses for a given Login.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IpAddressLists.PutIplistsId(new PutIplistsIdRequest
    {
        Id = "t1_ipl_67d42f7567ea0e8f1b43e0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new IplistsPutRequest(),
    });
    // TODO: Handle 'response' of type IplistsResponseResult
}
catch (ApiException<PutIplistsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutIplistsIdRequest](Requests/IpAddressLists/PutIplistsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IplistsResponseResult](Models/IplistsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutIplistsIdError](Errors/PutIplistsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InvoiceItems

> Source: [InvoiceItems](Api/InvoiceItems.cs)

<details>
<summary><code>Task&lt;InvoiceItemsResponseResult&gt; DeleteInvoiceItemsId(DeleteInvoiceItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Invoice Item or a resource that stores line item details for an invoice.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceItems.DeleteInvoiceItemsId(new DeleteInvoiceItemsIdRequest
    {
        Id = "t1_ini_67a18bcde1a1b2ec3d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoiceItemsResponseResult
}
catch (ApiException<DeleteInvoiceItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteInvoiceItemsIdRequest](Requests/InvoiceItems/DeleteInvoiceItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceItemsResponseResult](Models/InvoiceItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteInvoiceItemsIdError](Errors/DeleteInvoiceItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceItemsResponseResult&gt; GetInvoiceItems(GetInvoiceItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Invoice Item. A Invoice Item is a resource that stores line item details for an invoice.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceItems.GetInvoiceItems(new GetInvoiceItemsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type InvoiceItemsResponseResult
}
catch (ApiException<GetInvoiceItemsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceItemsRequest](Requests/InvoiceItems/GetInvoiceItemsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceItemsResponseResult](Models/InvoiceItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceItemsError](Errors/GetInvoiceItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceItemsResponseResult&gt; GetInvoiceItemsId(GetInvoiceItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Invoice Item or query Invoice Items.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceItems.GetInvoiceItemsId(new GetInvoiceItemsIdRequest
    {
        Id = "t1_ini_67a18bcde1a1b2ec3d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoiceItemsResponseResult
}
catch (ApiException<GetInvoiceItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceItemsIdRequest](Requests/InvoiceItems/GetInvoiceItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceItemsResponseResult](Models/InvoiceItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceItemsIdError](Errors/GetInvoiceItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceItemsResponseResult&gt; PostInvoiceItems(PostInvoiceItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Invoice Item, a resource that stores line item details for an invoice.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceItems.PostInvoiceItems(new PostInvoiceItemsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoiceItemsPostRequest { Login = "some example string", Item = "some example string" },
    });
    // TODO: Handle 'response' of type InvoiceItemsResponseResult
}
catch (ApiException<PostInvoiceItemsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostInvoiceItemsRequest](Requests/InvoiceItems/PostInvoiceItemsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceItemsResponseResult](Models/InvoiceItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostInvoiceItemsError](Errors/PostInvoiceItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceItemsResponseResult&gt; PutInvoiceItemsId(PutInvoiceItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Invoice Item, A InvoiceItem is a resource that stores line item details for an invoice.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceItems.PutInvoiceItemsId(new PutInvoiceItemsIdRequest
    {
        Id = "t1_ini_67a18bcde1a1b2ec3d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoiceItemsPutRequest(),
    });
    // TODO: Handle 'response' of type InvoiceItemsResponseResult
}
catch (ApiException<PutInvoiceItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutInvoiceItemsIdRequest](Requests/InvoiceItems/PutInvoiceItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceItemsResponseResult](Models/InvoiceItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutInvoiceItemsIdError](Errors/PutInvoiceItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InvoiceLineItems

> Source: [InvoiceLineItems](Api/InvoiceLineItems.cs)

<details>
<summary><code>Task&lt;InvoiceLineItemsResponseResult&gt; DeleteInvoiceLineItemsId(DeleteInvoiceLineItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an InvoiceLineItem or Invoice Line Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceLineItems.DeleteInvoiceLineItemsId(new DeleteInvoiceLineItemsIdRequest
    {
        Id = "t1_ini_00a18bcde1a1b2ec1d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoiceLineItemsResponseResult
}
catch (ApiException<DeleteInvoiceLineItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteInvoiceLineItemsIdRequest](Requests/InvoiceLineItems/DeleteInvoiceLineItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceLineItemsResponseResult](Models/InvoiceLineItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteInvoiceLineItemsIdError](Errors/DeleteInvoiceLineItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceLineItemsResponseResult&gt; GetInvoiceLineItems(GetInvoiceLineItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an InvoiceLineItem. InvoiceLineItem is a resource that relates an invoice item with an invoice. It holds information such as quantity, and price each item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceLineItems.GetInvoiceLineItems(new GetInvoiceLineItemsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type InvoiceLineItemsResponseResult
}
catch (ApiException<GetInvoiceLineItemsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceLineItemsRequest](Requests/InvoiceLineItems/GetInvoiceLineItemsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceLineItemsResponseResult](Models/InvoiceLineItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceLineItemsError](Errors/GetInvoiceLineItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceLineItemsResponseResult&gt; GetInvoiceLineItemsId(GetInvoiceLineItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an InvoiceLineItem or Invoice Line Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceLineItems.GetInvoiceLineItemsId(new GetInvoiceLineItemsIdRequest
    {
        Id = "t1_ini_00a18bcde1a1b2ec1d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoiceLineItemsResponseResult
}
catch (ApiException<GetInvoiceLineItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceLineItemsIdRequest](Requests/InvoiceLineItems/GetInvoiceLineItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceLineItemsResponseResult](Models/InvoiceLineItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceLineItemsIdError](Errors/GetInvoiceLineItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceLineItemsResponseResult&gt; PostInvoiceLineItems(PostInvoiceLineItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an InvoiceLineItem or Invoice Line Item.InvoiceLineItem is a resource that relates an invoice item with an invoice. It holds information such as quantity, and price each item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceLineItems.PostInvoiceLineItems(new PostInvoiceLineItemsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoiceLineItemsPostRequest { Invoice = "some example string", InvoiceItem = "some example string" },
    });
    // TODO: Handle 'response' of type InvoiceLineItemsResponseResult
}
catch (ApiException<PostInvoiceLineItemsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostInvoiceLineItemsRequest](Requests/InvoiceLineItems/PostInvoiceLineItemsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceLineItemsResponseResult](Models/InvoiceLineItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostInvoiceLineItemsError](Errors/PostInvoiceLineItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceLineItemsResponseResult&gt; PutInvoiceLineItemsId(PutInvoiceLineItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an InvoiceLineItem or Invoice Line Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceLineItems.PutInvoiceLineItemsId(new PutInvoiceLineItemsIdRequest
    {
        Id = "t1_ini_00a18bcde1a1b2ec1d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoiceLineItemsPutRequest(),
    });
    // TODO: Handle 'response' of type InvoiceLineItemsResponseResult
}
catch (ApiException<PutInvoiceLineItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutInvoiceLineItemsIdRequest](Requests/InvoiceLineItems/PutInvoiceLineItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceLineItemsResponseResult](Models/InvoiceLineItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutInvoiceLineItemsIdError](Errors/PutInvoiceLineItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InvoiceParameters

> Source: [InvoiceParameters](Api/InvoiceParameters.cs)

<details>
<summary><code>Task&lt;InvoiceParametersResponseResult&gt; DeleteInvoiceParametersId(DeleteInvoiceParametersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Invoice Parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceParameters.DeleteInvoiceParametersId(new DeleteInvoiceParametersIdRequest
    {
        Id = "t1_inp_67e46c1f4245ca0a6398000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoiceParametersResponseResult
}
catch (ApiException<DeleteInvoiceParametersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteInvoiceParametersIdRequest](Requests/InvoiceParameters/DeleteInvoiceParametersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceParametersResponseResult](Models/InvoiceParametersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteInvoiceParametersIdError](Errors/DeleteInvoiceParametersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceParametersResponseResult&gt; GetInvoiceParameters(GetInvoiceParametersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an invoice parameter resource that holds a certain configuration used for creating an invoice, including dba, address, and api key.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceParameters.GetInvoiceParameters(new GetInvoiceParametersRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type InvoiceParametersResponseResult
}
catch (ApiException<GetInvoiceParametersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceParametersRequest](Requests/InvoiceParameters/GetInvoiceParametersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceParametersResponseResult](Models/InvoiceParametersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceParametersError](Errors/GetInvoiceParametersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceParametersResponseResult&gt; GetInvoiceParametersId(GetInvoiceParametersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an invoice parameter that holds a certain configuration used for creating an invoice such as dba, address, and apikey.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceParameters.GetInvoiceParametersId(new GetInvoiceParametersIdRequest
    {
        Id = "t1_inp_67e46c1f4245ca0a6398000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoiceParametersResponseResult
}
catch (ApiException<GetInvoiceParametersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceParametersIdRequest](Requests/InvoiceParameters/GetInvoiceParametersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceParametersResponseResult](Models/InvoiceParametersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceParametersIdError](Errors/GetInvoiceParametersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceParametersResponseResult&gt; PostInvoiceParameters(PostInvoiceParametersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Invoice Parameter that holds a certain configuration used for creating an invoice such as dba, address, and apikey.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceParameters.PostInvoiceParameters(new PostInvoiceParametersRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoiceParametersPostRequest
        {
            Login = "some example string",
            Type = InvoiceParameterType1.Apikey,
            Value = "some example string",
        },
    });
    // TODO: Handle 'response' of type InvoiceParametersResponseResult
}
catch (ApiException<PostInvoiceParametersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostInvoiceParametersRequest](Requests/InvoiceParameters/PostInvoiceParametersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceParametersResponseResult](Models/InvoiceParametersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostInvoiceParametersError](Errors/PostInvoiceParametersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceParametersResponseResult&gt; PutInvoiceParametersId(PutInvoiceParametersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an invoice parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceParameters.PutInvoiceParametersId(new PutInvoiceParametersIdRequest
    {
        Id = "t1_inp_67e46c1f4245ca0a6398000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoiceParametersPutRequest(),
    });
    // TODO: Handle 'response' of type InvoiceParametersResponseResult
}
catch (ApiException<PutInvoiceParametersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutInvoiceParametersIdRequest](Requests/InvoiceParameters/PutInvoiceParametersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceParametersResponseResult](Models/InvoiceParametersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutInvoiceParametersIdError](Errors/PutInvoiceParametersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InvoiceResults

> Source: [InvoiceResults](Api/InvoiceResults.cs)

<details>
<summary><code>Task&lt;InvoiceResultsResponseResult&gt; GetInvoiceResults(GetInvoiceResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query InvoiceResults resource that represents the result of an invoice processing. In other words, when the customer pays for an invoice it will then generate an invoice result.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceResults.GetInvoiceResults(new GetInvoiceResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type InvoiceResultsResponseResult
}
catch (ApiException<GetInvoiceResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceResultsRequest](Requests/InvoiceResults/GetInvoiceResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceResultsResponseResult](Models/InvoiceResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceResultsError](Errors/GetInvoiceResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceResultsResponseResult&gt; GetInvoiceResultsId(GetInvoiceResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an invoiceResults resource that represents the result of an invoice processing, which is generated when a customer pays for an invoice.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceResults.GetInvoiceResultsId(new GetInvoiceResultsIdRequest
    {
        Id = "t1_inr_00a18bcde1a1b2ec3d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoiceResultsResponseResult
}
catch (ApiException<GetInvoiceResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceResultsIdRequest](Requests/InvoiceResults/GetInvoiceResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceResultsResponseResult](Models/InvoiceResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoiceResultsIdError](Errors/GetInvoiceResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoiceResultsResponseResult&gt; PostInvoiceResults(PostInvoiceResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

create a invoiceResult.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceResults.PostInvoiceResults(new PostInvoiceResultsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoiceResultPostRequest { Invoice = "some example string" },
    });
    // TODO: Handle 'response' of type InvoiceResultsResponseResult
}
catch (ApiException<PostInvoiceResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostInvoiceResultsRequest](Requests/InvoiceResults/PostInvoiceResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoiceResultsResponseResult](Models/InvoiceResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostInvoiceResultsError](Errors/PostInvoiceResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Invoices

> Source: [Invoices](Api/Invoices.cs)

<details>
<summary><code>Task&lt;InvoicesResponseResult&gt; DeleteInvoicesId(DeleteInvoicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Invoice or use it for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.DeleteInvoicesId(new DeleteInvoicesIdRequest
    {
        Id = "t1_inv_00b3a1f7e418cd6e378d410",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoicesResponseResult
}
catch (ApiException<DeleteInvoicesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteInvoicesIdRequest](Requests/Invoices/DeleteInvoicesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicesResponseResult](Models/InvoicesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteInvoicesIdError](Errors/DeleteInvoicesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicesResponseResult&gt; GetInvoices(GetInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Invoice or query an Invoice. An Invoice resource is used for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.GetInvoices(new GetInvoicesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type InvoicesResponseResult
}
catch (ApiException<GetInvoicesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoicesRequest](Requests/Invoices/GetInvoicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicesResponseResult](Models/InvoicesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoicesError](Errors/GetInvoicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicesResponseResult&gt; GetInvoicesId(GetInvoicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Invoice or use it for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.GetInvoicesId(new GetInvoicesIdRequest
    {
        Id = "t1_inv_00b3a1f7e418cd6e378d410",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type InvoicesResponseResult
}
catch (ApiException<GetInvoicesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoicesIdRequest](Requests/Invoices/GetInvoicesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicesResponseResult](Models/InvoicesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetInvoicesIdError](Errors/GetInvoicesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicesResponseResult&gt; PostInvoices(PostInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Invoice, which is used for invoicing customers, emailing the invoice to them, allowing them to pay the invoice and tracking payments with invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.PostInvoices(new PostInvoicesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoicesPostRequest
        {
            Login = "some example string",
            Merchant = "some example string",
            Subscription = "some example string",
            Number = "some example string",
            Status = InvoiceStatus1.Pending,
        },
    });
    // TODO: Handle 'response' of type InvoicesResponseResult
}
catch (ApiException<PostInvoicesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostInvoicesRequest](Requests/Invoices/PostInvoicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicesResponseResult](Models/InvoicesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostInvoicesError](Errors/PostInvoicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicesResponseResult&gt; PutInvoicesId(PutInvoicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Invoice. An Invoice resource is used for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.PutInvoicesId(new PutInvoicesIdRequest
    {
        Id = "t1_inv_00b3a1f7e418cd6e378d410",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new InvoicesPutRequest(),
    });
    // TODO: Handle 'response' of type InvoicesResponseResult
}
catch (ApiException<PutInvoicesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutInvoicesIdRequest](Requests/Invoices/PutInvoicesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicesResponseResult](Models/InvoicesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutInvoicesIdError](Errors/PutInvoicesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Logins

> Source: [Logins](Api/Logins.cs)

<details>
<summary><code>Task&lt;LoginsResponseResult&gt; DeleteLoginsId(DeleteLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Login. A Login is a user of the API and has a unique username and password.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Logins.DeleteLoginsId(new DeleteLoginsIdRequest
    {
        Id = "t1_log_67c56806038bb4eb85a0000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type LoginsResponseResult
}
catch (ApiException<DeleteLoginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteLoginsIdRequest](Requests/Logins/DeleteLoginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsResponseResult](Models/LoginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteLoginsIdError](Errors/DeleteLoginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginsResponseResult&gt; GetLogins(GetLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Logins. Retrieves the list of all users details like name and email as well as management details like which partition and division the user belongs to. A Login represents the unique ID of the user making an API request. Each user has a unique username and password

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Logins.GetLogins(new GetLoginsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type LoginsResponseResult
}
catch (ApiException<GetLoginsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoginsRequest](Requests/Logins/GetLoginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsResponseResult](Models/LoginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoginsError](Errors/GetLoginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginsResponseResult&gt; GetLoginsId(GetLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Login. A Login is a user of the API and has a unique username and password.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Logins.GetLoginsId(new GetLoginsIdRequest
    {
        Id = "t1_log_67c56806038bb4eb85a0000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type LoginsResponseResult
}
catch (ApiException<GetLoginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoginsIdRequest](Requests/Logins/GetLoginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsResponseResult](Models/LoginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoginsIdError](Errors/GetLoginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginsResponseResult&gt; PostLogins(PostLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Login. A Login represents the unique ID of the user making an API request. Each user has a unique username and password.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Logins.PostLogins(new PostLoginsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new LoginsPostRequest
        {
            Username = "some example string",
            Password = "some example string",
            First = "some example string",
            Last = "some example string",
            Email = "some example string",
            MfaEnabled = LoginsMfaEnabled1.Value0,
        },
    });
    // TODO: Handle 'response' of type LoginsResponseResult
}
catch (ApiException<PostLoginsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostLoginsRequest](Requests/Logins/PostLoginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsResponseResult](Models/LoginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostLoginsError](Errors/PostLoginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginsResponseResult&gt; PutLoginsId(PutLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Login, which is a user of the API having a unique username and password.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Logins.PutLoginsId(new PutLoginsIdRequest
    {
        Id = "t1_log_67c56806038bb4eb85a0000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new LoginsPutRequest(),
    });
    // TODO: Handle 'response' of type LoginsResponseResult
}
catch (ApiException<PutLoginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutLoginsIdRequest](Requests/Logins/PutLoginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsResponseResult](Models/LoginsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutLoginsIdError](Errors/PutLoginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LoginsHelpers

> Source: [LoginsHelpers](Api/LoginsHelpers.cs)

<details>
<summary><code>Task&lt;LoginsHelpersResponseResult&gt; GetLoginsHelpers(GetLoginsHelpersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query loginsHelpers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LoginsHelpers.GetLoginsHelpers(new GetLoginsHelpersRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type LoginsHelpersResponseResult
}
catch (ApiException<GetLoginsHelpersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoginsHelpersRequest](Requests/LoginsHelpers/GetLoginsHelpersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsHelpersResponseResult](Models/LoginsHelpersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoginsHelpersError](Errors/GetLoginsHelpersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginsHelpersResponseResult&gt; GetLoginsHelpersId(GetLoginsHelpersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a loginsHelper.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LoginsHelpers.GetLoginsHelpersId(new GetLoginsHelpersIdRequest
    {
        Id = "t1_lgh_67ee09c7402cff94765db3c",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type LoginsHelpersResponseResult
}
catch (ApiException<GetLoginsHelpersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLoginsHelpersIdRequest](Requests/LoginsHelpers/GetLoginsHelpersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsHelpersResponseResult](Models/LoginsHelpersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLoginsHelpersIdError](Errors/GetLoginsHelpersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LoginsHelpersResponseResult&gt; PutLoginsHelpersId(PutLoginsHelpersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a loginsHelper.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LoginsHelpers.PutLoginsHelpersId(new PutLoginsHelpersIdRequest
    {
        Id = "t1_lgh_67ee09c7402cff94765db3c",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new LoginsHelpersPutRequest(),
    });
    // TODO: Handle 'response' of type LoginsHelpersResponseResult
}
catch (ApiException<PutLoginsHelpersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutLoginsHelpersIdRequest](Requests/LoginsHelpers/PutLoginsHelpersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LoginsHelpersResponseResult](Models/LoginsHelpersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutLoginsHelpersIdError](Errors/PutLoginsHelpersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Mappings

> Source: [Mappings](Api/Mappings.cs)

<details>
<summary><code>Task&lt;MappingsResponseResult&gt; DeleteMappingsId(DeleteMappingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Mapping. A Mapping represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mappings.DeleteMappingsId(new DeleteMappingsIdRequest
    {
        Id = "t1_map_63d6a1df609e000f10b00d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MappingsResponseResult
}
catch (ApiException<DeleteMappingsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMappingsIdRequest](Requests/Mappings/DeleteMappingsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MappingsResponseResult](Models/MappingsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteMappingsIdError](Errors/DeleteMappingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MappingsResponseResult&gt; GetMappings(GetMappingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Mapping resource. 
A Mapping resource represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings. 
For example, if your system uses a different format for output data that it will send to the API, then you can re-map the input fields for the API using a Mapping resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mappings.GetMappings(new GetMappingsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type MappingsResponseResult
}
catch (ApiException<GetMappingsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMappingsRequest](Requests/Mappings/GetMappingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MappingsResponseResult](Models/MappingsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMappingsError](Errors/GetMappingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MappingsResponseResult&gt; GetMappingsId(GetMappingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Mapping resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mappings.GetMappingsId(new GetMappingsIdRequest
    {
        Id = "t1_map_63d6a1df609e000f10b00d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MappingsResponseResult
}
catch (ApiException<GetMappingsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMappingsIdRequest](Requests/Mappings/GetMappingsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MappingsResponseResult](Models/MappingsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMappingsIdError](Errors/GetMappingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MappingsResponseResult&gt; PostMappings(PostMappingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Mapping resource. 
A Mapping resource represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings. 
For example, if your system uses a different format for output data that it will send to the API, then you can re-map the input fields for the API using a Mapping resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mappings.PostMappings(new PostMappingsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MappingsPostRequest { Login = "some example string" },
    });
    // TODO: Handle 'response' of type MappingsResponseResult
}
catch (ApiException<PostMappingsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMappingsRequest](Requests/Mappings/PostMappingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MappingsResponseResult](Models/MappingsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostMappingsError](Errors/PostMappingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MappingsResponseResult&gt; PutMappingsId(PutMappingsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Mapping. A Mapping represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings. For example, if your system uses a different format for output data that it will send to the API, then you can re-map the input fields for the API using a Mapping.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Mappings.PutMappingsId(new PutMappingsIdRequest
    {
        Id = "t1_map_63d6a1df609e000f10b00d0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MappingsPutRequest(),
    });
    // TODO: Handle 'response' of type MappingsResponseResult
}
catch (ApiException<PutMappingsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutMappingsIdRequest](Requests/Mappings/PutMappingsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MappingsResponseResult](Models/MappingsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutMappingsIdError](Errors/PutMappingsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Members

> Source: [Members](Api/Members.cs)

<details>
<summary><code>Task&lt;MembersResponseResult&gt; DeleteMembersId(DeleteMembersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Member. A Member is a person who is associated with a Merchant. One Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Members.DeleteMembersId(new DeleteMembersIdRequest
    {
        Id = "t1_mbr_67d0336c01048ea41c4382z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MembersResponseResult
}
catch (ApiException<DeleteMembersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMembersIdRequest](Requests/Members/DeleteMembersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MembersResponseResult](Models/MembersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteMembersIdError](Errors/DeleteMembersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MembersResponseResult&gt; GetMembers(GetMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Member, A Member being a person who is associated with a Merchant, and one Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Members.GetMembers(new GetMembersRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type MembersResponseResult
}
catch (ApiException<GetMembersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMembersRequest](Requests/Members/GetMembersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MembersResponseResult](Models/MembersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMembersError](Errors/GetMembersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MembersResponseResult&gt; GetMembersId(GetMembersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Member. A Member is a person who is associated with a Merchant; One Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Members.GetMembersId(new GetMembersIdRequest
    {
        Id = "t1_mbr_67d0336c01048ea41c4382z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MembersResponseResult
}
catch (ApiException<GetMembersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMembersIdRequest](Requests/Members/GetMembersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MembersResponseResult](Models/MembersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMembersIdError](Errors/GetMembersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MembersResponseResult&gt; PostMembers(PostMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Member. A Member is a person who is associated with a Merchant, and one Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Members.PostMembers(new PostMembersRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MembersPostRequest
        {
            Merchant = "some example string",
            First = "some example string",
            Last = "some example string",
            Dob = 1,
            Email = "some example string",
            Ownership = 1,
            Timezone = MembersTimezone1.Est,
        },
    });
    // TODO: Handle 'response' of type MembersResponseResult
}
catch (ApiException<PostMembersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMembersRequest](Requests/Members/PostMembersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MembersResponseResult](Models/MembersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostMembersError](Errors/PostMembersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MembersResponseResult&gt; PutMembersId(PutMembersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Member, A Member is a person who is associated with a Merchant, One Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Members.PutMembersId(new PutMembersIdRequest
    {
        Id = "t1_mbr_67d0336c01048ea41c4382z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MembersPutRequest(),
    });
    // TODO: Handle 'response' of type MembersResponseResult
}
catch (ApiException<PutMembersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutMembersIdRequest](Requests/Members/PutMembersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MembersResponseResult](Models/MembersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutMembersIdError](Errors/PutMembersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MerchantPlatformStatuses

> Source: [MerchantPlatformStatuses](Api/MerchantPlatformStatuses.cs)

<details>
<summary><code>Task&lt;MerchantPlatformStatusesResponseResult&gt; GetMerchantPlatformStatuses(GetMerchantPlatformStatusesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Merchant Platform Statuses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantPlatformStatuses.GetMerchantPlatformStatuses(
        new GetMerchantPlatformStatusesRequest
        {
            PageNumber = 1,
            PageLimit = 50,
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
            Search = "created[greater]=2025-01-01",
            Totals = "count[]=id",
        });
    // TODO: Handle 'response' of type MerchantPlatformStatusesResponseResult
}
catch (ApiException<GetMerchantPlatformStatusesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantPlatformStatusesRequest](Requests/MerchantPlatformStatuses/GetMerchantPlatformStatusesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantPlatformStatusesResponseResult](Models/MerchantPlatformStatusesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMerchantPlatformStatusesError](Errors/GetMerchantPlatformStatusesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MerchantPlatformStatusesResponseResult&gt; GetMerchantPlatformStatusesId(GetMerchantPlatformStatusesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a merchantPlatformStatuses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantPlatformStatuses.GetMerchantPlatformStatusesId(
        new GetMerchantPlatformStatusesIdRequest
        {
            Id = "t1_mps_6819e572f2251288844d0zz",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
        });
    // TODO: Handle 'response' of type MerchantPlatformStatusesResponseResult
}
catch (ApiException<GetMerchantPlatformStatusesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantPlatformStatusesIdRequest](Requests/MerchantPlatformStatuses/GetMerchantPlatformStatusesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantPlatformStatusesResponseResult](Models/MerchantPlatformStatusesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMerchantPlatformStatusesIdError](Errors/GetMerchantPlatformStatusesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MerchantResults

> Source: [MerchantResults](Api/MerchantResults.cs)

<details>
<summary><code>Task&lt;MerchantResultsResponseResult&gt; GetMerchantResults(GetMerchantResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Merchant Result. A Merchant Reusult is a result created after a boarding attempt, it will contain important information related to the boarding and attempt.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantResults.GetMerchantResults(new GetMerchantResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type MerchantResultsResponseResult
}
catch (ApiException<GetMerchantResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantResultsRequest](Requests/MerchantResults/GetMerchantResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantResultsResponseResult](Models/MerchantResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMerchantResultsError](Errors/GetMerchantResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MerchantResultsResponseResult&gt; GetMerchantResultsId(GetMerchantResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Merchant Result or Query Merchant Results.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantResults.GetMerchantResultsId(new GetMerchantResultsIdRequest
    {
        Id = "p1_mrt_680b3a1e5c07f4e2c1b4zzz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MerchantResultsResponseResult
}
catch (ApiException<GetMerchantResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantResultsIdRequest](Requests/MerchantResults/GetMerchantResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantResultsResponseResult](Models/MerchantResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMerchantResultsIdError](Errors/GetMerchantResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Merchants

> Source: [Merchants](Api/Merchants.cs)

<details>
<summary><code>Task&lt;MerchantsResponseResult&gt; GetMerchants(GetMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Merchant, an organization that processes credit card payments, each associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Merchants.GetMerchants(new GetMerchantsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type MerchantsResponseResult
}
catch (ApiException<GetMerchantsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsRequest](Requests/Merchants/GetMerchantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantsResponseResult](Models/MerchantsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMerchantsError](Errors/GetMerchantsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MerchantsResponseResult&gt; GetMerchantsId(GetMerchantsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Merchant, which is an organization that processes credit card payments and each is associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Merchants.GetMerchantsId(new GetMerchantsIdRequest
    {
        Id = "p1_mer_00c6b12d04ac280ed694323",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MerchantsResponseResult
}
catch (ApiException<GetMerchantsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMerchantsIdRequest](Requests/Merchants/GetMerchantsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantsResponseResult](Models/MerchantsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMerchantsIdError](Errors/GetMerchantsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MerchantsResponseResult&gt; PutMerchantsId(PutMerchantsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Merchant, A Merchant is an organization that processes credit card payments. Each Merchant is associated with an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Merchants.PutMerchantsId(new PutMerchantsIdRequest
    {
        Id = "p1_mer_00c6b12d04ac280ed694323",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MerchantsPutRequest(),
    });
    // TODO: Handle 'response' of type MerchantsResponseResult
}
catch (ApiException<PutMerchantsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutMerchantsIdRequest](Requests/Merchants/PutMerchantsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MerchantsResponseResult](Models/MerchantsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutMerchantsIdError](Errors/PutMerchantsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MessageThreads

> Source: [MessageThreads](Api/MessageThreads.cs)

<details>
<summary><code>Task&lt;MessageThreadsResponseResult&gt; GetMessageThreads(GetMessageThreadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Message Threads resource that represents the sender, receiver, and subject of the Messages resources

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MessageThreads.GetMessageThreads(new GetMessageThreadsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type MessageThreadsResponseResult
}
catch (ApiException<GetMessageThreadsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMessageThreadsRequest](Requests/MessageThreads/GetMessageThreadsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MessageThreadsResponseResult](Models/MessageThreadsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMessageThreadsError](Errors/GetMessageThreadsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MessageThreadsResponseResult&gt; GetMessageThreadsId(GetMessageThreadsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Message Thread that represents the sender, receiver, and subject of the Messages resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MessageThreads.GetMessageThreadsId(new GetMessageThreadsIdRequest
    {
        Id = "t1_mtd_67ef5bad402b6b61e701e0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MessageThreadsResponseResult
}
catch (ApiException<GetMessageThreadsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMessageThreadsIdRequest](Requests/MessageThreads/GetMessageThreadsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MessageThreadsResponseResult](Models/MessageThreadsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMessageThreadsIdError](Errors/GetMessageThreadsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MessageThreadsResponseResult&gt; PutMessageThreadsId(PutMessageThreadsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Message Thread that represents the sender, receiver, and subject of the Messages resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MessageThreads.PutMessageThreadsId(new PutMessageThreadsIdRequest
    {
        Id = "t1_mtd_67ef5bad402b6b61e701e0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MessageThreadsPutRequest(),
    });
    // TODO: Handle 'response' of type MessageThreadsResponseResult
}
catch (ApiException<PutMessageThreadsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutMessageThreadsIdRequest](Requests/MessageThreads/PutMessageThreadsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MessageThreadsResponseResult](Models/MessageThreadsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutMessageThreadsIdError](Errors/PutMessageThreadsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Messages

> Source: [Messages](Api/Messages.cs)

<details>
<summary><code>Task&lt;MessagesResponseResult&gt; GetMessages(GetMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Message or query a messages resource that represents a message for a messageThreads.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Messages.GetMessages(new GetMessagesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type MessagesResponseResult
}
catch (ApiException<GetMessagesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMessagesRequest](Requests/Messages/GetMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MessagesResponseResult](Models/MessagesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMessagesError](Errors/GetMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MessagesResponseResult&gt; GetMessagesId(GetMessagesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Message for a messageThreads.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Messages.GetMessagesId(new GetMessagesIdRequest
    {
        Id = "t1_mtd_10ca1fcf172a9ac47656a21",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type MessagesResponseResult
}
catch (ApiException<GetMessagesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMessagesIdRequest](Requests/Messages/GetMessagesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MessagesResponseResult](Models/MessagesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMessagesIdError](Errors/GetMessagesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MessagesPostResponseResult&gt; PostMessages(PostMessagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Messages resource, which represents a message for a messageThread.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Messages.PostMessages(new PostMessagesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MessagesPostRequest
        {
            MessageThread = "some example string",
            Read = MessagesRead1.Value0,
            Message = "some example string",
        },
    });
    // TODO: Handle 'response' of type MessagesPostResponseResult
}
catch (ApiException<PostMessagesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostMessagesRequest](Requests/Messages/PostMessagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MessagesPostResponseResult](Models/MessagesPostResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostMessagesError](Errors/PostMessagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MessagesResponseResult&gt; PutMessagesId(PutMessagesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a messages or Message resource, which represents a message for a messageThread.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Messages.PutMessagesId(new PutMessagesIdRequest
    {
        Id = "t1_mtd_10ca1fcf172a9ac47656a21",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new MessagesPutRequest(),
    });
    // TODO: Handle 'response' of type MessagesResponseResult
}
catch (ApiException<PutMessagesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutMessagesIdRequest](Requests/Messages/PutMessagesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MessagesResponseResult](Models/MessagesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutMessagesIdError](Errors/PutMessagesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## NoteDocuments

> Source: [NoteDocuments](Api/NoteDocuments.cs)

<details>
<summary><code>Task&lt;NoteDocumentsResponseResult&gt; DeleteNoteDocumentsId(DeleteNoteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Note Document, which represents a file related to a specific note record.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NoteDocuments.DeleteNoteDocumentsId(new DeleteNoteDocumentsIdRequest
    {
        Id = "t1_ntd_67eef7a7ac0627e1fce0000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type NoteDocumentsResponseResult
}
catch (ApiException<DeleteNoteDocumentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteNoteDocumentsIdRequest](Requests/NoteDocuments/DeleteNoteDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NoteDocumentsResponseResult](Models/NoteDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteNoteDocumentsIdError](Errors/DeleteNoteDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NoteDocumentsResponseResult&gt; GetNoteDocuments(GetNoteDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Note Document, which represents a file that is related to a specific note record and documents resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NoteDocuments.GetNoteDocuments(new GetNoteDocumentsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type NoteDocumentsResponseResult
}
catch (ApiException<GetNoteDocumentsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNoteDocumentsRequest](Requests/NoteDocuments/GetNoteDocumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NoteDocumentsResponseResult](Models/NoteDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNoteDocumentsError](Errors/GetNoteDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NoteDocumentsResponseResult&gt; GetNoteDocumentsId(GetNoteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Note Document that represents a file that is related to a specific note record.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NoteDocuments.GetNoteDocumentsId(new GetNoteDocumentsIdRequest
    {
        Id = "t1_ntd_67eef7a7ac0627e1fce0000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type NoteDocumentsResponseResult
}
catch (ApiException<GetNoteDocumentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNoteDocumentsIdRequest](Requests/NoteDocuments/GetNoteDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NoteDocumentsResponseResult](Models/NoteDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNoteDocumentsIdError](Errors/GetNoteDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NoteDocumentsResponseResult&gt; PostNoteDocuments(PostNoteDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a note document, representing a file related to a specific note record.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NoteDocuments.PostNoteDocuments(new PostNoteDocumentsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new NoteDocumentsPostRequest { Note = "some example string" },
    });
    // TODO: Handle 'response' of type NoteDocumentsResponseResult
}
catch (ApiException<PostNoteDocumentsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostNoteDocumentsRequest](Requests/NoteDocuments/PostNoteDocumentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NoteDocumentsResponseResult](Models/NoteDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostNoteDocumentsError](Errors/PostNoteDocumentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NoteDocumentsResponseResult&gt; PutNoteDocumentsId(PutNoteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a note document, which represents a file related to a specific note record.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NoteDocuments.PutNoteDocumentsId(new PutNoteDocumentsIdRequest
    {
        Id = "t1_ntd_67eef7a7ac0627e1fce0000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new NoteDocumentsPutRequest(),
    });
    // TODO: Handle 'response' of type NoteDocumentsResponseResult
}
catch (ApiException<PutNoteDocumentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutNoteDocumentsIdRequest](Requests/NoteDocuments/PutNoteDocumentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NoteDocumentsResponseResult](Models/NoteDocumentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutNoteDocumentsIdError](Errors/PutNoteDocumentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Notes

> Source: [Notes](Api/Notes.cs)

<details>
<summary><code>Task&lt;NotesResponseResult&gt; DeleteNotesId(DeleteNotesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Note.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notes.DeleteNotesId(new DeleteNotesIdRequest
    {
        Id = "p1_not_00c7145c4daae43427e0d91",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type NotesResponseResult
}
catch (ApiException<DeleteNotesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteNotesIdRequest](Requests/Notes/DeleteNotesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotesResponseResult](Models/NotesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteNotesIdError](Errors/DeleteNotesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotesResponseResult&gt; GetNotes(GetNotesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Notes resource that represents risk management notes, reviews, and releases for a Hold, Txn, and Entity specific data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notes.GetNotes(new GetNotesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type NotesResponseResult
}
catch (ApiException<GetNotesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNotesRequest](Requests/Notes/GetNotesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotesResponseResult](Models/NotesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNotesError](Errors/GetNotesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotesResponseResult&gt; GetNotesId(GetNotesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Notes resource that represents risk management notes, reviews, and releases for a Hold, Txn, and Entity specific data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notes.GetNotesId(new GetNotesIdRequest
    {
        Id = "p1_not_00c7145c4daae43427e0d91",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type NotesResponseResult
}
catch (ApiException<GetNotesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetNotesIdRequest](Requests/Notes/GetNotesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotesResponseResult](Models/NotesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetNotesIdError](Errors/GetNotesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotesResponseResult&gt; PostNotes(PostNotesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Notes resource that represents risk management notes, reviews, and releases for a Hold, Txn, and Entity-specific data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notes.PostNotes(new PostNotesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new NotesPostRequest { Type = NoteType1.Note },
    });
    // TODO: Handle 'response' of type NotesResponseResult
}
catch (ApiException<PostNotesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostNotesRequest](Requests/Notes/PostNotesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotesResponseResult](Models/NotesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostNotesError](Errors/PostNotesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NotesResponseResult&gt; PutNotesId(PutNotesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Note.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Notes.PutNotesId(new PutNotesIdRequest
    {
        Id = "p1_not_00c7145c4daae43427e0d91",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new NotesPutRequest(),
    });
    // TODO: Handle 'response' of type NotesResponseResult
}
catch (ApiException<PutNotesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutNotesIdRequest](Requests/Notes/PutNotesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NotesResponseResult](Models/NotesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutNotesIdError](Errors/PutNotesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OmniTokens

> Source: [OmniTokens](Api/OmniTokens.cs)

<details>
<summary><code>Task&lt;OmniTokensResponseResult&gt; GetOmniTokens(GetOmniTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a omniTokens.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OmniTokens.GetOmniTokens(new GetOmniTokensRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type OmniTokensResponseResult
}
catch (ApiException<GetOmniTokensError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOmniTokensRequest](Requests/OmniTokens/GetOmniTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OmniTokensResponseResult](Models/OmniTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOmniTokensError](Errors/GetOmniTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OmniTokensResponseResult&gt; GetOmniTokensId(GetOmniTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a omniToken.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OmniTokens.GetOmniTokensId(new GetOmniTokensIdRequest
    {
        Id = "t1_otk_6809db98230a5b02b08f00z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
    });
    // TODO: Handle 'response' of type OmniTokensResponseResult
}
catch (ApiException<GetOmniTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOmniTokensIdRequest](Requests/OmniTokens/GetOmniTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OmniTokensResponseResult](Models/OmniTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOmniTokensIdError](Errors/GetOmniTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OptOuts

> Source: [OptOuts](Api/OptOuts.cs)

<details>
<summary><code>Task&lt;VasOptOutResponseResult&gt; PostOptouts(PostOptoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable a merchant or entity from a specific Value Added Service (VAS). This endpoint allows you to opt out a merchant or entity from participating in available VAS features.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OptOuts.PostOptouts(new PostOptoutsRequest
    {
        Service = VasOptOutService1.FraudSight,
        Target = VasOptOutTargetType1.Merchant,
        TargetId = "p1_mer_00c66ace58ad2d376bb0067",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new VasOptOutPostRequestModel(),
    });
    // TODO: Handle 'response' of type VasOptOutResponseResult
}
catch (ApiException<PostOptoutsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOptoutsRequest](Requests/OptOuts/PostOptoutsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VasOptOutResponseResult](Models/VasOptOutResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostOptoutsError](Errors/PostOptoutsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OrgEntities

> Source: [OrgEntities](Api/OrgEntities.cs)

<details>
<summary><code>Task&lt;OrgEntitiesResponseResult&gt; DeleteOrgEntitiesId(DeleteOrgEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Org Entity. An orgEntity is a record of an association between a particular Org and a particular Entity. One Org can contain and be associated with many Entities.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgEntities.DeleteOrgEntitiesId(new DeleteOrgEntitiesIdRequest
    {
        Id = "p1_oet_61c9a3e852a54260ebb505b",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type OrgEntitiesResponseResult
}
catch (ApiException<DeleteOrgEntitiesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOrgEntitiesIdRequest](Requests/OrgEntities/DeleteOrgEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgEntitiesResponseResult](Models/OrgEntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteOrgEntitiesIdError](Errors/DeleteOrgEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgEntitiesResponseResult&gt; GetOrgEntities(GetOrgEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an orgEntity. 
An orgEntity is a record of an association between a particular Org and a particular Entity. 
You can associate Entities with an Org by creating orgEntity resources. One Org can contain and be associated with many Entities.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgEntities.GetOrgEntities(new GetOrgEntitiesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type OrgEntitiesResponseResult
}
catch (ApiException<GetOrgEntitiesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgEntitiesRequest](Requests/OrgEntities/GetOrgEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgEntitiesResponseResult](Models/OrgEntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgEntitiesError](Errors/GetOrgEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgEntitiesResponseResult&gt; GetOrgEntitiesId(GetOrgEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an orgEntity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgEntities.GetOrgEntitiesId(new GetOrgEntitiesIdRequest
    {
        Id = "p1_oet_61c9a3e852a54260ebb505b",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type OrgEntitiesResponseResult
}
catch (ApiException<GetOrgEntitiesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgEntitiesIdRequest](Requests/OrgEntities/GetOrgEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgEntitiesResponseResult](Models/OrgEntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgEntitiesIdError](Errors/GetOrgEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgEntitiesResponseResult&gt; PostOrgEntities(PostOrgEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an orgEntity. 
An orgEntity is a record of an association between a particular Org and a particular Entity. 
You can associate Entities with an Org by creating orgEntity resources. One Org can contain and be associated with many Entities.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgEntities.PostOrgEntities(new PostOrgEntitiesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new OrgEntitiesPostRequest { Org = new OrgsPostRequest(), Entity = "some example string" },
    });
    // TODO: Handle 'response' of type OrgEntitiesResponseResult
}
catch (ApiException<PostOrgEntitiesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOrgEntitiesRequest](Requests/OrgEntities/PostOrgEntitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgEntitiesResponseResult](Models/OrgEntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostOrgEntitiesError](Errors/PostOrgEntitiesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgEntitiesResponseResult&gt; PutOrgEntitiesId(PutOrgEntitiesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an orgEntity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgEntities.PutOrgEntitiesId(new PutOrgEntitiesIdRequest
    {
        Id = "p1_oet_61c9a3e852a54260ebb505b",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new OrgEntitiesPutRequest { Org = "some example string", Entity = "some example string" },
    });
    // TODO: Handle 'response' of type OrgEntitiesResponseResult
}
catch (ApiException<PutOrgEntitiesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutOrgEntitiesIdRequest](Requests/OrgEntities/PutOrgEntitiesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgEntitiesResponseResult](Models/OrgEntitiesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutOrgEntitiesIdError](Errors/PutOrgEntitiesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OrgFlowRules

> Source: [OrgFlowRules](Api/OrgFlowRules.cs)

<details>
<summary><code>Task&lt;OrgFlowRulesResponseResult&gt; DeleteOrgFlowRulesId(DeleteOrgFlowRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Org Flow Rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgFlowRules.DeleteOrgFlowRulesId(new DeleteOrgFlowRulesIdRequest
    {
        Id = "t1_ofr_6810c6e4dad2480c7733b00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type OrgFlowRulesResponseResult
}
catch (ApiException<DeleteOrgFlowRulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOrgFlowRulesIdRequest](Requests/OrgFlowRules/DeleteOrgFlowRulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgFlowRulesResponseResult](Models/OrgFlowRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteOrgFlowRulesIdError](Errors/DeleteOrgFlowRulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgFlowRulesResponseResult&gt; GetOrgFlowRules(GetOrgFlowRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an orgFlowRules resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgFlowRules.GetOrgFlowRules(new GetOrgFlowRulesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type OrgFlowRulesResponseResult
}
catch (ApiException<GetOrgFlowRulesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgFlowRulesRequest](Requests/OrgFlowRules/GetOrgFlowRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgFlowRulesResponseResult](Models/OrgFlowRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgFlowRulesError](Errors/GetOrgFlowRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgFlowRulesResponseResult&gt; GetOrgFlowRulesId(GetOrgFlowRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Org Flow Rules resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgFlowRules.GetOrgFlowRulesId(new GetOrgFlowRulesIdRequest
    {
        Id = "t1_ofr_6810c6e4dad2480c7733b00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type OrgFlowRulesResponseResult
}
catch (ApiException<GetOrgFlowRulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgFlowRulesIdRequest](Requests/OrgFlowRules/GetOrgFlowRulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgFlowRulesResponseResult](Models/OrgFlowRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgFlowRulesIdError](Errors/GetOrgFlowRulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgFlowRulesResponseResult&gt; PostOrgFlowRules(PostOrgFlowRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Org Flow Rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgFlowRules.PostOrgFlowRules(new PostOrgFlowRulesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new OrgFlowRulesPostRequest(),
    });
    // TODO: Handle 'response' of type OrgFlowRulesResponseResult
}
catch (ApiException<PostOrgFlowRulesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOrgFlowRulesRequest](Requests/OrgFlowRules/PostOrgFlowRulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgFlowRulesResponseResult](Models/OrgFlowRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostOrgFlowRulesError](Errors/PostOrgFlowRulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgFlowRulesResponseResult&gt; PutOrgFlowRulesId(PutOrgFlowRulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Org Flow Rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgFlowRules.PutOrgFlowRulesId(new PutOrgFlowRulesIdRequest
    {
        Id = "t1_ofr_6810c6e4dad2480c7733b00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new OrgFlowRulesPutRequest(),
    });
    // TODO: Handle 'response' of type OrgFlowRulesResponseResult
}
catch (ApiException<PutOrgFlowRulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutOrgFlowRulesIdRequest](Requests/OrgFlowRules/PutOrgFlowRulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgFlowRulesResponseResult](Models/OrgFlowRulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutOrgFlowRulesIdError](Errors/PutOrgFlowRulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orgs

> Source: [Orgs](Api/Orgs.cs)

<details>
<summary><code>Task&lt;OrgsResponseResult&gt; DeleteOrgsId(DeleteOrgsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Organization, which is a collection of Entities that you can associate with it by creating organization-entity resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orgs.DeleteOrgsId(new DeleteOrgsIdRequest
    {
        Id = "t1_org_67cab1c56e1fd4f4c0a355z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type OrgsResponseResult
}
catch (ApiException<DeleteOrgsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOrgsIdRequest](Requests/Orgs/DeleteOrgsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgsResponseResult](Models/OrgsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteOrgsIdError](Errors/DeleteOrgsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgsResponseResult&gt; GetOrgs(GetOrgsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Org, which is a collection of Entities, To associate Entities with an Org use the [orgEntity](/api/payrix/org-entities/getOrgEntitiesId) endpoint. You will need the created Org ID when adding entities, such as a Merchant, to the Organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orgs.GetOrgs(new GetOrgsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type OrgsResponseResult
}
catch (ApiException<GetOrgsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgsRequest](Requests/Orgs/GetOrgsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgsResponseResult](Models/OrgsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgsError](Errors/GetOrgsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgsResponseResult&gt; GetOrgsId(GetOrgsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Org, which is a collection of Entities that you can associate with by creating orgEntity resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orgs.GetOrgsId(new GetOrgsIdRequest
    {
        Id = "t1_org_67cab1c56e1fd4f4c0a355z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type OrgsResponseResult
}
catch (ApiException<GetOrgsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgsIdRequest](Requests/Orgs/GetOrgsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgsResponseResult](Models/OrgsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgsIdError](Errors/GetOrgsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgsResponseResult&gt; PostOrgs(PostOrgsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Org which is a collection of Entities, To associate Entities with an Org use the [orgEntity](/api/payrix/org-entities/getOrgEntitiesId) endpoint. You will need the created Org ID when adding entities, such as a Merchant, to the Organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orgs.PostOrgs(new PostOrgsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new OrgsPostRequest(),
    });
    // TODO: Handle 'response' of type OrgsResponseResult
}
catch (ApiException<PostOrgsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOrgsRequest](Requests/Orgs/PostOrgsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgsResponseResult](Models/OrgsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostOrgsError](Errors/PostOrgsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgsResponseResult&gt; PutOrgsId(PutOrgsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Org, which is a collection of Entities that you can associate with other entities by creating orgEntity resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orgs.PutOrgsId(new PutOrgsIdRequest
    {
        Id = "t1_org_67cab1c56e1fd4f4c0a355z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new OrgsPutRequest(),
    });
    // TODO: Handle 'response' of type OrgsResponseResult
}
catch (ApiException<PutOrgsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutOrgsIdRequest](Requests/Orgs/PutOrgsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgsResponseResult](Models/OrgsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutOrgsIdError](Errors/PutOrgsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OrgsVasRevenueBoosts

> Source: [OrgsVasRevenueBoosts](Api/OrgsVasRevenueBoosts.cs)

<details>
<summary><code>Task&lt;OrgsVasRevenueBoostsResponseResult&gt; GetOrgsVasRevenueBoosts(GetOrgsVasRevenueBoostsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query all OrgsVasNetworkPaymentManager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgsVasRevenueBoosts.GetOrgsVasRevenueBoosts(new GetOrgsVasRevenueBoostsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type OrgsVasRevenueBoostsResponseResult
}
catch (ApiException<GetOrgsVasRevenueBoostsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgsVasRevenueBoostsRequest](Requests/OrgsVasRevenueBoosts/GetOrgsVasRevenueBoostsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgsVasRevenueBoostsResponseResult](Models/OrgsVasRevenueBoostsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgsVasRevenueBoostsError](Errors/GetOrgsVasRevenueBoostsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OrgsVasRevenueBoostsResponseResult&gt; GetOrgsVasRevenueBoostsId(GetOrgsVasRevenueBoostsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a OrgsVasNetworkPaymentManager. an Entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrgsVasRevenueBoosts.GetOrgsVasRevenueBoostsId(new GetOrgsVasRevenueBoostsIdRequest
    {
        Id = "t1_ovr_67a18bcde1a1b2ec3d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type OrgsVasRevenueBoostsResponseResult
}
catch (ApiException<GetOrgsVasRevenueBoostsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrgsVasRevenueBoostsIdRequest](Requests/OrgsVasRevenueBoosts/GetOrgsVasRevenueBoostsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrgsVasRevenueBoostsResponseResult](Models/OrgsVasRevenueBoostsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrgsVasRevenueBoostsIdError](Errors/GetOrgsVasRevenueBoostsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentUpdateGroups

> Source: [PaymentUpdateGroups](Api/PaymentUpdateGroups.cs)

<details>
<summary><code>Task&lt;PaymentUpdateGroupsResponseResult&gt; GetPaymentUpdateGroups(GetPaymentUpdateGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a PaymentUpdateGroup. 
A PaymentUpdateGroup has a collection of paymentUpdates owned by the merchant's entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentUpdateGroups.GetPaymentUpdateGroups(new GetPaymentUpdateGroupsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type PaymentUpdateGroupsResponseResult
}
catch (ApiException<GetPaymentUpdateGroupsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentUpdateGroupsRequest](Requests/PaymentUpdateGroups/GetPaymentUpdateGroupsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentUpdateGroupsResponseResult](Models/PaymentUpdateGroupsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPaymentUpdateGroupsError](Errors/GetPaymentUpdateGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentUpdateGroupsResponseResult&gt; GetPaymentUpdateGroupsId(GetPaymentUpdateGroupsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Payment Update Group that has a collection of payment updates owned by the merchant's entity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentUpdateGroups.GetPaymentUpdateGroupsId(new GetPaymentUpdateGroupsIdRequest
    {
        Id = "t1_pug_67c80c1f44bc3a7dcb1f000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type PaymentUpdateGroupsResponseResult
}
catch (ApiException<GetPaymentUpdateGroupsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentUpdateGroupsIdRequest](Requests/PaymentUpdateGroups/GetPaymentUpdateGroupsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentUpdateGroupsResponseResult](Models/PaymentUpdateGroupsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPaymentUpdateGroupsIdError](Errors/GetPaymentUpdateGroupsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentUpdates

> Source: [PaymentUpdates](Api/PaymentUpdates.cs)

<details>
<summary><code>Task&lt;PaymentUpdatesResponseResult&gt; GetPaymentUpdates(GetPaymentUpdatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a PaymentUpdate. 
A PaymentUpdate holds information about the payment update. The paymentUpdate will be related to a payment, subscriptionToken or account, and owned by a paymentUpdateGroup.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentUpdates.GetPaymentUpdates(new GetPaymentUpdatesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type PaymentUpdatesResponseResult
}
catch (ApiException<GetPaymentUpdatesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentUpdatesRequest](Requests/PaymentUpdates/GetPaymentUpdatesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentUpdatesResponseResult](Models/PaymentUpdatesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPaymentUpdatesError](Errors/GetPaymentUpdatesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentUpdatesResponseResult&gt; GetPaymentUpdatesId(GetPaymentUpdatesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

_CONFLICT Query a Payment Update that holds information about the payment update, related to a payment, subscriptionToken or account, and owned by a paymentUpdateGroup.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentUpdates.GetPaymentUpdatesId(new GetPaymentUpdatesIdRequest
    {
        Id = "t1_pmu_67c80c49a8274b15ad4dd0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type PaymentUpdatesResponseResult
}
catch (ApiException<GetPaymentUpdatesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentUpdatesIdRequest](Requests/PaymentUpdates/GetPaymentUpdatesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentUpdatesResponseResult](Models/PaymentUpdatesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPaymentUpdatesIdError](Errors/GetPaymentUpdatesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payouts

> Source: [Payouts](Api/Payouts.cs)

<details>
<summary><code>Task&lt;PayoutsResponseResult&gt; DeletePayoutsId(DeletePayoutsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited. These details include the schedule or trigger, the beneficiary account and the amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.DeletePayoutsId(new DeletePayoutsIdRequest
    {
        Id = "p1_pay_00ce7e77b58ffe7d31b250e",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type PayoutsResponseResult
}
catch (ApiException<DeletePayoutsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePayoutsIdRequest](Requests/Payouts/DeletePayoutsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutsResponseResult](Models/PayoutsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeletePayoutsIdError](Errors/DeletePayoutsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutsResponseResult&gt; GetPayouts(GetPayoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited. These details include the schedule or trigger, the beneficiary account and the amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.GetPayouts(new GetPayoutsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type PayoutsResponseResult
}
catch (ApiException<GetPayoutsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPayoutsRequest](Requests/Payouts/GetPayoutsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutsResponseResult](Models/PayoutsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPayoutsError](Errors/GetPayoutsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutsResponseResult&gt; GetPayoutsId(GetPayoutsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited; these details include the schedule or trigger, the beneficiary account and the amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.GetPayoutsId(new GetPayoutsIdRequest
    {
        Id = "p1_pay_00ce7e77b58ffe7d31b250e",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type PayoutsResponseResult
}
catch (ApiException<GetPayoutsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPayoutsIdRequest](Requests/Payouts/GetPayoutsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutsResponseResult](Models/PayoutsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPayoutsIdError](Errors/GetPayoutsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutsResponseResult&gt; PostPayouts(PostPayoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited; these details include the schedule or trigger, the beneficiary account and the amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.PostPayouts(new PostPayoutsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new PayoutPostRequest
        {
            Account = new Account5 { Entity = "some example string", Account = new Account4(), Currency = currency },
            Entity = "some example string",
            Schedule = PayoutSchedule1.Value1,
            Start = 1,
            Um = PayoutUm1.Value1,
            Amount = 1L,
            SkipOffDays = PayoutFlowsSkipOffDays1.Value0,
        },
    });
    // TODO: Handle 'response' of type PayoutsResponseResult
}
catch (ApiException<PostPayoutsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPayoutsRequest](Requests/Payouts/PostPayoutsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutsResponseResult](Models/PayoutsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostPayoutsError](Errors/PostPayoutsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayoutsResponseResult&gt; PutPayoutsId(PutPayoutsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited. These details include the schedule or trigger, the beneficiary account and the amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.PutPayoutsId(new PutPayoutsIdRequest
    {
        Id = "p1_pay_00ce7e77b58ffe7d31b250e",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new PayoutPutRequest(),
    });
    // TODO: Handle 'response' of type PayoutsResponseResult
}
catch (ApiException<PutPayoutsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutPayoutsIdRequest](Requests/Payouts/PutPayoutsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayoutsResponseResult](Models/PayoutsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutPayoutsIdError](Errors/PutPayoutsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PendingEntryApi

> Source: [PendingEntryApi](Api/PendingEntryApi.cs)

<details>
<summary><code>Task&lt;PendingEntriesResponseResult&gt; GetPendingEntries(GetPendingEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a PendingEntry resource. 
A PendingEntry resource represents a record of amounts moving in or out of the funds held by an Entity. 
For example, this could be a time-based activity such as a weekly or monthly summary, or an event-based activity such as a Capture, a Payout, or a Fee. In the case of an event-based activity, the PendingEntry contains references the activity in the appropriate field. Eventually the PendingEntry will trigger the creation of an Entry resource and its amount will reflect any unsourced amounts for the Entry.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PendingEntryApi.GetPendingEntries(new GetPendingEntriesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type PendingEntriesResponseResult
}
catch (ApiException<GetPendingEntriesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPendingEntriesRequest](Requests/PendingEntryApi/GetPendingEntriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PendingEntriesResponseResult](Models/PendingEntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPendingEntriesError](Errors/GetPendingEntriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PendingEntriesResponseResult&gt; GetPendingEntriesId(GetPendingEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Pending Entry resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PendingEntryApi.GetPendingEntriesId(new GetPendingEntriesIdRequest
    {
        Id = "t1_per_67f51ffc08643b7442a0c0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type PendingEntriesResponseResult
}
catch (ApiException<GetPendingEntriesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPendingEntriesIdRequest](Requests/PendingEntryApi/GetPendingEntriesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PendingEntriesResponseResult](Models/PendingEntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPendingEntriesIdError](Errors/GetPendingEntriesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PinlessDebitConversions

> Source: [PinlessDebitConversions](Api/PinlessDebitConversions.cs)

<details>
<summary><code>Task&lt;PinlessDebitConversionsResponseResult&gt; GetPinlessDebitConversions(GetPinlessDebitConversionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a pinlessDebitConversions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PinlessDebitConversions.GetPinlessDebitConversions(new GetPinlessDebitConversionsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type PinlessDebitConversionsResponseResult
}
catch (ApiException<GetPinlessDebitConversionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPinlessDebitConversionsRequest](Requests/PinlessDebitConversions/GetPinlessDebitConversionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinlessDebitConversionsResponseResult](Models/PinlessDebitConversionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPinlessDebitConversionsError](Errors/GetPinlessDebitConversionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PinlessDebitConversionsResponseResult&gt; GetPinlessDebitConversionsId(GetPinlessDebitConversionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a pinlessDebitConversion.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PinlessDebitConversions.GetPinlessDebitConversionsId(
        new GetPinlessDebitConversionsIdRequest
        {
            Id = "t1_pdc_684c7ec770b6d462c4cd000",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
        });
    // TODO: Handle 'response' of type PinlessDebitConversionsResponseResult
}
catch (ApiException<GetPinlessDebitConversionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPinlessDebitConversionsIdRequest](Requests/PinlessDebitConversions/GetPinlessDebitConversionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PinlessDebitConversionsResponseResult](Models/PinlessDebitConversionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPinlessDebitConversionsIdError](Errors/GetPinlessDebitConversionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Plans

> Source: [Plans](Api/Plans.cs)

<details>
<summary><code>Task&lt;PlansResponseResult&gt; DeletePlansId(DeletePlansIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, once created, allowing association with a Subscription and user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.DeletePlansId(new DeletePlansIdRequest
    {
        Id = "p1_pln_00bdbe193c3abe3b2243695",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type PlansResponseResult
}
catch (ApiException<DeletePlansIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePlansIdRequest](Requests/Plans/DeletePlansIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlansResponseResult](Models/PlansResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeletePlansIdError](Errors/DeletePlansIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlansResponseResult&gt; GetPlans(GetPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Plan. 
A Plan represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis. 
Once you create a Plan, you can associate a Subscription and user with it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.GetPlans(new GetPlansRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type PlansResponseResult
}
catch (ApiException<GetPlansError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPlansRequest](Requests/Plans/GetPlansRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlansResponseResult](Models/PlansResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPlansError](Errors/GetPlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlansResponseResult&gt; GetPlansId(GetPlansIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, once created, allowing association with a Subscription and user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.GetPlansId(new GetPlansIdRequest
    {
        Id = "p1_pln_00bdbe193c3abe3b2243695",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type PlansResponseResult
}
catch (ApiException<GetPlansIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPlansIdRequest](Requests/Plans/GetPlansIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlansResponseResult](Models/PlansResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPlansIdError](Errors/GetPlansIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlansResponseResult&gt; PostPlans(PostPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, which once created, allows you to associate a Subscription and user with it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.PostPlans(new PostPlansRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new PlansPostRequest { Amount = 1L, Merchant = "some example string", Schedule = PlanSchedule1.Value1 },
    });
    // TODO: Handle 'response' of type PlansResponseResult
}
catch (ApiException<PostPlansError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostPlansRequest](Requests/Plans/PostPlansRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlansResponseResult](Models/PlansResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostPlansError](Errors/PostPlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlansResponseResult&gt; PutPlansId(PutPlansIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, once created, allowing association with a Subscription and user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.PutPlansId(new PutPlansIdRequest
    {
        Id = "p1_pln_00bdbe193c3abe3b2243695",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new PlansPutRequest(),
    });
    // TODO: Handle 'response' of type PlansResponseResult
}
catch (ApiException<PutPlansIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutPlansIdRequest](Requests/Plans/PutPlansIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlansResponseResult](Models/PlansResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutPlansIdError](Errors/PutPlansIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ProfitShareResults

> Source: [ProfitShareResults](Api/ProfitShareResults.cs)

<details>
<summary><code>Task&lt;ProfitShareResultsResponseResult&gt; GetProfitShareResults(GetProfitShareResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a ProfitShareResult or Profit Share Result resource, which holds a message regarding a failed ProfitShare process.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProfitShareResults.GetProfitShareResults(new GetProfitShareResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ProfitShareResultsResponseResult
}
catch (ApiException<GetProfitShareResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetProfitShareResultsRequest](Requests/ProfitShareResults/GetProfitShareResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProfitShareResultsResponseResult](Models/ProfitShareResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetProfitShareResultsError](Errors/GetProfitShareResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProfitShareResultsResponseResult&gt; GetProfitShareResultsId(GetProfitShareResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a ProfitShareResult or Profit Share Result.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProfitShareResults.GetProfitShareResultsId(new GetProfitShareResultsIdRequest
    {
        Id = "t1_psr_655c21ba778461b81b98b00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ProfitShareResultsResponseResult
}
catch (ApiException<GetProfitShareResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetProfitShareResultsIdRequest](Requests/ProfitShareResults/GetProfitShareResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProfitShareResultsResponseResult](Models/ProfitShareResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetProfitShareResultsIdError](Errors/GetProfitShareResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RevShareSchedules

> Source: [RevShareSchedules](Api/RevShareSchedules.cs)

<details>
<summary><code>Task&lt;RevShareSchedulesResponseResult&gt; DeleteRevShareSchedulesId(DeleteRevShareSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a revShareSchedule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevShareSchedules.DeleteRevShareSchedulesId(new DeleteRevShareSchedulesIdRequest
    {
        Id = "t1_rsc_6800f8590a3fc6c0caed9zz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type RevShareSchedulesResponseResult
}
catch (ApiException<DeleteRevShareSchedulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteRevShareSchedulesIdRequest](Requests/RevShareSchedules/DeleteRevShareSchedulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevShareSchedulesResponseResult](Models/RevShareSchedulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteRevShareSchedulesIdError](Errors/DeleteRevShareSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevShareSchedulesResponseResult&gt; GetRevShareSchedules(GetRevShareSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query revShareSchedules.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevShareSchedules.GetRevShareSchedules(new GetRevShareSchedulesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type RevShareSchedulesResponseResult
}
catch (ApiException<GetRevShareSchedulesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRevShareSchedulesRequest](Requests/RevShareSchedules/GetRevShareSchedulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevShareSchedulesResponseResult](Models/RevShareSchedulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRevShareSchedulesError](Errors/GetRevShareSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevShareSchedulesResponseResult&gt; GetRevShareSchedulesId(GetRevShareSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a revShareSchedule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevShareSchedules.GetRevShareSchedulesId(new GetRevShareSchedulesIdRequest
    {
        Id = "t1_rsc_6800f8590a3fc6c0caed9zz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type RevShareSchedulesResponseResult
}
catch (ApiException<GetRevShareSchedulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRevShareSchedulesIdRequest](Requests/RevShareSchedules/GetRevShareSchedulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevShareSchedulesResponseResult](Models/RevShareSchedulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRevShareSchedulesIdError](Errors/GetRevShareSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevShareSchedulesResponseResult&gt; PostRevShareSchedules(PostRevShareSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a revShareSchedules.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevShareSchedules.PostRevShareSchedules(new PostRevShareSchedulesRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new RevShareSchedulesPostRequest
        {
            Entity = "some example string",
            Forentity = "some example string",
            Start = "some example string",
            Share = 1,
            Event = RevShareScheduleEvent1.Value1,
        },
    });
    // TODO: Handle 'response' of type RevShareSchedulesResponseResult
}
catch (ApiException<PostRevShareSchedulesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostRevShareSchedulesRequest](Requests/RevShareSchedules/PostRevShareSchedulesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevShareSchedulesResponseResult](Models/RevShareSchedulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostRevShareSchedulesError](Errors/PostRevShareSchedulesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevShareSchedulesResponseResult&gt; PutRevShareSchedulesId(PutRevShareSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a revShareSchedule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevShareSchedules.PutRevShareSchedulesId(new PutRevShareSchedulesIdRequest
    {
        Id = "t1_rsc_6800f8590a3fc6c0caed9zz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new RevShareSchedulesPutRequest(),
    });
    // TODO: Handle 'response' of type RevShareSchedulesResponseResult
}
catch (ApiException<PutRevShareSchedulesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutRevShareSchedulesIdRequest](Requests/RevShareSchedules/PutRevShareSchedulesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevShareSchedulesResponseResult](Models/RevShareSchedulesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutRevShareSchedulesIdError](Errors/PutRevShareSchedulesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RevShareStatements

> Source: [RevShareStatements](Api/RevShareStatements.cs)

<details>
<summary><code>Task&lt;RevShareStatementsResponseResult&gt; GetRevShareStatements(GetRevShareStatementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query revShareStatements.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevShareStatements.GetRevShareStatements(new GetRevShareStatementsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type RevShareStatementsResponseResult
}
catch (ApiException<GetRevShareStatementsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRevShareStatementsRequest](Requests/RevShareStatements/GetRevShareStatementsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevShareStatementsResponseResult](Models/RevShareStatementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRevShareStatementsError](Errors/GetRevShareStatementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevShareStatementsResponseResult&gt; GetRevShareStatementsId(GetRevShareStatementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a revShareStatement.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevShareStatements.GetRevShareStatementsId(new GetRevShareStatementsIdRequest
    {
        Id = "t1_rst_680197f6aa2a84514675c0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type RevShareStatementsResponseResult
}
catch (ApiException<GetRevShareStatementsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRevShareStatementsIdRequest](Requests/RevShareStatements/GetRevShareStatementsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevShareStatementsResponseResult](Models/RevShareStatementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRevShareStatementsIdError](Errors/GetRevShareStatementsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RevenueBoosts

> Source: [RevenueBoosts](Api/RevenueBoosts.cs)

<details>
<summary><code>Task&lt;RevenueBoostsResponseResult&gt; GetRevenueBoosts(GetRevenueBoostsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query revenue boosts

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevenueBoosts.GetRevenueBoosts(new GetRevenueBoostsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type RevenueBoostsResponseResult
}
catch (ApiException<GetRevenueBoostsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRevenueBoostsRequest](Requests/RevenueBoosts/GetRevenueBoostsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevenueBoostsResponseResult](Models/RevenueBoostsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRevenueBoostsError](Errors/GetRevenueBoostsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevenueBoostsResponseResult&gt; GetRevenueBoostsId(GetRevenueBoostsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a RevenueBoost

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RevenueBoosts.GetRevenueBoostsId(new GetRevenueBoostsIdRequest
    {
        Id = "t1_rev_12a003cde5d6b2ec3d9canb",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
    });
    // TODO: Handle 'response' of type RevenueBoostsResponseResult
}
catch (ApiException<GetRevenueBoostsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRevenueBoostsIdRequest](Requests/RevenueBoosts/GetRevenueBoostsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevenueBoostsResponseResult](Models/RevenueBoostsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRevenueBoostsIdError](Errors/GetRevenueBoostsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SaferPayments

> Source: [SaferPayments](Api/SaferPayments.cs)

<details>
<summary><code>Task&lt;SaferPaymentsResponseResult&gt; GetSaferPayments(GetSaferPaymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Safer Payments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SaferPayments.GetSaferPayments(new GetSaferPaymentsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type SaferPaymentsResponseResult
}
catch (ApiException<GetSaferPaymentsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSaferPaymentsRequest](Requests/SaferPayments/GetSaferPaymentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SaferPaymentsResponseResult](Models/SaferPaymentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSaferPaymentsError](Errors/GetSaferPaymentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SaferPaymentsResponseResult&gt; GetSaferPaymentsId(GetSaferPaymentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query Safer Payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SaferPayments.GetSaferPaymentsId(new GetSaferPaymentsIdRequest
    {
        Id = "t1_saf_67f4d59664ed122a5915300",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
    });
    // TODO: Handle 'response' of type SaferPaymentsResponseResult
}
catch (ApiException<GetSaferPaymentsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSaferPaymentsIdRequest](Requests/SaferPayments/GetSaferPaymentsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SaferPaymentsResponseResult](Models/SaferPaymentsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSaferPaymentsIdError](Errors/GetSaferPaymentsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Secrets

> Source: [Secrets](Api/Secrets.cs)

<details>
<summary><code>Task&lt;SecretsResponseResult&gt; DeleteSecretsId(DeleteSecretsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Secret. A Secret represents either a key used to decrypt data or an indicator of which key to be used to decrypt data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.DeleteSecretsId(new DeleteSecretsIdRequest
    {
        Id = "t1_sct_678933d597288379adacez0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SecretsResponseResult
}
catch (ApiException<DeleteSecretsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSecretsIdRequest](Requests/Secrets/DeleteSecretsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretsResponseResult](Models/SecretsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteSecretsIdError](Errors/DeleteSecretsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecretsResponseResult&gt; GetSecrets(GetSecretsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Secret.
A Secret represents either a key used to decrypt data or an indicator of which key to be used to decrypt data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.GetSecrets(new GetSecretsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type SecretsResponseResult
}
catch (ApiException<GetSecretsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSecretsRequest](Requests/Secrets/GetSecretsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretsResponseResult](Models/SecretsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSecretsError](Errors/GetSecretsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecretsResponseResult&gt; GetSecretsId(GetSecretsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Secret, A Secret represents either a key used to decrypt data or an indicator of which key to be used to decrypt data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.GetSecretsId(new GetSecretsIdRequest
    {
        Id = "t1_sct_678933d597288379adacez0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SecretsResponseResult
}
catch (ApiException<GetSecretsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSecretsIdRequest](Requests/Secrets/GetSecretsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretsResponseResult](Models/SecretsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSecretsIdError](Errors/GetSecretsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecretsResponseResult&gt; PostSecrets(PostSecretsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Secret.
A Secret represents either a key used to decrypt data or an indicator of which key to be used to decrypt data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.PostSecrets(new PostSecretsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new SecretsPostRequest
        {
            Login = "some example string",
            Type = SecretType1.BaseKey,
            Key = "some example string",
        },
    });
    // TODO: Handle 'response' of type SecretsResponseResult
}
catch (ApiException<PostSecretsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSecretsRequest](Requests/Secrets/PostSecretsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretsResponseResult](Models/SecretsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostSecretsError](Errors/PostSecretsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecretsResponseResult&gt; PutSecretsId(PutSecretsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Secret, A Secret represents either a key used to decrypt data or an indicator of which key to be used to decrypt data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.PutSecretsId(new PutSecretsIdRequest
    {
        Id = "t1_sct_678933d597288379adacez0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new SecretsPutRequest(),
    });
    // TODO: Handle 'response' of type SecretsResponseResult
}
catch (ApiException<PutSecretsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutSecretsIdRequest](Requests/Secrets/PutSecretsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretsResponseResult](Models/SecretsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutSecretsIdError](Errors/PutSecretsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Sessions

> Source: [Sessions](Api/Sessions.cs)

<details>
<summary><code>Task&lt;SessionsResponseResult&gt; DeleteSessionsId(DeleteSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Statement. 
A Statement resource represents the total collection of funds owed for a Billing period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sessions.DeleteSessionsId(new DeleteSessionsIdRequest
    {
        Id = "p1_ssn_00c741e02fbbe0645cb1fe7",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SessionsResponseResult
}
catch (ApiException<DeleteSessionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSessionsIdRequest](Requests/Sessions/DeleteSessionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionsResponseResult](Models/SessionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteSessionsIdError](Errors/DeleteSessionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionsPostResponseResult&gt; GetSessions(GetSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Session. 
A Session represents a temporary method of authentication to the API. Each Session expires automatically after 30 minutes of inactivity. 
They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, Sessions are not permanent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sessions.GetSessions(new GetSessionsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type SessionsPostResponseResult
}
catch (ApiException<GetSessionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSessionsRequest](Requests/Sessions/GetSessionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionsPostResponseResult](Models/SessionsPostResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSessionsError](Errors/GetSessionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionsResponseResult&gt; GetSessionsId(GetSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Querying a session resource represents a third-party session who interacts with the API, for example, a referral platform.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sessions.GetSessionsId(new GetSessionsIdRequest
    {
        Id = "p1_ssn_00c741e02fbbe0645cb1fe7",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SessionsResponseResult
}
catch (ApiException<GetSessionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSessionsIdRequest](Requests/Sessions/GetSessionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionsResponseResult](Models/SessionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSessionsIdError](Errors/GetSessionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionsResponseResult&gt; PostSessions(PostSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Session. 
A Session represents a temporary method of authentication to the API. Each Session expires automatically after 30 minutes of inactivity. 
They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, Sessions are not permanent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sessions.PostSessions(new PostSessionsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new SessionsPostRequest(),
    });
    // TODO: Handle 'response' of type SessionsResponseResult
}
catch (ApiException<PostSessionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSessionsRequest](Requests/Sessions/PostSessionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionsResponseResult](Models/SessionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostSessionsError](Errors/PostSessionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## StatementEntry

> Source: [StatementEntry](Api/StatementEntry.cs)

<details>
<summary><code>Task&lt;StatementEntriesResponseResult&gt; GetStatementEntries(GetStatementEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a StatementEntry resource. 
A StatementEntry resource represents a record of funds owed for a billing schedule. 
For example, this could be a scheduled weekly or monthly fee, or an event-based activity such as a capture or payout fee.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StatementEntry.GetStatementEntries(new GetStatementEntriesRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type StatementEntriesResponseResult
}
catch (ApiException<GetStatementEntriesError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStatementEntriesRequest](Requests/StatementEntry/GetStatementEntriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatementEntriesResponseResult](Models/StatementEntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetStatementEntriesError](Errors/GetStatementEntriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StatementEntriesResponseResult&gt; GetStatementEntriesId(GetStatementEntriesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a StatementEntry resource. A StatementEntry resource represents a record of funds owed for a billing schedule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StatementEntry.GetStatementEntriesId(new GetStatementEntriesIdRequest
    {
        Id = "t1_ste_67a18bcde1a1b2ec3d9c9az",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type StatementEntriesResponseResult
}
catch (ApiException<GetStatementEntriesIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStatementEntriesIdRequest](Requests/StatementEntry/GetStatementEntriesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatementEntriesResponseResult](Models/StatementEntriesResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetStatementEntriesIdError](Errors/GetStatementEntriesIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Statements

> Source: [Statements](Api/Statements.cs)

<details>
<summary><code>Task&lt;StatementsResponseResult&gt; GetStatements(GetStatementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Statement. 
A Statement resource represents the total collection of funds owed for a Billing period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Statements.GetStatements(new GetStatementsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type StatementsResponseResult
}
catch (ApiException<GetStatementsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStatementsRequest](Requests/Statements/GetStatementsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatementsResponseResult](Models/StatementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetStatementsError](Errors/GetStatementsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StatementsResponseResult&gt; GetStatementsId(GetStatementsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Statement. A Statement resource represents the total collection of funds owed for a Billing period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Statements.GetStatementsId(new GetStatementsIdRequest
    {
        Id = "p1_stm_00ce6abbac436354cd82bba",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type StatementsResponseResult
}
catch (ApiException<GetStatementsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetStatementsIdRequest](Requests/Statements/GetStatementsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatementsResponseResult](Models/StatementsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetStatementsIdError](Errors/GetStatementsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SubscriptionTokens

> Source: [SubscriptionTokens](Api/SubscriptionTokens.cs)

<details>
<summary><code>Task&lt;SubscriptionTokensResponseResult&gt; DeleteSubscriptionTokensId(DeleteSubscriptionTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Subscription Token, which represents an association between a Subscription and a means of payment (Token) for that Subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubscriptionTokens.DeleteSubscriptionTokensId(new DeleteSubscriptionTokensIdRequest
    {
        Id = "t1_stn_680064d2e16ab367d7dffz0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SubscriptionTokensResponseResult
}
catch (ApiException<DeleteSubscriptionTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSubscriptionTokensIdRequest](Requests/SubscriptionTokens/DeleteSubscriptionTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionTokensResponseResult](Models/SubscriptionTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteSubscriptionTokensIdError](Errors/DeleteSubscriptionTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionTokensResponseResult&gt; GetSubscriptionTokens(GetSubscriptionTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Subscription Tokens resource. 
A Subscription Tokens resource represents an association between a Subscription and a means of payment (Token) for that Subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubscriptionTokens.GetSubscriptionTokens(new GetSubscriptionTokensRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type SubscriptionTokensResponseResult
}
catch (ApiException<GetSubscriptionTokensError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSubscriptionTokensRequest](Requests/SubscriptionTokens/GetSubscriptionTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionTokensResponseResult](Models/SubscriptionTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSubscriptionTokensError](Errors/GetSubscriptionTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionTokensResponseResult&gt; GetSubscriptionTokensId(GetSubscriptionTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Subscription Token, which represents an association between a Subscription and a means of payment (Token) for that Subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubscriptionTokens.GetSubscriptionTokensId(new GetSubscriptionTokensIdRequest
    {
        Id = "t1_stn_680064d2e16ab367d7dffz0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SubscriptionTokensResponseResult
}
catch (ApiException<GetSubscriptionTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSubscriptionTokensIdRequest](Requests/SubscriptionTokens/GetSubscriptionTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionTokensResponseResult](Models/SubscriptionTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSubscriptionTokensIdError](Errors/GetSubscriptionTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionTokensResponseResult&gt; PostSubscriptionTokens(PostSubscriptionTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Subscription Tokens resource. 
A Subscription Tokens resource represents an association between a Subscription and a means of payment (Token) for that Subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubscriptionTokens.PostSubscriptionTokens(new PostSubscriptionTokensRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new SubscriptionTokensPostRequest
        {
            Subscription = new SubscriptionsPostRequest
            {
                Plan = "some example string",
                Start = 1,
                Authentication = "some example string",
                Failures = 1,
            },
            Token = new TokenPostRequest
            {
                Customer = new CustomersPostRequest { Login = "some example string" },
                Payment = new PaymentPostRequest(),
                Status = TokenStatus1.Pending,
                Inactive = Inactive1.Value0,
                Frozen = Frozen1.Value0,
            },
        },
    });
    // TODO: Handle 'response' of type SubscriptionTokensResponseResult
}
catch (ApiException<PostSubscriptionTokensError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSubscriptionTokensRequest](Requests/SubscriptionTokens/PostSubscriptionTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionTokensResponseResult](Models/SubscriptionTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostSubscriptionTokensError](Errors/PostSubscriptionTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionTokensResponseResult&gt; PutSubscriptionTokensId(PutSubscriptionTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Subscription Token, which represents an association between a Subscription and a means of payment (Token) for that Subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubscriptionTokens.PutSubscriptionTokensId(new PutSubscriptionTokensIdRequest
    {
        Id = "t1_stn_680064d2e16ab367d7dffz0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new SubscriptionTokensPutRequest(),
    });
    // TODO: Handle 'response' of type SubscriptionTokensResponseResult
}
catch (ApiException<PutSubscriptionTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutSubscriptionTokensIdRequest](Requests/SubscriptionTokens/PutSubscriptionTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionTokensResponseResult](Models/SubscriptionTokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutSubscriptionTokensIdError](Errors/PutSubscriptionTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Subscriptions

> Source: [Subscriptions](Api/Subscriptions.cs)

<details>
<summary><code>Task&lt;SubscriptionResponseResult&gt; DeleteSubscriptionsId(DeleteSubscriptionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Subscription. A Subscription is a scheduled invocation of a particular Plan over a certain period of time, specifying both starting and ending dates, and the customer is charged according to the schedule in the associated Plan during the interval between these dates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.DeleteSubscriptionsId(new DeleteSubscriptionsIdRequest
    {
        Id = "t1_sbn_680064d2db9dbdc8d3e9a0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SubscriptionResponseResult
}
catch (ApiException<DeleteSubscriptionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSubscriptionsIdRequest](Requests/Subscriptions/DeleteSubscriptionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionResponseResult](Models/SubscriptionResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteSubscriptionsIdError](Errors/DeleteSubscriptionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionResponseResult&gt; GetSubscriptions(GetSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Subscription. 
A Subscription is a scheduled invocation of a particular Plan over a certain period of time. 
A Subscription specifies both starting and ending dates and the customer is charged according to the schedule in the associated Plan during the interval between these dates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.GetSubscriptions(new GetSubscriptionsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type SubscriptionResponseResult
}
catch (ApiException<GetSubscriptionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSubscriptionsRequest](Requests/Subscriptions/GetSubscriptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionResponseResult](Models/SubscriptionResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSubscriptionsError](Errors/GetSubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionResponseResult&gt; GetSubscriptionsId(GetSubscriptionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Subscription that specifies both starting and ending dates and charges the customer according to the schedule in the associated Plan during the interval between these dates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.GetSubscriptionsId(new GetSubscriptionsIdRequest
    {
        Id = "t1_sbn_680064d2db9dbdc8d3e9a0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type SubscriptionResponseResult
}
catch (ApiException<GetSubscriptionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSubscriptionsIdRequest](Requests/Subscriptions/GetSubscriptionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionResponseResult](Models/SubscriptionResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSubscriptionsIdError](Errors/GetSubscriptionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionResponseResult&gt; PostSubscriptions(PostSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Subscription. 
A Subscription is a scheduled invocation of a particular Plan over a certain period of time. 
A Subscription specifies both starting and ending dates and the customer is charged according to the schedule in the associated Plan during the interval between these dates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.PostSubscriptions(new PostSubscriptionsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new SubscriptionsPostRequest
        {
            Plan = "some example string",
            Start = 1,
            Authentication = "some example string",
            Failures = 1,
        },
    });
    // TODO: Handle 'response' of type SubscriptionResponseResult
}
catch (ApiException<PostSubscriptionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostSubscriptionsRequest](Requests/Subscriptions/PostSubscriptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionResponseResult](Models/SubscriptionResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostSubscriptionsError](Errors/PostSubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionResponseResult&gt; PutSubscriptionsId(PutSubscriptionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Subscription, A Subscription specifies both starting and ending dates and the customer is charged according to the schedule in the associated Plan during the interval between these dates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.PutSubscriptionsId(new PutSubscriptionsIdRequest
    {
        Id = "t1_sbn_680064d2db9dbdc8d3e9a0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new SubscriptionsPutRequest(),
    });
    // TODO: Handle 'response' of type SubscriptionResponseResult
}
catch (ApiException<PutSubscriptionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutSubscriptionsIdRequest](Requests/Subscriptions/PutSubscriptionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionResponseResult](Models/SubscriptionResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutSubscriptionsIdError](Errors/PutSubscriptionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TaxFormRequests

> Source: [TaxFormRequests](Api/TaxFormRequests.cs)

<details>
<summary><code>Task&lt;TaxFormRequestsResponseResult&gt; GetTaxFormRequests(GetTaxFormRequestsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a taxFormRequests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TaxFormRequests.GetTaxFormRequests(new GetTaxFormRequestsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TaxFormRequestsResponseResult
}
catch (ApiException<GetTaxFormRequestsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTaxFormRequestsRequest](Requests/TaxFormRequests/GetTaxFormRequestsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TaxFormRequestsResponseResult](Models/TaxFormRequestsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTaxFormRequestsError](Errors/GetTaxFormRequestsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TaxFormRequestsResponseResult&gt; GetTaxFormRequestsId(GetTaxFormRequestsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a taxFormRequests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TaxFormRequests.GetTaxFormRequestsId(new GetTaxFormRequestsIdRequest
    {
        Id = "t1_tdr_67ea5cb2c4be3c25dbc1zz0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TaxFormRequestsResponseResult
}
catch (ApiException<GetTaxFormRequestsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTaxFormRequestsIdRequest](Requests/TaxFormRequests/GetTaxFormRequestsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TaxFormRequestsResponseResult](Models/TaxFormRequestsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTaxFormRequestsIdError](Errors/GetTaxFormRequestsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TaxFormRequestsResponseResult&gt; PostTaxFormRequests(PostTaxFormRequestsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Tax Form Requests

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TaxFormRequests.PostTaxFormRequests(new PostTaxFormRequestsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TaxFormRequestsPostRequest(),
    });
    // TODO: Handle 'response' of type TaxFormRequestsResponseResult
}
catch (ApiException<PostTaxFormRequestsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTaxFormRequestsRequest](Requests/TaxFormRequests/PostTaxFormRequestsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TaxFormRequestsResponseResult](Models/TaxFormRequestsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTaxFormRequestsError](Errors/PostTaxFormRequestsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TeamLogins

> Source: [TeamLogins](Api/TeamLogins.cs)

<details>
<summary><code>Task&lt;TeamLoginResponseResult&gt; DeleteTeamLoginsId(DeleteTeamLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Team Login, which represents the link between a Login and a Team as well as the Login's rights on the Team, where the Login resource identified in its 'login' field is considered part of the Team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamLogins.DeleteTeamLoginsId(new DeleteTeamLoginsIdRequest
    {
        Id = "t1_tel_6802c54d22f16393d4be00z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TeamLoginResponseResult
}
catch (ApiException<DeleteTeamLoginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTeamLoginsIdRequest](Requests/TeamLogins/DeleteTeamLoginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamLoginResponseResult](Models/TeamLoginResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteTeamLoginsIdError](Errors/DeleteTeamLoginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamLoginResponseResult&gt; GetTeamLogins(GetTeamLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a teamLogins resource. 
A teamLogins resource represents the link between a Login and a Team as well as the Login's rights on the Team. The Login resource identified in its 'login' field is considered part of the Team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamLogins.GetTeamLogins(new GetTeamLoginsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TeamLoginResponseResult
}
catch (ApiException<GetTeamLoginsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTeamLoginsRequest](Requests/TeamLogins/GetTeamLoginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamLoginResponseResult](Models/TeamLoginResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTeamLoginsError](Errors/GetTeamLoginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamLoginResponseResult&gt; GetTeamLoginsId(GetTeamLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a teamLogins or Team Login resource that represents the link between a Login and a Team as well as the Login's rights on the Team, where the Login resource identified in its 'login' field is considered part of the Team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamLogins.GetTeamLoginsId(new GetTeamLoginsIdRequest
    {
        Id = "t1_tel_6802c54d22f16393d4be00z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TeamLoginResponseResult
}
catch (ApiException<GetTeamLoginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTeamLoginsIdRequest](Requests/TeamLogins/GetTeamLoginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamLoginResponseResult](Models/TeamLoginResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTeamLoginsIdError](Errors/GetTeamLoginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamLoginResponseResult&gt; PostTeamLogins(PostTeamLoginsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a teamLogins resource. 
A teamLogins resource represents the link between a Login and a Team as well as the Login's rights on the Team. The Login resource identified in its 'login' field is considered part of the Team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamLogins.PostTeamLogins(new PostTeamLoginsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TeamLoginPostRequest
        {
            Login = "some example string",
            Team = new TeamsPostRequest { Login = "some example string" },
        },
    });
    // TODO: Handle 'response' of type TeamLoginResponseResult
}
catch (ApiException<PostTeamLoginsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTeamLoginsRequest](Requests/TeamLogins/PostTeamLoginsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamLoginResponseResult](Models/TeamLoginResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTeamLoginsError](Errors/PostTeamLoginsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamLoginResponseResult&gt; PutTeamLoginsId(PutTeamLoginsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a teamLogins or Team Login resource, representing the link between a Login and a Team as well as the Login's rights on the Team, where the Login resource identified in its 'login' field is considered part of the Team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamLogins.PutTeamLoginsId(new PutTeamLoginsIdRequest
    {
        Id = "t1_tel_6802c54d22f16393d4be00z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TeamLoginPutRequest(),
    });
    // TODO: Handle 'response' of type TeamLoginResponseResult
}
catch (ApiException<PutTeamLoginsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutTeamLoginsIdRequest](Requests/TeamLogins/PutTeamLoginsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamLoginResponseResult](Models/TeamLoginResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutTeamLoginsIdError](Errors/PutTeamLoginsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Teams

> Source: [Teams](Api/Teams.cs)

<details>
<summary><code>Task&lt;TeamsResponseResult&gt; DeleteTeamsId(DeleteTeamsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Team, A Team is a collection of Logins, You can associate Logins with a Team by creating teamLogin resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Teams.DeleteTeamsId(new DeleteTeamsIdRequest
    {
        Id = "t1_tem_680155b5a6467e4911aa0z0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TeamsResponseResult
}
catch (ApiException<DeleteTeamsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTeamsIdRequest](Requests/Teams/DeleteTeamsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamsResponseResult](Models/TeamsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteTeamsIdError](Errors/DeleteTeamsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamsResponseResult&gt; GetTeams(GetTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Team. 
A Team is a collection of Logins. 
You can associate Logins with a Team by creating teamLogin resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Teams.GetTeams(new GetTeamsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TeamsResponseResult
}
catch (ApiException<GetTeamsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTeamsRequest](Requests/Teams/GetTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamsResponseResult](Models/TeamsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTeamsError](Errors/GetTeamsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamsResponseResult&gt; GetTeamsId(GetTeamsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Team, which is a collection of Logins that you can associate by creating teamLogin resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Teams.GetTeamsId(new GetTeamsIdRequest
    {
        Id = "t1_tem_680155b5a6467e4911aa0z0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TeamsResponseResult
}
catch (ApiException<GetTeamsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTeamsIdRequest](Requests/Teams/GetTeamsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamsResponseResult](Models/TeamsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTeamsIdError](Errors/GetTeamsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamsResponseResult&gt; PostTeams(PostTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Team. 
A Team is a collection of Logins. 
You can associate Logins with a Team by creating teamLogin resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Teams.PostTeams(new PostTeamsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TeamsPostRequest { Login = "some example string" },
    });
    // TODO: Handle 'response' of type TeamsResponseResult
}
catch (ApiException<PostTeamsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTeamsRequest](Requests/Teams/PostTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamsResponseResult](Models/TeamsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTeamsError](Errors/PostTeamsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamsResponseResult&gt; PutTeamsId(PutTeamsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Team, A Team is a collection of Logins, You can associate Logins with a Team by creating teamLogin resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Teams.PutTeamsId(new PutTeamsIdRequest
    {
        Id = "t1_tem_680155b5a6467e4911aa0z0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TeamsPutRequest(),
    });
    // TODO: Handle 'response' of type TeamsResponseResult
}
catch (ApiException<PutTeamsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutTeamsIdRequest](Requests/Teams/PutTeamsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamsResponseResult](Models/TeamsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutTeamsIdError](Errors/PutTeamsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalTransactionReference

> Source: [TerminalTransactionReference](Api/TerminalTransactionReference.cs)

<details>
<summary><code>Task&lt;TerminalTxnRefResponseResult&gt; PostTerminalTxnRefs(PostTerminalTxnRefsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a terminalTxnRefs resource, which represents a reference code issued by the Processor in relation to a particular Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionReference.PostTerminalTxnRefs(new PostTerminalTxnRefsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TerminalTxnRefPostRequest
        {
            TerminalTxn = "some example string",
            Ref = "some example string",
            Stage = TerminalTxnRefStage1.Activation,
            Platform = PlatformModel1.Apple,
        },
    });
    // TODO: Handle 'response' of type TerminalTxnRefResponseResult
}
catch (ApiException<PostTerminalTxnRefsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTerminalTxnRefsRequest](Requests/TerminalTransactionReference/PostTerminalTxnRefsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnRefResponseResult](Models/TerminalTxnRefResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTerminalTxnRefsError](Errors/PostTerminalTxnRefsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalTransactionResults

> Source: [TerminalTransactionResults](Api/TerminalTransactionResults.cs)

<details>
<summary><code>Task&lt;TerminalTxnResultsResponseResult&gt; GetTerminalTxnResults(GetTerminalTxnResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Querying a terminalTxnResults resource represents the result of a Transaction from a processor, which can be approved, declined, or raise an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionResults.GetTerminalTxnResults(new GetTerminalTxnResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TerminalTxnResultsResponseResult
}
catch (ApiException<GetTerminalTxnResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnResultsRequest](Requests/TerminalTransactionResults/GetTerminalTxnResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnResultsResponseResult](Models/TerminalTxnResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnResultsError](Errors/GetTerminalTxnResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnResultsResponseResult&gt; GetTerminalTxnResultsId(GetTerminalTxnResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Querying a terminalTxnResults resource represents the result of a Transaction from a processor, which may be approved, declined, or raise an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionResults.GetTerminalTxnResultsId(new GetTerminalTxnResultsIdRequest
    {
        Id = "t1_tts_67fd471bc46e25858d21f0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TerminalTxnResultsResponseResult
}
catch (ApiException<GetTerminalTxnResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnResultsIdRequest](Requests/TerminalTransactionResults/GetTerminalTxnResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnResultsResponseResult](Models/TerminalTxnResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnResultsIdError](Errors/GetTerminalTxnResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalTransactions

> Source: [TerminalTransactions](Api/TerminalTransactions.cs)

<details>
<summary><code>Task&lt;TerminalTxnsResponseResult&gt; DeleteTerminalTxnsById(DeleteTerminalTxnsByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a TerminalTxn that holds all of the information to a related final transaction and is used to be reconciled with that actual, final transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactions.DeleteTerminalTxnsById(new DeleteTerminalTxnsByIdRequest
    {
        Id = "t1_ttx_67c76e07ebc6fbbbd476ee0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TerminalTxnsResponseResult
}
catch (ApiException<DeleteTerminalTxnsByIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTerminalTxnsByIdRequest](Requests/TerminalTransactions/DeleteTerminalTxnsByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnsResponseResult](Models/TerminalTxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteTerminalTxnsByIdError](Errors/DeleteTerminalTxnsByIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnsResponseResult&gt; GetTerminalTxns(GetTerminalTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a TerminalTxn, which holds all of the information to a related final transaction and is used to reconcile with the actual, final transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactions.GetTerminalTxns(new GetTerminalTxnsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TerminalTxnsResponseResult
}
catch (ApiException<GetTerminalTxnsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnsRequest](Requests/TerminalTransactions/GetTerminalTxnsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnsResponseResult](Models/TerminalTxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnsError](Errors/GetTerminalTxnsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnsResponseResult&gt; GetTerminalTxnsById(GetTerminalTxnsByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a TerminalTxn holds all of the information to a related final transaction, which they are used to be reconciled with that actual, final transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactions.GetTerminalTxnsById(new GetTerminalTxnsByIdRequest
    {
        Id = "t1_ttx_67c76e07ebc6fbbbd476ee0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TerminalTxnsResponseResult
}
catch (ApiException<GetTerminalTxnsByIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnsByIdRequest](Requests/TerminalTransactions/GetTerminalTxnsByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnsResponseResult](Models/TerminalTxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnsByIdError](Errors/GetTerminalTxnsByIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnsResponseResult&gt; PostTerminalTxns(PostTerminalTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a TerminalTxn. 
TerminalTxns hold all of the information to a related final transaction. They are used to be reconcilliated with that actual, final transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactions.PostTerminalTxns(new PostTerminalTxnsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TerminalTxnsPostRequest
        {
            BinType = TerminalTxnsBinType1.Credit,
            Origin = TerminalTxnOrigin1.Value1,
            Pos = TerminalTxnsPos1.Value0,
            Type = TerminalTxnType1.Value1,
            Currency = currency,
            FundingCurrency = fundingCurrency,
            Swiped = TerminalTxnsSwiped1.Value0,
            Merchant = "some example string",
            Mid = "some example string",
            Pin = TerminalTxnsPin1.Value0,
            Signature = TerminalTxnsSignature1.Value0,
            Total = 1L,
            Status = TerminalTxnStatus1.Value0,
            Inactive = Inactive1.Value0,
            Frozen = Frozen1.Value0,
        },
    });
    // TODO: Handle 'response' of type TerminalTxnsResponseResult
}
catch (ApiException<PostTerminalTxnsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTerminalTxnsRequest](Requests/TerminalTransactions/PostTerminalTxnsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnsResponseResult](Models/TerminalTxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTerminalTxnsError](Errors/PostTerminalTxnsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnsResponseResult&gt; UpdateTerminalTxnsById(UpdateTerminalTxnsByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a TerminalTxn holds all of the information to a related final transaction and is used to be reconciled with that actual, final transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactions.UpdateTerminalTxnsById(new UpdateTerminalTxnsByIdRequest
    {
        Id = "t1_ttx_67c76e07ebc6fbbbd476ee0",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TerminalTxnsPutRequest(),
    });
    // TODO: Handle 'response' of type TerminalTxnsResponseResult
}
catch (ApiException<UpdateTerminalTxnsByIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTerminalTxnsByIdRequest](Requests/TerminalTransactions/UpdateTerminalTxnsByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnsResponseResult](Models/TerminalTxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateTerminalTxnsByIdError](Errors/UpdateTerminalTxnsByIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalTransactionsDatas

> Source: [TerminalTransactionsDatas](Api/TerminalTransactionsDatas.cs)

<details>
<summary><code>Task&lt;TerminalTxnDatasResponseResult&gt; GetTerminalTxnsDatas(GetTerminalTxnsDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a TerminalTxnData resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionsDatas.GetTerminalTxnsDatas(new GetTerminalTxnsDatasRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TerminalTxnDatasResponseResult
}
catch (ApiException<GetTerminalTxnsDatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnsDatasRequest](Requests/TerminalTransactionsDatas/GetTerminalTxnsDatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnDatasResponseResult](Models/TerminalTxnDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnsDatasError](Errors/GetTerminalTxnsDatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnDatasResponseResult&gt; GetTerminalTxnsDatasId(GetTerminalTxnsDatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a TerminalTxnData resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionsDatas.GetTerminalTxnsDatasId(new GetTerminalTxnsDatasIdRequest
    {
        Id = "t1_ttd_67fd4be4e353654e911c6zz",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TerminalTxnDatasResponseResult
}
catch (ApiException<GetTerminalTxnsDatasIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnsDatasIdRequest](Requests/TerminalTransactionsDatas/GetTerminalTxnsDatasIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnDatasResponseResult](Models/TerminalTxnDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnsDatasIdError](Errors/GetTerminalTxnsDatasIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnDatasResponseResult&gt; PostTerminalTxnsDatas(PostTerminalTxnsDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a TerminalTxnData resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionsDatas.PostTerminalTxnsDatas(new PostTerminalTxnsDatasRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TerminalTxnsDatasPostRequest
        {
            TerminalTxn = "some example string",
            Signature = "some example string",
        },
    });
    // TODO: Handle 'response' of type TerminalTxnDatasResponseResult
}
catch (ApiException<PostTerminalTxnsDatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTerminalTxnsDatasRequest](Requests/TerminalTransactionsDatas/PostTerminalTxnsDatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnDatasResponseResult](Models/TerminalTxnDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTerminalTxnsDatasError](Errors/PostTerminalTxnsDatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TerminalTransactionsMetadatas

> Source: [TerminalTransactionsMetadatas](Api/TerminalTransactionsMetadatas.cs)

<details>
<summary><code>Task&lt;TerminalTxnMetadatasResponseResult&gt; GetTerminalTxnsMetadatas(GetTerminalTxnsMetadatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a terminalTxnMetadatas resource. 
A terminalTxnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionsMetadatas.GetTerminalTxnsMetadatas(
        new GetTerminalTxnsMetadatasRequest
        {
            PageNumber = 1,
            PageLimit = 50,
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
            Search = "created[greater]=2025-01-01",
            Totals = "count[]=id",
        });
    // TODO: Handle 'response' of type TerminalTxnMetadatasResponseResult
}
catch (ApiException<GetTerminalTxnsMetadatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnsMetadatasRequest](Requests/TerminalTransactionsMetadatas/GetTerminalTxnsMetadatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnMetadatasResponseResult](Models/TerminalTxnMetadatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnsMetadatasError](Errors/GetTerminalTxnsMetadatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnMetadatasResponseResult&gt; GetTerminalTxnsMetadatasId(GetTerminalTxnsMetadatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a terminalTxnMetadatas resource. 
A terminalTxnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionsMetadatas.GetTerminalTxnsMetadatasId(
        new GetTerminalTxnsMetadatasIdRequest
        {
            Id = "t1_ttm_6806cde43c3480e154d7a0z",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
        });
    // TODO: Handle 'response' of type TerminalTxnMetadatasResponseResult
}
catch (ApiException<GetTerminalTxnsMetadatasIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalTxnsMetadatasIdRequest](Requests/TerminalTransactionsMetadatas/GetTerminalTxnsMetadatasIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnMetadatasResponseResult](Models/TerminalTxnMetadatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalTxnsMetadatasIdError](Errors/GetTerminalTxnsMetadatasIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalTxnMetadatasResponseResult&gt; PostTerminalTxnsMetadatas(PostTerminalTxnsMetadatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a terminalTxnMetadatas resource. A terminalTxnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TerminalTransactionsMetadatas.PostTerminalTxnsMetadatas(
        new PostTerminalTxnsMetadatasRequest
        {
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
            Body = new TerminalTxnsMetadatasPostRequest
            {
                TerminalTxn = "some example string",
                Type = TerminalTxnMetadataType1.Amounts,
                Field = TerminalTxnsMetadatasField1.Discretionary1,
                Value = "some example string",
            },
        });
    // TODO: Handle 'response' of type TerminalTxnMetadatasResponseResult
}
catch (ApiException<PostTerminalTxnsMetadatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTerminalTxnsMetadatasRequest](Requests/TerminalTransactionsMetadatas/PostTerminalTxnsMetadatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalTxnMetadatasResponseResult](Models/TerminalTxnMetadatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTerminalTxnsMetadatasError](Errors/PostTerminalTxnsMetadatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Terminals

> Source: [Terminals](Api/Terminals.cs)

<details>
<summary><code>Task&lt;TerminalsResponseResult&gt; DeleteTerminalsId(DeleteTerminalsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a terminal resource that represents a device/software that will be used to process transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminals.DeleteTerminalsId(new DeleteTerminalsIdRequest
    {
        Id = "t1_tml_67c12924f339facb1c80000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TerminalsResponseResult
}
catch (ApiException<DeleteTerminalsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTerminalsIdRequest](Requests/Terminals/DeleteTerminalsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalsResponseResult](Models/TerminalsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteTerminalsIdError](Errors/DeleteTerminalsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalsResponseResult&gt; GetTerminals(GetTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a terminal resource. 
A terminal resource represents a device/software that will be used to process transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminals.GetTerminals(new GetTerminalsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TerminalsResponseResult
}
catch (ApiException<GetTerminalsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalsRequest](Requests/Terminals/GetTerminalsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalsResponseResult](Models/TerminalsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalsError](Errors/GetTerminalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalsResponseResult&gt; GetTerminalsId(GetTerminalsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Terminal resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminals.GetTerminalsId(new GetTerminalsIdRequest
    {
        Id = "t1_tml_67c12924f339facb1c80000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TerminalsResponseResult
}
catch (ApiException<GetTerminalsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalsIdRequest](Requests/Terminals/GetTerminalsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalsResponseResult](Models/TerminalsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTerminalsIdError](Errors/GetTerminalsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalsResponseResult&gt; PostTerminals(PostTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a terminal resource. 
A terminal resource represents a device/software that will be used to process transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminals.PostTerminals(new PostTerminalsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TerminalsPostRequest
        {
            Merchant = "some example string",
            Type = TerminalType1._125158Llc,
            AutoClose = TerminalsAutoClose1.Value0,
            Status = TerminalStatus1.Value0,
        },
    });
    // TODO: Handle 'response' of type TerminalsResponseResult
}
catch (ApiException<PostTerminalsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTerminalsRequest](Requests/Terminals/PostTerminalsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalsResponseResult](Models/TerminalsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTerminalsError](Errors/PostTerminalsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TerminalsResponseResult&gt; PutTerminalsId(PutTerminalsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Terminal resource.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminals.PutTerminalsId(new PutTerminalsIdRequest
    {
        Id = "t1_tml_67c12924f339facb1c80000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TerminalsPutRequest(),
    });
    // TODO: Handle 'response' of type TerminalsResponseResult
}
catch (ApiException<PutTerminalsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutTerminalsIdRequest](Requests/Terminals/PutTerminalsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TerminalsResponseResult](Models/TerminalsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutTerminalsIdError](Errors/PutTerminalsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TokenResults

> Source: [TokenResults](Api/TokenResults.cs)

<details>
<summary><code>Task&lt;TokenResultsResponseResult&gt; GetTokenResults(GetTokenResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Token Results.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TokenResults.GetTokenResults(new GetTokenResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TokenResultsResponseResult
}
catch (ApiException<GetTokenResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTokenResultsRequest](Requests/TokenResults/GetTokenResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenResultsResponseResult](Models/TokenResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTokenResultsError](Errors/GetTokenResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenResultsResponseResult&gt; GetTokenResultsId(GetTokenResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a tokenResults.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TokenResults.GetTokenResultsId(new GetTokenResultsIdRequest
    {
        Id = "t1_tkr_681b008f046d4ddae223z00",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TokenResultsResponseResult
}
catch (ApiException<GetTokenResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTokenResultsIdRequest](Requests/TokenResults/GetTokenResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenResultsResponseResult](Models/TokenResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTokenResultsIdError](Errors/GetTokenResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Tokens

> Source: [Tokens](Api/Tokens.cs)

<details>
<summary><code>Task&lt;TokensResponseResult&gt; DeleteTokensId(DeleteTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Token, which is a resource that acts as a storage place for credit card and customer information, allowing you to run Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tokens.DeleteTokensId(new DeleteTokensIdRequest
    {
        Id = "p1_tok_00c82eb304b0067620c82be",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TokensResponseResult
}
catch (ApiException<DeleteTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTokensIdRequest](Requests/Tokens/DeleteTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokensResponseResult](Models/TokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteTokensIdError](Errors/DeleteTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokensResponseResult&gt; GetTokens(GetTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Token. A Token is a resource that acts as a storage place for credit card and customer information. You can use a Token to run Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tokens.GetTokens(new GetTokensRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TokensResponseResult
}
catch (ApiException<GetTokensError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTokensRequest](Requests/Tokens/GetTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokensResponseResult](Models/TokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTokensError](Errors/GetTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokensResponseResult&gt; GetTokensId(GetTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Token, which is a resource that acts as a storage place for credit card and customer information, allowing you to run Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tokens.GetTokensId(new GetTokensIdRequest
    {
        Id = "p1_tok_00c82eb304b0067620c82be",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TokensResponseResult
}
catch (ApiException<GetTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTokensIdRequest](Requests/Tokens/GetTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokensResponseResult](Models/TokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTokensIdError](Errors/GetTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokensResponseResult&gt; PostTokens(PostTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Token. A Token is a resource that acts as a storage place for credit card and customer information. You can use a Token to run Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tokens.PostTokens(new PostTokensRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TokenPostRequest
        {
            Customer = new CustomersPostRequest { Login = "some example string" },
            Payment = new PaymentPostRequest(),
            Status = TokenStatus1.Pending,
            Inactive = Inactive1.Value0,
            Frozen = Frozen1.Value0,
        },
    });
    // TODO: Handle 'response' of type TokensResponseResult
}
catch (ApiException<PostTokensError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTokensRequest](Requests/Tokens/PostTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokensResponseResult](Models/TokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTokensError](Errors/PostTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokensResponseResult&gt; PutTokensId(PutTokensIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Token, which is a resource that acts as a storage place for credit card and customer information, allowing you to run Transactions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tokens.PutTokensId(new PutTokensIdRequest
    {
        Id = "p1_tok_00c82eb304b0067620c82be",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        Body = new TokenPutRequest(),
    });
    // TODO: Handle 'response' of type TokensResponseResult
}
catch (ApiException<PutTokensIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutTokensIdRequest](Requests/Tokens/PutTokensIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokensResponseResult](Models/TokensResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutTokensIdError](Errors/PutTokensIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionDatas

> Source: [TransactionDatas](Api/TransactionDatas.cs)

<details>
<summary><code>Task&lt;TxnDatasResponseResult&gt; GetTxnDatas(GetTxnDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query txnDatas resource. 
A txnDatas resource represents data associated with a Transaction - in particular, a Base64 encoded image of a signature captured at the time of entering the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionDatas.GetTxnDatas(new GetTxnDatasRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TxnDatasResponseResult
}
catch (ApiException<GetTxnDatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnDatasRequest](Requests/TransactionDatas/GetTxnDatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnDatasResponseResult](Models/TxnDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnDatasError](Errors/GetTxnDatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnDatasResponseResult&gt; GetTxnDatasId(GetTxnDatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a txnDatas resource. 
A txnDatas resource represents data associated with a Transaction - in particular, a Base64 encoded image of a signature captured at the time of entering the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionDatas.GetTxnDatasId(new GetTxnDatasIdRequest
    {
        Id = "t1_td_67b3168bbed12b9eb75aab8",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TxnDatasResponseResult
}
catch (ApiException<GetTxnDatasIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnDatasIdRequest](Requests/TransactionDatas/GetTxnDatasIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnDatasResponseResult](Models/TxnDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnDatasIdError](Errors/GetTxnDatasIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnDatasResponseResult&gt; PostTxnDatas(PostTxnDatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a txnData. A txnDatas resource represents data associated with a Transaction - in particular, a Base64 encoded image of a signature captured at the time of entering the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionDatas.PostTxnDatas(new PostTxnDatasRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TxnDatasPostRequest { Txn = "some example string", Signature = "some example string" },
    });
    // TODO: Handle 'response' of type TxnDatasResponseResult
}
catch (ApiException<PostTxnDatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTxnDatasRequest](Requests/TransactionDatas/PostTxnDatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnDatasResponseResult](Models/TxnDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTxnDatasError](Errors/PostTxnDatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionHolds

> Source: [TransactionHolds](Api/TransactionHolds.cs)

<details>
<summary><code>Task&lt;HoldsResponseResult&gt; GetHolds(GetHoldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a holds resource. 
A holds resource represents a reviewable action taken on a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionHolds.GetHolds(new GetHoldsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type HoldsResponseResult
}
catch (ApiException<GetHoldsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetHoldsRequest](Requests/TransactionHolds/GetHoldsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[HoldsResponseResult](Models/HoldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetHoldsError](Errors/GetHoldsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;HoldsResponseResult&gt; GetHoldsId(GetHoldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a holds resource. 
A holds resource represents a reviewable action taken on a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionHolds.GetHoldsId(new GetHoldsIdRequest
    {
        Id = "t1_hld_0000fc11df8e4c00000e00c",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type HoldsResponseResult
}
catch (ApiException<GetHoldsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetHoldsIdRequest](Requests/TransactionHolds/GetHoldsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[HoldsResponseResult](Models/HoldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetHoldsIdError](Errors/GetHoldsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;HoldsResponseResult&gt; PostHolds(PostHoldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a holds resource. 
A holds resource represents a reviewable action taken on a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionHolds.PostHolds(new PostHoldsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new HoldsPostRequest { Login = "some example string" },
    });
    // TODO: Handle 'response' of type HoldsResponseResult
}
catch (ApiException<PostHoldsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostHoldsRequest](Requests/TransactionHolds/PostHoldsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[HoldsResponseResult](Models/HoldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostHoldsError](Errors/PostHoldsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;HoldsResponseResult&gt; PutHoldsId(PutHoldsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Details for update on holds

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionHolds.PutHoldsId(new PutHoldsIdRequest
    {
        Id = "t1_hld_0000fc11df8e4c00000e00c",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new HoldsPutRequest(),
    });
    // TODO: Handle 'response' of type HoldsResponseResult
}
catch (ApiException<PutHoldsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutHoldsIdRequest](Requests/TransactionHolds/PutHoldsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[HoldsResponseResult](Models/HoldsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutHoldsIdError](Errors/PutHoldsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionItems

> Source: [TransactionItems](Api/TransactionItems.cs)

<details>
<summary><code>Task&lt;ItemsResponseResult&gt; DeleteItemsId(DeleteItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an Item. 
An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionItems.DeleteItemsId(new DeleteItemsIdRequest
    {
        Id = "t1_itm_67b48390abd89e15be2d000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ItemsResponseResult
}
catch (ApiException<DeleteItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteItemsIdRequest](Requests/TransactionItems/DeleteItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemsResponseResult](Models/ItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteItemsIdError](Errors/DeleteItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemsResponseResult&gt; GetItems(GetItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Item. 
An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionItems.GetItems(new GetItemsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type ItemsResponseResult
}
catch (ApiException<GetItemsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetItemsRequest](Requests/TransactionItems/GetItemsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemsResponseResult](Models/ItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetItemsError](Errors/GetItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemsResponseResult&gt; GetItemsId(GetItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query an Item. 
An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionItems.GetItemsId(new GetItemsIdRequest
    {
        Id = "t1_itm_67b48390abd89e15be2d000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type ItemsResponseResult
}
catch (ApiException<GetItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetItemsIdRequest](Requests/TransactionItems/GetItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemsResponseResult](Models/ItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetItemsIdError](Errors/GetItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemsResponseResult&gt; PostItems(PostItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Item. 
An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionItems.PostItems(new PostItemsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ItemsPostRequest
        {
            Txn = new TxnsPostRequest
            {
                AllowPartial = TxnsAllowPartial1.Value0,
                Authentication = "some example string",
                DebtRepayment = TxnsDebtRepayment1.Value0,
                Fortxn = "some example string",
                Origin = TxnOrigin1.Value0,
                Type = TxnType1.Value1,
                UnauthReason = UnauthReason1.Incomplete,
                Currency = currency,
                FundingCurrency = fundingCurrency,
                Swiped = TerminalTxnsSwiped1.Value0,
                Merchant = "some example string",
                Mid = "some example string",
                Pin = TerminalTxnsPin1.Value0,
                Signature = TerminalTxnsSignature1.Value0,
                Total = 1L,
                Unattended = TerminalTxnsUnattended1.Value0,
                Payment = new Payment4 { Method = TxnPaymentMethod1.Value0, Number = "some example string" },
            },
            Item = "some example string",
            Quantity = 1,
            Price = 1,
        },
    });
    // TODO: Handle 'response' of type ItemsResponseResult
}
catch (ApiException<PostItemsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostItemsRequest](Requests/TransactionItems/PostItemsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemsResponseResult](Models/ItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostItemsError](Errors/PostItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemsResponseResult&gt; PutItemsId(PutItemsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an Item. 
An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionItems.PutItemsId(new PutItemsIdRequest
    {
        Id = "t1_itm_67b48390abd89e15be2d000",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new ItemsPutRequest(),
    });
    // TODO: Handle 'response' of type ItemsResponseResult
}
catch (ApiException<PutItemsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutItemsIdRequest](Requests/TransactionItems/PutItemsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemsResponseResult](Models/ItemsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutItemsIdError](Errors/PutItemsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionMetadatas

> Source: [TransactionMetadatas](Api/TransactionMetadatas.cs)

<details>
<summary><code>Task&lt;TxnMetaDatasResponseResult&gt; GetTxnMetadatas(GetTxnMetadatasRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a txnMetadatas resource. 
A txnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionMetadatas.GetTxnMetadatas(new GetTxnMetadatasRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TxnMetaDatasResponseResult
}
catch (ApiException<GetTxnMetadatasError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnMetadatasRequest](Requests/TransactionMetadatas/GetTxnMetadatasRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnMetaDatasResponseResult](Models/TxnMetaDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnMetadatasError](Errors/GetTxnMetadatasError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnMetaDatasResponseResult&gt; GetTxnMetadatasId(GetTxnMetadatasIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a txnMetadatas resource. 
A txnMetadatas resource represents data from an EMV Transaction and/or returned by the credit card network associated with a Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionMetadatas.GetTxnMetadatasId(new GetTxnMetadatasIdRequest
    {
        Id = "p1_tmd_67a000db8b464f000d8ea2d",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TxnMetaDatasResponseResult
}
catch (ApiException<GetTxnMetadatasIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnMetadatasIdRequest](Requests/TransactionMetadatas/GetTxnMetadatasIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnMetaDatasResponseResult](Models/TxnMetaDatasResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnMetadatasIdError](Errors/GetTxnMetadatasIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionsTxns

> Source: [TransactionsTxns](Api/TransactionsTxns.cs)

<details>
<summary><code>Task&lt;TxnsResponseResult&gt; GetTxns(GetTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Transaction. 
Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsTxns.GetTxns(new GetTxnsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TxnsResponseResult
}
catch (ApiException<GetTxnsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnsRequest](Requests/TransactionsTxns/GetTxnsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnsResponseResult](Models/TxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnsError](Errors/GetTxnsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnsResponseResult&gt; GetTxnsId(GetTxnsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a Transaction. 
Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsTxns.GetTxnsId(new GetTxnsIdRequest
    {
        Id = "p1_txn_5a1ef5e55658af7cf012866",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TxnsResponseResult
}
catch (ApiException<GetTxnsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnsIdRequest](Requests/TransactionsTxns/GetTxnsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnsResponseResult](Models/TxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnsIdError](Errors/GetTxnsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnsPostResponseResult&gt; PostTxns(PostTxnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Transaction. 
Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsTxns.PostTxns(new PostTxnsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TxnsPostRequest
        {
            AllowPartial = TxnsAllowPartial1.Value0,
            Authentication = "some example string",
            DebtRepayment = TxnsDebtRepayment1.Value0,
            Fortxn = "some example string",
            Origin = TxnOrigin1.Value0,
            Type = TxnType1.Value1,
            UnauthReason = UnauthReason1.Incomplete,
            Currency = currency,
            FundingCurrency = fundingCurrency,
            Swiped = TerminalTxnsSwiped1.Value0,
            Merchant = "some example string",
            Mid = "some example string",
            Pin = TerminalTxnsPin1.Value0,
            Signature = TerminalTxnsSignature1.Value0,
            Total = 1L,
            Unattended = TerminalTxnsUnattended1.Value0,
            Payment = new Payment4 { Method = TxnPaymentMethod1.Value0, Number = "some example string" },
        },
    });
    // TODO: Handle 'response' of type TxnsPostResponseResult
}
catch (ApiException<PostTxnsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTxnsRequest](Requests/TransactionsTxns/PostTxnsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnsPostResponseResult](Models/TxnsPostResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTxnsError](Errors/PostTxnsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnsResponseResult&gt; PutTxnsId(PutTxnsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Transaction. 
Transactions hold all of the information relating to a particular credit card transaction, including the merchant, token, subscription, customer and card information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsTxns.PutTxnsId(new PutTxnsIdRequest
    {
        Id = "p1_txn_5a1ef5e55658af7cf012866",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TxnsPutRequest(),
    });
    // TODO: Handle 'response' of type TxnsResponseResult
}
catch (ApiException<PutTxnsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PutTxnsIdRequest](Requests/TransactionsTxns/PutTxnsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnsResponseResult](Models/TxnsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PutTxnsIdError](Errors/PutTxnsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionsResults

> Source: [TransactionsResults](Api/TransactionsResults.cs)

<details>
<summary><code>Task&lt;TxnResultsResponseResult&gt; GetTxnResults(GetTxnResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a txnResults resource. 
A txnResults resource represents the result of a Transaction from a processor. 
For example, the Transaction may be approved, declined, or raise an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsResults.GetTxnResults(new GetTxnResultsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TxnResultsResponseResult
}
catch (ApiException<GetTxnResultsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnResultsRequest](Requests/TransactionsResults/GetTxnResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnResultsResponseResult](Models/TxnResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnResultsError](Errors/GetTxnResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnResultsResponseResult&gt; GetTxnResultsId(GetTxnResultsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a txnResults resource. 
A txnResults resource represents the result of a Transaction from a processor. 
For example, the Transaction may be approved, declined, or raise an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsResults.GetTxnResultsId(new GetTxnResultsIdRequest
    {
        Id = "t1_trs_67b867ff0b004311c46fb0z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TxnResultsResponseResult
}
catch (ApiException<GetTxnResultsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnResultsIdRequest](Requests/TransactionsResults/GetTxnResultsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnResultsResponseResult](Models/TxnResultsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnResultsIdError](Errors/GetTxnResultsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TxnSessions

> Source: [TxnSessions](Api/TxnSessions.cs)

<details>
<summary><code>Task&lt;TxnSessionsResponseResult&gt; DeleteTxnSessionsId(DeleteTxnSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a TxnSession. 
A TxnSession represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field. 
They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TxnSessions.DeleteTxnSessionsId(new DeleteTxnSessionsIdRequest
    {
        Id = "t1_tss_67bc56867a5c6b8f7756d1z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TxnSessionsResponseResult
}
catch (ApiException<DeleteTxnSessionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTxnSessionsIdRequest](Requests/TxnSessions/DeleteTxnSessionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnSessionsResponseResult](Models/TxnSessionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteTxnSessionsIdError](Errors/DeleteTxnSessionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnSessionsResponseResult&gt; GetTxnSessions(GetTxnSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a TxnSession. 
A TxnSession represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field. 
They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TxnSessions.GetTxnSessions(new GetTxnSessionsRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type TxnSessionsResponseResult
}
catch (ApiException<GetTxnSessionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnSessionsRequest](Requests/TxnSessions/GetTxnSessionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnSessionsResponseResult](Models/TxnSessionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnSessionsError](Errors/GetTxnSessionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnSessionsResponseResult&gt; GetTxnSessionsId(GetTxnSessionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a TxnSession. 
A TxnSession represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field. 
They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TxnSessions.GetTxnSessionsId(new GetTxnSessionsIdRequest
    {
        Id = "t1_tss_67bc56867a5c6b8f7756d1z",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type TxnSessionsResponseResult
}
catch (ApiException<GetTxnSessionsIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTxnSessionsIdRequest](Requests/TxnSessions/GetTxnSessionsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnSessionsResponseResult](Models/TxnSessionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTxnSessionsIdError](Errors/GetTxnSessionsIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TxnSessionsResponseResult&gt; PostTxnSessions(PostTxnSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a TxnSession. 
A TxnSessions represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field. 
They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TxnSessions.PostTxnSessions(new PostTxnSessionsRequest
    {
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Body = new TxnSessionsPostRequest { Login = "some example string", Merchant = "some example string" },
    });
    // TODO: Handle 'response' of type TxnSessionsResponseResult
}
catch (ApiException<PostTxnSessionsError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostTxnSessionsRequest](Requests/TxnSessions/PostTxnSessionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TxnSessionsResponseResult](Models/TxnSessionsResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PostTxnSessionsError](Errors/PostTxnSessionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VasEfeOffers

> Source: [VasEfeOffers](Api/VasEfeOffers.cs)

<details>
<summary><code>Task&lt;VasEfeOffersResponseResult&gt; GetVasEfeOffers(GetVasEfeOffersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a vasEfeOffers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VasEfeOffers.GetVasEfeOffers(new GetVasEfeOffersRequest
    {
        PageNumber = 1,
        PageLimit = 50,
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
        Search = "created[greater]=2025-01-01",
        Totals = "count[]=id",
    });
    // TODO: Handle 'response' of type VasEfeOffersResponseResult
}
catch (ApiException<GetVasEfeOffersError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetVasEfeOffersRequest](Requests/VasEfeOffers/GetVasEfeOffersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VasEfeOffersResponseResult](Models/VasEfeOffersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetVasEfeOffersError](Errors/GetVasEfeOffersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VasEfeOffersResponseResult&gt; GetVasEfeOffersId(GetVasEfeOffersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Query a vasEfeOffers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VasEfeOffers.GetVasEfeOffersId(new GetVasEfeOffersIdRequest
    {
        Id = "000000000000002",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
    // TODO: Handle 'response' of type VasEfeOffersResponseResult
}
catch (ApiException<GetVasEfeOffersIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetVasEfeOffersIdRequest](Requests/VasEfeOffers/GetVasEfeOffersIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VasEfeOffersResponseResult](Models/VasEfeOffersResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetVasEfeOffersIdError](Errors/GetVasEfeOffersIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ValueAddedServices

> Source: [ValueAddedServices](Api/ValueAddedServices.cs)

<details>
<summary><code>Task&lt;VasEnablementStatusResponseResult&gt; GetValueAddedServicesEnablementStatusTargetId(GetValueAddedServicesEnablementStatusTargetIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the enablement status of a specific merchant or entity for a Value Added Service (VAS).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ValueAddedServices.GetValueAddedServicesEnablementStatusTargetId(
        new GetValueAddedServicesEnablementStatusTargetIdRequest
        {
            Service = VasEnablementStatusService1.FraudSight,
            Target = VasEnablementStatusTargetType1.Merchant,
            TargetId = "p1_mer_00c66ace58ad2d376bb0067",
            Token = "a12bc3d4e56f789g0h1ij23kl456789",
            RequestToken = "20250423-yourmerchant-refunds-001",
        });
    // TODO: Handle 'response' of type VasEnablementStatusResponseResult
}
catch (ApiException<GetValueAddedServicesEnablementStatusTargetIdError> ex)
{
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // TODO: Handle 'error' of type ErrorFourHundred1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetValueAddedServicesEnablementStatusTargetIdRequest](Requests/ValueAddedServices/GetValueAddedServicesEnablementStatusTargetIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VasEnablementStatusResponseResult](Models/VasEnablementStatusResponseResult.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetValueAddedServicesEnablementStatusTargetIdError](Errors/GetValueAddedServicesEnablementStatusTargetIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

