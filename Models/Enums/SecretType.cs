using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SecretType>))]
public sealed record SecretType : OpenStringEnum<SecretType>
{
    private SecretType(string value) : base(value)
    {
    }

    public static readonly SecretType BaseKey = new("baseKey");

    public static readonly SecretType Sftp = new("sftp");

    public static readonly SecretType PublicKey = new("publicKey");

    public static readonly SecretType PrivateKey = new("privateKey");

    public static readonly SecretType EcPrivateKey = new("ecPrivateKey");

    public static readonly SecretType Apikey = new("apikey");

    public static readonly SecretType OldPrivateKey = new("oldPrivateKey");

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
