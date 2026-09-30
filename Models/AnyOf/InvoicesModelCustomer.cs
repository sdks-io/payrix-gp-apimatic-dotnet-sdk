using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Customer of this invoice resource.
/// </summary>
[JsonConverter(typeof(InvoicesModelCustomerConverter))]
public record InvoicesModelCustomer
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<CustomersResponse> _customersResponseValue;

    private InvoicesModelCustomer(Optional<string> stringValue, Optional<CustomersResponse> customersResponseValue)
    {
        _stringValue = stringValue;
        _customersResponseValue = customersResponseValue;
    }

    public static InvoicesModelCustomer String(string value) => new(Optional<string>.Some(value), default);

    public static InvoicesModelCustomer CustomersResponse(CustomersResponse value) =>
        new(default, Optional<CustomersResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetCustomersResponse(out CustomersResponse value) => _customersResponseValue.TryGetValue(out value);

    public static implicit operator InvoicesModelCustomer(string value) => String(value);

    public static implicit operator InvoicesModelCustomer(CustomersResponse value) => CustomersResponse(value);
}

file sealed class InvoicesModelCustomerConverter : JsonConverter<InvoicesModelCustomer>
{
    public override InvoicesModelCustomer Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return InvoicesModelCustomer.String(value);
        }
        if (JsonSerializer.TryDeserialize<CustomersResponse>(root, options, out var customersResponseValue))
        {
            return InvoicesModelCustomer.CustomersResponse(customersResponseValue);
        }
        throw new JsonException($"JSON does not match string or CustomersResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, InvoicesModelCustomer value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetCustomersResponse(out var customersResponseValue))
        {
            JsonSerializer.Serialize(writer, customersResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(InvoicesModelCustomer)} contains no valid value to serialize.");
        }
    }
}
