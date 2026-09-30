using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ID of the disbursementRef for which this result is recorded.
/// </summary>
[JsonConverter(typeof(DisbursementResultsModelDisbursementRefConverter))]
public record DisbursementResultsModelDisbursementRef
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DisbursementRefsResponse> _disbursementRefsResponseValue;

    private DisbursementResultsModelDisbursementRef(Optional<string> stringValue,
        Optional<DisbursementRefsResponse> disbursementRefsResponseValue)
    {
        _stringValue = stringValue;
        _disbursementRefsResponseValue = disbursementRefsResponseValue;
    }

    public static DisbursementResultsModelDisbursementRef String(string value) =>
        new(Optional<string>.Some(value), default);

    public static DisbursementResultsModelDisbursementRef DisbursementRefsResponse(DisbursementRefsResponse value) =>
        new(default, Optional<DisbursementRefsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDisbursementRefsResponse(out DisbursementRefsResponse value) =>
        _disbursementRefsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementResultsModelDisbursementRef(string value) => String(value);

    public static implicit operator DisbursementResultsModelDisbursementRef(DisbursementRefsResponse value) =>
        DisbursementRefsResponse(value);
}

file sealed class DisbursementResultsModelDisbursementRefConverter : JsonConverter<DisbursementResultsModelDisbursementRef>
{
    public override DisbursementResultsModelDisbursementRef Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementResultsModelDisbursementRef.String(value);
        }
        if (JsonSerializer.TryDeserialize<DisbursementRefsResponse>(
            root,
            options,
            out var disbursementRefsResponseValue))
        {
            return DisbursementResultsModelDisbursementRef.DisbursementRefsResponse(disbursementRefsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DisbursementRefsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementResultsModelDisbursementRef value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDisbursementRefsResponse(out var disbursementRefsResponseValue))
        {
            JsonSerializer.Serialize(writer, disbursementRefsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(DisbursementResultsModelDisbursementRef)} contains no valid value to serialize.");
        }
    }
}
