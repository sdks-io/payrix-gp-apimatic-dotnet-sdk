using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Org associated with this secret.
/// </summary>
[JsonConverter(typeof(SecretsPostRequestModelOrgConverter))]
public record SecretsPostRequestModelOrg
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgsPostRequest> _orgsPostRequestValue;

    private SecretsPostRequestModelOrg(Optional<string> stringValue, Optional<OrgsPostRequest> orgsPostRequestValue)
    {
        _stringValue = stringValue;
        _orgsPostRequestValue = orgsPostRequestValue;
    }

    public static SecretsPostRequestModelOrg String(string value) => new(Optional<string>.Some(value), default);

    public static SecretsPostRequestModelOrg OrgsPostRequest(OrgsPostRequest value) =>
        new(default, Optional<OrgsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgsPostRequest(out OrgsPostRequest value) => _orgsPostRequestValue.TryGetValue(out value);

    public static implicit operator SecretsPostRequestModelOrg(string value) => String(value);

    public static implicit operator SecretsPostRequestModelOrg(OrgsPostRequest value) => OrgsPostRequest(value);
}

file sealed class SecretsPostRequestModelOrgConverter : JsonConverter<SecretsPostRequestModelOrg>
{
    public override SecretsPostRequestModelOrg Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SecretsPostRequestModelOrg.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgsPostRequest>(root, options, out var orgsPostRequestValue))
        {
            return SecretsPostRequestModelOrg.OrgsPostRequest(orgsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or OrgsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SecretsPostRequestModelOrg value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(SecretsPostRequestModelOrg)} contains no valid value to serialize.");
        }
    }
}
