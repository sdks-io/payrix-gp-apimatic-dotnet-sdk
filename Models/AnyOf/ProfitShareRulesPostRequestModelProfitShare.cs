using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the ProfitShare that this ProfitShare Rule applies to.
/// </summary>
[JsonConverter(typeof(ProfitShareRulesPostRequestModelProfitShareConverter))]
public record ProfitShareRulesPostRequestModelProfitShare
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ProfitSharesPostRequest> _profitSharesPostRequestValue;

    private ProfitShareRulesPostRequestModelProfitShare(Optional<string> stringValue,
        Optional<ProfitSharesPostRequest> profitSharesPostRequestValue)
    {
        _stringValue = stringValue;
        _profitSharesPostRequestValue = profitSharesPostRequestValue;
    }

    public static ProfitShareRulesPostRequestModelProfitShare String(string value) =>
        new(Optional<string>.Some(value), default);

    public static ProfitShareRulesPostRequestModelProfitShare ProfitSharesPostRequest(ProfitSharesPostRequest value) =>
        new(default, Optional<ProfitSharesPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetProfitSharesPostRequest(out ProfitSharesPostRequest value) =>
        _profitSharesPostRequestValue.TryGetValue(out value);

    public static implicit operator ProfitShareRulesPostRequestModelProfitShare(string value) => String(value);

    public static implicit operator ProfitShareRulesPostRequestModelProfitShare(ProfitSharesPostRequest value) =>
        ProfitSharesPostRequest(value);
}

file sealed class ProfitShareRulesPostRequestModelProfitShareConverter : JsonConverter<ProfitShareRulesPostRequestModelProfitShare>
{
    public override ProfitShareRulesPostRequestModelProfitShare Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ProfitShareRulesPostRequestModelProfitShare.String(value);
        }
        if (JsonSerializer.TryDeserialize<ProfitSharesPostRequest>(root, options, out var profitSharesPostRequestValue))
        {
            return ProfitShareRulesPostRequestModelProfitShare.ProfitSharesPostRequest(profitSharesPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or ProfitSharesPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ProfitShareRulesPostRequestModelProfitShare value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetProfitSharesPostRequest(out var profitSharesPostRequestValue))
        {
            JsonSerializer.Serialize(writer, profitSharesPostRequestValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ProfitShareRulesPostRequestModelProfitShare)} contains no valid value to serialize.");
        }
    }
}
