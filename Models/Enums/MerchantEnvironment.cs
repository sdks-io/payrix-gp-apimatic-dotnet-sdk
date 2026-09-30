using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantEnvironment>))]
public sealed record MerchantEnvironment : OpenStringEnum<MerchantEnvironment>
{
    private MerchantEnvironment(string value) : base(value)
    {
    }

    public static readonly MerchantEnvironment Supermarket = new("supermarket");

    public static readonly MerchantEnvironment Moto = new("moto");

    public static readonly MerchantEnvironment CardPresent = new("cardPresent");

    public static readonly MerchantEnvironment Fuel = new("fuel");

    public static readonly MerchantEnvironment ServiceStation = new("serviceStation");

    public static readonly MerchantEnvironment Restaurant = new("restaurant");

    public static readonly MerchantEnvironment Ecommerce = new("ecommerce");

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
