using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Fund that this Entry refers to.
/// </summary>
[JsonConverter(typeof(EntriesModelFundConverter))]
public record EntriesModelFund
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<FundsResponse> _fundsResponseValue;

    private EntriesModelFund(Optional<string> stringValue, Optional<FundsResponse> fundsResponseValue)
    {
        _stringValue = stringValue;
        _fundsResponseValue = fundsResponseValue;
    }

    public static EntriesModelFund String(string value) => new(Optional<string>.Some(value), default);

    public static EntriesModelFund FundsResponse(FundsResponse value) =>
        new(default, Optional<FundsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetFundsResponse(out FundsResponse value) => _fundsResponseValue.TryGetValue(out value);

    public static implicit operator EntriesModelFund(string value) => String(value);

    public static implicit operator EntriesModelFund(FundsResponse value) => FundsResponse(value);
}

file sealed class EntriesModelFundConverter : JsonConverter<EntriesModelFund>
{
    public override EntriesModelFund Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntriesModelFund.String(value);
        }
        if (JsonSerializer.TryDeserialize<FundsResponse>(root, options, out var fundsResponseValue))
        {
            return EntriesModelFund.FundsResponse(fundsResponseValue);
        }
        throw new JsonException($"JSON does not match string or FundsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntriesModelFund value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetFundsResponse(out var fundsResponseValue))
        {
            JsonSerializer.Serialize(writer, fundsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntriesModelFund)} contains no valid value to serialize.");
        }
    }
}
