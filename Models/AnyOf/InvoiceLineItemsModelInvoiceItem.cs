using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the InvoiceItem associated with this InvoiceLineItem.
/// </summary>
[JsonConverter(typeof(InvoiceLineItemsModelInvoiceItemConverter))]
public record InvoiceLineItemsModelInvoiceItem
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<InvoiceItemsResponse> _invoiceItemsResponseValue;

    private InvoiceLineItemsModelInvoiceItem(Optional<string> stringValue,
        Optional<InvoiceItemsResponse> invoiceItemsResponseValue)
    {
        _stringValue = stringValue;
        _invoiceItemsResponseValue = invoiceItemsResponseValue;
    }

    public static InvoiceLineItemsModelInvoiceItem String(string value) => new(Optional<string>.Some(value), default);

    public static InvoiceLineItemsModelInvoiceItem InvoiceItemsResponse(InvoiceItemsResponse value) =>
        new(default, Optional<InvoiceItemsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInvoiceItemsResponse(out InvoiceItemsResponse value) =>
        _invoiceItemsResponseValue.TryGetValue(out value);

    public static implicit operator InvoiceLineItemsModelInvoiceItem(string value) => String(value);

    public static implicit operator InvoiceLineItemsModelInvoiceItem(InvoiceItemsResponse value) =>
        InvoiceItemsResponse(value);
}

file sealed class InvoiceLineItemsModelInvoiceItemConverter : JsonConverter<InvoiceLineItemsModelInvoiceItem>
{
    public override InvoiceLineItemsModelInvoiceItem Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return InvoiceLineItemsModelInvoiceItem.String(value);
        }
        if (JsonSerializer.TryDeserialize<InvoiceItemsResponse>(root, options, out var invoiceItemsResponseValue))
        {
            return InvoiceLineItemsModelInvoiceItem.InvoiceItemsResponse(invoiceItemsResponseValue);
        }
        throw new JsonException($"JSON does not match string or InvoiceItemsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        InvoiceLineItemsModelInvoiceItem value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetInvoiceItemsResponse(out var invoiceItemsResponseValue))
        {
            JsonSerializer.Serialize(writer, invoiceItemsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(InvoiceLineItemsModelInvoiceItem)} contains no valid value to serialize.");
        }
    }
}
