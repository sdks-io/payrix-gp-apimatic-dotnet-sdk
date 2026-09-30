using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NoteDocumentType>))]
public sealed record NoteDocumentType : OpenStringEnum<NoteDocumentType>
{
    private NoteDocumentType(string value) : base(value)
    {
    }

    public static readonly NoteDocumentType Jpg = new("jpg");

    public static readonly NoteDocumentType Jpeg = new("jpeg");

    public static readonly NoteDocumentType Gif = new("gif");

    public static readonly NoteDocumentType Png = new("png");

    public static readonly NoteDocumentType Pdf = new("pdf");

    public static readonly NoteDocumentType Tif = new("tif");

    public static readonly NoteDocumentType Tiff = new("tiff");

    public static readonly NoteDocumentType Txt = new("txt");

    public static readonly NoteDocumentType Xml = new("xml");

    public static readonly NoteDocumentType Asc = new("asc");

    public static readonly NoteDocumentType Rtf = new("rtf");

    public static readonly NoteDocumentType Csv = new("csv");

    public static readonly NoteDocumentType Xls = new("xls");

    public static readonly NoteDocumentType Doc = new("doc");

    public static readonly NoteDocumentType Odt = new("odt");

    public static readonly NoteDocumentType Ods = new("ods");

    public static readonly NoteDocumentType Json = new("json");

    public static readonly NoteDocumentType Soap = new("soap");

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
