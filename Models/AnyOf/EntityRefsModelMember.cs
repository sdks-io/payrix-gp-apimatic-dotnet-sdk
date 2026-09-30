using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Member associated with this entityRefs resource.
/// </summary>
[JsonConverter(typeof(EntityRefsModelMemberConverter))]
public record EntityRefsModelMember
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<MembersResponse> _membersResponseValue;

    private EntityRefsModelMember(Optional<string> stringValue, Optional<MembersResponse> membersResponseValue)
    {
        _stringValue = stringValue;
        _membersResponseValue = membersResponseValue;
    }

    public static EntityRefsModelMember String(string value) => new(Optional<string>.Some(value), default);

    public static EntityRefsModelMember MembersResponse(MembersResponse value) =>
        new(default, Optional<MembersResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetMembersResponse(out MembersResponse value) => _membersResponseValue.TryGetValue(out value);

    public static implicit operator EntityRefsModelMember(string value) => String(value);

    public static implicit operator EntityRefsModelMember(MembersResponse value) => MembersResponse(value);
}

file sealed class EntityRefsModelMemberConverter : JsonConverter<EntityRefsModelMember>
{
    public override EntityRefsModelMember Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntityRefsModelMember.String(value);
        }
        if (JsonSerializer.TryDeserialize<MembersResponse>(root, options, out var membersResponseValue))
        {
            return EntityRefsModelMember.MembersResponse(membersResponseValue);
        }
        throw new JsonException($"JSON does not match string or MembersResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntityRefsModelMember value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetMembersResponse(out var membersResponseValue))
        {
            JsonSerializer.Serialize(writer, membersResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntityRefsModelMember)} contains no valid value to serialize.");
        }
    }
}
