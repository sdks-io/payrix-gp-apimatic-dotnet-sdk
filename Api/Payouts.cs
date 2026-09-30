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
using Payrix.Requests.Payouts;

namespace Payrix.Api;

/// <summary>
/// Resource that tracks details that allow a Disbursement to be paid or debited.
/// </summary>
public sealed class Payouts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Payouts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deletePayoutsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeletePayoutsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited. These details include the schedule or trigger, the beneficiary account and the amount.
    /// </remarks>
    public Task<PayoutsResponseResult> DeletePayoutsId(DeletePayoutsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payouts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutsResponseResult>(),
            DeletePayoutsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPayouts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPayoutsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited. These details include the schedule or trigger, the beneficiary account and the amount.
    /// </remarks>
    public Task<PayoutsResponseResult> GetPayouts(GetPayoutsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payouts"),
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
            JsonResponse.Create<PayoutsResponseResult>(),
            GetPayoutsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPayoutsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPayoutsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited; these details include the schedule or trigger, the beneficiary account and the amount.
    /// </remarks>
    public Task<PayoutsResponseResult> GetPayoutsId(GetPayoutsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payouts/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutsResponseResult>(),
            GetPayoutsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postPayouts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPayoutsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited; these details include the schedule or trigger, the beneficiary account and the amount.
    /// </remarks>
    public Task<PayoutsResponseResult> PostPayouts(PostPayoutsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payouts"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PayoutsResponseResult>(),
            PostPayoutsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putPayoutsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutPayoutsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Payout. A Payout is a resource that represents all the details that allow a Disbursement to be paid or debited. These details include the schedule or trigger, the beneficiary account and the amount.
    /// </remarks>
    public Task<PayoutsResponseResult> PutPayoutsId(PutPayoutsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payouts/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PayoutsResponseResult>(),
            PutPayoutsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
