using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entity that will have it's earnings/expenses shared.
/// </summary>
[JsonConverter(typeof(ProfitSharesPostRequestModelForentityConverter))]
public record ProfitSharesPostRequestModelForentity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesPostRequest> _entitiesPostRequestValue;

    private ProfitSharesPostRequestModelForentity(Optional<string> stringValue,
        Optional<EntitiesPostRequest> entitiesPostRequestValue)
    {
        _stringValue = stringValue;
        _entitiesPostRequestValue = entitiesPostRequestValue;
    }

    public static ProfitSharesPostRequestModelForentity String(string value) =>
        new(Optional<string>.Some(value), default);

    public static ProfitSharesPostRequestModelForentity EntitiesPostRequest(EntitiesPostRequest value) =>
        new(default, Optional<EntitiesPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesPostRequest(out EntitiesPostRequest value) =>
        _entitiesPostRequestValue.TryGetValue(out value);

    public static implicit operator ProfitSharesPostRequestModelForentity(string value) => String(value);

    public static implicit operator ProfitSharesPostRequestModelForentity(EntitiesPostRequest value) =>
        EntitiesPostRequest(value);
}

file sealed class ProfitSharesPostRequestModelForentityConverter : JsonConverter<ProfitSharesPostRequestModelForentity>
{
    public override ProfitSharesPostRequestModelForentity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ProfitSharesPostRequestModelForentity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesPostRequest>(root, options, out var entitiesPostRequestValue))
        {
            return ProfitSharesPostRequestModelForentity.EntitiesPostRequest(entitiesPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ProfitSharesPostRequestModelForentity value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntitiesPostRequest(out var entitiesPostRequestValue))
        {
            JsonSerializer.Serialize(writer, entitiesPostRequestValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ProfitSharesPostRequestModelForentity)} contains no valid value to serialize.");
        }
    }
}
