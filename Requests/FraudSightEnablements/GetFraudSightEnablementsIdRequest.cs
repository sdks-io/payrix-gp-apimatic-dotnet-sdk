namespace Payrix.Requests.FraudSightEnablements;

/// <summary>
/// The inputs of the GetFraudSightEnablementsId operation.
/// </summary>
public sealed record GetFraudSightEnablementsIdRequest
{
    /// <summary>
    /// The ID of this Fraud Sight Enablements.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Use the embed query parameter to include full object(s) of related resource(s) directly within the API response. This allows retrieval of associated resources in a single request, reducing the need for multiple round-trips.
    /// Format: GET https://{server}.payrix.com/{endpoint}?embed={relatedObject}
    /// </summary>
    public string? Embed { get; init; }

    /// <summary>
    /// A custom, one-time identifier for any API request (GET, PUT, POST, or DELETE). Blocks future requests with the same token for 48 hours, ensuring only the first request is processed. Valid values can contain 1-100 alphanumeric and special characters. See &lt;a href="https://docs.worldpay.com/apis/payrix/dev-int-guide/references/authentication/request-tokens" target="_blank"&gt;Request Tokens&lt;/a&gt;  for more information.
    /// </summary>
    public string? RequestToken { get; init; }
}
