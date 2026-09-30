using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Statement being paid by this Disbursement.
/// </summary>
[JsonConverter(typeof(DisbursementsModelStatementConverter))]
public record DisbursementsModelStatement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<StatementsResponse> _statementsResponseValue;

    private DisbursementsModelStatement(Optional<string> stringValue,
        Optional<StatementsResponse> statementsResponseValue)
    {
        _stringValue = stringValue;
        _statementsResponseValue = statementsResponseValue;
    }

    public static DisbursementsModelStatement String(string value) => new(Optional<string>.Some(value), default);

    public static DisbursementsModelStatement StatementsResponse(StatementsResponse value) =>
        new(default, Optional<StatementsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetStatementsResponse(out StatementsResponse value) =>
        _statementsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementsModelStatement(string value) => String(value);

    public static implicit operator DisbursementsModelStatement(StatementsResponse value) => StatementsResponse(value);
}

file sealed class DisbursementsModelStatementConverter : JsonConverter<DisbursementsModelStatement>
{
    public override DisbursementsModelStatement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementsModelStatement.String(value);
        }
        if (JsonSerializer.TryDeserialize<StatementsResponse>(root, options, out var statementsResponseValue))
        {
            return DisbursementsModelStatement.StatementsResponse(statementsResponseValue);
        }
        throw new JsonException($"JSON does not match string or StatementsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DisbursementsModelStatement value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetStatementsResponse(out var statementsResponseValue))
        {
            JsonSerializer.Serialize(writer, statementsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DisbursementsModelStatement)} contains no valid value to serialize.");
        }
    }
}
