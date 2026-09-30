using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The Customer that this Token is associated with.
/// </summary>
[JsonConverter(typeof(TokensPostRequestModelCustomerConverter))]
public record TokensPostRequestModelCustomer
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<CustomersPostRequest> _customersPostRequestValue;

    private TokensPostRequestModelCustomer(Optional<string> stringValue,
        Optional<CustomersPostRequest> customersPostRequestValue)
    {
        _stringValue = stringValue;
        _customersPostRequestValue = customersPostRequestValue;
    }

    public static TokensPostRequestModelCustomer String(string value) => new(Optional<string>.Some(value), default);

    public static TokensPostRequestModelCustomer CustomersPostRequest(CustomersPostRequest value) =>
        new(default, Optional<CustomersPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetCustomersPostRequest(out CustomersPostRequest value) =>
        _customersPostRequestValue.TryGetValue(out value);

    public static implicit operator TokensPostRequestModelCustomer(string value) => String(value);

    public static implicit operator TokensPostRequestModelCustomer(CustomersPostRequest value) =>
        CustomersPostRequest(value);
}

file sealed class TokensPostRequestModelCustomerConverter : JsonConverter<TokensPostRequestModelCustomer>
{
    public override TokensPostRequestModelCustomer Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TokensPostRequestModelCustomer.String(value);
        }
        if (JsonSerializer.TryDeserialize<CustomersPostRequest>(root, options, out var customersPostRequestValue))
        {
            return TokensPostRequestModelCustomer.CustomersPostRequest(customersPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or CustomersPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        TokensPostRequestModelCustomer value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetCustomersPostRequest(out var customersPostRequestValue))
        {
            JsonSerializer.Serialize(writer, customersPostRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TokensPostRequestModelCustomer)} contains no valid value to serialize.");
        }
    }
}
