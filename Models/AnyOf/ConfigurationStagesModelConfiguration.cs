using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Configuration that owns this configurationStage resource.
/// </summary>
[JsonConverter(typeof(ConfigurationStagesModelConfigurationConverter))]
public record ConfigurationStagesModelConfiguration
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ConfigurationsResponse> _configurationsResponseValue;

    private ConfigurationStagesModelConfiguration(Optional<string> stringValue,
        Optional<ConfigurationsResponse> configurationsResponseValue)
    {
        _stringValue = stringValue;
        _configurationsResponseValue = configurationsResponseValue;
    }

    public static ConfigurationStagesModelConfiguration String(string value) =>
        new(Optional<string>.Some(value), default);

    public static ConfigurationStagesModelConfiguration ConfigurationsResponse(ConfigurationsResponse value) =>
        new(default, Optional<ConfigurationsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetConfigurationsResponse(out ConfigurationsResponse value) =>
        _configurationsResponseValue.TryGetValue(out value);

    public static implicit operator ConfigurationStagesModelConfiguration(string value) => String(value);

    public static implicit operator ConfigurationStagesModelConfiguration(ConfigurationsResponse value) =>
        ConfigurationsResponse(value);
}

file sealed class ConfigurationStagesModelConfigurationConverter : JsonConverter<ConfigurationStagesModelConfiguration>
{
    public override ConfigurationStagesModelConfiguration Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ConfigurationStagesModelConfiguration.String(value);
        }
        if (JsonSerializer.TryDeserialize<ConfigurationsResponse>(root, options, out var configurationsResponseValue))
        {
            return ConfigurationStagesModelConfiguration.ConfigurationsResponse(configurationsResponseValue);
        }
        throw new JsonException($"JSON does not match string or ConfigurationsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ConfigurationStagesModelConfiguration value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetConfigurationsResponse(out var configurationsResponseValue))
        {
            JsonSerializer.Serialize(writer, configurationsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ConfigurationStagesModelConfiguration)} contains no valid value to serialize.");
        }
    }
}
