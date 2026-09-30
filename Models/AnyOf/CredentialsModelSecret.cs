using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The secret resource identifier to use when connecting using this Credential.
/// This field is only necessary when a private key is required by the integration.
/// </summary>
[JsonConverter(typeof(CredentialsModelSecretConverter))]
public record CredentialsModelSecret
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<SecretsResponse> _secretsResponseValue;

    private CredentialsModelSecret(Optional<string> stringValue, Optional<SecretsResponse> secretsResponseValue)
    {
        _stringValue = stringValue;
        _secretsResponseValue = secretsResponseValue;
    }

    public static CredentialsModelSecret String(string value) => new(Optional<string>.Some(value), default);

    public static CredentialsModelSecret SecretsResponse(SecretsResponse value) =>
        new(default, Optional<SecretsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetSecretsResponse(out SecretsResponse value) => _secretsResponseValue.TryGetValue(out value);

    public static implicit operator CredentialsModelSecret(string value) => String(value);

    public static implicit operator CredentialsModelSecret(SecretsResponse value) => SecretsResponse(value);
}

file sealed class CredentialsModelSecretConverter : JsonConverter<CredentialsModelSecret>
{
    public override CredentialsModelSecret Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return CredentialsModelSecret.String(value);
        }
        if (JsonSerializer.TryDeserialize<SecretsResponse>(root, options, out var secretsResponseValue))
        {
            return CredentialsModelSecret.SecretsResponse(secretsResponseValue);
        }
        throw new JsonException($"JSON does not match string or SecretsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CredentialsModelSecret value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetSecretsResponse(out var secretsResponseValue))
        {
            JsonSerializer.Serialize(writer, secretsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CredentialsModelSecret)} contains no valid value to serialize.");
        }
    }
}
