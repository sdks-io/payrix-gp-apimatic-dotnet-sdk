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
using Payrix.Requests.Subscriptions;

namespace Payrix.Api;

/// <summary>
/// Resources that deal with customer subscriptions to a plan. Customers are subscribed to plans to allow for recurring payments to be made from that customer.
/// </summary>
public sealed class Subscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Subscriptions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteSubscriptionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteSubscriptionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Subscription. A Subscription is a scheduled invocation of a particular Plan over a certain period of time, specifying both starting and ending dates, and the customer is charged according to the schedule in the associated Plan during the interval between these dates.
    /// </remarks>
    public Task<SubscriptionResponseResult> DeleteSubscriptionsId(DeleteSubscriptionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SubscriptionResponseResult>(),
            DeleteSubscriptionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSubscriptions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSubscriptionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Subscription.
    /// A Subscription is a scheduled invocation of a particular Plan over a certain period of time.
    /// A Subscription specifies both starting and ending dates and the customer is charged according to the schedule in the associated Plan during the interval between these dates.
    /// </remarks>
    public Task<SubscriptionResponseResult> GetSubscriptions(GetSubscriptionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptions"),
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
            JsonResponse.Create<SubscriptionResponseResult>(),
            GetSubscriptionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSubscriptionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSubscriptionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Subscription that specifies both starting and ending dates and charges the customer according to the schedule in the associated Plan during the interval between these dates.
    /// </remarks>
    public Task<SubscriptionResponseResult> GetSubscriptionsId(GetSubscriptionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptions/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SubscriptionResponseResult>(),
            GetSubscriptionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postSubscriptions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostSubscriptionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Subscription.
    /// A Subscription is a scheduled invocation of a particular Plan over a certain period of time.
    /// A Subscription specifies both starting and ending dates and the customer is charged according to the schedule in the associated Plan during the interval between these dates.
    /// </remarks>
    public Task<SubscriptionResponseResult> PostSubscriptions(PostSubscriptionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptions"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SubscriptionResponseResult>(),
            PostSubscriptionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putSubscriptionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubscriptionResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutSubscriptionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Subscription, A Subscription specifies both starting and ending dates and the customer is charged according to the schedule in the associated Plan during the interval between these dates.
    /// </remarks>
    public Task<SubscriptionResponseResult> PutSubscriptionsId(PutSubscriptionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/subscriptions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SubscriptionResponseResult>(),
            PutSubscriptionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
