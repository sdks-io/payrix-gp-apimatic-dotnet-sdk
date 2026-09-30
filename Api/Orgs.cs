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
using Payrix.Requests.Orgs;

namespace Payrix.Api;

/// <summary>
/// Resource that deals with records of all orgs. An org is an arbitrary grouping of entity records that can be attached to other resources as a unit for shared functionality.
/// </summary>
public sealed class Orgs
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Orgs(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteOrgsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteOrgsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Organization, which is a collection of Entities that you can associate with it by creating organization-entity resources.
    /// </remarks>
    public Task<OrgsResponseResult> DeleteOrgsId(DeleteOrgsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgs/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<OrgsResponseResult>(),
            DeleteOrgsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOrgs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Org, which is a collection of Entities, To associate Entities with an Org use the <see href="/api/payrix/org-entities/getOrgEntitiesId">orgEntity</see> endpoint. You will need the created Org ID when adding entities, such as a Merchant, to the Organization.
    /// </remarks>
    public Task<OrgsResponseResult> GetOrgs(GetOrgsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgs"),
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
            JsonResponse.Create<OrgsResponseResult>(),
            GetOrgsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOrgsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Org, which is a collection of Entities that you can associate with by creating orgEntity resources.
    /// </remarks>
    public Task<OrgsResponseResult> GetOrgsId(GetOrgsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgs/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OrgsResponseResult>(),
            GetOrgsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postOrgs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostOrgsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Org which is a collection of Entities, To associate Entities with an Org use the <see href="/api/payrix/org-entities/getOrgEntitiesId">orgEntity</see> endpoint. You will need the created Org ID when adding entities, such as a Merchant, to the Organization.
    /// </remarks>
    public Task<OrgsResponseResult> PostOrgs(PostOrgsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgs"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OrgsResponseResult>(),
            PostOrgsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putOrgsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutOrgsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Org, which is a collection of Entities that you can associate with other entities by creating orgEntity resources.
    /// </remarks>
    public Task<OrgsResponseResult> PutOrgsId(PutOrgsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgs/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<OrgsResponseResult>(),
            PutOrgsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
