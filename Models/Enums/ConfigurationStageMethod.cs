using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfigurationStageMethod>))]
public sealed record ConfigurationStageMethod : OpenStringEnum<ConfigurationStageMethod>
{
    private ConfigurationStageMethod(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageMethod SftpUpload = new("sftpUpload");

    public static readonly ConfigurationStageMethod SftpDownload = new("sftpDownload");

    public static readonly ConfigurationStageMethod Post = new("post");

    public static readonly ConfigurationStageMethod Get = new("get");

    public static readonly ConfigurationStageMethod Put = new("put");

    public static readonly ConfigurationStageMethod Delete = new("delete");

    public static readonly ConfigurationStageMethod Tcp = new("tcp");

    public TResult Match<TResult>(Func<TResult> onSftpUpload,
        Func<TResult> onSftpDownload,
        Func<TResult> onPost,
        Func<TResult> onGet,
        Func<TResult> onPut,
        Func<TResult> onDelete,
        Func<TResult> onTcp,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SftpUpload => onSftpUpload(),
            _ when this == SftpDownload => onSftpDownload(),
            _ when this == Post => onPost(),
            _ when this == Get => onGet(),
            _ when this == Put => onPut(),
            _ when this == Delete => onDelete(),
            _ when this == Tcp => onTcp(),
            _ => otherwise(Value)
        };

    public void Match(Action onSftpUpload,
        Action onSftpDownload,
        Action onPost,
        Action onGet,
        Action onPut,
        Action onDelete,
        Action onTcp,
        Action<string> otherwise)
    {
        if (this == SftpUpload) onSftpUpload();
        else if (this == SftpDownload) onSftpDownload();
        else if (this == Post) onPost();
        else if (this == Get) onGet();
        else if (this == Put) onPut();
        else if (this == Delete) onDelete();
        else if (this == Tcp) onTcp();
        else otherwise(Value);
    }
}
