using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Org who should pay this Fee on behalf of the Entity identified in the value of the 'forentity' field.
/// This field is optional. If it is set, then the Fee is charged to this Org instead.
/// </summary>
[JsonConverter(typeof(FeesPostRequestModelOrgConverter))]
public record FeesPostRequestModelOrg
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgsPostRequest> _orgsPostRequestValue;

    private FeesPostRequestModelOrg(Optional<string> stringValue, Optional<OrgsPostRequest> orgsPostRequestValue)
    {
        _stringValue = stringValue;
        _orgsPostRequestValue = orgsPostRequestValue;
    }

    public static FeesPostRequestModelOrg String(string value) => new(Optional<string>.Some(value), default);

    public static FeesPostRequestModelOrg OrgsPostRequest(OrgsPostRequest value) =>
        new(default, Optional<OrgsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgsPostRequest(out OrgsPostRequest value) => _orgsPostRequestValue.TryGetValue(out value);

    public static implicit operator FeesPostRequestModelOrg(string value) => String(value);

    public static implicit operator FeesPostRequestModelOrg(OrgsPostRequest value) => OrgsPostRequest(value);
}

file sealed class FeesPostRequestModelOrgConverter : JsonConverter<FeesPostRequestModelOrg>
{
    public override FeesPostRequestModelOrg Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return FeesPostRequestModelOrg.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgsPostRequest>(root, options, out var orgsPostRequestValue))
        {
            return FeesPostRequestModelOrg.OrgsPostRequest(orgsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or OrgsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FeesPostRequestModelOrg value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(FeesPostRequestModelOrg)} contains no valid value to serialize.");
        }
    }
}
