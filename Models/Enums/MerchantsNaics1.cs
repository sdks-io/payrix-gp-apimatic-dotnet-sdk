using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The NAICS sector code that accurately describes the industry the business operates in.
/// <para>
/// For more information, see the <see href="https://www.census.gov/naics/reference_files_tools/2022_NAICS_Manual.pdf">NAICS Manual provided by the US Census Bureau's North American Industry Classification System.</see>
/// </para>
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>11</c> - <b>Agriculture, Forestry, Fishing and Hunting</b></description></item>
///   <item><description><c>21</c> - <b>Mining, Quarrying, and Oil and Gas Extraction</b></description></item>
///   <item><description><c>22</c> - <b>Utilities</b></description></item>
///   <item><description><c>23</c> - <b>Construction</b></description></item>
///   <item><description><c>31</c> / <c>33</c> - <b>Manufacturing</b></description></item>
///   <item><description><c>41</c> - <b>Wholesale Trade</b></description></item>
///   <item><description><c>44</c> / <c>45</c> - <b>Retail Trade</b></description></item>
///   <item><description><c>48</c> / <c>49</c> - <b>Transportation and Warehousing</b></description></item>
///   <item><description><c>51</c> - <b>Information</b></description></item>
///   <item><description><c>52</c> - <b>Finance and Insurance</b></description></item>
///   <item><description><c>53</c> - <b>Real Estate and Property Rental / Leasing</b></description></item>
///   <item><description><c>54</c> - <b>Professional, Scientific, and Technical Services</b></description></item>
///   <item><description><c>55</c> - <b>Management of Companies and Enterprises</b></description></item>
///   <item><description><c>56</c> - <b>Administrative and Support and Waste Management and Remediation Services</b></description></item>
///   <item><description><c>61</c> - <b>Educational Services</b></description></item>
///   <item><description><c>62</c> - <b>Health Care and Social Assistance</b></description></item>
///   <item><description><c>71</c> - <b>Arts, Entertainment, and Recreation</b></description></item>
///   <item><description><c>72</c> - <b>Accommodation and Food Services</b></description></item>
///   <item><description><c>81</c> - <b>Other Services (except Public Administration)</b></description></item>
///   <item><description><c>91</c> / <c>92</c> - <b>Public Administration</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantsNaics1>))]
public sealed record MerchantsNaics1 : OpenStringEnum<MerchantsNaics1>
{
    private MerchantsNaics1(string value) : base(value)
    {
    }

    public static readonly MerchantsNaics1 _11 = new("11");

    public static readonly MerchantsNaics1 _21 = new("21");

    public static readonly MerchantsNaics1 _22 = new("22");

    public static readonly MerchantsNaics1 _23 = new("23");

    public static readonly MerchantsNaics1 _3133 = new("31-33");

    public static readonly MerchantsNaics1 _41 = new("41");

    public static readonly MerchantsNaics1 _4445 = new("44-45");

    public static readonly MerchantsNaics1 _4849 = new("48-49");

    public static readonly MerchantsNaics1 _51 = new("51");

    public static readonly MerchantsNaics1 _52 = new("52");

    public static readonly MerchantsNaics1 _53 = new("53");

    public static readonly MerchantsNaics1 _54 = new("54");

    public static readonly MerchantsNaics1 _55 = new("55");

    public static readonly MerchantsNaics1 _56 = new("56");

    public static readonly MerchantsNaics1 _61 = new("61");

    public static readonly MerchantsNaics1 _62 = new("62");

    public static readonly MerchantsNaics1 _71 = new("71");

    public static readonly MerchantsNaics1 _72 = new("72");

    public static readonly MerchantsNaics1 _81 = new("81");

    public static readonly MerchantsNaics1 _9192 = new("91/92");

    public TResult Match<TResult>(Func<TResult> on_11,
        Func<TResult> on_21,
        Func<TResult> on_22,
        Func<TResult> on_23,
        Func<TResult> on_3133,
        Func<TResult> on_41,
        Func<TResult> on_4445,
        Func<TResult> on_4849,
        Func<TResult> on_51,
        Func<TResult> on_52,
        Func<TResult> on_53,
        Func<TResult> on_54,
        Func<TResult> on_55,
        Func<TResult> on_56,
        Func<TResult> on_61,
        Func<TResult> on_62,
        Func<TResult> on_71,
        Func<TResult> on_72,
        Func<TResult> on_81,
        Func<TResult> on_9192,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _11 => on_11(),
            _ when this == _21 => on_21(),
            _ when this == _22 => on_22(),
            _ when this == _23 => on_23(),
            _ when this == _3133 => on_3133(),
            _ when this == _41 => on_41(),
            _ when this == _4445 => on_4445(),
            _ when this == _4849 => on_4849(),
            _ when this == _51 => on_51(),
            _ when this == _52 => on_52(),
            _ when this == _53 => on_53(),
            _ when this == _54 => on_54(),
            _ when this == _55 => on_55(),
            _ when this == _56 => on_56(),
            _ when this == _61 => on_61(),
            _ when this == _62 => on_62(),
            _ when this == _71 => on_71(),
            _ when this == _72 => on_72(),
            _ when this == _81 => on_81(),
            _ when this == _9192 => on_9192(),
            _ => otherwise(Value)
        };

    public void Match(Action on_11,
        Action on_21,
        Action on_22,
        Action on_23,
        Action on_3133,
        Action on_41,
        Action on_4445,
        Action on_4849,
        Action on_51,
        Action on_52,
        Action on_53,
        Action on_54,
        Action on_55,
        Action on_56,
        Action on_61,
        Action on_62,
        Action on_71,
        Action on_72,
        Action on_81,
        Action on_9192,
        Action<string> otherwise)
    {
        if (this == _11) on_11();
        else if (this == _21) on_21();
        else if (this == _22) on_22();
        else if (this == _23) on_23();
        else if (this == _3133) on_3133();
        else if (this == _41) on_41();
        else if (this == _4445) on_4445();
        else if (this == _4849) on_4849();
        else if (this == _51) on_51();
        else if (this == _52) on_52();
        else if (this == _53) on_53();
        else if (this == _54) on_54();
        else if (this == _55) on_55();
        else if (this == _56) on_56();
        else if (this == _61) on_61();
        else if (this == _62) on_62();
        else if (this == _71) on_71();
        else if (this == _72) on_72();
        else if (this == _81) on_81();
        else if (this == _9192) on_9192();
        else otherwise(Value);
    }
}
