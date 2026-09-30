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
using Payrix.Requests.MessageThreads;

namespace Payrix.Api;

/// <summary>
/// Represents the sender, receiver, and subject of the Messages resources.
/// </summary>
public sealed class MessageThreads
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal MessageThreads(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getMessageThreads
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MessageThreadsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMessageThreadsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Message Threads resource that represents the sender, receiver, and subject of the Messages resources
    /// </remarks>
    public Task<MessageThreadsResponseResult> GetMessageThreads(GetMessageThreadsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/messageThreads"),
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
            JsonResponse.Create<MessageThreadsResponseResult>(),
            GetMessageThreadsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getMessageThreadsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MessageThreadsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMessageThreadsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Message Thread that represents the sender, receiver, and subject of the Messages resources.
    /// </remarks>
    public Task<MessageThreadsResponseResult> GetMessageThreadsId(GetMessageThreadsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/messageThreads/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MessageThreadsResponseResult>(),
            GetMessageThreadsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putMessageThreadsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MessageThreadsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutMessageThreadsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Message Thread that represents the sender, receiver, and subject of the Messages resources.
    /// </remarks>
    public Task<MessageThreadsResponseResult> PutMessageThreadsId(PutMessageThreadsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/messageThreads/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<MessageThreadsResponseResult>(),
            PutMessageThreadsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
