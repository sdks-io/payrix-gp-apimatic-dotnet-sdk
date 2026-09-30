using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Invoice that owns this invoiceResult resource.
/// </summary>
[JsonConverter(typeof(InvoiceResultModelInvoiceConverter))]
public record InvoiceResultModelInvoice
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<InvoicesResponse> _invoicesResponseValue;

    private InvoiceResultModelInvoice(Optional<string> stringValue, Optional<InvoicesResponse> invoicesResponseValue)
    {
        _stringValue = stringValue;
        _invoicesResponseValue = invoicesResponseValue;
    }

    public static InvoiceResultModelInvoice String(string value) => new(Optional<string>.Some(value), default);

    public static InvoiceResultModelInvoice InvoicesResponse(InvoicesResponse value) =>
        new(default, Optional<InvoicesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInvoicesResponse(out InvoicesResponse value) => _invoicesResponseValue.TryGetValue(out value);

    public static implicit operator InvoiceResultModelInvoice(string value) => String(value);

    public static implicit operator InvoiceResultModelInvoice(InvoicesResponse value) => InvoicesResponse(value);
}

file sealed class InvoiceResultModelInvoiceConverter : JsonConverter<InvoiceResultModelInvoice>
{
    public override InvoiceResultModelInvoice Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return InvoiceResultModelInvoice.String(value);
        }
        if (JsonSerializer.TryDeserialize<InvoicesResponse>(root, options, out var invoicesResponseValue))
        {
            return InvoiceResultModelInvoice.InvoicesResponse(invoicesResponseValue);
        }
        throw new JsonException($"JSON does not match string or InvoicesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, InvoiceResultModelInvoice value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(InvoiceResultModelInvoice)} contains no valid value to serialize.");
        }
    }
}
