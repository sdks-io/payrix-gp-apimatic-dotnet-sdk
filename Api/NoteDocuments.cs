using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Payrix.Core;
using Payrix.Core.Authentication;
using Payrix.Core.Exceptions;
using Payrix.Core.Models;
using Payrix.Core.Request;
using Payrix.Core.Response;
using Payrix.Errors;
using Payrix.Models;
using Payrix.Requests.NoteDocuments;

namespace Payrix.Api;

/// <summary>
/// Note Documents represents a file that is related to a specific note record.
/// </summary>
public sealed class NoteDocuments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal NoteDocuments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteNoteDocumentsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NoteDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteNoteDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Note Document, which represents a file related to a specific note record.
    /// </remarks>
    public Task<NoteDocumentsResponseResult> DeleteNoteDocumentsId(DeleteNoteDocumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/noteDocuments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<NoteDocumentsResponseResult>(),
            DeleteNoteDocumentsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getNoteDocuments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NoteDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetNoteDocumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Note Document, which represents a file that is related to a specific note record and documents resources.
    /// </remarks>
    public Task<NoteDocumentsResponseResult> GetNoteDocuments(GetNoteDocumentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/noteDocuments"),
            [],
            [
                new Param("page[number]", request.PageNumber),
                new Param("page[limit]", request.PageLimit),
                new Param("embed", request.Embed),
            ],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("search", request.Search),
                new HeaderParam("totals", request.Totals),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NoteDocumentsResponseResult>(),
            GetNoteDocumentsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getNoteDocumentsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NoteDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetNoteDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Note Document that represents a file that is related to a specific note record.
    /// </remarks>
    public Task<NoteDocumentsResponseResult> GetNoteDocumentsId(GetNoteDocumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/noteDocuments/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NoteDocumentsResponseResult>(),
            GetNoteDocumentsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postNoteDocuments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NoteDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostNoteDocumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a note document, representing a file related to a specific note record.
    /// </remarks>
    public Task<NoteDocumentsResponseResult> PostNoteDocuments(PostNoteDocumentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/noteDocuments"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<NoteDocumentsResponseResult>(),
            PostNoteDocumentsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putNoteDocumentsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NoteDocumentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutNoteDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a note document, which represents a file related to a specific note record.
    /// </remarks>
    public Task<NoteDocumentsResponseResult> PutNoteDocumentsId(PutNoteDocumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/noteDocuments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<NoteDocumentsResponseResult>(),
            PutNoteDocumentsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
