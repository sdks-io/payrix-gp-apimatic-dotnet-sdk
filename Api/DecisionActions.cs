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
using Payrix.Requests.DecisionActions;

namespace Payrix.Api;

/// <summary>
/// A piece of conditional logic that makes a Verification Result change the application and the decision action in certain circumstance.
/// </summary>
public sealed class DecisionActions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DecisionActions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteDecisionActionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteDecisionActionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Decision Action. A Decision Action is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.
    /// </remarks>
    public Task<DecisionActionsResponseResult> DeleteDecisionActionsId(DeleteDecisionActionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionActions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DecisionActionsResponseResult>(),
            DeleteDecisionActionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getDecisionActions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDecisionActionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Decision Action, A Decision Action is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.
    /// </remarks>
    public Task<DecisionActionsResponseResult> GetDecisionActions(GetDecisionActionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionActions"),
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
            JsonResponse.Create<DecisionActionsResponseResult>(),
            GetDecisionActionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getDecisionActionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDecisionActionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Decision Action, which is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.
    /// </remarks>
    public Task<DecisionActionsResponseResult> GetDecisionActionsId(GetDecisionActionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionActions/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DecisionActionsResponseResult>(),
            GetDecisionActionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postDecisionActions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDecisionActionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Decision Action in conjunction with This resource, which is used to further tune the reactions based on conditions defined in the DecisionAction.
    /// </remarks>
    public Task<DecisionActionsResponseResult> PostDecisionActions(PostDecisionActionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionActions"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DecisionActionsResponseResult>(),
            PostDecisionActionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putDecisionActionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionActionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutDecisionActionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Decision Action, which is a piece of conditional logic that makes a VerificationResult change the application and the decision action in certain circumstances.
    /// </remarks>
    public Task<DecisionActionsResponseResult> PutDecisionActionsId(PutDecisionActionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionActions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DecisionActionsResponseResult>(),
            PutDecisionActionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
