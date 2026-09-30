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
using Payrix.Requests.TxnSessions;

namespace Payrix.Api;

/// <summary>
/// The txnSessionKey is designed to securely handle transactions within Payrix Pro PayFields/PayFrame integrations. This key aims to prevent misuse by third parties, as it is hosted on the front-end side. Unlike the public apiKey, which is vulnerable to bot attacks and fraudulent activities, the txnSessionKey offers enhanced security. Partners can generate keys with various configurations, including default values or customized settings.
/// </summary>
public sealed class TxnSessions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TxnSessions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteTxnSessionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnSessionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteTxnSessionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a TxnSession.
    /// A TxnSession represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field.
    /// They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.
    /// </remarks>
    public Task<TxnSessionsResponseResult> DeleteTxnSessionsId(DeleteTxnSessionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnSessions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TxnSessionsResponseResult>(),
            DeleteTxnSessionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTxnSessions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnSessionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnSessionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a TxnSession.
    /// A TxnSession represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field.
    /// They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.
    /// </remarks>
    public Task<TxnSessionsResponseResult> GetTxnSessions(GetTxnSessionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnSessions"),
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
            JsonResponse.Create<TxnSessionsResponseResult>(),
            GetTxnSessionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTxnSessionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnSessionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTxnSessionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a TxnSession.
    /// A TxnSession represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field.
    /// They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.
    /// </remarks>
    public Task<TxnSessionsResponseResult> GetTxnSessionsId(GetTxnSessionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnSessions/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TxnSessionsResponseResult>(),
            GetTxnSessionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTxnSessions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TxnSessionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTxnSessionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a TxnSession.
    /// A TxnSessions represents a temporary method of authentication to the API. Each TxnSession expires automatically after 10 minutes of inactivity or by the customizable configurations field.
    /// They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, TxnSessions are not permanent.
    /// </remarks>
    public Task<TxnSessionsResponseResult> PostTxnSessions(PostTxnSessionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/txnSessions"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TxnSessionsResponseResult>(),
            PostTxnSessionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
