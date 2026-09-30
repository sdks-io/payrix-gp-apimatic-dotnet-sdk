using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The RevShareSchedule object defines specific income sharing rules.
/// </summary>
[JsonConverter(typeof(RevShareStatmentsModelRevShareScheduleConverter))]
public record RevShareStatmentsModelRevShareSchedule
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<RevShareSchedulesResponse> _revShareSchedulesResponseValue;

    private RevShareStatmentsModelRevShareSchedule(Optional<string> stringValue,
        Optional<RevShareSchedulesResponse> revShareSchedulesResponseValue)
    {
        _stringValue = stringValue;
        _revShareSchedulesResponseValue = revShareSchedulesResponseValue;
    }

    public static RevShareStatmentsModelRevShareSchedule String(string value) =>
        new(Optional<string>.Some(value), default);

    public static RevShareStatmentsModelRevShareSchedule RevShareSchedulesResponse(RevShareSchedulesResponse value) =>
        new(default, Optional<RevShareSchedulesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetRevShareSchedulesResponse(out RevShareSchedulesResponse value) =>
        _revShareSchedulesResponseValue.TryGetValue(out value);

    public static implicit operator RevShareStatmentsModelRevShareSchedule(string value) => String(value);

    public static implicit operator RevShareStatmentsModelRevShareSchedule(RevShareSchedulesResponse value) =>
        RevShareSchedulesResponse(value);
}

file sealed class RevShareStatmentsModelRevShareScheduleConverter : JsonConverter<RevShareStatmentsModelRevShareSchedule>
{
    public override RevShareStatmentsModelRevShareSchedule Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return RevShareStatmentsModelRevShareSchedule.String(value);
        }
        if (JsonSerializer.TryDeserialize<RevShareSchedulesResponse>(
            root,
            options,
            out var revShareSchedulesResponseValue))
        {
            return RevShareStatmentsModelRevShareSchedule.RevShareSchedulesResponse(revShareSchedulesResponseValue);
        }
        throw new JsonException($"JSON does not match string or RevShareSchedulesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        RevShareStatmentsModelRevShareSchedule value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetRevShareSchedulesResponse(out var revShareSchedulesResponseValue))
        {
            JsonSerializer.Serialize(writer, revShareSchedulesResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(RevShareStatmentsModelRevShareSchedule)} contains no valid value to serialize.");
        }
    }
}
