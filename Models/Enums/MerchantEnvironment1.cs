using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The environment which the Merchant is in, if applicable.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>supermarket</c> - <b>Supermarkets / Grocery</b></description></item>
///   <item><description><c>moto</c> - <b>Mail Order / Telephone Order</b></description></item>
///   <item><description><c>cardPresent</c> - <b>Card Present Environment</b></description></item>
///   <item><description><c>fuel</c> - <b>Fuel / Gas Stations</b></description></item>
///   <item><description><c>serviceStation</c> - <b>Service Stations</b></description></item>
///   <item><description><c>restaurant</c> - <b>Restaurants</b></description></item>
///   <item><description><c>ecommerce</c> - <b>eCommerce / Online Sales</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantEnvironment1>))]
public sealed record MerchantEnvironment1 : OpenStringEnum<MerchantEnvironment1>
{
    private MerchantEnvironment1(string value) : base(value)
    {
    }

    public static readonly MerchantEnvironment1 Supermarket = new("supermarket");

    public static readonly MerchantEnvironment1 Moto = new("moto");

    public static readonly MerchantEnvironment1 CardPresent = new("cardPresent");

    public static readonly MerchantEnvironment1 Fuel = new("fuel");

    public static readonly MerchantEnvironment1 ServiceStation = new("serviceStation");

    public static readonly MerchantEnvironment1 Restaurant = new("restaurant");

    public static readonly MerchantEnvironment1 Ecommerce = new("ecommerce");

    public TResult Match<TResult>(Func<TResult> onSupermarket,
        Func<TResult> onMoto,
        Func<TResult> onCardPresent,
        Func<TResult> onFuel,
        Func<TResult> onServiceStation,
        Func<TResult> onRestaurant,
        Func<TResult> onEcommerce,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Supermarket => onSupermarket(),
            _ when this == Moto => onMoto(),
            _ when this == CardPresent => onCardPresent(),
            _ when this == Fuel => onFuel(),
            _ when this == ServiceStation => onServiceStation(),
            _ when this == Restaurant => onRestaurant(),
            _ when this == Ecommerce => onEcommerce(),
            _ => otherwise(Value)
        };

    public void Match(Action onSupermarket,
        Action onMoto,
        Action onCardPresent,
        Action onFuel,
        Action onServiceStation,
        Action onRestaurant,
        Action onEcommerce,
        Action<string> otherwise)
    {
        if (this == Supermarket) onSupermarket();
        else if (this == Moto) onMoto();
        else if (this == CardPresent) onCardPresent();
        else if (this == Fuel) onFuel();
        else if (this == ServiceStation) onServiceStation();
        else if (this == Restaurant) onRestaurant();
        else if (this == Ecommerce) onEcommerce();
        else otherwise(Value);
    }
}
