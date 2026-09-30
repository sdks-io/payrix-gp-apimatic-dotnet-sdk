using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Customer of this invoice resource.
/// </summary>
[JsonConverter(typeof(InvoicesPostRequestModelCustomerConverter))]
public record InvoicesPostRequestModelCustomer
{
    private readonly Optional<string?> _stringValue;

    private readonly Optional<CustomersPostRequest> _customersPostRequestValue;

    private InvoicesPostRequestModelCustomer(Optional<string?> stringValue,
        Optional<CustomersPostRequest> customersPostRequestValue)
    {
        _stringValue = stringValue;
        _customersPostRequestValue = customersPostRequestValue;
    }

    public static InvoicesPostRequestModelCustomer String(string? value) => new(Optional<string?>.Some(value), default);

    public static InvoicesPostRequestModelCustomer CustomersPostRequest(CustomersPostRequest value) =>
        new(default, Optional<CustomersPostRequest>.Some(value));

    public bool TryGetString(out string? value) => _stringValue.TryGetValue(out value);

    public bool TryGetCustomersPostRequest(out CustomersPostRequest value) =>
        _customersPostRequestValue.TryGetValue(out value);

    public static implicit operator InvoicesPostRequestModelCustomer(string? value) => String(value);

    public static implicit operator InvoicesPostRequestModelCustomer(CustomersPostRequest value) =>
        CustomersPostRequest(value);
}

file sealed class InvoicesPostRequestModelCustomerConverter : JsonConverter<InvoicesPostRequestModelCustomer>
{
    public override InvoicesPostRequestModelCustomer Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return InvoicesPostRequestModelCustomer.String(value);
        }
        if (JsonSerializer.TryDeserialize<CustomersPostRequest>(root, options, out var customersPostRequestValue))
        {
            return InvoicesPostRequestModelCustomer.CustomersPostRequest(customersPostRequestValue);
        }
        throw new JsonException($"JSON does not match string? or CustomersPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        InvoicesPostRequestModelCustomer value,
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
            throw new JsonException(
                $"{nameof(InvoicesPostRequestModelCustomer)} contains no valid value to serialize.");
        }
    }
}
