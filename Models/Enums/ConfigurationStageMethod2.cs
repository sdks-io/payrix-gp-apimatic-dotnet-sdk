using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The method used for configurationStage resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>sftpUpload</c> - <b>SFtpUpload. Use sftp to Upload</b></description></item>
///   <item><description><c>sftpDownload</c> - <b>sftpDownload. Use sftp to Download</b></description></item>
///   <item><description><c>post</c> - <b>POST. Use a post request</b></description></item>
///   <item><description><c>get</c> - <b>GET. Use a get request</b></description></item>
///   <item><description><c>put</c> - <b>PUT. Use a put request</b></description></item>
///   <item><description><c>delete</c> - <b>DELETE. Use a delete request</b></description></item>
///   <item><description><c>tcp</c> - <b>TCP. Use tcp protocol</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConfigurationStageMethod2>))]
public sealed record ConfigurationStageMethod2 : OpenStringEnum<ConfigurationStageMethod2>
{
    private ConfigurationStageMethod2(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageMethod2 SftpUpload = new("sftpUpload");

    public static readonly ConfigurationStageMethod2 SftpDownload = new("sftpDownload");

    public static readonly ConfigurationStageMethod2 Post = new("post");

    public static readonly ConfigurationStageMethod2 Get = new("get");

    public static readonly ConfigurationStageMethod2 Put = new("put");

    public static readonly ConfigurationStageMethod2 Delete = new("delete");

    public static readonly ConfigurationStageMethod2 Tcp = new("tcp");

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
