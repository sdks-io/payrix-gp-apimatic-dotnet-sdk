<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — Payrix (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | Payrix |
| Root namespace | `Payrix` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `1.7.0` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file and `Payrix.csproj` — never to the page that carries them. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options = new PayrixClientOptions
{
    ApiKey = "YOUR_API_KEY",
    SessionKey = "YOUR_API_KEY",
    TxnSessionKey = "YOUR_API_KEY",
    Username = "YOUR_API_KEY",
    Password = "YOUR_API_KEY",
    Environment = ServerEnvironment.Production,
};
var client = new PayrixClient(httpClient, options);
```

DI alternative (`services.AddPayrixClient`):

```csharp
services.AddPayrixClient(options =>
{
    options.ApiKey = "YOUR_API_KEY";
    options.SessionKey = "YOUR_API_KEY";
    options.TxnSessionKey = "YOUR_API_KEY";
    options.Username = "YOUR_API_KEY";
    options.Password = "YOUR_API_KEY";
    options.Environment = ServerEnvironment.Production;
    // TODO: configure more client options here
});
```

Every API group is a property on the client (e.g. `client.ApiKeys`). Source: `PayrixClient.cs`. The only constructor is `PayrixClient(HttpClient httpClient, PayrixClientOptions options)`.

All `PayrixClientOptions` properties (source: `PayrixClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `TimeProvider` | `TimeProvider` |
| `Server` | `ServerOptions` |
| `StreamReadTimeout` | `TimeSpan?` |
| `Hooks` | `IReadOnlyList<SdkHook>` |
| `ApiKey` | `string?` |
| `SessionKey` | `string?` |
| `TxnSessionKey` | `string?` |
| `Username` | `string?` |
| `Password` | `string?` |

`ServerEnvironment` (source: `Servers/ServerEnvironment.cs`, namespace `Payrix.Servers`)

`RetryOptions` members (namespace `Payrix.Core.Configuration` — add `using Payrix.Core.Configuration;`; source: `Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `ApiException<TError>` (`Core/Exceptions/ApiException.cs`, namespace `Payrix.Core.Exceptions`) exposing `.Error` of type `TError` beside the `StatusCode`, `Headers` and `ContentType` of the response. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class (namespace `Payrix.Errors`) with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`Core/ErrorResponse/RawError.cs`, namespace `Payrix.Core.ErrorResponse`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

⚠ Each of the three lives in its own namespace. `Core/` holds several namespaces, so a catch block naming `ApiException<T>`, a typed `{Operation}Error` and `RawError` together needs a `using` for each.

`ApiException<TError>` is one leaf of the `SdkException` family (`Core/Exceptions/SdkException.cs`): a request that produced no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match its declared type as `ResponseDeserializationException`, and a credential that could not be applied as `AuthSchemeException`. Every one of them names the failed call. The full table is in [README → Error Handling](README.md#error-handling).

Core error types (`Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of the 361 typed error classes in `Errors/` | `TryGetRawError(out RawError error): bool` | `Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

```csharp
try
{
    var response = await client.ApiKeys.DeleteApikeysId(new DeleteApikeysIdRequest
    {
        Id = "t1_api_676a5353d67a6df2c47b198",
        Token = "a12bc3d4e56f789g0h1ij23kl456789",
        RequestToken = "20250423-yourmerchant-refunds-001",
    });
}
catch (ApiException<DeleteApikeysIdError> ex)
{
    // Case A — typed error
    if (ex.Error.TryGetErrorFourHundred1(out var error))
    {
        // Handle 400
    }
    else if (ex.Error.TryGetRawError(out var raw))
    {
        // Any other error status
    }
}
catch (ApiException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **361 operations**, **361 are Case A (typed)** and **0 are Case B (raw)**.

---

## Operations — by controller (105 groups, 361 operations)

Each links to a sub-page with one row per operation: signature, the request record's required members, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Default`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Inputs are one request record** — an operation that takes input takes a single request record as its first parameter; build it with an object initializer, using the property names in the record's source (its file is in the operation's **Type sources**). A member the row does not list as required is optional or already carries the spec's default | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `ApiKeys` | 5 | [map/operations/ApiKeys.md](map/operations/ApiKeys.md) |
| `Accounts` | 5 | [map/operations/Accounts.md](map/operations/Accounts.md) |
| `AccountsVerifications` | 2 | [map/operations/AccountsVerifications.md](map/operations/AccountsVerifications.md) |
| `Adjustments` | 2 | [map/operations/Adjustments.md](map/operations/Adjustments.md) |
| `AggregationResultGroups` | 3 | [map/operations/AggregationResultGroups.md](map/operations/AggregationResultGroups.md) |
| `AggregationResults` | 3 | [map/operations/AggregationResults.md](map/operations/AggregationResults.md) |
| `Aggregations` | 5 | [map/operations/Aggregations.md](map/operations/Aggregations.md) |
| `AlertActions` | 5 | [map/operations/AlertActions.md](map/operations/AlertActions.md) |
| `AlertTriggers` | 5 | [map/operations/AlertTriggers.md](map/operations/AlertTriggers.md) |
| `Alerts` | 5 | [map/operations/Alerts.md](map/operations/Alerts.md) |
| `AppleDomains` | 2 | [map/operations/AppleDomains.md](map/operations/AppleDomains.md) |
| `AppleDomainsMassEnablement` | 4 | [map/operations/AppleDomainsMassEnablement.md](map/operations/AppleDomainsMassEnablement.md) |
| `AuthenticationTokens` | 5 | [map/operations/AuthenticationTokens.md](map/operations/AuthenticationTokens.md) |
| `BatchesSettlements` | 4 | [map/operations/BatchesSettlements.md](map/operations/BatchesSettlements.md) |
| `Bins` | 2 | [map/operations/Bins.md](map/operations/Bins.md) |
| `ChangeRequests` | 3 | [map/operations/ChangeRequests.md](map/operations/ChangeRequests.md) |
| `ChargebackDocuments` | 5 | [map/operations/ChargebackDocuments.md](map/operations/ChargebackDocuments.md) |
| `ChargebackMessageResults` | 2 | [map/operations/ChargebackMessageResults.md](map/operations/ChargebackMessageResults.md) |
| `ChargebackMessages` | 3 | [map/operations/ChargebackMessages.md](map/operations/ChargebackMessages.md) |
| `ChargebackStatuses` | 2 | [map/operations/ChargebackStatuses.md](map/operations/ChargebackStatuses.md) |
| `Chargebacks` | 2 | [map/operations/Chargebacks.md](map/operations/Chargebacks.md) |
| `ConfirmationCodes` | 4 | [map/operations/ConfirmationCodes.md](map/operations/ConfirmationCodes.md) |
| `Contacts` | 5 | [map/operations/Contacts.md](map/operations/Contacts.md) |
| `Credentials` | 5 | [map/operations/Credentials.md](map/operations/Credentials.md) |
| `Customers` | 5 | [map/operations/Customers.md](map/operations/Customers.md) |
| `DecisionActions` | 5 | [map/operations/DecisionActions.md](map/operations/DecisionActions.md) |
| `DecisionRules` | 5 | [map/operations/DecisionRules.md](map/operations/DecisionRules.md) |
| `Decisions` | 5 | [map/operations/Decisions.md](map/operations/Decisions.md) |
| `DisbursementEntries` | 2 | [map/operations/DisbursementEntries.md](map/operations/DisbursementEntries.md) |
| `DisbursementResults` | 2 | [map/operations/DisbursementResults.md](map/operations/DisbursementResults.md) |
| `Disbursements` | 2 | [map/operations/Disbursements.md](map/operations/Disbursements.md) |
| `EmbeddedFinance` | 2 | [map/operations/EmbeddedFinance.md](map/operations/EmbeddedFinance.md) |
| `Entities` | 6 | [map/operations/Entities.md](map/operations/Entities.md) |
| `EntitiesCustomFields` | 5 | [map/operations/EntitiesCustomFields.md](map/operations/EntitiesCustomFields.md) |
| `EntityDebts` | 2 | [map/operations/EntityDebts.md](map/operations/EntityDebts.md) |
| `EntityReturns` | 2 | [map/operations/EntityReturns.md](map/operations/EntityReturns.md) |
| `EntityTerms` | 3 | [map/operations/EntityTerms.md](map/operations/EntityTerms.md) |
| `EntityData` | 3 | [map/operations/EntityData.md](map/operations/EntityData.md) |
| `Entries` | 2 | [map/operations/Entries.md](map/operations/Entries.md) |
| `EntryOrigin` | 2 | [map/operations/EntryOrigin.md](map/operations/EntryOrigin.md) |
| `FraudSightEnablements` | 2 | [map/operations/FraudSightEnablements.md](map/operations/FraudSightEnablements.md) |
| `FraudSightResults` | 2 | [map/operations/FraudSightResults.md](map/operations/FraudSightResults.md) |
| `FundOrigins` | 2 | [map/operations/FundOrigins.md](map/operations/FundOrigins.md) |
| `Funds` | 2 | [map/operations/Funds.md](map/operations/Funds.md) |
| `HostThemes` | 2 | [map/operations/HostThemes.md](map/operations/HostThemes.md) |
| `IpAddressLists` | 5 | [map/operations/IpAddressLists.md](map/operations/IpAddressLists.md) |
| `InvoiceItems` | 5 | [map/operations/InvoiceItems.md](map/operations/InvoiceItems.md) |
| `InvoiceLineItems` | 5 | [map/operations/InvoiceLineItems.md](map/operations/InvoiceLineItems.md) |
| `InvoiceParameters` | 5 | [map/operations/InvoiceParameters.md](map/operations/InvoiceParameters.md) |
| `InvoiceResults` | 3 | [map/operations/InvoiceResults.md](map/operations/InvoiceResults.md) |
| `Invoices` | 5 | [map/operations/Invoices.md](map/operations/Invoices.md) |
| `Logins` | 5 | [map/operations/Logins.md](map/operations/Logins.md) |
| `LoginsHelpers` | 3 | [map/operations/LoginsHelpers.md](map/operations/LoginsHelpers.md) |
| `Mappings` | 5 | [map/operations/Mappings.md](map/operations/Mappings.md) |
| `Members` | 5 | [map/operations/Members.md](map/operations/Members.md) |
| `MerchantPlatformStatuses` | 2 | [map/operations/MerchantPlatformStatuses.md](map/operations/MerchantPlatformStatuses.md) |
| `MerchantResults` | 2 | [map/operations/MerchantResults.md](map/operations/MerchantResults.md) |
| `Merchants` | 3 | [map/operations/Merchants.md](map/operations/Merchants.md) |
| `MessageThreads` | 3 | [map/operations/MessageThreads.md](map/operations/MessageThreads.md) |
| `Messages` | 4 | [map/operations/Messages.md](map/operations/Messages.md) |
| `NoteDocuments` | 5 | [map/operations/NoteDocuments.md](map/operations/NoteDocuments.md) |
| `Notes` | 5 | [map/operations/Notes.md](map/operations/Notes.md) |
| `OmniTokens` | 2 | [map/operations/OmniTokens.md](map/operations/OmniTokens.md) |
| `OptOuts` | 1 | [map/operations/OptOuts.md](map/operations/OptOuts.md) |
| `OrgEntities` | 5 | [map/operations/OrgEntities.md](map/operations/OrgEntities.md) |
| `OrgFlowRules` | 5 | [map/operations/OrgFlowRules.md](map/operations/OrgFlowRules.md) |
| `Orgs` | 5 | [map/operations/Orgs.md](map/operations/Orgs.md) |
| `OrgsVasRevenueBoosts` | 2 | [map/operations/OrgsVasRevenueBoosts.md](map/operations/OrgsVasRevenueBoosts.md) |
| `PaymentUpdateGroups` | 2 | [map/operations/PaymentUpdateGroups.md](map/operations/PaymentUpdateGroups.md) |
| `PaymentUpdates` | 2 | [map/operations/PaymentUpdates.md](map/operations/PaymentUpdates.md) |
| `Payouts` | 5 | [map/operations/Payouts.md](map/operations/Payouts.md) |
| `PendingEntryApi` | 2 | [map/operations/PendingEntryApi.md](map/operations/PendingEntryApi.md) |
| `PinlessDebitConversions` | 2 | [map/operations/PinlessDebitConversions.md](map/operations/PinlessDebitConversions.md) |
| `Plans` | 5 | [map/operations/Plans.md](map/operations/Plans.md) |
| `ProfitShareResults` | 2 | [map/operations/ProfitShareResults.md](map/operations/ProfitShareResults.md) |
| `RevShareSchedules` | 5 | [map/operations/RevShareSchedules.md](map/operations/RevShareSchedules.md) |
| `RevShareStatements` | 2 | [map/operations/RevShareStatements.md](map/operations/RevShareStatements.md) |
| `RevenueBoosts` | 2 | [map/operations/RevenueBoosts.md](map/operations/RevenueBoosts.md) |
| `SaferPayments` | 2 | [map/operations/SaferPayments.md](map/operations/SaferPayments.md) |
| `Secrets` | 5 | [map/operations/Secrets.md](map/operations/Secrets.md) |
| `Sessions` | 4 | [map/operations/Sessions.md](map/operations/Sessions.md) |
| `StatementEntry` | 2 | [map/operations/StatementEntry.md](map/operations/StatementEntry.md) |
| `Statements` | 2 | [map/operations/Statements.md](map/operations/Statements.md) |
| `SubscriptionTokens` | 5 | [map/operations/SubscriptionTokens.md](map/operations/SubscriptionTokens.md) |
| `Subscriptions` | 5 | [map/operations/Subscriptions.md](map/operations/Subscriptions.md) |
| `TaxFormRequests` | 3 | [map/operations/TaxFormRequests.md](map/operations/TaxFormRequests.md) |
| `TeamLogins` | 5 | [map/operations/TeamLogins.md](map/operations/TeamLogins.md) |
| `Teams` | 5 | [map/operations/Teams.md](map/operations/Teams.md) |
| `TerminalTransactionReference` | 1 | [map/operations/TerminalTransactionReference.md](map/operations/TerminalTransactionReference.md) |
| `TerminalTransactionResults` | 2 | [map/operations/TerminalTransactionResults.md](map/operations/TerminalTransactionResults.md) |
| `TerminalTransactions` | 5 | [map/operations/TerminalTransactions.md](map/operations/TerminalTransactions.md) |
| `TerminalTransactionsDatas` | 3 | [map/operations/TerminalTransactionsDatas.md](map/operations/TerminalTransactionsDatas.md) |
| `TerminalTransactionsMetadatas` | 3 | [map/operations/TerminalTransactionsMetadatas.md](map/operations/TerminalTransactionsMetadatas.md) |
| `Terminals` | 5 | [map/operations/Terminals.md](map/operations/Terminals.md) |
| `TokenResults` | 2 | [map/operations/TokenResults.md](map/operations/TokenResults.md) |
| `Tokens` | 5 | [map/operations/Tokens.md](map/operations/Tokens.md) |
| `TransactionDatas` | 3 | [map/operations/TransactionDatas.md](map/operations/TransactionDatas.md) |
| `TransactionHolds` | 4 | [map/operations/TransactionHolds.md](map/operations/TransactionHolds.md) |
| `TransactionItems` | 5 | [map/operations/TransactionItems.md](map/operations/TransactionItems.md) |
| `TransactionMetadatas` | 2 | [map/operations/TransactionMetadatas.md](map/operations/TransactionMetadatas.md) |
| `TransactionsTxns` | 4 | [map/operations/TransactionsTxns.md](map/operations/TransactionsTxns.md) |
| `TransactionsResults` | 2 | [map/operations/TransactionsResults.md](map/operations/TransactionsResults.md) |
| `TxnSessions` | 4 | [map/operations/TxnSessions.md](map/operations/TxnSessions.md) |
| `VasEfeOffers` | 2 | [map/operations/VasEfeOffers.md](map/operations/VasEfeOffers.md) |
| `ValueAddedServices` | 1 | [map/operations/ValueAddedServices.md](map/operations/ValueAddedServices.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `Models/`, `Errors/` and `Requests/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 781 | `Models/` |
| Unions (`AnyOf`) — variant factories + `TryGet…` | 410 | `Models/AnyOf/` |
| Enums (`OpenStringEnum<T>` / `OpenIntEnum<T>`) — C# member names + wire values | 750 | `Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 361 | `Errors/` |
| Request records (one per operation that takes input; never serialized) | 361 | `Requests/` — a controller's records sit in a folder named after it (an operation with several tags is filed under the first tag it declares) |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — use the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`); there is no public factory, so resolve a raw value with `TryGetKnownValue` and branch with the generated `Match`, whose `otherwise` arm receives any value the SDK does not declare.

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `Payrix` |
| Operation controllers (`Api/`) | `Payrix.Api` |
| Records (`Models/`) | `Payrix.Models` |
| Enums (`Models/Enums/`) | `Payrix.Models.Enums` |
| AnyOf unions (`Models/AnyOf/`) | `Payrix.Models.AnyOf` |
| Error classes (`Errors/`) | `Payrix.Errors` |
| Request records (`Requests/`) | `Payrix.Requests` — plus `.<Controller>` for a controller's records (an operation with several tags is filed under the first tag it declares) |

---

## Servers & auth

**API key (header `APIKEY`).** Set `options.ApiKey = "<api_key>"`; sent as the `APIKEY` request header.

**API key (header `SESSIONKEY`).** Set `options.SessionKey = "<api_key>"`; sent as the `SESSIONKEY` request header.

**API key (header `TXNSESSIONKEY`).** Set `options.TxnSessionKey = "<api_key>"`; sent as the `TXNSESSIONKEY` request header.

**API key (header `USERNAME`).** Set `options.Username = "<api_key>"`; sent as the `USERNAME` request header.

**API key (header `PASSWORD`).** Set `options.Password = "<api_key>"`; sent as the `PASSWORD` request header.

Operation blocks name their credential in an **Auth** bullet; an operation whose spec declares no scheme carries no such bullet.

- `AND` — every credential listed must be set for the call to be fully authenticated.
- `OR` — the first credential you set that applies successfully is the one sent, in the order listed.

A credential you never set is skipped rather than throwing, and the request is sent anyway — so an authentication failure can mean no credential was sent rather than a bad one. Under `OR`, if every credential you did set fails to apply, `AuthSchemeException` is thrown.

**Environments.** `options.Environment` selects the target environment (`Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `production` | — |
| `ServerEnvironment.Environment2` | `environment2` | — |
| `ServerEnvironment.Environment3` | `environment3` | — |

**1 server group.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | `Environment2` base URL | `Environment3` base URL | Override point |
| --- | --- | --- | --- | --- |
| `Default` | `https://test-api.payrix.com` | `https://test-api.payrixcanada.com` | `{serverUrl}` | `options.Server.Default.Production.BaseUrl` (and the other environments) |

`Default` · `Environment3` template variables: `{serverUrl}` defaults to `"https://custom.payrix.com"` — override `options.Server.Default.Environment3.ServerUrl`.

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

