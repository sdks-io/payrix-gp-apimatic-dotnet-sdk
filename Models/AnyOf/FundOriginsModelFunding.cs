using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The processor's funding ID (related to a merchant, this field is required if the adjustment is not between entities.
/// </summary>
[JsonConverter(typeof(FundOriginsModelFundingConverter))]
public record FundOriginsModelFunding
{
    private readonly Optional<FundOriginPlatform> _fundOriginPlatformValue;

    private readonly Optional<EntityRefsResponse> _entityRefsResponseValue;

    private FundOriginsModelFunding(Optional<FundOriginPlatform> fundOriginPlatformValue,
        Optional<EntityRefsResponse> entityRefsResponseValue)
    {
        _fundOriginPlatformValue = fundOriginPlatformValue;
        _entityRefsResponseValue = entityRefsResponseValue;
    }

    public static FundOriginsModelFunding FundOriginPlatform(FundOriginPlatform value) =>
        new(Optional<FundOriginPlatform>.Some(value), default);

    public static FundOriginsModelFunding EntityRefsResponse(EntityRefsResponse value) =>
        new(default, Optional<EntityRefsResponse>.Some(value));

    public bool TryGetFundOriginPlatform(out FundOriginPlatform value) =>
        _fundOriginPlatformValue.TryGetValue(out value);

    public bool TryGetEntityRefsResponse(out EntityRefsResponse value) =>
        _entityRefsResponseValue.TryGetValue(out value);

    public static implicit operator FundOriginsModelFunding(FundOriginPlatform value) => FundOriginPlatform(value);

    public static implicit operator FundOriginsModelFunding(EntityRefsResponse value) => EntityRefsResponse(value);
}

file sealed class FundOriginsModelFundingConverter : JsonConverter<FundOriginsModelFunding>
{
    public override FundOriginsModelFunding Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<FundOriginPlatform>(root, options, out var fundOriginPlatformValue))
        {
            return FundOriginsModelFunding.FundOriginPlatform(fundOriginPlatformValue);
        }
        if (JsonSerializer.TryDeserialize<EntityRefsResponse>(root, options, out var entityRefsResponseValue))
        {
            return FundOriginsModelFunding.EntityRefsResponse(entityRefsResponseValue);
        }
        throw new JsonException(
            $"JSON does not match FundOriginPlatform or EntityRefsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FundOriginsModelFunding value, JsonSerializerOptions options)
    {
        if (value.TryGetFundOriginPlatform(out var fundOriginPlatformValue))
        {
            JsonSerializer.Serialize(writer, fundOriginPlatformValue, options);
        }
        else if (value.TryGetEntityRefsResponse(out var entityRefsResponseValue))
        {
            JsonSerializer.Serialize(writer, entityRefsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(FundOriginsModelFunding)} contains no valid value to serialize.");
        }
    }
}
