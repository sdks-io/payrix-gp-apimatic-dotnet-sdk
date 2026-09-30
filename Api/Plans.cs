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
using Payrix.Requests.Plans;

namespace Payrix.Api;

/// <summary>
/// Resource that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis.
/// </summary>
public sealed class Plans
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Plans(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deletePlansId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlansResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeletePlansIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, once created, allowing association with a Subscription and user.
    /// </remarks>
    public Task<PlansResponseResult> DeletePlansId(DeletePlansIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/plans/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<PlansResponseResult>(),
            DeletePlansIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPlans
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlansResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPlansError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Plan.
    /// A Plan represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis.
    /// Once you create a Plan, you can associate a Subscription and user with it.
    /// </remarks>
    public Task<PlansResponseResult> GetPlans(GetPlansRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/plans"),
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
            JsonResponse.Create<PlansResponseResult>(),
            GetPlansError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPlansId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlansResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPlansIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, once created, allowing association with a Subscription and user.
    /// </remarks>
    public Task<PlansResponseResult> GetPlansId(GetPlansIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/plans/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlansResponseResult>(),
            GetPlansIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postPlans
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlansResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPlansError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, which once created, allows you to associate a Subscription and user with it.
    /// </remarks>
    public Task<PlansResponseResult> PostPlans(PostPlansRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/plans"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PlansResponseResult>(),
            PostPlansError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putPlansId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlansResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutPlansIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Plan that represents a recurring type of payment that charges a certain amount on a weekly, monthly, quarterly, or annual basis, once created, allowing association with a Subscription and user.
    /// </remarks>
    public Task<PlansResponseResult> PutPlansId(PutPlansIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/plans/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PlansResponseResult>(),
            PutPlansIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
