using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Org that this orgEntity is associated with.
/// </summary>
[JsonConverter(typeof(OrgEntitiesPostRequestModelOrgConverter))]
public record OrgEntitiesPostRequestModelOrg
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgsPostRequest> _orgsPostRequestValue;

    private OrgEntitiesPostRequestModelOrg(Optional<string> stringValue, Optional<OrgsPostRequest> orgsPostRequestValue)
    {
        _stringValue = stringValue;
        _orgsPostRequestValue = orgsPostRequestValue;
    }

    public static OrgEntitiesPostRequestModelOrg String(string value) => new(Optional<string>.Some(value), default);

    public static OrgEntitiesPostRequestModelOrg OrgsPostRequest(OrgsPostRequest value) =>
        new(default, Optional<OrgsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgsPostRequest(out OrgsPostRequest value) => _orgsPostRequestValue.TryGetValue(out value);

    public static implicit operator OrgEntitiesPostRequestModelOrg(string value) => String(value);

    public static implicit operator OrgEntitiesPostRequestModelOrg(OrgsPostRequest value) => OrgsPostRequest(value);
}

file sealed class OrgEntitiesPostRequestModelOrgConverter : JsonConverter<OrgEntitiesPostRequestModelOrg>
{
    public override OrgEntitiesPostRequestModelOrg Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return OrgEntitiesPostRequestModelOrg.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgsPostRequest>(root, options, out var orgsPostRequestValue))
        {
            return OrgEntitiesPostRequestModelOrg.OrgsPostRequest(orgsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or OrgsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        OrgEntitiesPostRequestModelOrg value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetOrgsPostRequest(out var orgsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, orgsPostRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(OrgEntitiesPostRequestModelOrg)} contains no valid value to serialize.");
        }
    }
}
