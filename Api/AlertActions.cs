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
using Payrix.Requests.AlertActions;

namespace Payrix.Api;

/// <summary>
/// Alert Actions deals with specific action that occurs following a triggered web alert.
/// </summary>
public sealed class AlertActions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AlertActions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteAlertActionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAlertActionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an alertAction.
    /// </remarks>
    public Task<AlertActionsResponseResult> DeleteAlertActionsId(DeleteAlertActionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertActions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<AlertActionsResponseResult>(),
            DeleteAlertActionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAlertActions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAlertActionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an alertAction representing a particular instance of an Alert that is sent out through one particular channel. For example, SMS, mobile application notification, or email, each being associated with an Alert resource.
    /// </remarks>
    public Task<AlertActionsResponseResult> GetAlertActions(GetAlertActionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertActions"),
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
            JsonResponse.Create<AlertActionsResponseResult>(),
            GetAlertActionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAlertActionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAlertActionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an alertAction; An alertAction resource represents a particular instance of an Alert that is sent out through one particular channel, for example, SMS, mobile application notification, or email, each alertAction being associated with an Alert resource.
    /// </remarks>
    public Task<AlertActionsResponseResult> GetAlertActionsId(GetAlertActionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertActions/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlertActionsResponseResult>(),
            GetAlertActionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postAlertActions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAlertActionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an alertAction, which represents a particular instance of an Alert sent out through one particular channel, such as SMS, mobile application notification, or email, and each alertAction is associated with an Alert resource.
    /// </remarks>
    public Task<AlertActionsResponseResult> PostAlertActions(PostAlertActionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertActions"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AlertActionsResponseResult>(),
            PostAlertActionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putAlertActionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutAlertActionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an alertAction representing a particular instance of an Alert that is sent out through one particular channel, for example, SMS, mobile application notification, or email, each being associated with an Alert resource.
    /// </remarks>
    public Task<AlertActionsResponseResult> PutAlertActionsId(PutAlertActionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertActions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AlertActionsResponseResult>(),
            PutAlertActionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
