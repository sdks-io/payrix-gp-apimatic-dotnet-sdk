using Payrix.Models.Enums;

namespace Payrix.Requests.Entities;

/// <summary>
/// The inputs of the GetEntitiesIdNextPayout operation.
/// </summary>
public sealed record GetEntitiesIdNextPayoutRequest
{
    /// <summary>
    /// The ID of the entity to retrieve the next Payout for.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Determines whether one-off Payouts are considered when the next Payout is selected.
    /// Set this field to '1' to exclude Payouts with a 'schedule' of '5' (Single). Set this field to '0', or omit it, to include them.
    /// </summary>
    public ExcludeSingle1? ExcludeSingle { get; init; }

    /// <summary>
    /// A single-use, limited authentication layer in addition to an API Key or Session Key to authorize sensitive operations. &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/auth-tokens" target="_blank"&gt;Auth Tokens&lt;/a&gt; add security by requiring one-time approval for specific actions.
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// A custom, one-time identifier for any API request (GET, PUT, POST, or DELETE). Blocks future requests with the same token for 48 hours, ensuring only the first request is processed. Valid values can contain 1-100 alphanumeric and special characters. See &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/request-tokens" target="_blank"&gt;Request Tokens&lt;/a&gt;  for more information.
    /// </summary>
    public string? RequestToken { get; init; }
}
