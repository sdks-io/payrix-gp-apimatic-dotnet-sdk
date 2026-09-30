using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The desired type to take on the referenced Note.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>jpg</c> - <b>JPG Image File Type</b></description></item>
///   <item><description><c>jpeg</c> - <b>JPEG Image File Type</b></description></item>
///   <item><description><c>gif</c> - <b>GIF Image File Type</b></description></item>
///   <item><description><c>png</c> - <b>PNG Image File Type</b></description></item>
///   <item><description><c>pdf</c> - <b>PDF Document File Type</b></description></item>
///   <item><description><c>tif</c> - <b>TIF Tag Image File Type</b></description></item>
///   <item><description><c>tiff</c> - <b>TIFF Tag Image File Type</b></description></item>
///   <item><description><c>txt</c> - <b>TXT Document File Type</b></description></item>
///   <item><description><c>xml</c> - <b>XML Document File Type</b></description></item>
///   <item><description><c>asc</c> - <b>American Standard Code II File Type</b></description></item>
///   <item><description><c>rtf</c> - <b>Rich Text Document File Type</b></description></item>
///   <item><description><c>csv</c> - <b>Comma Separated Values Table File Type</b></description></item>
///   <item><description><c>xls</c> - <b>Microsoft Excel File Type</b></description></item>
///   <item><description><c>doc</c> - <b>Microsoft Word File Type</b></description></item>
///   <item><description><c>odt</c> - <b>OpenDocument Text File Type</b></description></item>
///   <item><description><c>ods</c> - <b>OpenDocument Spreadsheet File Type</b></description></item>
///   <item><description><c>json</c> - <b>JSON Document File Type</b></description></item>
///   <item><description><c>soap</c> - <b>SOAP Document File Type</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NoteDocumentType1>))]
public sealed record NoteDocumentType1 : OpenStringEnum<NoteDocumentType1>
{
    private NoteDocumentType1(string value) : base(value)
    {
    }

    public static readonly NoteDocumentType1 Jpg = new("jpg");

    public static readonly NoteDocumentType1 Jpeg = new("jpeg");

    public static readonly NoteDocumentType1 Gif = new("gif");

    public static readonly NoteDocumentType1 Png = new("png");

    public static readonly NoteDocumentType1 Pdf = new("pdf");

    public static readonly NoteDocumentType1 Tif = new("tif");

    public static readonly NoteDocumentType1 Tiff = new("tiff");

    public static readonly NoteDocumentType1 Txt = new("txt");

    public static readonly NoteDocumentType1 Xml = new("xml");

    public static readonly NoteDocumentType1 Asc = new("asc");

    public static readonly NoteDocumentType1 Rtf = new("rtf");

    public static readonly NoteDocumentType1 Csv = new("csv");

    public static readonly NoteDocumentType1 Xls = new("xls");

    public static readonly NoteDocumentType1 Doc = new("doc");

    public static readonly NoteDocumentType1 Odt = new("odt");

    public static readonly NoteDocumentType1 Ods = new("ods");

    public static readonly NoteDocumentType1 Json = new("json");

    public static readonly NoteDocumentType1 Soap = new("soap");

    public TResult Match<TResult>(Func<TResult> onJpg,
        Func<TResult> onJpeg,
        Func<TResult> onGif,
        Func<TResult> onPng,
        Func<TResult> onPdf,
        Func<TResult> onTif,
        Func<TResult> onTiff,
        Func<TResult> onTxt,
        Func<TResult> onXml,
        Func<TResult> onAsc,
        Func<TResult> onRtf,
        Func<TResult> onCsv,
        Func<TResult> onXls,
        Func<TResult> onDoc,
        Func<TResult> onOdt,
        Func<TResult> onOds,
        Func<TResult> onJson,
        Func<TResult> onSoap,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Jpg => onJpg(),
            _ when this == Jpeg => onJpeg(),
            _ when this == Gif => onGif(),
            _ when this == Png => onPng(),
            _ when this == Pdf => onPdf(),
            _ when this == Tif => onTif(),
            _ when this == Tiff => onTiff(),
            _ when this == Txt => onTxt(),
            _ when this == Xml => onXml(),
            _ when this == Asc => onAsc(),
            _ when this == Rtf => onRtf(),
            _ when this == Csv => onCsv(),
            _ when this == Xls => onXls(),
            _ when this == Doc => onDoc(),
            _ when this == Odt => onOdt(),
            _ when this == Ods => onOds(),
            _ when this == Json => onJson(),
            _ when this == Soap => onSoap(),
            _ => otherwise(Value)
        };

    public void Match(Action onJpg,
        Action onJpeg,
        Action onGif,
        Action onPng,
        Action onPdf,
        Action onTif,
        Action onTiff,
        Action onTxt,
        Action onXml,
        Action onAsc,
        Action onRtf,
        Action onCsv,
        Action onXls,
        Action onDoc,
        Action onOdt,
        Action onOds,
        Action onJson,
        Action onSoap,
        Action<string> otherwise)
    {
        if (this == Jpg) onJpg();
        else if (this == Jpeg) onJpeg();
        else if (this == Gif) onGif();
        else if (this == Png) onPng();
        else if (this == Pdf) onPdf();
        else if (this == Tif) onTif();
        else if (this == Tiff) onTiff();
        else if (this == Txt) onTxt();
        else if (this == Xml) onXml();
        else if (this == Asc) onAsc();
        else if (this == Rtf) onRtf();
        else if (this == Csv) onCsv();
        else if (this == Xls) onXls();
        else if (this == Doc) onDoc();
        else if (this == Odt) onOdt();
        else if (this == Ods) onOds();
        else if (this == Json) onJson();
        else if (this == Soap) onSoap();
        else otherwise(Value);
    }
}
