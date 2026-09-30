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
using Payrix.Requests.RevShareSchedules;

namespace Payrix.Api;

/// <summary>
/// Rev Share Schedules table records the rules for income sharing, detailing who receives and who pays, along with the start and end dates of these rules. It also identifies the partners involved in revenue sharing and specifies the amounts per event.
/// </summary>
public sealed class RevShareSchedules
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RevShareSchedules(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteRevShareSchedulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevShareSchedulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteRevShareSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a revShareSchedule.
    /// </remarks>
    public Task<RevShareSchedulesResponseResult> DeleteRevShareSchedulesId(DeleteRevShareSchedulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revShareSchedules/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<RevShareSchedulesResponseResult>(),
            DeleteRevShareSchedulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getRevShareSchedules
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevShareSchedulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRevShareSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query revShareSchedules.
    /// </remarks>
    public Task<RevShareSchedulesResponseResult> GetRevShareSchedules(GetRevShareSchedulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revShareSchedules"),
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
            JsonResponse.Create<RevShareSchedulesResponseResult>(),
            GetRevShareSchedulesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getRevShareSchedulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevShareSchedulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRevShareSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a revShareSchedule.
    /// </remarks>
    public Task<RevShareSchedulesResponseResult> GetRevShareSchedulesId(GetRevShareSchedulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revShareSchedules/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RevShareSchedulesResponseResult>(),
            GetRevShareSchedulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postRevShareSchedules
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevShareSchedulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRevShareSchedulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a revShareSchedules.
    /// </remarks>
    public Task<RevShareSchedulesResponseResult> PostRevShareSchedules(PostRevShareSchedulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revShareSchedules"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RevShareSchedulesResponseResult>(),
            PostRevShareSchedulesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putRevShareSchedulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevShareSchedulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutRevShareSchedulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a revShareSchedule.
    /// </remarks>
    public Task<RevShareSchedulesResponseResult> PutRevShareSchedulesId(PutRevShareSchedulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revShareSchedules/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RevShareSchedulesResponseResult>(),
            PutRevShareSchedulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
