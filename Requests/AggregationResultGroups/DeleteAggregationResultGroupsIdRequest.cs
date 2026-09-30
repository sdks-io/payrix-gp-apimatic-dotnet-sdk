namespace Payrix.Requests.AggregationResultGroups;

/// <summary>
/// The inputs of the DeleteAggregationResultGroupsId operation.
/// </summary>
public sealed record DeleteAggregationResultGroupsIdRequest
{
    /// <summary>
    /// The ID of this resource or The Aggregation Result Group ID.
    /// </summary>
    public required string Id { get; init; }

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
    /// For example, to find all resources that have a property of 'public' set to '1', set this header to 'public[equals]=1'. You can use the operators 'equals', 'greater', 'less', 'like', 'in' and 'sort'. To sort the resources, use the keywords 'asc' (for an ascending sort) or 'desc' (for a descending sort).
    /// You may also use explicit 'and/or' querying by passing arrays of or and arrays of and parameters. For example, to find all resources that have a property of 'public' set to '1' or a property of 'active' set to '0', set this header to 'or[][public][equals]=1&amp;or[][active][equals]=0'.
    /// </summary>
    public string? SearchFilter { get; init; }
}
