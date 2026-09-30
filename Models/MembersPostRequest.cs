using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record MembersPostRequest
{
    /// <summary>
    /// The identifier of the Merchant associated with this Member.
    /// </summary>
    [JsonPropertyName("merchant")]
    public required string Merchant { get; init; }

    /// <summary>
    /// The title that this Member holds in relation to the associated Merchant.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// For example, 'CEO', 'Owner' or 'Director of Finance'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// The first name associated with this Member.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonPropertyName("first")]
    public required string First { get; init; }

    /// <summary>
    /// The middle name associated with this Member.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middle")]
    public string? Middle { get; init; }

    /// <summary>
    /// The last name associated with this Member.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonPropertyName("last")]
    public required string Last { get; init; }

    /// <summary>
    /// The social security number of this Member. This field is required if the Merchant associated with the Member is a sole trader.
    /// This field is stored as a text string and must be 9 characters long and numeric characters only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn")]
    public string? Ssn { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("citizenship")]
    public Country139? Citizenship { get; init; }

    /// <summary>
    /// The date of birth of this Member.  The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// </summary>
    [JsonPropertyName("dob")]
    public required int Dob { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gender")]
    public MembersGender1? Gender { get; init; }

    /// <summary>
    /// The driver's license number of this Member.
    /// This field is stored as a text string and must be between 0 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dl")]
    public string? Dl { get; init; }

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
    [JsonPropertyName("dlstate")]
    public string? Dlstate { get; init; }

    /// <summary>
    /// The email address of this Member.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The share of the Member's ownership of the associated Merchant, expressed in basis points.
    /// For example, 25.3% is expressed as '2530'.
    /// This field is stored as an integer and must be between 1 and 10000 characters long.
    /// </summary>
    [JsonPropertyName("ownership")]
    public required int Ownership { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary")]
    public MembersPrimary1? Primary { get; init; }

    /// <summary>
    /// A credit score is a three-digit number that rates your creditworthiness. scores range from 334 to 818.
    /// </summary>
    [JsonPropertyName("creditScore")]
    public int? CreditScore { get; init; } = 0;

    /// <summary>
    /// Date for Credit Score.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditScoreDate")]
    public string? CreditScoreDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("significantResponsibility")]
    public MembersSignificantResponsibility1? SignificantResponsibility { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("politicallyExposed")]
    public MembersPoliticallyExposed1? PoliticallyExposed { get; init; }

    /// <summary>
    /// The mailing first line of the address associated with this Member.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mailingAddress1")]
    public string? MailingAddress1 { get; init; }

    /// <summary>
    /// The mailing second line of the address associated with this Member.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mailingAddress2")]
    public string? MailingAddress2 { get; init; }

    /// <summary>
    /// The mailing name of the city in the address associated with this Member.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mailingCity")]
    public string? MailingCity { get; init; }

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
    [JsonPropertyName("mailingState")]
    public string? MailingState { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mailingCountry")]
    public Country139? MailingCountry { get; init; }

    /// <summary>
    /// The mailing postal code in the address associated with this Member.
    /// This field is stored as a text string and must be between 1 and 20 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mailingPostalCode")]
    public string? MailingPostalCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("treasuryPrimeRoles")]
    public object? TreasuryPrimeRoles { get; init; }

    [JsonPropertyName("timezone")]
    public required MembersTimezone1 Timezone { get; init; }

    /// <summary>
    /// The first line of the address associated with this Member.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    public string? Address1 { get; init; }

    /// <summary>
    /// The second line of the address associated with this Member.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    public string? Address2 { get; init; }

    /// <summary>
    /// The name of the city in the address associated with this Member.
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
    /// The ZIP code in the address associated with this Member.
    /// This field is stored as a text string and must be between 1 and 20 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip")]
    public string? Zip { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Country139? Country { get; init; }

    /// <summary>
    /// The phone number associated with this Member.
    /// This field is stored as a text string and must be between 5 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

    /// <summary>
    /// The fax number associated with this Member.
    /// This field is stored as a text string and must be between 5 and 15 characters long.
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
