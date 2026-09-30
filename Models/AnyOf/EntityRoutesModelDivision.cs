using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// Division ID in which the entity route is associated.
/// </summary>
[JsonConverter(typeof(EntityRoutesModelDivisionConverter))]
public record EntityRoutesModelDivision
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DivisionsResponse> _divisionsResponseValue;

    private EntityRoutesModelDivision(Optional<string> stringValue, Optional<DivisionsResponse> divisionsResponseValue)
    {
        _stringValue = stringValue;
        _divisionsResponseValue = divisionsResponseValue;
    }

    public static EntityRoutesModelDivision String(string value) => new(Optional<string>.Some(value), default);

    public static EntityRoutesModelDivision DivisionsResponse(DivisionsResponse value) =>
        new(default, Optional<DivisionsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDivisionsResponse(out DivisionsResponse value) => _divisionsResponseValue.TryGetValue(out value);

    public static implicit operator EntityRoutesModelDivision(string value) => String(value);

    public static implicit operator EntityRoutesModelDivision(DivisionsResponse value) => DivisionsResponse(value);
}

file sealed class EntityRoutesModelDivisionConverter : JsonConverter<EntityRoutesModelDivision>
{
    public override EntityRoutesModelDivision Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntityRoutesModelDivision.String(value);
        }
        if (JsonSerializer.TryDeserialize<DivisionsResponse>(root, options, out var divisionsResponseValue))
        {
            return EntityRoutesModelDivision.DivisionsResponse(divisionsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DivisionsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntityRoutesModelDivision value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDivisionsResponse(out var divisionsResponseValue))
        {
            JsonSerializer.Serialize(writer, divisionsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntityRoutesModelDivision)} contains no valid value to serialize.");
        }
    }
}
