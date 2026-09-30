using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Login that owns this fundingParameter resource.
/// </summary>
[JsonConverter(typeof(FundingParametersModelLoginConverter))]
public record FundingParametersModelLogin
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<LoginsResponse> _loginsResponseValue;

    private FundingParametersModelLogin(Optional<string> stringValue, Optional<LoginsResponse> loginsResponseValue)
    {
        _stringValue = stringValue;
        _loginsResponseValue = loginsResponseValue;
    }

    public static FundingParametersModelLogin String(string value) => new(Optional<string>.Some(value), default);

    public static FundingParametersModelLogin LoginsResponse(LoginsResponse value) =>
        new(default, Optional<LoginsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetLoginsResponse(out LoginsResponse value) => _loginsResponseValue.TryGetValue(out value);

    public static implicit operator FundingParametersModelLogin(string value) => String(value);

    public static implicit operator FundingParametersModelLogin(LoginsResponse value) => LoginsResponse(value);
}

file sealed class FundingParametersModelLoginConverter : JsonConverter<FundingParametersModelLogin>
{
    public override FundingParametersModelLogin Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return FundingParametersModelLogin.String(value);
        }
        if (JsonSerializer.TryDeserialize<LoginsResponse>(root, options, out var loginsResponseValue))
        {
            return FundingParametersModelLogin.LoginsResponse(loginsResponseValue);
        }
        throw new JsonException($"JSON does not match string or LoginsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FundingParametersModelLogin value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetLoginsResponse(out var loginsResponseValue))
        {
            JsonSerializer.Serialize(writer, loginsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(FundingParametersModelLogin)} contains no valid value to serialize.");
        }
    }
}
