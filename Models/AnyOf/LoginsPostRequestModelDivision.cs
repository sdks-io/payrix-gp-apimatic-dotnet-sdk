using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The division that this Login belongs to. The division association opens access to division-level administrators on this user and all records owned by this user. Defaults to authenticated user’s division if no value is explicitly set.
/// </summary>
[JsonConverter(typeof(LoginsPostRequestModelDivisionConverter))]
public record LoginsPostRequestModelDivision
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DivisionsPostRequest> _divisionsPostRequestValue;

    private LoginsPostRequestModelDivision(Optional<string> stringValue,
        Optional<DivisionsPostRequest> divisionsPostRequestValue)
    {
        _stringValue = stringValue;
        _divisionsPostRequestValue = divisionsPostRequestValue;
    }

    public static LoginsPostRequestModelDivision String(string value) => new(Optional<string>.Some(value), default);

    public static LoginsPostRequestModelDivision DivisionsPostRequest(DivisionsPostRequest value) =>
        new(default, Optional<DivisionsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDivisionsPostRequest(out DivisionsPostRequest value) =>
        _divisionsPostRequestValue.TryGetValue(out value);

    public static implicit operator LoginsPostRequestModelDivision(string value) => String(value);

    public static implicit operator LoginsPostRequestModelDivision(DivisionsPostRequest value) =>
        DivisionsPostRequest(value);
}

file sealed class LoginsPostRequestModelDivisionConverter : JsonConverter<LoginsPostRequestModelDivision>
{
    public override LoginsPostRequestModelDivision Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return LoginsPostRequestModelDivision.String(value);
        }
        if (JsonSerializer.TryDeserialize<DivisionsPostRequest>(root, options, out var divisionsPostRequestValue))
        {
            return LoginsPostRequestModelDivision.DivisionsPostRequest(divisionsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or DivisionsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        LoginsPostRequestModelDivision value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDivisionsPostRequest(out var divisionsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, divisionsPostRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(LoginsPostRequestModelDivision)} contains no valid value to serialize.");
        }
    }
}
