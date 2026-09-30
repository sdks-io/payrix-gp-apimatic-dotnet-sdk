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
using Payrix.Requests.Entities;

namespace Payrix.Api;

/// <summary>
/// Entities are portion of a single facilitator, vendor or merchant. Common business-related details for each type of entity are stored here (like name and address) as well as management details (like which login the entity belongs to). ny kind of business within the Payrix Pro API (like board merchants as a facilitator, capture fees as a vendor or accept payments as a merchant) an entity record is required.
/// </summary>
public sealed class Entities
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Entities(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteEntitiesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteEntitiesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Entity, which is the top-level resource of a business in the API and describes the details of that business in its fields, including a Merchant, a Partner, or a Facilitator (payment facilitator).
    /// </remarks>
    public Task<EntitiesResponseResult> DeleteEntitiesId(DeleteEntitiesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<EntitiesResponseResult>(),
            DeleteEntitiesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEntities
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntitiesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query entities. An Entity is the top-level resource of a business in the API, describing the details of that business in its fields. Each entity can describe a Merchant, a Partner, or a Facilitator (payment facilitator).
    /// </remarks>
    public Task<EntitiesResponseResult> GetEntities(GetEntitiesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities"),
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
            JsonResponse.Create<EntitiesResponseResult>(),
            GetEntitiesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEntitiesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntitiesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Entity, which is the top-level resource of a business in the API and describes the details of that business in its fields. An Entity can describe a Merchant, a Partner, or a Facilitator (payment facilitator).
    /// </remarks>
    public Task<EntitiesResponseResult> GetEntitiesId(GetEntitiesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EntitiesResponseResult>(),
            GetEntitiesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEntitiesIdNextPayout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityNextPayoutResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntitiesIdNextPayoutError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve the next Payout that is scheduled to process for an Entity, including the date it is due, the amount, and the last 4 digits of the account it is paid to.
    /// <para>
    /// If the Entity has no upcoming Payout, the API still returns a 200 response. In that case the response contains an entry in the 'errors' array and no 'data' array.
    /// </para>
    /// </remarks>
    public Task<EntityNextPayoutResponseResult> GetEntitiesIdNextPayout(GetEntitiesIdNextPayoutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities/{id}/nextPayout"),
            [new TemplateParam("id", request.Id)],
            [new Param("excludeSingle", request.ExcludeSingle)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EntityNextPayoutResponseResult>(),
            GetEntitiesIdNextPayoutError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postEntities
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostEntitiesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Entity, the top-level resource of a business in the API, describing its details through fields. An entity can represent a Merchant, a Partner, or a Facilitator (payment facilitator).
    /// </remarks>
    public Task<EntitiesResponseResult> PostEntities(PostEntitiesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EntitiesResponseResult>(),
            PostEntitiesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putEntitiesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntitiesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutEntitiesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Entity, which is the top-level resource of a business in the API and describes the details of that business in its fields. An Entity can be a Merchant, a Partner, or a Facilitator (payment facilitator).
    /// </remarks>
    public Task<EntitiesResponseResult> PutEntitiesId(PutEntitiesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EntitiesResponseResult>(),
            PutEntitiesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
