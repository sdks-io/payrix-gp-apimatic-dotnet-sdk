using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Statement that this StatementEntry refers to.
/// </summary>
[JsonConverter(typeof(StatementEntriesModelStatementConverter))]
public record StatementEntriesModelStatement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<StatementsResponse> _statementsResponseValue;

    private StatementEntriesModelStatement(Optional<string> stringValue,
        Optional<StatementsResponse> statementsResponseValue)
    {
        _stringValue = stringValue;
        _statementsResponseValue = statementsResponseValue;
    }

    public static StatementEntriesModelStatement String(string value) => new(Optional<string>.Some(value), default);

    public static StatementEntriesModelStatement StatementsResponse(StatementsResponse value) =>
        new(default, Optional<StatementsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetStatementsResponse(out StatementsResponse value) =>
        _statementsResponseValue.TryGetValue(out value);

    public static implicit operator StatementEntriesModelStatement(string value) => String(value);

    public static implicit operator StatementEntriesModelStatement(StatementsResponse value) =>
        StatementsResponse(value);
}

file sealed class StatementEntriesModelStatementConverter : JsonConverter<StatementEntriesModelStatement>
{
    public override StatementEntriesModelStatement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return StatementEntriesModelStatement.String(value);
        }
        if (JsonSerializer.TryDeserialize<StatementsResponse>(root, options, out var statementsResponseValue))
        {
            return StatementEntriesModelStatement.StatementsResponse(statementsResponseValue);
        }
        throw new JsonException($"JSON does not match string or StatementsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        StatementEntriesModelStatement value,
        JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(StatementEntriesModelStatement)} contains no valid value to serialize.");
        }
    }
}
