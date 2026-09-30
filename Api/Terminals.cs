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
using Payrix.Requests.Terminals;

namespace Payrix.Api;

/// <summary>
/// Resources for dealing with transaction that occur on physical terminals, such as a table or register.
/// </summary>
public sealed class Terminals
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Terminals(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteTerminalsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteTerminalsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a terminal resource that represents a device/software that will be used to process transactions.
    /// </remarks>
    public Task<TerminalsResponseResult> DeleteTerminalsId(DeleteTerminalsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminals/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalsResponseResult>(),
            DeleteTerminalsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTerminals
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a terminal resource.
    /// A terminal resource represents a device/software that will be used to process transactions.
    /// </remarks>
    public Task<TerminalsResponseResult> GetTerminals(GetTerminalsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminals"),
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
            JsonResponse.Create<TerminalsResponseResult>(),
            GetTerminalsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTerminalsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTerminalsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Terminal resource.
    /// </remarks>
    public Task<TerminalsResponseResult> GetTerminalsId(GetTerminalsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminals/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalsResponseResult>(),
            GetTerminalsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTerminals
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTerminalsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a terminal resource.
    /// A terminal resource represents a device/software that will be used to process transactions.
    /// </remarks>
    public Task<TerminalsResponseResult> PostTerminals(PostTerminalsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminals"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalsResponseResult>(),
            PostTerminalsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putTerminalsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutTerminalsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Terminal resource.
    /// </remarks>
    public Task<TerminalsResponseResult> PutTerminalsId(PutTerminalsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminals/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalsResponseResult>(),
            PutTerminalsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
