using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Fund that this reserveEntries resource relates to.
/// </summary>
[JsonConverter(typeof(ReserveEntriesModelFundConverter))]
public record ReserveEntriesModelFund
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<FundsResponse> _fundsResponseValue;

    private ReserveEntriesModelFund(Optional<string> stringValue, Optional<FundsResponse> fundsResponseValue)
    {
        _stringValue = stringValue;
        _fundsResponseValue = fundsResponseValue;
    }

    public static ReserveEntriesModelFund String(string value) => new(Optional<string>.Some(value), default);

    public static ReserveEntriesModelFund FundsResponse(FundsResponse value) =>
        new(default, Optional<FundsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetFundsResponse(out FundsResponse value) => _fundsResponseValue.TryGetValue(out value);

    public static implicit operator ReserveEntriesModelFund(string value) => String(value);

    public static implicit operator ReserveEntriesModelFund(FundsResponse value) => FundsResponse(value);
}

file sealed class ReserveEntriesModelFundConverter : JsonConverter<ReserveEntriesModelFund>
{
    public override ReserveEntriesModelFund Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReserveEntriesModelFund.String(value);
        }
        if (JsonSerializer.TryDeserialize<FundsResponse>(root, options, out var fundsResponseValue))
        {
            return ReserveEntriesModelFund.FundsResponse(fundsResponseValue);
        }
        throw new JsonException($"JSON does not match string or FundsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReserveEntriesModelFund value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(ReserveEntriesModelFund)} contains no valid value to serialize.");
        }
    }
}
