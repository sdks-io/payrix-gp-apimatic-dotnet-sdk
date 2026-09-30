using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Alert resource that defines this alertAction.
/// </summary>
[JsonConverter(typeof(AlertActionsModelAlertConverter))]
public record AlertActionsModelAlert
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AlertsResponse> _alertsResponseValue;

    private AlertActionsModelAlert(Optional<string> stringValue, Optional<AlertsResponse> alertsResponseValue)
    {
        _stringValue = stringValue;
        _alertsResponseValue = alertsResponseValue;
    }

    public static AlertActionsModelAlert String(string value) => new(Optional<string>.Some(value), default);

    public static AlertActionsModelAlert AlertsResponse(AlertsResponse value) =>
        new(default, Optional<AlertsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAlertsResponse(out AlertsResponse value) => _alertsResponseValue.TryGetValue(out value);

    public static implicit operator AlertActionsModelAlert(string value) => String(value);

    public static implicit operator AlertActionsModelAlert(AlertsResponse value) => AlertsResponse(value);
}

file sealed class AlertActionsModelAlertConverter : JsonConverter<AlertActionsModelAlert>
{
    public override AlertActionsModelAlert Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AlertActionsModelAlert.String(value);
        }
        if (JsonSerializer.TryDeserialize<AlertsResponse>(root, options, out var alertsResponseValue))
        {
            return AlertActionsModelAlert.AlertsResponse(alertsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AlertsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AlertActionsModelAlert value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAlertsResponse(out var alertsResponseValue))
        {
            JsonSerializer.Serialize(writer, alertsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AlertActionsModelAlert)} contains no valid value to serialize.");
        }
    }
}
