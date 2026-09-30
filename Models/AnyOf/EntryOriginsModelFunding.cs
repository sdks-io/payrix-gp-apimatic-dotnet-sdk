using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The processor’s funding ID (related to a merchant, for some processors it is the merchant ID) from which the funds were sourced.
/// </summary>
[JsonConverter(typeof(EntryOriginsModelFundingConverter))]
public record EntryOriginsModelFunding
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntityRefsResponse> _entityRefsResponseValue;

    private EntryOriginsModelFunding(Optional<string> stringValue, Optional<EntityRefsResponse> entityRefsResponseValue)
    {
        _stringValue = stringValue;
        _entityRefsResponseValue = entityRefsResponseValue;
    }

    public static EntryOriginsModelFunding String(string value) => new(Optional<string>.Some(value), default);

    public static EntryOriginsModelFunding EntityRefsResponse(EntityRefsResponse value) =>
        new(default, Optional<EntityRefsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntityRefsResponse(out EntityRefsResponse value) =>
        _entityRefsResponseValue.TryGetValue(out value);

    public static implicit operator EntryOriginsModelFunding(string value) => String(value);

    public static implicit operator EntryOriginsModelFunding(EntityRefsResponse value) => EntityRefsResponse(value);
}

file sealed class EntryOriginsModelFundingConverter : JsonConverter<EntryOriginsModelFunding>
{
    public override EntryOriginsModelFunding Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntryOriginsModelFunding.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntityRefsResponse>(root, options, out var entityRefsResponseValue))
        {
            return EntryOriginsModelFunding.EntityRefsResponse(entityRefsResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntityRefsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntryOriginsModelFunding value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntityRefsResponse(out var entityRefsResponseValue))
        {
            JsonSerializer.Serialize(writer, entityRefsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntryOriginsModelFunding)} contains no valid value to serialize.");
        }
    }
}
