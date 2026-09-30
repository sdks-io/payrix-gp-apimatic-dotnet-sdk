using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the ProfitShare that this ProfitShareResult refers to.
/// </summary>
[JsonConverter(typeof(ProfitShareResultsModelProfitShareConverter))]
public record ProfitShareResultsModelProfitShare
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ProfitSharesResponse> _profitSharesResponseValue;

    private ProfitShareResultsModelProfitShare(Optional<string> stringValue,
        Optional<ProfitSharesResponse> profitSharesResponseValue)
    {
        _stringValue = stringValue;
        _profitSharesResponseValue = profitSharesResponseValue;
    }

    public static ProfitShareResultsModelProfitShare String(string value) => new(Optional<string>.Some(value), default);

    public static ProfitShareResultsModelProfitShare ProfitSharesResponse(ProfitSharesResponse value) =>
        new(default, Optional<ProfitSharesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetProfitSharesResponse(out ProfitSharesResponse value) =>
        _profitSharesResponseValue.TryGetValue(out value);

    public static implicit operator ProfitShareResultsModelProfitShare(string value) => String(value);

    public static implicit operator ProfitShareResultsModelProfitShare(ProfitSharesResponse value) =>
        ProfitSharesResponse(value);
}

file sealed class ProfitShareResultsModelProfitShareConverter : JsonConverter<ProfitShareResultsModelProfitShare>
{
    public override ProfitShareResultsModelProfitShare Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ProfitShareResultsModelProfitShare.String(value);
        }
        if (JsonSerializer.TryDeserialize<ProfitSharesResponse>(root, options, out var profitSharesResponseValue))
        {
            return ProfitShareResultsModelProfitShare.ProfitSharesResponse(profitSharesResponseValue);
        }
        throw new JsonException($"JSON does not match string or ProfitSharesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ProfitShareResultsModelProfitShare value,
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
                $"{nameof(ProfitShareResultsModelProfitShare)} contains no valid value to serialize.");
        }
    }
}
