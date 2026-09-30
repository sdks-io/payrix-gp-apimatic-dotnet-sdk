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
using Payrix.Requests.Alerts;

namespace Payrix.Api;

/// <summary>
/// Web alerts, also known as webhooks, are automated notifications sent from the API server when triggered by a specific action that occurs in your portfolio. You can configure the actions that trigger the alerts to notify you of any event that's important to your business model.
/// </summary>
public sealed class Alerts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Alerts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteAlertsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAlertsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Alert resource, which represents a particular event notification delivered to a user, and you can invoke alerts by setting up triggers in an alertTriggers resource.
    /// </remarks>
    public Task<AlertsResponseResult> DeleteAlertsId(DeleteAlertsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alerts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<AlertsResponseResult>(),
            DeleteAlertsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAlerts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAlertsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Alert resource, which represents a particular event notification delivered to a user; you can invoke alerts by setting up triggers in an alertTriggers resource.
    /// </remarks>
    public Task<AlertsResponseResult> GetAlerts(GetAlertsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alerts"),
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
            JsonResponse.Create<AlertsResponseResult>(),
            GetAlertsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAlertsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAlertsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Alert resource, which represents a particular event notification delivered to a user, and you can invoke alerts by setting up triggers in an alertTriggers resource.
    /// </remarks>
    public Task<AlertsResponseResult> GetAlertsId(GetAlertsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alerts/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlertsResponseResult>(),
            GetAlertsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postAlerts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAlertsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Alert resource, which represents a particular event notification delivered to a user. You can invoke alerts by setting up triggers in an <see href="/api/payrix/alert-triggers/postAlertTriggers">AlertTriggers</see> resource and specify the delivery method through an alertActions resource. <see href="/api/payrix/alert-actions/getAlertActionsId">Alert Actions</see> represent particular instances of an Alert sent out through specific channels, such as SMS, mobile application notifications, or email. Each Alert Action is associated with an Alert resource.
    /// </remarks>
    public Task<AlertsResponseResult> PostAlerts(PostAlertsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alerts"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AlertsResponseResult>(),
            PostAlertsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putAlertsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlertsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutAlertsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Alert resource, which represents a particular event notification delivered to a user, and you can invoke alerts by setting up triggers in an alertTriggers resource.
    /// </remarks>
    public Task<AlertsResponseResult> PutAlertsId(PutAlertsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/alerts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AlertsResponseResult>(),
            PutAlertsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
