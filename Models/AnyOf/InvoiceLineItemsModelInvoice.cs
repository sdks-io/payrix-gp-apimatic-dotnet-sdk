using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Invoice that owns this InvoiceLineItem.
/// </summary>
[JsonConverter(typeof(InvoiceLineItemsModelInvoiceConverter))]
public record InvoiceLineItemsModelInvoice
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<InvoicesResponse> _invoicesResponseValue;

    private InvoiceLineItemsModelInvoice(Optional<string> stringValue, Optional<InvoicesResponse> invoicesResponseValue)
    {
        _stringValue = stringValue;
        _invoicesResponseValue = invoicesResponseValue;
    }

    public static InvoiceLineItemsModelInvoice String(string value) => new(Optional<string>.Some(value), default);

    public static InvoiceLineItemsModelInvoice InvoicesResponse(InvoicesResponse value) =>
        new(default, Optional<InvoicesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInvoicesResponse(out InvoicesResponse value) => _invoicesResponseValue.TryGetValue(out value);

    public static implicit operator InvoiceLineItemsModelInvoice(string value) => String(value);

    public static implicit operator InvoiceLineItemsModelInvoice(InvoicesResponse value) => InvoicesResponse(value);
}

file sealed class InvoiceLineItemsModelInvoiceConverter : JsonConverter<InvoiceLineItemsModelInvoice>
{
    public override InvoiceLineItemsModelInvoice Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return InvoiceLineItemsModelInvoice.String(value);
        }
        if (JsonSerializer.TryDeserialize<InvoicesResponse>(root, options, out var invoicesResponseValue))
        {
            return InvoiceLineItemsModelInvoice.InvoicesResponse(invoicesResponseValue);
        }
        throw new JsonException($"JSON does not match string or InvoicesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, InvoiceLineItemsModelInvoice value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetInvoicesResponse(out var invoicesResponseValue))
        {
            JsonSerializer.Serialize(writer, invoicesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(InvoiceLineItemsModelInvoice)} contains no valid value to serialize.");
        }
    }
}
