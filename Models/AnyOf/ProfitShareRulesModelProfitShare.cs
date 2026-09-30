using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the ProfitShare that this ProfitShare Rule applies to.
/// </summary>
[JsonConverter(typeof(ProfitShareRulesModelProfitShareConverter))]
public record ProfitShareRulesModelProfitShare
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ProfitSharesResponse> _profitSharesResponseValue;

    private ProfitShareRulesModelProfitShare(Optional<string> stringValue,
        Optional<ProfitSharesResponse> profitSharesResponseValue)
    {
        _stringValue = stringValue;
        _profitSharesResponseValue = profitSharesResponseValue;
    }

    public static ProfitShareRulesModelProfitShare String(string value) => new(Optional<string>.Some(value), default);

    public static ProfitShareRulesModelProfitShare ProfitSharesResponse(ProfitSharesResponse value) =>
        new(default, Optional<ProfitSharesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetProfitSharesResponse(out ProfitSharesResponse value) =>
        _profitSharesResponseValue.TryGetValue(out value);

    public static implicit operator ProfitShareRulesModelProfitShare(string value) => String(value);

    public static implicit operator ProfitShareRulesModelProfitShare(ProfitSharesResponse value) =>
        ProfitSharesResponse(value);
}

file sealed class ProfitShareRulesModelProfitShareConverter : JsonConverter<ProfitShareRulesModelProfitShare>
{
    public override ProfitShareRulesModelProfitShare Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ProfitShareRulesModelProfitShare.String(value);
        }
        if (JsonSerializer.TryDeserialize<ProfitSharesResponse>(root, options, out var profitSharesResponseValue))
        {
            return ProfitShareRulesModelProfitShare.ProfitSharesResponse(profitSharesResponseValue);
        }
        throw new JsonException($"JSON does not match string or ProfitSharesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ProfitShareRulesModelProfitShare value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetProfitSharesResponse(out var profitSharesResponseValue))
        {
            JsonSerializer.Serialize(writer, profitSharesResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ProfitShareRulesModelProfitShare)} contains no valid value to serialize.");
        }
    }
}
