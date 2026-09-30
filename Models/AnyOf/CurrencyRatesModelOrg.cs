using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If this currency rate relates to an org, then this field stores the identifier of the Org.
/// </summary>
[JsonConverter(typeof(CurrencyRatesModelOrgConverter))]
public record CurrencyRatesModelOrg
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgsResponse> _orgsResponseValue;

    private CurrencyRatesModelOrg(Optional<string> stringValue, Optional<OrgsResponse> orgsResponseValue)
    {
        _stringValue = stringValue;
        _orgsResponseValue = orgsResponseValue;
    }

    public static CurrencyRatesModelOrg String(string value) => new(Optional<string>.Some(value), default);

    public static CurrencyRatesModelOrg OrgsResponse(OrgsResponse value) =>
        new(default, Optional<OrgsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgsResponse(out OrgsResponse value) => _orgsResponseValue.TryGetValue(out value);

    public static implicit operator CurrencyRatesModelOrg(string value) => String(value);

    public static implicit operator CurrencyRatesModelOrg(OrgsResponse value) => OrgsResponse(value);
}

file sealed class CurrencyRatesModelOrgConverter : JsonConverter<CurrencyRatesModelOrg>
{
    public override CurrencyRatesModelOrg Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return CurrencyRatesModelOrg.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgsResponse>(root, options, out var orgsResponseValue))
        {
            return CurrencyRatesModelOrg.OrgsResponse(orgsResponseValue);
        }
        throw new JsonException($"JSON does not match string or OrgsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CurrencyRatesModelOrg value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetOrgsResponse(out var orgsResponseValue))
        {
            JsonSerializer.Serialize(writer, orgsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CurrencyRatesModelOrg)} contains no valid value to serialize.");
        }
    }
}
