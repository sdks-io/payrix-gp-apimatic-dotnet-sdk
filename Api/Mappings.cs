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
using Payrix.Requests.Mappings;

namespace Payrix.Api;

/// <summary>
/// Mappings enable the re-mapping of fields in the API for either in or out, using a set of JSON field mappings.  For example, if your system uses a different format for out data that it will send to the API, then you can re-map the in fields for the API using a Mapping resource.
/// </summary>
public sealed class Mappings
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Mappings(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteMappingsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MappingsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteMappingsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Mapping. A Mapping represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings.
    /// </remarks>
    public Task<MappingsResponseResult> DeleteMappingsId(DeleteMappingsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/mappings/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<MappingsResponseResult>(),
            DeleteMappingsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getMappings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MappingsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMappingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Mapping resource.
    /// A Mapping resource represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings.
    /// For example, if your system uses a different format for output data that it will send to the API, then you can re-map the input fields for the API using a Mapping resource.
    /// </remarks>
    public Task<MappingsResponseResult> GetMappings(GetMappingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/mappings"),
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
            JsonResponse.Create<MappingsResponseResult>(),
            GetMappingsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getMappingsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MappingsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMappingsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Mapping resource.
    /// </remarks>
    public Task<MappingsResponseResult> GetMappingsId(GetMappingsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/mappings/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MappingsResponseResult>(),
            GetMappingsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postMappings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MappingsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMappingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Mapping resource.
    /// A Mapping resource represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings.
    /// For example, if your system uses a different format for output data that it will send to the API, then you can re-map the input fields for the API using a Mapping resource.
    /// </remarks>
    public Task<MappingsResponseResult> PostMappings(PostMappingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/mappings"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<MappingsResponseResult>(),
            PostMappingsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putMappingsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MappingsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutMappingsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Mapping. A Mapping represents a way to re-map the fields in the API for either input or output, using a set of JSON field mappings. For example, if your system uses a different format for output data that it will send to the API, then you can re-map the input fields for the API using a Mapping.
    /// </remarks>
    public Task<MappingsResponseResult> PutMappingsId(PutMappingsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/mappings/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<MappingsResponseResult>(),
            PutMappingsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
