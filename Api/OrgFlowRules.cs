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
using Payrix.Requests.OrgFlowRules;

namespace Payrix.Api;

/// <summary>
/// Org Flow Rules Provides access to manage workflows that add or remove merchants from a group based on specific criteria.
/// </summary>
public sealed class OrgFlowRules
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OrgFlowRules(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteOrgFlowRulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgFlowRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteOrgFlowRulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Org Flow Rule.
    /// </remarks>
    public Task<OrgFlowRulesResponseResult> DeleteOrgFlowRulesId(DeleteOrgFlowRulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgFlowRules/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<OrgFlowRulesResponseResult>(),
            DeleteOrgFlowRulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOrgFlowRules
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgFlowRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgFlowRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an orgFlowRules resource.
    /// </remarks>
    public Task<OrgFlowRulesResponseResult> GetOrgFlowRules(GetOrgFlowRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgFlowRules"),
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
            JsonResponse.Create<OrgFlowRulesResponseResult>(),
            GetOrgFlowRulesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOrgFlowRulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgFlowRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgFlowRulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Org Flow Rules resource.
    /// </remarks>
    public Task<OrgFlowRulesResponseResult> GetOrgFlowRulesId(GetOrgFlowRulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgFlowRules/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OrgFlowRulesResponseResult>(),
            GetOrgFlowRulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postOrgFlowRules
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgFlowRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostOrgFlowRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Org Flow Rule.
    /// </remarks>
    public Task<OrgFlowRulesResponseResult> PostOrgFlowRules(PostOrgFlowRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgFlowRules"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OrgFlowRulesResponseResult>(),
            PostOrgFlowRulesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putOrgFlowRulesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgFlowRulesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutOrgFlowRulesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Org Flow Rule.
    /// </remarks>
    public Task<OrgFlowRulesResponseResult> PutOrgFlowRulesId(PutOrgFlowRulesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgFlowRules/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OrgFlowRulesResponseResult>(),
            PutOrgFlowRulesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
