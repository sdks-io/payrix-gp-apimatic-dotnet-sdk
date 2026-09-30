using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Note that owns this note documents resource.
/// </summary>
[JsonConverter(typeof(NoteDocumentsModelNoteConverter))]
public record NoteDocumentsModelNote
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<NotesResponse> _notesResponseValue;

    private NoteDocumentsModelNote(Optional<string> stringValue, Optional<NotesResponse> notesResponseValue)
    {
        _stringValue = stringValue;
        _notesResponseValue = notesResponseValue;
    }

    public static NoteDocumentsModelNote String(string value) => new(Optional<string>.Some(value), default);

    public static NoteDocumentsModelNote NotesResponse(NotesResponse value) =>
        new(default, Optional<NotesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetNotesResponse(out NotesResponse value) => _notesResponseValue.TryGetValue(out value);

    public static implicit operator NoteDocumentsModelNote(string value) => String(value);

    public static implicit operator NoteDocumentsModelNote(NotesResponse value) => NotesResponse(value);
}

file sealed class NoteDocumentsModelNoteConverter : JsonConverter<NoteDocumentsModelNote>
{
    public override NoteDocumentsModelNote Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return NoteDocumentsModelNote.String(value);
        }
        if (JsonSerializer.TryDeserialize<NotesResponse>(root, options, out var notesResponseValue))
        {
            return NoteDocumentsModelNote.NotesResponse(notesResponseValue);
        }
        throw new JsonException($"JSON does not match string or NotesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, NoteDocumentsModelNote value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetNotesResponse(out var notesResponseValue))
        {
            JsonSerializer.Serialize(writer, notesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(NoteDocumentsModelNote)} contains no valid value to serialize.");
        }
    }
}
