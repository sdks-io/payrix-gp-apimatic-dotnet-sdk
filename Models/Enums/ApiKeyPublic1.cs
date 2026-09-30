using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether this API key should have access to only public resources.
/// Public resources include Transactions, Tokens, Customers, and Items.
/// All other resources are private. &lt;details&gt; &lt;summary&gt;Valid Values&lt;/summary&gt;
///  - <c>0</c> - <b>The key can also access private resources.</b>
///  - <c>1</c> - <b>The key can only access public resources.</b>
///  &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ApiKeyPublic1>))]
public sealed record ApiKeyPublic1 : OpenIntEnum<ApiKeyPublic1>
{
    private ApiKeyPublic1(long value) : base(value)
    {
    }

    public static readonly ApiKeyPublic1 Value0 = new(0L);

    public static readonly ApiKeyPublic1 Value1 = new(1L);

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
