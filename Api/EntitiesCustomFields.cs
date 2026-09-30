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
using Payrix.Requests.EntitiesCustomFields;

namespace Payrix.Api;

/// <summary>
/// the Entity Custom Fields feature, designed to empower partners to send identifiers and Risk-requested items using unlimited custom fields.  By leveraging this feature, partners can ensure that their software works seamlessly, leading to increased Boarding Rates. Additionally,  partners can avoid waiting for Risk to request information manually, streamlining their operations.
/// </summary>
public sealed class EntitiesCustomFields
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EntitiesCustomFields(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteEntityCustomFieldsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityCustomFieldsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteEntityCustomFieldsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Entity Custom Field.
    /// </remarks>
    public Task<EntityCustomFieldsResponseResult> DeleteEntityCustomFieldsId(DeleteEntityCustomFieldsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityCustomFields/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<EntityCustomFieldsResponseResult>(),
            DeleteEntityCustomFieldsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEntityCustomFields
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityCustomFieldsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntityCustomFieldsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Entity Custom Field.
    /// Custom Fields can be added to entities associated by the Entity Id.
    /// An Entity Id can have various fields associated to it.
    /// </remarks>
    public Task<EntityCustomFieldsResponseResult> GetEntityCustomFields(GetEntityCustomFieldsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityCustomFields"),
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
            JsonResponse.Create<EntityCustomFieldsResponseResult>(),
            GetEntityCustomFieldsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEntityCustomFieldsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityCustomFieldsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEntityCustomFieldsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Entity Custom Field.
    /// Custom Fields can be added to entities associated by the Entity Id.
    /// An Entity Id can have various fields associated to it.
    /// </remarks>
    public Task<EntityCustomFieldsResponseResult> GetEntityCustomFieldsId(GetEntityCustomFieldsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityCustomFields/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EntityCustomFieldsResponseResult>(),
            GetEntityCustomFieldsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postEntityCustomFields
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityCustomFieldsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostEntityCustomFieldsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Entity Custom Field. Custom Fields can be added to entities associated by the Entity Id. An Entity Id can have various fields associated to it.
    /// </remarks>
    public Task<EntityCustomFieldsResponseResult> PostEntityCustomFields(PostEntityCustomFieldsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityCustomFields"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EntityCustomFieldsResponseResult>(),
            PostEntityCustomFieldsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putEntityCustomFieldsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityCustomFieldsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutEntityCustomFieldsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Entity Custom Field.
    /// Custom Fields can be added to entities associated by the Entity Id.
    /// An Entity Id can have various fields associated to it.
    /// </remarks>
    public Task<EntityCustomFieldsResponseResult> PutEntityCustomFieldsId(PutEntityCustomFieldsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entityCustomFields/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EntityCustomFieldsResponseResult>(),
            PutEntityCustomFieldsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
