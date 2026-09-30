using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Org in which entities will have their earnings/expenses shares.
/// </summary>
[JsonConverter(typeof(ProfitSharesPostRequestModelOrgConverter))]
public record ProfitSharesPostRequestModelOrg
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgsPostRequest> _orgsPostRequestValue;

    private ProfitSharesPostRequestModelOrg(Optional<string> stringValue,
        Optional<OrgsPostRequest> orgsPostRequestValue)
    {
        _stringValue = stringValue;
        _orgsPostRequestValue = orgsPostRequestValue;
    }

    public static ProfitSharesPostRequestModelOrg String(string value) => new(Optional<string>.Some(value), default);

    public static ProfitSharesPostRequestModelOrg OrgsPostRequest(OrgsPostRequest value) =>
        new(default, Optional<OrgsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgsPostRequest(out OrgsPostRequest value) => _orgsPostRequestValue.TryGetValue(out value);

    public static implicit operator ProfitSharesPostRequestModelOrg(string value) => String(value);

    public static implicit operator ProfitSharesPostRequestModelOrg(OrgsPostRequest value) => OrgsPostRequest(value);
}

file sealed class ProfitSharesPostRequestModelOrgConverter : JsonConverter<ProfitSharesPostRequestModelOrg>
{
    public override ProfitSharesPostRequestModelOrg Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ProfitSharesPostRequestModelOrg.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgsPostRequest>(root, options, out var orgsPostRequestValue))
        {
            return ProfitSharesPostRequestModelOrg.OrgsPostRequest(orgsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or OrgsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ProfitSharesPostRequestModelOrg value,
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
            throw new JsonException($"{nameof(ProfitSharesPostRequestModelOrg)} contains no valid value to serialize.");
        }
    }
}
