using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the related host.
/// </summary>
[JsonConverter(typeof(HostThemesModelHostConverter))]
public record HostThemesModelHost
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<HostsResponse> _hostsResponseValue;

    private HostThemesModelHost(Optional<string> stringValue, Optional<HostsResponse> hostsResponseValue)
    {
        _stringValue = stringValue;
        _hostsResponseValue = hostsResponseValue;
    }

    public static HostThemesModelHost String(string value) => new(Optional<string>.Some(value), default);

    public static HostThemesModelHost HostsResponse(HostsResponse value) =>
        new(default, Optional<HostsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetHostsResponse(out HostsResponse value) => _hostsResponseValue.TryGetValue(out value);

    public static implicit operator HostThemesModelHost(string value) => String(value);

    public static implicit operator HostThemesModelHost(HostsResponse value) => HostsResponse(value);
}

file sealed class HostThemesModelHostConverter : JsonConverter<HostThemesModelHost>
{
    public override HostThemesModelHost Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return HostThemesModelHost.String(value);
        }
        if (JsonSerializer.TryDeserialize<HostsResponse>(root, options, out var hostsResponseValue))
        {
            return HostThemesModelHost.HostsResponse(hostsResponseValue);
        }
        throw new JsonException($"JSON does not match string or HostsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, HostThemesModelHost value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetHostsResponse(out var hostsResponseValue))
        {
            JsonSerializer.Serialize(writer, hostsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(HostThemesModelHost)} contains no valid value to serialize.");
        }
    }
}
