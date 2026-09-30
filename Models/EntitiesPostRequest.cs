using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record EntitiesPostRequest
{
    /// <summary>
    /// The client IP address from which the Entity was created. Valid values are any IPv4 or IPv6 address.
    /// </summary>
    [JsonPropertyName("clientIp")]
    public required string? ClientIp { get; init; }

    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    [JsonPropertyName("type")]
    public required EntityType1 Type { get; init; }

    /// <summary>
    /// The name of this Entity.
    /// This field is stored as a string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The display name of this Entity.
    /// This field is stored as a string and must be between 1 and 1,000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }

    /// <summary>
    /// The first line of the address associated with this Entity.
    /// This field is stored as a string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonPropertyName("address1")]
    public required string Address1 { get; init; }

    /// <summary>
    /// The second line of the address associated with this Entity.
    /// This field is stored as a string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    public string? Address2 { get; init; }

    /// <summary>
    /// The name of the city in the address associated with this Entity.
    /// This field is stored as a string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonPropertyName("city")]
    public required string City { get; init; }

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
    [JsonPropertyName("state")]
    public required string State { get; init; }

    /// <summary>
    /// The ZIP code in the address associated with this Entity.
    /// This field is stored as a text string and must be between 1 and 20 characters long.
    /// </summary>
    [JsonPropertyName("zip")]
    public required string Zip { get; init; }

    [JsonPropertyName("country")]
    public required EntityCountry1 Country { get; init; }

    [JsonPropertyName("timezone")]
    public required EntitiesTimezone1 Timezone { get; init; }

    /// <summary>
    /// The phone number associated with this Entity.
    /// This field is stored as a text string and must be between 5 and 15 characters long.
    /// </summary>
    [JsonPropertyName("phone")]
    public required string Phone { get; init; }

    /// <summary>
    /// The customer service phone number associated with this Entity. For Merchants, this number will be displayed on the customer's credit card statement.
    /// This field is stored as a text string and must be between 5 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerPhone")]
    public string? CustomerPhone { get; init; }

    /// <summary>
    /// The fax number associated with this Entity.
    /// This field is stored as a text string and must be between 5 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fax")]
    public string? Fax { get; init; }

    /// <summary>
    /// The email address associated with this Entity.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The web site URL associated with this Entity.
    /// This field is stored as a text string and must be between 0 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("website")]
    public string? Website { get; init; }

    /// <summary>
    /// The web sites URL associated with this Entity.
    /// This field is stored as a text string; must be between 0 and 1,000 characters long and separated by comma.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appleDomain")]
    public string? AppleDomain { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("einType")]
    public EntitiesEinType1? EinType { get; init; }

    /// <summary>
    /// The IRS Legal Filing Name. This must match what has been provided to the IRS when filing taxes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("irsFilingName")]
    public string? IrsFilingName { get; init; }

    /// <summary>
    /// The IRS Employer Identification Number (EIN) for the Entity.
    /// This field is stored as an integer and must be 9 characters long.
    /// </summary>
    [JsonPropertyName("ein")]
    public required string? Ein { get; init; }

    /// <summary>
    /// The number of locations at which this Entity does business.
    /// This field is stored as an integer and must be between 1 and 1,000,000 characters long.
    /// </summary>
    [JsonPropertyName("locations")]
    public int? Locations { get; init; } = 1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("public")]
    public EntitiesPublic1? Public { get; init; }

    /// <summary>
    /// An indicator showing the version of the terms and conditions that this Entity has accepted. The API indicates the version as a string.
    /// This field is stored as a text string and must be between 0 and 20 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tcVersion")]
    public string? TcVersion { get; init; }

    /// <summary>
    /// Date and time on which this Entity accepted the Terms and Conditions, if different than <c>tcDate</c>.
    /// The date is specified as a 12-digit string in YYYYMMDDHHII format, for example, <c>201601201528</c> for January 20, 2016, at 15:28 (3:28 PM).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tcAcceptDate")]
    public string? TcAcceptDate { get; init; }

    /// <summary>
    /// IP address from which this Entity accepted the Terms and Conditions, if different than <c>tcIp</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tcAcceptIp")]
    public string? TcAcceptIp { get; init; }

    /// <summary>
    /// Custom, free-form field for client-supplied text; must be between 0 and 1,000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom")]
    public string? Custom { get; init; }

    /// <summary>
    /// The secondary billing descriptor to appear on the bank statements for funds transfer for the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutSecondaryDescriptor")]
    public string? PayoutSecondaryDescriptor { get; init; }

    /// <summary>
    /// This field is stored as a text string and must be between 0 and 1,000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industry")]
    public string? Industry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("globalBusinessType")]
    public GlobalBusinessType1? GlobalBusinessType { get; init; }

    /// <summary>
    /// The business registration number for the entity.
    /// This field is stored as an alphanumeric and must be between 9 to 10 characters long
    /// </summary>
    [JsonPropertyName("globalBusinessId")]
    public required string? GlobalBusinessId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accounts")]
    public IReadOnlyList<AccountsPostRequest>? Accounts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billings")]
    public IReadOnlyList<BillingsPostRequest>? Billings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contacts")]
    public IReadOnlyList<ContactsPostRequest>? Contacts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentials")]
    public IReadOnlyList<CredentialsPostRequest>? Credentials { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embeddedFinance")]
    public IReadOnlyList<EmbeddedFinancePostRequest>? EmbeddedFinance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityCustomFields")]
    public IReadOnlyList<EntityCustomFieldsPostRequest>? EntityCustomFields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityData")]
    public IReadOnlyList<EntityDataPostRequest>? EntityData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityRefs")]
    public IReadOnlyList<EntityRefsPostRequest>? EntityRefs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityRoutes")]
    public IReadOnlyList<EntityRoutesPostRequest>? EntityRoutes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityTerms")]
    public IReadOnlyList<EntityTermsPostRequest>? EntityTerms { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orgEntities")]
    public IReadOnlyList<OrgEntitiesPostRequest>? OrgEntities { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("omniTokens")]
    public IReadOnlyList<OmniTokensPostRequest>? OmniTokens { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forentityProfitShares")]
    public IReadOnlyList<ProfitSharesPostRequest>? ForentityProfitShares { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holds")]
    public IReadOnlyList<HoldsPostRequest>? Holds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public MerchantsPostRequest? Merchant { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public IReadOnlyList<NotesPostRequest>? Notes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payouts")]
    public IReadOnlyList<PayoutPostRequest>? Payouts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinlessDebitConversions")]
    public IReadOnlyList<PinlessDebitConversionsPostRequest>? PinlessDebitConversions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profitShares")]
    public IReadOnlyList<ProfitSharesPostRequest>? ProfitShares { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reserves")]
    public IReadOnlyList<ReservesPostRequest>? Reserves { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revenueBoosts")]
    public IReadOnlyList<RevenueBoostsPostRequest>? RevenueBoosts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor")]
    public VendorsPostRequest? Vendor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fees")]
    public IReadOnlyList<FeesPostRequest>? Fees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forentityFees")]
    public IReadOnlyList<FeesPostRequest>? ForentityFees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("saferPayments")]
    public IReadOnlyList<SaferPaymentsPostRequest>? SaferPayments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
