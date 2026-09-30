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
using Payrix.Requests.OrgEntities;

namespace Payrix.Api;

/// <summary>
/// A record of an association between a particular Org and a particular Entity. You can associate Entities with an Org by creating Org Entity resources.  One Org can contain and be associated with many Entities.
/// </summary>
public sealed class OrgEntities
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OrgEntities(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteOrgEntitiesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgEntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteOrgEntitiesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Org Entity. An orgEntity is a record of an association between a particular Org and a particular Entity. One Org can contain and be associated with many Entities.
    /// </remarks>
    public Task<OrgEntitiesResponseResult> DeleteOrgEntitiesId(DeleteOrgEntitiesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgEntities/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<OrgEntitiesResponseResult>(),
            DeleteOrgEntitiesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOrgEntities
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgEntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgEntitiesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an orgEntity.
    /// An orgEntity is a record of an association between a particular Org and a particular Entity.
    /// You can associate Entities with an Org by creating orgEntity resources. One Org can contain and be associated with many Entities.
    /// </remarks>
    public Task<OrgEntitiesResponseResult> GetOrgEntities(GetOrgEntitiesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgEntities"),
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
            JsonResponse.Create<OrgEntitiesResponseResult>(),
            GetOrgEntitiesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOrgEntitiesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgEntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgEntitiesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an orgEntity.
    /// </remarks>
    public Task<OrgEntitiesResponseResult> GetOrgEntitiesId(GetOrgEntitiesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgEntities/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OrgEntitiesResponseResult>(),
            GetOrgEntitiesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postOrgEntities
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgEntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostOrgEntitiesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an orgEntity.
    /// An orgEntity is a record of an association between a particular Org and a particular Entity.
    /// You can associate Entities with an Org by creating orgEntity resources. One Org can contain and be associated with many Entities.
    /// </remarks>
    public Task<OrgEntitiesResponseResult> PostOrgEntities(PostOrgEntitiesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgEntities"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OrgEntitiesResponseResult>(),
            PostOrgEntitiesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putOrgEntitiesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgEntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutOrgEntitiesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an orgEntity.
    /// </remarks>
    public Task<OrgEntitiesResponseResult> PutOrgEntitiesId(PutOrgEntitiesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgEntities/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OrgEntitiesResponseResult>(),
            PutOrgEntitiesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
