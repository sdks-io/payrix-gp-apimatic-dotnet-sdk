using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The id of user who deleted the revenueBoost entity.
/// </summary>
[JsonConverter(typeof(RevenueBoostsModelDeleterConverter))]
public record RevenueBoostsModelDeleter
{
    private readonly Optional<string?> _stringValue;

    private readonly Optional<LoginsResponse> _loginsResponseValue;

    private RevenueBoostsModelDeleter(Optional<string?> stringValue, Optional<LoginsResponse> loginsResponseValue)
    {
        _stringValue = stringValue;
        _loginsResponseValue = loginsResponseValue;
    }

    public static RevenueBoostsModelDeleter String(string? value) => new(Optional<string?>.Some(value), default);

    public static RevenueBoostsModelDeleter LoginsResponse(LoginsResponse value) =>
        new(default, Optional<LoginsResponse>.Some(value));

    public bool TryGetString(out string? value) => _stringValue.TryGetValue(out value);

    public bool TryGetLoginsResponse(out LoginsResponse value) => _loginsResponseValue.TryGetValue(out value);

    public static implicit operator RevenueBoostsModelDeleter(string? value) => String(value);

    public static implicit operator RevenueBoostsModelDeleter(LoginsResponse value) => LoginsResponse(value);
}

file sealed class RevenueBoostsModelDeleterConverter : JsonConverter<RevenueBoostsModelDeleter>
{
    public override RevenueBoostsModelDeleter Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return RevenueBoostsModelDeleter.String(value);
        }
        if (JsonSerializer.TryDeserialize<LoginsResponse>(root, options, out var loginsResponseValue))
        {
            return RevenueBoostsModelDeleter.LoginsResponse(loginsResponseValue);
        }
        throw new JsonException($"JSON does not match string? or LoginsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, RevenueBoostsModelDeleter value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetLoginsResponse(out var loginsResponseValue))
        {
            JsonSerializer.Serialize(writer, loginsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(RevenueBoostsModelDeleter)} contains no valid value to serialize.");
        }
    }
}
