using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If the activity that this Entry refers to is a Revenue Share, then this field stores the identifier of the corresponding RevShareStatement resource.
/// </summary>
[JsonConverter(typeof(EntriesModelRevShareStatementConverter))]
public record EntriesModelRevShareStatement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<RevShareStatmentsResponse> _revShareStatmentsResponseValue;

    private EntriesModelRevShareStatement(Optional<string> stringValue,
        Optional<RevShareStatmentsResponse> revShareStatmentsResponseValue)
    {
        _stringValue = stringValue;
        _revShareStatmentsResponseValue = revShareStatmentsResponseValue;
    }

    public static EntriesModelRevShareStatement String(string value) => new(Optional<string>.Some(value), default);

    public static EntriesModelRevShareStatement RevShareStatmentsResponse(RevShareStatmentsResponse value) =>
        new(default, Optional<RevShareStatmentsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetRevShareStatmentsResponse(out RevShareStatmentsResponse value) =>
        _revShareStatmentsResponseValue.TryGetValue(out value);

    public static implicit operator EntriesModelRevShareStatement(string value) => String(value);

    public static implicit operator EntriesModelRevShareStatement(RevShareStatmentsResponse value) =>
        RevShareStatmentsResponse(value);
}

file sealed class EntriesModelRevShareStatementConverter : JsonConverter<EntriesModelRevShareStatement>
{
    public override EntriesModelRevShareStatement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntriesModelRevShareStatement.String(value);
        }
        if (JsonSerializer.TryDeserialize<RevShareStatmentsResponse>(
            root,
            options,
            out var revShareStatmentsResponseValue))
        {
            return EntriesModelRevShareStatement.RevShareStatmentsResponse(revShareStatmentsResponseValue);
        }
        throw new JsonException($"JSON does not match string or RevShareStatmentsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        EntriesModelRevShareStatement value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetRevShareStatmentsResponse(out var revShareStatmentsResponseValue))
        {
            JsonSerializer.Serialize(writer, revShareStatmentsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntriesModelRevShareStatement)} contains no valid value to serialize.");
        }
    }
}
