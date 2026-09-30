using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Alert resource that you want to invoke with this trigger.
/// </summary>
[JsonConverter(typeof(AlertTriggersPostRequestModelAlertConverter))]
public record AlertTriggersPostRequestModelAlert
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AlertsPostRequest> _alertsPostRequestValue;

    private AlertTriggersPostRequestModelAlert(Optional<string> stringValue,
        Optional<AlertsPostRequest> alertsPostRequestValue)
    {
        _stringValue = stringValue;
        _alertsPostRequestValue = alertsPostRequestValue;
    }

    public static AlertTriggersPostRequestModelAlert String(string value) => new(Optional<string>.Some(value), default);

    public static AlertTriggersPostRequestModelAlert AlertsPostRequest(AlertsPostRequest value) =>
        new(default, Optional<AlertsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAlertsPostRequest(out AlertsPostRequest value) => _alertsPostRequestValue.TryGetValue(out value);

    public static implicit operator AlertTriggersPostRequestModelAlert(string value) => String(value);

    public static implicit operator AlertTriggersPostRequestModelAlert(AlertsPostRequest value) =>
        AlertsPostRequest(value);
}

file sealed class AlertTriggersPostRequestModelAlertConverter : JsonConverter<AlertTriggersPostRequestModelAlert>
{
    public override AlertTriggersPostRequestModelAlert Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AlertTriggersPostRequestModelAlert.String(value);
        }
        if (JsonSerializer.TryDeserialize<AlertsPostRequest>(root, options, out var alertsPostRequestValue))
        {
            return AlertTriggersPostRequestModelAlert.AlertsPostRequest(alertsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or AlertsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AlertTriggersPostRequestModelAlert value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAlertsPostRequest(out var alertsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, alertsPostRequestValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(AlertTriggersPostRequestModelAlert)} contains no valid value to serialize.");
        }
    }
}
