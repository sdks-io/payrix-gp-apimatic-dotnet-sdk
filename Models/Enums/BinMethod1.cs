using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of payment method used for this transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Unknown Payment Method</b></description></item>
///   <item><description><c>1</c> - <b>American Express</b></description></item>
///   <item><description><c>2</c> - <b>Visa</b></description></item>
///   <item><description><c>3</c> - <b>MasterCard</b></description></item>
///   <item><description><c>4</c> - <b>Diners Club</b></description></item>
///   <item><description><c>5</c> - <b>Discover</b></description></item>
///   <item><description><c>6</c> - <b>PayPal</b></description></item>
///   <item><description><c>7</c> - <b>Debit Card</b></description></item>
///   <item><description><c>8</c> - <b>Checking Account</b></description></item>
///   <item><description><c>9</c> - <b>Savings Account</b></description></item>
///   <item><description><c>10</c> - <b>Corporate Checking Account</b></description></item>
///   <item><description><c>11</c> - <b>Corporate Savings Account</b></description></item>
///   <item><description><c>12</c> - <b>Gift Card</b></description></item>
///   <item><description><c>13</c> - <b>EBT (Electronic Benefits Transfer) Card</b></description></item>
///   <item><description><c>14</c> - <b>WIC (Women, Infants and Children) Card</b></description></item>
///   <item><description><c>15</c> - <b>Accel</b></description></item>
///   <item><description><c>16</c> - <b>ATH</b></description></item>
///   <item><description><c>17</c> - <b>AFFN</b></description></item>
///   <item><description><c>18</c> - <b>Culiance</b></description></item>
///   <item><description><c>19</c> - <b>Interlink</b></description></item>
///   <item><description><c>20</c> - <b>Jeanie</b></description></item>
///   <item><description><c>21</c> - <b>Maestro</b></description></item>
///   <item><description><c>22</c> - <b>NYCE</b></description></item>
///   <item><description><c>23</c> - <b>Pulse</b></description></item>
///   <item><description><c>24</c> - <b>Shazam</b></description></item>
///   <item><description><c>25</c> - <b>Star</b></description></item>
///   <item><description><c>26</c> - <b>Interac</b></description></item>
///   <item><description><c>27</c> - <b>OmniToken</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<BinMethod1>))]
public sealed record BinMethod1 : OpenIntEnum<BinMethod1>
{
    private BinMethod1(long value) : base(value)
    {
    }

    public static readonly BinMethod1 Value0 = new(0L);

    public static readonly BinMethod1 Value1 = new(1L);

    public static readonly BinMethod1 Value2 = new(2L);

    public static readonly BinMethod1 Value3 = new(3L);

    public static readonly BinMethod1 Value4 = new(4L);

    public static readonly BinMethod1 Value5 = new(5L);

    public static readonly BinMethod1 Value6 = new(6L);

    public static readonly BinMethod1 Value7 = new(7L);

    public static readonly BinMethod1 Value8 = new(8L);

    public static readonly BinMethod1 Value9 = new(9L);

    public static readonly BinMethod1 Value10 = new(10L);

    public static readonly BinMethod1 Value11 = new(11L);

    public static readonly BinMethod1 Value12 = new(12L);

    public static readonly BinMethod1 Value13 = new(13L);

    public static readonly BinMethod1 Value14 = new(14L);

    public static readonly BinMethod1 Value15 = new(15L);

    public static readonly BinMethod1 Value16 = new(16L);

    public static readonly BinMethod1 Value17 = new(17L);

    public static readonly BinMethod1 Value18 = new(18L);

    public static readonly BinMethod1 Value19 = new(19L);

    public static readonly BinMethod1 Value20 = new(20L);

    public static readonly BinMethod1 Value21 = new(21L);

    public static readonly BinMethod1 Value22 = new(22L);

    public static readonly BinMethod1 Value23 = new(23L);

    public static readonly BinMethod1 Value24 = new(24L);

    public static readonly BinMethod1 Value25 = new(25L);

    public static readonly BinMethod1 Value26 = new(26L);

    public static readonly BinMethod1 Value27 = new(27L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<TResult> onValue10,
        Func<TResult> onValue11,
        Func<TResult> onValue12,
        Func<TResult> onValue13,
        Func<TResult> onValue14,
        Func<TResult> onValue15,
        Func<TResult> onValue16,
        Func<TResult> onValue17,
        Func<TResult> onValue18,
        Func<TResult> onValue19,
        Func<TResult> onValue20,
        Func<TResult> onValue21,
        Func<TResult> onValue22,
        Func<TResult> onValue23,
        Func<TResult> onValue24,
        Func<TResult> onValue25,
        Func<TResult> onValue26,
        Func<TResult> onValue27,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ when this == Value10 => onValue10(),
            _ when this == Value11 => onValue11(),
            _ when this == Value12 => onValue12(),
            _ when this == Value13 => onValue13(),
            _ when this == Value14 => onValue14(),
            _ when this == Value15 => onValue15(),
            _ when this == Value16 => onValue16(),
            _ when this == Value17 => onValue17(),
            _ when this == Value18 => onValue18(),
            _ when this == Value19 => onValue19(),
            _ when this == Value20 => onValue20(),
            _ when this == Value21 => onValue21(),
            _ when this == Value22 => onValue22(),
            _ when this == Value23 => onValue23(),
            _ when this == Value24 => onValue24(),
            _ when this == Value25 => onValue25(),
            _ when this == Value26 => onValue26(),
            _ when this == Value27 => onValue27(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0,
        Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue7,
        Action onValue8,
        Action onValue9,
        Action onValue10,
        Action onValue11,
        Action onValue12,
        Action onValue13,
        Action onValue14,
        Action onValue15,
        Action onValue16,
        Action onValue17,
        Action onValue18,
        Action onValue19,
        Action onValue20,
        Action onValue21,
        Action onValue22,
        Action onValue23,
        Action onValue24,
        Action onValue25,
        Action onValue26,
        Action onValue27,
        Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else if (this == Value10) onValue10();
        else if (this == Value11) onValue11();
        else if (this == Value12) onValue12();
        else if (this == Value13) onValue13();
        else if (this == Value14) onValue14();
        else if (this == Value15) onValue15();
        else if (this == Value16) onValue16();
        else if (this == Value17) onValue17();
        else if (this == Value18) onValue18();
        else if (this == Value19) onValue19();
        else if (this == Value20) onValue20();
        else if (this == Value21) onValue21();
        else if (this == Value22) onValue22();
        else if (this == Value23) onValue23();
        else if (this == Value24) onValue24();
        else if (this == Value25) onValue25();
        else if (this == Value26) onValue26();
        else if (this == Value27) onValue27();
        else otherwise(Value);
    }
}
