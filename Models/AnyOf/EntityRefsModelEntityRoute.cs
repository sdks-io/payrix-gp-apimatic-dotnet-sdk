using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The original 'entity_route' that routed the merchant onto the platform which then returned this reference information, if applicable
/// </summary>
[JsonConverter(typeof(EntityRefsModelEntityRouteConverter))]
public record EntityRefsModelEntityRoute
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntityRoutesResponse> _entityRoutesResponseValue;

    private EntityRefsModelEntityRoute(Optional<string> stringValue,
        Optional<EntityRoutesResponse> entityRoutesResponseValue)
    {
        _stringValue = stringValue;
        _entityRoutesResponseValue = entityRoutesResponseValue;
    }

    public static EntityRefsModelEntityRoute String(string value) => new(Optional<string>.Some(value), default);

    public static EntityRefsModelEntityRoute EntityRoutesResponse(EntityRoutesResponse value) =>
        new(default, Optional<EntityRoutesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntityRoutesResponse(out EntityRoutesResponse value) =>
        _entityRoutesResponseValue.TryGetValue(out value);

    public static implicit operator EntityRefsModelEntityRoute(string value) => String(value);

    public static implicit operator EntityRefsModelEntityRoute(EntityRoutesResponse value) =>
        EntityRoutesResponse(value);
}

file sealed class EntityRefsModelEntityRouteConverter : JsonConverter<EntityRefsModelEntityRoute>
{
    public override EntityRefsModelEntityRoute Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntityRefsModelEntityRoute.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntityRoutesResponse>(root, options, out var entityRoutesResponseValue))
        {
            return EntityRefsModelEntityRoute.EntityRoutesResponse(entityRoutesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntityRoutesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntityRefsModelEntityRoute value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntityRoutesResponse(out var entityRoutesResponseValue))
        {
            JsonSerializer.Serialize(writer, entityRoutesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntityRefsModelEntityRoute)} contains no valid value to serialize.");
        }
    }
}
