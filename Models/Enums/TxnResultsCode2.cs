using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// TxnResult is the result code that is associated with this terminal
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Transaction approved.</b></description></item>
///   <item><description><c>1</c> - <b>Partially approved. The processor has only approved a portion of the total transaction amount.</b></description></item>
///   <item><description><c>2</c> - <b>Declined. The processor has declined the Transaction.</b></description></item>
///   <item><description><c>3</c> - <b>Verification successful, values provided matched.</b></description></item>
///   <item><description><c>4</c> - <b>Verification unsuccessful, values provided did not match.</b></description></item>
///   <item><description><c>5</c> - <b>The ZIP code in the Transaction data does not match the customer details held by the card issuer.</b></description></item>
///   <item><description><c>6</c> - <b>The address in the Transaction data does not match the customer details held by the card issuer.</b></description></item>
///   <item><description><c>7</c> - <b>The name in the Transaction data does not match the customer details held by the card issuer.</b></description></item>
///   <item><description><c>8</c> - <b>The name and phone number in the Transaction data do not match the details held by the card issuer.</b></description></item>
///   <item><description><c>9</c> - <b>The name and email address in the Transaction data do not match the customer details held by the card issuer.</b></description></item>
///   <item><description><c>10</c> - <b>The phone number in the Transaction data does not match the customer details held by the card issuer.</b></description></item>
///   <item><description><c>11</c> - <b>The phone number and email address in the Transaction data do not match the customer details held by the card issuer.</b></description></item>
///   <item><description><c>12</c> - <b>The email address in the Transaction data does not match the customer details held by the card issuer.</b></description></item>
///   <item><description><c>13</c> - <b>The customer name could not be found in the Transaction data.</b></description></item>
///   <item><description><c>14</c> - <b>The customer name and phone number were not found in the Transaction data.</b></description></item>
///   <item><description><c>15</c> - <b>The customer name and email address were not found in the Transaction data.</b></description></item>
///   <item><description><c>16</c> - <b>The customer phone number was not found in the Transaction data.</b></description></item>
///   <item><description><c>17</c> - <b>The customer phone number and email address were not found in the Transaction data.</b></description></item>
///   <item><description><c>18</c> - <b>The customer email address was not found in the Transaction data.</b></description></item>
///   <item><description><c>19</c> - <b>Information about the customer was not found in the Transaction data.</b></description></item>
///   <item><description><c>20</c> - <b>Non-sufficient funds. The customer did not have sufficient credit or balance to cover the Transaction.</b></description></item>
///   <item><description><c>21</c> - <b>The account in the Transaction data is not valid.</b></description></item>
///   <item><description><c>22</c> - <b>The account is unauthorized.</b></description></item>
///   <item><description><c>23</c> - <b>General error.</b></description></item>
///   <item><description><c>24</c> - <b>The ZIP code in the Transaction data was not verified.</b></description></item>
///   <item><description><c>25</c> - <b>The ZIP code and the Address in the Transaction data were not verified.</b></description></item>
///   <item><description><c>26</c> - <b>The Address in the Transaction data was not verified.</b></description></item>
///   <item><description><c>27</c> - <b>Txn did not fail but was not captured.</b></description></item>
///   <item><description><c>28</c> - <b>3DS authentication passed.</b></description></item>
///   <item><description><c>29</c> - <b>3DS authentication is invalid.</b></description></item>
///   <item><description><c>30</c> - <b>3DS authentication failed.</b></description></item>
///   <item><description><c>31</c> - <b>3DS authentication was not validated.</b></description></item>
///   <item><description><c>32</c> - <b>3DS authentication passed without liability shift.</b></description></item>
///   <item><description><c>33</c> - <b>Transaction processing timed out.</b></description></item>
///   <item><description><c>34</c> - **Transaction cancelled</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnResultsCode2>))]
public sealed record TxnResultsCode2 : OpenIntEnum<TxnResultsCode2>
{
    private TxnResultsCode2(long value) : base(value)
    {
    }

    public static readonly TxnResultsCode2 Value0 = new(0L);

    public static readonly TxnResultsCode2 Value1 = new(1L);

    public static readonly TxnResultsCode2 Value2 = new(2L);

    public static readonly TxnResultsCode2 Value3 = new(3L);

    public static readonly TxnResultsCode2 Value4 = new(4L);

    public static readonly TxnResultsCode2 Value5 = new(5L);

    public static readonly TxnResultsCode2 Value6 = new(6L);

    public static readonly TxnResultsCode2 Value7 = new(7L);

    public static readonly TxnResultsCode2 Value8 = new(8L);

    public static readonly TxnResultsCode2 Value9 = new(9L);

    public static readonly TxnResultsCode2 Value10 = new(10L);

    public static readonly TxnResultsCode2 Value11 = new(11L);

    public static readonly TxnResultsCode2 Value12 = new(12L);

    public static readonly TxnResultsCode2 Value13 = new(13L);

    public static readonly TxnResultsCode2 Value14 = new(14L);

    public static readonly TxnResultsCode2 Value15 = new(15L);

    public static readonly TxnResultsCode2 Value16 = new(16L);

    public static readonly TxnResultsCode2 Value17 = new(17L);

    public static readonly TxnResultsCode2 Value18 = new(18L);

    public static readonly TxnResultsCode2 Value19 = new(19L);

    public static readonly TxnResultsCode2 Value20 = new(20L);

    public static readonly TxnResultsCode2 Value21 = new(21L);

    public static readonly TxnResultsCode2 Value22 = new(22L);

    public static readonly TxnResultsCode2 Value23 = new(23L);

    public static readonly TxnResultsCode2 Value24 = new(24L);

    public static readonly TxnResultsCode2 Value25 = new(25L);

    public static readonly TxnResultsCode2 Value26 = new(26L);

    public static readonly TxnResultsCode2 Value27 = new(27L);

    public static readonly TxnResultsCode2 Value28 = new(28L);

    public static readonly TxnResultsCode2 Value29 = new(29L);

    public static readonly TxnResultsCode2 Value30 = new(30L);

    public static readonly TxnResultsCode2 Value31 = new(31L);

    public static readonly TxnResultsCode2 Value32 = new(32L);

    public static readonly TxnResultsCode2 Value33 = new(33L);

    public static readonly TxnResultsCode2 Value34 = new(34L);

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
        Func<TResult> onValue28,
        Func<TResult> onValue29,
        Func<TResult> onValue30,
        Func<TResult> onValue31,
        Func<TResult> onValue32,
        Func<TResult> onValue33,
        Func<TResult> onValue34,
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
            _ when this == Value28 => onValue28(),
            _ when this == Value29 => onValue29(),
            _ when this == Value30 => onValue30(),
            _ when this == Value31 => onValue31(),
            _ when this == Value32 => onValue32(),
            _ when this == Value33 => onValue33(),
            _ when this == Value34 => onValue34(),
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
        Action onValue28,
        Action onValue29,
        Action onValue30,
        Action onValue31,
        Action onValue32,
        Action onValue33,
        Action onValue34,
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
        else if (this == Value28) onValue28();
        else if (this == Value29) onValue29();
        else if (this == Value30) onValue30();
        else if (this == Value31) onValue31();
        else if (this == Value32) onValue32();
        else if (this == Value33) onValue33();
        else if (this == Value34) onValue34();
        else otherwise(Value);
    }
}
