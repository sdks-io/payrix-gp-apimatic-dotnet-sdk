namespace Payrix.Requests.ConfirmationCodes;

/// <summary>
/// The inputs of the GetConfirmCodesId operation.
/// </summary>
public sealed record GetConfirmCodesIdRequest
{
    /// <summary>
    /// The ID of this resource and The Confirmation Code ID.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Use the embed query parameter to include full object(s) of related resource(s) directly within the API response. This allows retrieval of associated resources in a single request, reducing the need for multiple round-trips.
    /// Format: GET https://{server}.payrix.com/{endpoint}?embed={relatedObject}
    /// </summary>
    public string? Embed { get; init; }

    /// <summary>
    /// A single-use, limited authentication layer in addition to an API Key or Session Key to authorize sensitive operations. &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/auth-tokens" target="_blank"&gt;Auth Tokens&lt;/a&gt; add security by requiring one-time approval for specific actions.
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// A custom, one-time identifier for any API request (GET, PUT, POST, or DELETE). Blocks future requests with the same token for 48 hours, ensuring only the first request is processed. Valid values can contain 1-100 alphanumeric and special characters. See &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/request-tokens" target="_blank"&gt;Request Tokens&lt;/a&gt;  for more information.
    /// </summary>
    public string? RequestToken { get; init; }

    /// <summary>
    /// Set this header to filter or sort the list of resources that the method returns.
    /// See <see href="https://docs.worldpay.com/apis/payrix/api-specification/payrix/partner#/rest/welcome-to-payrix-pro/welcome-to-payrix-pro">Searches</see> for detailed information and examples on how to use search header.
    /// </summary>
    public string? Search { get; init; }
}
