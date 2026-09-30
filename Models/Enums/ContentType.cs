using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ContentType>))]
public sealed record ContentType : OpenStringEnum<ContentType>
{
    private ContentType(string value) : base(value)
    {
    }

    public static readonly ContentType MultipartFormDataBoundaryCalculatedWhenRequestIsSent = new(
        "multipart/form-data; boundary=<calculated when request is sent>");

    public TResult Match<TResult>(Func<TResult> onMultipartFormDataBoundaryCalculatedWhenRequestIsSent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this ==
                MultipartFormDataBoundaryCalculatedWhenRequestIsSent => onMultipartFormDataBoundaryCalculatedWhenRequestIsSent(),
            _ => otherwise(Value)
        };

    public void Match(Action onMultipartFormDataBoundaryCalculatedWhenRequestIsSent, Action<string> otherwise)
    {
        if (this ==
            MultipartFormDataBoundaryCalculatedWhenRequestIsSent) onMultipartFormDataBoundaryCalculatedWhenRequestIsSent();
        else otherwise(Value);
    }
}
