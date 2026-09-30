using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Assessment of the <c>forentity</c> assessment.
/// </summary>
[JsonConverter(typeof(AssessmentsModelOpposingAssessmentConverter))]
public record AssessmentsModelOpposingAssessment
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AssessmentsResponse> _assessmentsResponseValue;

    private AssessmentsModelOpposingAssessment(Optional<string> stringValue,
        Optional<AssessmentsResponse> assessmentsResponseValue)
    {
        _stringValue = stringValue;
        _assessmentsResponseValue = assessmentsResponseValue;
    }

    public static AssessmentsModelOpposingAssessment String(string value) => new(Optional<string>.Some(value), default);

    public static AssessmentsModelOpposingAssessment AssessmentsResponse(AssessmentsResponse value) =>
        new(default, Optional<AssessmentsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAssessmentsResponse(out AssessmentsResponse value) =>
        _assessmentsResponseValue.TryGetValue(out value);

    public static implicit operator AssessmentsModelOpposingAssessment(string value) => String(value);

    public static implicit operator AssessmentsModelOpposingAssessment(AssessmentsResponse value) =>
        AssessmentsResponse(value);
}

file sealed class AssessmentsModelOpposingAssessmentConverter : JsonConverter<AssessmentsModelOpposingAssessment>
{
    public override AssessmentsModelOpposingAssessment Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AssessmentsModelOpposingAssessment.String(value);
        }
        if (JsonSerializer.TryDeserialize<AssessmentsResponse>(root, options, out var assessmentsResponseValue))
        {
            return AssessmentsModelOpposingAssessment.AssessmentsResponse(assessmentsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AssessmentsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AssessmentsModelOpposingAssessment value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAssessmentsResponse(out var assessmentsResponseValue))
        {
            JsonSerializer.Serialize(writer, assessmentsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(AssessmentsModelOpposingAssessment)} contains no valid value to serialize.");
        }
    }
}
