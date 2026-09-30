using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record LoginsPostRequest
{
    /// <summary>
    /// The parent user that owns this user. Defaults to authenticated user’s ID if no value is explicitly set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The partition that this Login is associated with. The partition association opens access to partition-level administrators on this user and all records owned by this user. Defaults to authenticated user’s partition if no value is explicitly set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public DivisionsPostRequest? Division { get; init; }

    /// <summary>
    /// The parent division that this Login belongs to. Children of this Login will inherit its parent division. The parentDivision association may be used for whitelabeling the user experience for parent divisions that have implemented a whitelabel solution (as long as the child division that the user is associated with has not implemented their own). Defaults to authenticated user’s parentDivision if no value is explicitly set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parentDivision")]
    public string? ParentDivision { get; init; }

    /// <summary>
    /// The roles associated with this Login, specified as an integer. &lt;details&gt; &lt;summary&gt;Single Roles- Valid Values&lt;/summary&gt; &lt;ul&gt; &lt;li&gt;&lt;code&gt;16&lt;/code&gt; - Entity&lt;/li&gt; &lt;li&gt;&lt;code&gt;64&lt;/code&gt; - Vendor&lt;/li&gt; &lt;li&gt;&lt;code&gt;128&lt;/code&gt; - Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;256&lt;/code&gt; - Create Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;512&lt;/code&gt; - Password&lt;/li&gt; &lt;li&gt;&lt;code&gt;1024&lt;/code&gt; - Log&lt;/li&gt; &lt;li&gt;&lt;code&gt;2048&lt;/code&gt; - Unfreeze&lt;/li&gt; &lt;li&gt;&lt;code&gt;4096&lt;/code&gt; - Modify Roles&lt;/li&gt; &lt;li&gt;&lt;code&gt;8192&lt;/code&gt; - Payment IDs&lt;/li&gt; &lt;li&gt;&lt;code&gt;65536&lt;/code&gt; - MCC&lt;/li&gt; &lt;li&gt;&lt;code&gt;131072&lt;/code&gt; - TXN Report&lt;/li&gt; &lt;li&gt;&lt;code&gt;262144&lt;/code&gt; - Disbursement&lt;/li&gt; &lt;li&gt;&lt;code&gt;524288&lt;/code&gt; - Fund Reserve&lt;/li&gt; &lt;li&gt;&lt;code&gt;1048576&lt;/code&gt; - Platform Refs&lt;/li&gt; &lt;li&gt;&lt;code&gt;2097152&lt;/code&gt; - Verification&lt;/li&gt; &lt;li&gt;&lt;code&gt;4194304&lt;/code&gt; - Fee&lt;/li&gt; &lt;li&gt;&lt;code&gt;8388608&lt;/code&gt; - Challenge&lt;/li&gt; &lt;li&gt;&lt;code&gt;16777216&lt;/code&gt; - Reserve TXN&lt;/li&gt; &lt;li&gt;&lt;code&gt;33554432&lt;/code&gt; - Set Boarded&lt;/li&gt; &lt;li&gt;&lt;code&gt;67108864&lt;/code&gt; - Assessment&lt;/li&gt; &lt;li&gt;&lt;code&gt;134217728&lt;/code&gt; - Adjustment&lt;/li&gt; &lt;li&gt;&lt;code&gt;268435456&lt;/code&gt; - Merchant Flow&lt;/li&gt; &lt;li&gt;&lt;code&gt;1073741824&lt;/code&gt; - Confirm Email&lt;/li&gt; &lt;li&gt;&lt;code&gt;2147483648&lt;/code&gt; - TIN Status&lt;/li&gt; &lt;li&gt;&lt;code&gt;4294967296&lt;/code&gt; - Entity Route&lt;/li&gt; &lt;li&gt;&lt;code&gt;8589934592&lt;/code&gt; - Files&lt;/li&gt; &lt;li&gt;&lt;code&gt;17179869184&lt;/code&gt; - Unmask Private&lt;/li&gt; &lt;li&gt;&lt;code&gt;34359738368&lt;/code&gt; - Unmask Bank&lt;/li&gt; &lt;li&gt;&lt;code&gt;68719476736&lt;/code&gt; - Thread Create&lt;/li&gt; &lt;li&gt;&lt;code&gt;137438953472&lt;/code&gt; - BIN Query&lt;/li&gt; &lt;li&gt;&lt;code&gt;274877906944&lt;/code&gt; - BIN Change&lt;/li&gt; &lt;li&gt;&lt;code&gt;1099511627776&lt;/code&gt; - Assessment View&lt;/li&gt; &lt;li&gt;&lt;code&gt;17592186044416&lt;/code&gt; - Entity Return&lt;/li&gt; &lt;li&gt;&lt;code&gt;70368744177664&lt;/code&gt; - Watchlist&lt;/li&gt; &lt;li&gt;&lt;code&gt;140737488355328&lt;/code&gt; - Profit Share&lt;/li&gt; &lt;li&gt;&lt;code&gt;281474976710656&lt;/code&gt; - MFA&lt;/li&gt; &lt;/ul&gt; &lt;/details&gt; &lt;details&gt; &lt;summary&gt;Multi-Roles- Valid Values&lt;/summary&gt; &lt;ul&gt; &lt;li&gt;&lt;code&gt;144&lt;/code&gt; - Entity, Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;192&lt;/code&gt; - Vendor, Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;208&lt;/code&gt; - Entity, Vendor, Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;320&lt;/code&gt; - Vendor, Create Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;384&lt;/code&gt; - Merchant, Create Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;400&lt;/code&gt; - Entity, Merchant, Create Merchant&lt;/li&gt; &lt;li&gt;&lt;code&gt;131136&lt;/code&gt; - Vendor, TXN Report&lt;/li&gt; &lt;li&gt;&lt;code&gt;131200&lt;/code&gt; - Merchant, TXN Report&lt;/li&gt; &lt;li&gt;&lt;code&gt;131456&lt;/code&gt; - Merchant, Create Merchant, TXN Report&lt;/li&gt; &lt;li&gt;&lt;code&gt;1048640&lt;/code&gt; - Vendor, Platform Refs&lt;/li&gt; &lt;li&gt;&lt;code&gt;1048704&lt;/code&gt; - Merchant, Platform Refs&lt;/li&gt; &lt;li&gt;&lt;code&gt;1048768&lt;/code&gt; - Vendor, Merchant, Platform Refs&lt;/li&gt; &lt;li&gt;&lt;code&gt;2097216&lt;/code&gt; - Vendor, Verification&lt;/li&gt; &lt;li&gt;&lt;code&gt;4194368&lt;/code&gt; - Vendor, Fee&lt;/li&gt; &lt;li&gt;&lt;code&gt;4194384&lt;/code&gt; - Entity, Vendor, Fee&lt;/li&gt; &lt;li&gt;&lt;code&gt;134217792&lt;/code&gt; - Vendor, Adjustment&lt;/li&gt; &lt;li&gt;&lt;code&gt;268435584&lt;/code&gt; - Merchant, Merchant Flow&lt;/li&gt; &lt;li&gt;&lt;code&gt;272630160&lt;/code&gt; - Entity, Merchant, Create Merchant, Fee, Merchant Flow&lt;/li&gt; &lt;li&gt;&lt;code&gt;272630224&lt;/code&gt; - Entity, Vendor, Merchant, Create Merchant, Fee, Merchant Flow&lt;/li&gt; &lt;li&gt;&lt;code&gt;273154512&lt;/code&gt; - Entity, Vendor, Merchant, Create Merchant, Fund Reserve, Fee, Merchant Flow&lt;/li&gt; &lt;li&gt;&lt;code&gt;1099511627840&lt;/code&gt; - Vendor, Assessment View&lt;/li&gt; &lt;li&gt;&lt;code&gt;1099511758912&lt;/code&gt; - Vendor, TXN Report, Assessment View&lt;/li&gt; &lt;/ul&gt; &lt;/details&gt;
    /// </summary>
    [JsonPropertyName("roles")]
    public long? Roles { get; init; } = 0L;

    /// <summary>
    /// The username associated with this Login.
    /// This field is stored as a text string, all lowercase, and must be between 0 and 50 characters long.
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; init; }

    /// <summary>
    /// The password associated with this Login.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; init; }

    /// <summary>
    /// The first name associated with this Login.
    /// </summary>
    [JsonPropertyName("first")]
    public required string First { get; init; }

    /// <summary>
    /// The middle name associated with this Login.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middle")]
    public string? Middle { get; init; }

    /// <summary>
    /// The last name associated with this Login.
    /// </summary>
    [JsonPropertyName("last")]
    public required string Last { get; init; }

    /// <summary>
    /// The email address associated with this Login.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The allowedResources field specifies the actions and resources a user can access. The JSON structure includes action keys (create, update, read, delete, totals) and lists of resources (e.g., logins, apikeys, sessions). Omitted action keys indicate no access for those actions. &lt;details&gt; &lt;summary&gt;Instructions&lt;/summary&gt; In addition to the roles for this login, you can specify API functionality by creating a JSON object as the value for this field using with data arrays titled: &lt;code&gt;”create”: []&lt;/code&gt;, &lt;code&gt;”read”: []&lt;/code&gt;, &lt;code&gt;”update”: []&lt;/code&gt;, &lt;code&gt;”delete”: []&lt;/code&gt;, and &lt;code&gt;”totals”: []&lt;/code&gt; for their API CRUD functions &lt;code&gt;POST&lt;/code&gt;, &lt;code&gt;GET&lt;/code&gt;, &lt;code&gt;PUT&lt;/code&gt;, &lt;code&gt;DELETE&lt;/code&gt; with the &lt;code&gt;totals&lt;/code&gt; array setting users ability to calculate and report on disbursements, funds, and other monetary totals relevant to the specified endpoint resources. Add the names of each endpoint resource separated by a comma (&lt;code&gt;,&lt;/code&gt;) for which you want to provide functionality.
    /// For example, &lt;code&gt;{ "create": ["payouts"] }&lt;/code&gt; allows this login to create payout transactions using the &lt;code&gt;POST /payouts&lt;/code&gt; API request method.
    /// &lt;ul&gt; &lt;li&gt;&lt;strong&gt;Note:&lt;/strong&gt; Resources are case sensitive. Our API uses &lt;a href="https://en.wikipedia.org/wiki/Camel_case"&gt;camelCase&lt;/a&gt;. If you are unsure of formatting, refer to the API specification to copy the exact endpoint title without the initial forward slash ( / ) for the relevant allowedResources or restrictedResources arrays.&lt;/li&gt; &lt;/ul&gt;
    /// &lt;/details&gt;
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedResources")]
    public string? AllowedResources { get; init; }

    /// <summary>
    /// The restrictedResources field defines the actions and resources a user is restricted from accessing. The JSON structure includes action keys (create, update, read, delete, totals) and lists of resources (e.g., logins, apikeys, sessions). Omitted action keys indicate no restrictions for those actions. &lt;details&gt; &lt;summary&gt;Instructions&lt;/summary&gt; In addition to the roles for this login, you can specify API functionality by creating a JSON object as the value for this field using with data arrays titled: &lt;code&gt;”create”: []&lt;/code&gt;, &lt;code&gt;”read”: []&lt;/code&gt;, &lt;code&gt;”update”: []&lt;/code&gt;, &lt;code&gt;”delete”: []&lt;/code&gt;, and &lt;code&gt;”totals”: []&lt;/code&gt; for their API CRUD functions &lt;code&gt;POST&lt;/code&gt;, &lt;code&gt;GET&lt;/code&gt;, &lt;code&gt;PUT&lt;/code&gt;, &lt;code&gt;DELETE&lt;/code&gt; with the &lt;code&gt;totals&lt;/code&gt; array setting users ability to calculate and report on disbursements, funds, and other monetary totals relevant to the specified endpoint resources. Add the names of each endpoint resource separated by a comma (&lt;code&gt;,&lt;/code&gt;) for which you want to provide functionality.
    /// For example, &lt;code&gt;{ "create": ["payouts"] }&lt;/code&gt; allows this login to create payout transactions using the &lt;code&gt;POST /payouts&lt;/code&gt; API request method.
    /// &lt;ul&gt; &lt;li&gt;&lt;strong&gt;Note:&lt;/strong&gt; Resources are case sensitive. Our API uses &lt;a href="https://en.wikipedia.org/wiki/Camel_case"&gt;camelCase&lt;/a&gt;. If you are unsure of formatting, refer to the API specification to copy the exact endpoint title without the initial forward slash ( / ) for the relevant allowedResources or restrictedResources arrays.&lt;/li&gt; &lt;/ul&gt;
    /// &lt;/details&gt;
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restrictedResources")]
    public string? RestrictedResources { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("portalAccess")]
    public LoginsPortalAccess1? PortalAccess { get; init; }

    [JsonPropertyName("mfaEnabled")]
    public required LoginsMfaEnabled1 MfaEnabled { get; init; }

    /// <summary>
    /// The MFA secret key used to link the MFA device with this Login.
    /// This field is stored as a text string and must be between 1 and 128 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mfaSecret")]
    public string? MfaSecret { get; init; }

    /// <summary>
    /// The datetimestamp when this Login was enabled for MFA.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mfaEnrolledDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}")]
    public string? MfaEnrolledDate { get; init; }

    /// <summary>
    /// The Type of the MFA enrolled.
    /// This field is stored as a text string and must be between 1 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mfaType")]
    public string? MfaType { get; init; }

    /// <summary>
    /// The first line of the address associated with this Login.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    public string? Address1 { get; init; }

    /// <summary>
    /// The second line of the address associated with this Login.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    public string? Address2 { get; init; }

    /// <summary>
    /// The name of the city in the address associated with this Login.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The U.S. state or Canadian province relevant to the address provided here. If the location is within the U.S. and Canada, specify the 2-character postal abbreviation for the state. If the location is outside of the U.S. and Canada, provide the full state name. This field is stored as a text string and must be between 2 and 100 characters long.
    /// <para>
    ///
    /// &lt;details&gt;
    /// &lt;summary&gt;U.S. States&lt;/summary&gt;
    ///
    ///  - <c>AK</c> - <b>Alaska (US)</b>
    ///
    ///  - <c>AR</c> - <b>Arkansas (US)</b>
    ///
    ///  - <c>AL</c> - <b>Alabama (US)</b>
    ///
    ///  - <c>AZ</c> - <b>Arizona (US)</b>
    ///
    ///  - <c>CA</c> - <b>California (US)</b>
    ///
    ///  - <c>CO</c> - <b>Colorado (US)</b>
    ///
    ///  - <c>CT</c> - <b>Connecticut (US)</b>
    ///
    ///  - <c>DE</c> - <b>Delaware (US)</b>
    ///
    ///  - <c>FL</c> - <b>Florida (US)</b>
    ///
    ///  - <c>GA</c> - <b>Georgia (US)</b>
    ///
    ///  - <c>HI</c> - <b>Hawaii (US)</b>
    ///
    ///  - <c>IA</c> - <b>Iowa (US)</b>
    ///
    ///  - <c>ID</c> - <b>Idaho (US)</b>
    ///
    ///  - <c>IL</c> - <b>Illinois (US)</b>
    ///
    ///  - <c>IN</c> - <b>Indiana (US)</b>
    ///
    ///  - <c>KY</c> - <b>Kentucky (US)</b>
    ///
    ///  - <c>KS</c> - <b>Kansas (US)</b>
    ///
    ///  - <c>LA</c> - <b>Louisiana (US)</b>
    ///
    ///  - <c>MA</c> - <b>Massachusetts (US)</b>
    ///
    ///  - <c>MD</c> - <b>Maryland (US)</b>
    ///
    ///  - <c>ME</c> - <b>Maine (US)</b>
    ///
    ///  - <c>MI</c> - <b>Michigan (US)</b>
    ///
    ///  - <c>MN</c> - <b>Minnesota (US)</b>
    ///
    ///  - <c>MO</c> - <b>Missouri (US)</b>
    ///
    ///  - <c>MS</c> - <b>Mississippi (US)</b>
    ///
    ///  - <c>MT</c> - <b>Montana (US)</b>
    ///
    ///  - <c>NC</c> - <b>North Carolina (US)</b>
    ///
    ///  - <c>ND</c> - <b>North Dakota (US)</b>
    ///
    ///  - <c>NE</c> - <b>Nebraska (US)</b>
    ///
    ///  - <c>NH</c> - <b>New Hampshire (US)</b>
    ///
    ///  - <c>NJ</c> - <b>New Jersey (US)</b>
    ///
    ///  - <c>NM</c> - <b>New Mexico (US)</b>
    ///
    ///  - <c>NV</c> - <b>Nevada (US)</b>
    ///
    ///  - <c>NY</c> - <b>New York (US)</b>
    ///
    ///  - <c>OH</c> - <b>Ohio (US)</b>
    ///
    ///  - <c>OK</c>- <b>Oklahoma (US)</b>
    ///
    ///  - <c>OR</c> - <b>Oregon (US)</b>
    ///
    ///  - <c>PA</c> - <b>Pennsylvania (US)</b>
    ///
    ///  - <c>RI</c> - <b>Rhode Island (US)</b>
    ///
    ///  - <c>SC</c>- <b>South Carolina (US)</b>
    ///
    ///  - <c>SD</c> - <b>South Dakota (US)</b>
    ///
    ///  - <c>TN</c> - <b>Tennessee (US)</b>
    ///
    ///  - <c>TX</c> - <b>Texas (US)</b>
    ///
    ///  - <c>UT</c> - <b>Utah (US)</b>
    ///
    ///  - <c>VA</c> - <b>Virginia (US)</b>
    ///
    ///  - <c>VT</c> - <b>Vermont (US)</b>
    ///
    ///  - <c>WA</c> - <b>Washington (US)</b>
    ///
    ///  - <c>WI</c> - <b>Wisconsin (US)</b>
    ///
    ///  - <c>WV</c> - <b>West Virginia (US)</b>
    ///
    ///  - <c>WY</c> - <b>Wyoming (US)</b>
    ///  &lt;/details&gt;
    /// </para>
    /// <para>
    ///
    /// </para>
    /// <para>
    ///  &lt;details&gt;
    /// &lt;summary&gt;Canada Provinces and Territories&lt;/summary&gt;
    ///
    ///  - <c>AB</c> - <b>Alberta (CAN)</b>
    ///
    ///  - <c>BC</c> - <b>British Columbia (CAN)</b>
    ///
    ///  - <c>MB</c> - <b>Manitoba (CAN)</b>
    ///
    ///  - <c>ON</c> - <b>Ontario (CAN)</b>
    ///
    ///  - <c>NS</c> - <b>Nova Scotia (CAN)</b>
    ///
    ///  - <c>NB</c> - <b>New Brunswick (CAN)</b>
    ///
    ///  - <c>NL</c> - <b>Newfoundland and Labrador (CAN)</b>
    ///
    ///  - <c>NT</c> - <b>Northwest Territories (CAN)</b>
    ///
    ///  - <c>NU</c> - <b>Nunavut (CAN)</b>
    ///
    ///  - <c>PE</c> - <b>Prince Edward Island (CAN)</b>
    ///
    ///  - <c>QC</c> - <b>Quebec (CAN)</b>
    ///
    ///  - <c>SK</c> - <b>Saskatchewan (CAN)</b>
    ///
    ///  - <c>YT</c> - <b>Yukon (CAN)</b>
    ///  &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// The ZIP code in the address associated with this Login.
    /// This field is stored as a text string and must be between 1 and 20 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip")]
    public string? Zip { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Country175? Country { get; init; }

    /// <summary>
    /// The phone number associated with this Login.
    /// This field is stored as a text string and must be between 10 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

    /// <summary>
    /// The fax number associated with this Login.
    /// This field is stored as a text string and must be between 10 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fax")]
    public string? Fax { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregations")]
    public IReadOnlyList<AggregationsPostRequest>? Aggregations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customers")]
    public IReadOnlyList<CustomersPostRequest>? Customers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billings")]
    public IReadOnlyList<BillingsPostRequest>? Billings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("divisions")]
    public IReadOnlyList<DivisionsPostRequest>? Divisions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entities")]
    public IReadOnlyList<EntitiesPostRequest>? Entities { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceParameters")]
    public IReadOnlyList<InvoiceParametersPostRequest>? InvoiceParameters { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageThreads")]
    public IReadOnlyList<MessageThreadsPostRequest>? MessageThreads { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public IReadOnlyList<NotesPostRequest>? Notes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orgFlows")]
    public IReadOnlyList<OrgFlowsPostRequest>? OrgFlows { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orgFlowsforlogin")]
    public IReadOnlyList<OrgFlowsPostRequest>? OrgFlowsforlogin { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profitShares")]
    public IReadOnlyList<ProfitSharesPostRequest>? ProfitShares { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("teamLogins")]
    public IReadOnlyList<TeamLoginPostRequest>? TeamLogins { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("teams")]
    public IReadOnlyList<TeamsPostRequest>? Teams { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
