using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the document upload.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>created</c> - <b>The database record has been created.</b></description></item>
///   <item><description><c>processed</c> - <b>The document upload for this record was processed successfully.</b></description></item>
///   <item><description><c>failed</c> - <b>The document upload for this record could not be processed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NoteDocumentStatus1>))]
public sealed record NoteDocumentStatus1 : OpenStringEnum<NoteDocumentStatus1>
{
    private NoteDocumentStatus1(string value) : base(value)
    {
    }

    public static readonly NoteDocumentStatus1 Created = new("created");

    public static readonly NoteDocumentStatus1 Processed = new("processed");

    public static readonly NoteDocumentStatus1 Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onCreated,
        Func<TResult> onProcessed,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ when this == Processed => onProcessed(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated, Action onProcessed, Action onFailed, Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else if (this == Processed) onProcessed();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
