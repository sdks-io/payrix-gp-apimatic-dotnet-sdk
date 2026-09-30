using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the DecisionAction associated with this Hold resource.
/// </summary>
[JsonConverter(typeof(HoldsModelDecisionActionConverter))]
public record HoldsModelDecisionAction
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DecisionActionsResponse> _decisionActionsResponseValue;

    private HoldsModelDecisionAction(Optional<string> stringValue,
        Optional<DecisionActionsResponse> decisionActionsResponseValue)
    {
        _stringValue = stringValue;
        _decisionActionsResponseValue = decisionActionsResponseValue;
    }

    public static HoldsModelDecisionAction String(string value) => new(Optional<string>.Some(value), default);

    public static HoldsModelDecisionAction DecisionActionsResponse(DecisionActionsResponse value) =>
        new(default, Optional<DecisionActionsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDecisionActionsResponse(out DecisionActionsResponse value) =>
        _decisionActionsResponseValue.TryGetValue(out value);

    public static implicit operator HoldsModelDecisionAction(string value) => String(value);

    public static implicit operator HoldsModelDecisionAction(DecisionActionsResponse value) =>
        DecisionActionsResponse(value);
}

file sealed class HoldsModelDecisionActionConverter : JsonConverter<HoldsModelDecisionAction>
{
    public override HoldsModelDecisionAction Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return HoldsModelDecisionAction.String(value);
        }
        if (JsonSerializer.TryDeserialize<DecisionActionsResponse>(root, options, out var decisionActionsResponseValue))
        {
            return HoldsModelDecisionAction.DecisionActionsResponse(decisionActionsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DecisionActionsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, HoldsModelDecisionAction value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDecisionActionsResponse(out var decisionActionsResponseValue))
        {
            JsonSerializer.Serialize(writer, decisionActionsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(HoldsModelDecisionAction)} contains no valid value to serialize.");
        }
    }
}
