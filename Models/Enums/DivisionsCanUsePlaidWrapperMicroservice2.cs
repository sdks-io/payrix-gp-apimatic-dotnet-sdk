using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Describes if the user can use the Plaid Wrapper Microservice or not
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// <para>
///   - <c>0</c> - <b>No.</b>
///   - <c>1</c> - <b>Yes.</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<DivisionsCanUsePlaidWrapperMicroservice2>))]
public sealed record DivisionsCanUsePlaidWrapperMicroservice2 : OpenIntEnum<DivisionsCanUsePlaidWrapperMicroservice2>
{
    private DivisionsCanUsePlaidWrapperMicroservice2(long value) : base(value)
    {
    }

    public static readonly DivisionsCanUsePlaidWrapperMicroservice2 Value0 = new(0L);

    public static readonly DivisionsCanUsePlaidWrapperMicroservice2 Value1 = new(1L);

    public TResult Match<TResult>(Func<TResult> onValue0, Func<TResult> onValue1, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else otherwise(Value);
    }
}
