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
using Payrix.Requests.DecisionRules;

namespace Payrix.Api;

/// <summary>
/// A piece of conditional logic that makes a Decision apply only in certain circumstances.
/// </summary>
public sealed class DecisionRules
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DecisionRules(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteDecisionRulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteDecisionRulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Decision Rule that makes a Decision apply only in certain circumstances, for example, applying an administration charge if a payment is under $50.
    /// </remarks>
    public Task<DecisionRulesResponseResult> DeleteDecisionRulesId(DeleteDecisionRulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionRules/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DecisionRulesResponseResult>(),
            DeleteDecisionRulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getDecisionRules
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDecisionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Decision Rule; A Decision Rule is a piece of conditional logic that makes a Decision apply only in certain circumstances, For example, a Decision Rule could apply an administration charge if a payment is under $50.
    /// </remarks>
    public Task<DecisionRulesResponseResult> GetDecisionRules(GetDecisionRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionRules"),
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
            JsonResponse.Create<DecisionRulesResponseResult>(),
            GetDecisionRulesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getDecisionRulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDecisionRulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Decision Rule that makes a Decision apply only in certain circumstances, such as applying an administration charge if a payment is under $50.
    /// </remarks>
    public Task<DecisionRulesResponseResult> GetDecisionRulesId(GetDecisionRulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionRules/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DecisionRulesResponseResult>(),
            GetDecisionRulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postDecisionRules
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDecisionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Decision Rule that makes a Decision apply only in certain circumstances, such as applying an administration charge if a payment is under $50.
    /// </remarks>
    public Task<DecisionRulesResponseResult> PostDecisionRules(PostDecisionRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionRules"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DecisionRulesResponseResult>(),
            PostDecisionRulesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putDecisionRulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DecisionRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutDecisionRulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Decision Rule that makes a Decision apply only in certain circumstances, for example, applying an administration charge if a payment is under $50.
    /// </remarks>
    public Task<DecisionRulesResponseResult> PutDecisionRulesId(PutDecisionRulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/decisionRules/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DecisionRulesResponseResult>(),
            PutDecisionRulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
