using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of secret.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>baseKey</c> - <b>Base Derivation Key.</b></description></item>
///   <item><description><c>sftp</c> - <b>SFTP Server Key.</b></description></item>
///   <item><description><c>publicKey</c> - <b>Public Key.</b></description></item>
///   <item><description><c>privateKey</c> - <b>Private Key.</b></description></item>
///   <item><description><c>ecPrivateKey</c> - <b>Elliptic Curve Private Key.</b></description></item>
///   <item><description><c>apikey</c> - <b>API Key.</b></description></item>
///   <item><description><c>oldPrivateKey</c> - <b>Expired Private Key.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SecretType1>))]
public sealed record SecretType1 : OpenStringEnum<SecretType1>
{
    private SecretType1(string value) : base(value)
    {
    }

    public static readonly SecretType1 BaseKey = new("baseKey");

    public static readonly SecretType1 Sftp = new("sftp");

    public static readonly SecretType1 PublicKey = new("publicKey");

    public static readonly SecretType1 PrivateKey = new("privateKey");

    public static readonly SecretType1 EcPrivateKey = new("ecPrivateKey");

    public static readonly SecretType1 Apikey = new("apikey");

    public static readonly SecretType1 OldPrivateKey = new("oldPrivateKey");

    public TResult Match<TResult>(Func<TResult> onBaseKey,
        Func<TResult> onSftp,
        Func<TResult> onPublicKey,
        Func<TResult> onPrivateKey,
        Func<TResult> onEcPrivateKey,
        Func<TResult> onApikey,
        Func<TResult> onOldPrivateKey,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BaseKey => onBaseKey(),
            _ when this == Sftp => onSftp(),
            _ when this == PublicKey => onPublicKey(),
            _ when this == PrivateKey => onPrivateKey(),
            _ when this == EcPrivateKey => onEcPrivateKey(),
            _ when this == Apikey => onApikey(),
            _ when this == OldPrivateKey => onOldPrivateKey(),
            _ => otherwise(Value)
        };

    public void Match(Action onBaseKey,
        Action onSftp,
        Action onPublicKey,
        Action onPrivateKey,
        Action onEcPrivateKey,
        Action onApikey,
        Action onOldPrivateKey,
        Action<string> otherwise)
    {
        if (this == BaseKey) onBaseKey();
        else if (this == Sftp) onSftp();
        else if (this == PublicKey) onPublicKey();
        else if (this == PrivateKey) onPrivateKey();
        else if (this == EcPrivateKey) onEcPrivateKey();
        else if (this == Apikey) onApikey();
        else if (this == OldPrivateKey) onOldPrivateKey();
        else otherwise(Value);
    }
}
