namespace Payrix.Requests.Aggregations;

/// <summary>
/// The inputs of the GetAggregations operation.
/// </summary>
public sealed record GetAggregationsRequest
{
    /// <summary>
    /// Set this path parameter to request a specific page of records.
    /// For example, set <c>?page[number]=2</c> to retrieve the second page of records for this request.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// Set this path parameter to request up to a specific amount of records. By default 30 records are retrieved per page. The maximum limit that can be set is 100.
    /// For example, set <c>?page[limit]=50</c> to retrieve up to 50 records for this request.
    /// </summary>
    public int? PageLimit { get; init; }

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
    /// For example, to find all resources that have a property of 'public' set to '1', set this header to 'public[equals]=1'. You can use the operators 'equals', 'greater', 'less', 'like', 'in' and 'sort'. To sort the resources, use the keywords 'asc' (for an ascending sort) or 'desc' (for a descending sort).
    /// You may also use explicit 'and/or' querying by passing arrays of or and arrays of and parameters. For example, to find all resources that have a property of 'public' set to '1' or a property of 'active' set to '0', set this header to 'or[][public][equals]=1&amp;or[][active][equals]=0'.
    /// </summary>
    public string? SearchFilter { get; init; }
}
