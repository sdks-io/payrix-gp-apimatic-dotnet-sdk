using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entity that this resource belongs to.
/// </summary>
[JsonConverter(typeof(PaymentUpdateGroupsModelEntityConverter))]
public record PaymentUpdateGroupsModelEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesResponse> _entitiesResponseValue;

    private PaymentUpdateGroupsModelEntity(Optional<string> stringValue,
        Optional<EntitiesResponse> entitiesResponseValue)
    {
        _stringValue = stringValue;
        _entitiesResponseValue = entitiesResponseValue;
    }

    public static PaymentUpdateGroupsModelEntity String(string value) => new(Optional<string>.Some(value), default);

    public static PaymentUpdateGroupsModelEntity EntitiesResponse(EntitiesResponse value) =>
        new(default, Optional<EntitiesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesResponse(out EntitiesResponse value) => _entitiesResponseValue.TryGetValue(out value);

    public static implicit operator PaymentUpdateGroupsModelEntity(string value) => String(value);

    public static implicit operator PaymentUpdateGroupsModelEntity(EntitiesResponse value) => EntitiesResponse(value);
}

file sealed class PaymentUpdateGroupsModelEntityConverter : JsonConverter<PaymentUpdateGroupsModelEntity>
{
    public override PaymentUpdateGroupsModelEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PaymentUpdateGroupsModelEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesResponse>(root, options, out var entitiesResponseValue))
        {
            return PaymentUpdateGroupsModelEntity.EntitiesResponse(entitiesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        PaymentUpdateGroupsModelEntity value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntitiesResponse(out var entitiesResponseValue))
        {
            JsonSerializer.Serialize(writer, entitiesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentUpdateGroupsModelEntity)} contains no valid value to serialize.");
        }
    }
}
