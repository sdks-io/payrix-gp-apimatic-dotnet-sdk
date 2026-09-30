using Payrix.Models;
using Payrix.Models.Enums;

namespace Payrix.Requests.OptOuts;

/// <summary>
/// The inputs of the PostOptouts operation.
/// </summary>
public sealed record PostOptoutsRequest
{
    /// <summary>
    /// The Value Added Service to opt out from. Currently only 'FraudSight' is supported.
    /// </summary>
    public required VasOptOutService1 Service { get; init; }

    /// <summary>
    /// The type of entity to opt out. Must be either 'merchant' or 'entity'.
    /// </summary>
    public required VasOptOutTargetType1 Target { get; init; }

    /// <summary>
    /// The ID of the merchant or entity to opt out from the service.
    /// </summary>
    public required string TargetId { get; init; }

    /// <summary>
    /// A single-use, limited authentication layer in addition to an API Key or Session Key to authorize sensitive operations. &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/auth-tokens" target="_blank"&gt;Auth Tokens&lt;/a&gt; add security by requiring one-time approval for specific actions.
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// A custom, one-time identifier for any API request (GET, PUT, POST, or DELETE). Blocks future requests with the same token for 48 hours, ensuring only the first request is processed. Valid values can contain 1-100 alphanumeric and special characters. See &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/request-tokens" target="_blank"&gt;Request Tokens&lt;/a&gt;  for more information.
    /// </summary>
    public string? RequestToken { get; init; }

    /// <summary>
    /// Request body for opting out a merchant or entity from a VAS
    /// </summary>
    public required VasOptOutPostRequestModel Body { get; init; }
}
