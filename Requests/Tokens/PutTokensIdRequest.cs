using Payrix.Models;

namespace Payrix.Requests.Tokens;

/// <summary>
/// The inputs of the PutTokensId operation.
/// </summary>
public sealed record PutTokensIdRequest
{
    /// <summary>
    /// The ID of this Token.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// A single-use, limited authentication layer in addition to an API Key or Session Key to authorize sensitive operations. &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/auth-tokens" target="_blank"&gt;Auth Tokens&lt;/a&gt; add security by requiring one-time approval for specific actions.
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Update Token Request
    /// </summary>
    public required TokenPutRequest Body { get; init; }
}
