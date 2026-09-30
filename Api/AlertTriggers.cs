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
using Payrix.Requests.AlertTriggers;

namespace Payrix.Api;

/// <summary>
/// Alert Trigger deals with  triggers associated with web alerts
/// </summary>
public sealed class AlertTriggers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AlertTriggers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteAlertTriggersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertTriggersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAlertTriggersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an alertTrigger resource that represents a set of triggers causing an Alert to be sent, for example levying a Fee or a Payout occurring, each linked to a particular Alert with the action to take set up in the alertActions resource.
    /// </remarks>
    public Task<AlertTriggersResponseResult> DeleteAlertTriggersId(DeleteAlertTriggersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertTriggers/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<AlertTriggersResponseResult>(),
            DeleteAlertTriggersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAlertTriggers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertTriggersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAlertTriggersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an alertTrigger resource that represents a set of triggers that cause an Alert to be sent, where for example this could be the levying of a Fee or a Payout occurring, and each alertTrigger is linked to a particular Alert, with the action to take when an Alert is triggered set up in the alertActions resource.
    /// </remarks>
    public Task<AlertTriggersResponseResult> GetAlertTriggers(GetAlertTriggersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertTriggers"),
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
            JsonResponse.Create<AlertTriggersResponseResult>(),
            GetAlertTriggersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAlertTriggersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertTriggersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAlertTriggersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an alertTrigger resource that represents a set of triggers causing an Alert to be sent, for example, the levying of a Fee or a Payout occurring, each linked to a particular Alert, with the action to take when triggered set up in the alertActions resource.
    /// </remarks>
    public Task<AlertTriggersResponseResult> GetAlertTriggersId(GetAlertTriggersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertTriggers/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlertTriggersResponseResult>(),
            GetAlertTriggersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postAlertTriggers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertTriggersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAlertTriggersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an alertTrigger resource that represents a set of triggers causing an Alert to be sent, such as the levying of a Fee or a Payout occurring, and each alertTrigger is linked to a particular Alert with actions set up in the alertActions resource.
    /// </remarks>
    public Task<AlertTriggersResponseResult> PostAlertTriggers(PostAlertTriggersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertTriggers"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AlertTriggersResponseResult>(),
            PostAlertTriggersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putAlertTriggersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertTriggersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutAlertTriggersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an alertTrigger resource that represents a set of triggers causing an Alert to be sent, for example levying a Fee or a Payout occurring, with each trigger linked to a particular Alert and the action taken when triggered set up in the alertActions resource.
    /// </remarks>
    public Task<AlertTriggersResponseResult> PutAlertTriggersId(PutAlertTriggersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alertTriggers/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AlertTriggersResponseResult>(),
            PutAlertTriggersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
