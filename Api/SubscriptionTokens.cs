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
using Payrix.Requests.SubscriptionTokens;

namespace Payrix.Api;

/// <summary>
/// Represents an association between a Subscription and a means of payment (Token) for that Subscription.
/// </summary>
public sealed class SubscriptionTokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SubscriptionTokens(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteSubscriptionTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteSubscriptionTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Subscription Token, which represents an association between a Subscription and a means of payment (Token) for that Subscription.
    /// </remarks>
    public Task<SubscriptionTokensResponseResult> DeleteSubscriptionTokensId(DeleteSubscriptionTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptionTokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SubscriptionTokensResponseResult>(),
            DeleteSubscriptionTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSubscriptionTokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSubscriptionTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Subscription Tokens resource.
    /// A Subscription Tokens resource represents an association between a Subscription and a means of payment (Token) for that Subscription.
    /// </remarks>
    public Task<SubscriptionTokensResponseResult> GetSubscriptionTokens(GetSubscriptionTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptionTokens"),
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
            JsonResponse.Create<SubscriptionTokensResponseResult>(),
            GetSubscriptionTokensError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSubscriptionTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSubscriptionTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Subscription Token, which represents an association between a Subscription and a means of payment (Token) for that Subscription.
    /// </remarks>
    public Task<SubscriptionTokensResponseResult> GetSubscriptionTokensId(GetSubscriptionTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptionTokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SubscriptionTokensResponseResult>(),
            GetSubscriptionTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postSubscriptionTokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostSubscriptionTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Subscription Tokens resource.
    /// A Subscription Tokens resource represents an association between a Subscription and a means of payment (Token) for that Subscription.
    /// </remarks>
    public Task<SubscriptionTokensResponseResult> PostSubscriptionTokens(PostSubscriptionTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptionTokens"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SubscriptionTokensResponseResult>(),
            PostSubscriptionTokensError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putSubscriptionTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutSubscriptionTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Subscription Token, which represents an association between a Subscription and a means of payment (Token) for that Subscription.
    /// </remarks>
    public Task<SubscriptionTokensResponseResult> PutSubscriptionTokensId(PutSubscriptionTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptionTokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SubscriptionTokensResponseResult>(),
            PutSubscriptionTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
