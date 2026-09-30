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
using Payrix.Requests.ApiKeys;

namespace Payrix.Api;

/// <summary>
/// Interaction with the API requires authentication. For application integration and persistent authentication, an API key is required.
/// </summary>
public sealed class ApiKeys
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiKeys(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteApikeysId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApikeysResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteApikeysIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an API key that represents a permanent method of authentication to the API and remains active until marked as inactive or deleted.
    /// </remarks>
    public Task<ApikeysResponseResult> DeleteApikeysId(DeleteApikeysIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apikeys/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<ApikeysResponseResult>(),
            DeleteApikeysIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getApikeys
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApikeysResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetApikeysError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query API keys that each represents a permanent method of authentication to the API and remains active until marked as inactive or deleted.
    /// </remarks>
    public Task<ApikeysResponseResult> GetApikeys(GetApikeysRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apikeys"),
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
            JsonResponse.Create<ApikeysResponseResult>(),
            GetApikeysError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getApikeysId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApikeysResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetApikeysIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an API key that represents a permanent method of authentication to the API, remaining active until marked as inactive or deleted.
    /// </remarks>
    public Task<ApikeysResponseResult> GetApikeysId(GetApikeysIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apikeys/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApikeysResponseResult>(),
            GetApikeysIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postApikeys
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApikeysResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostApikeysError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an API key that represents a permanent method of authentication to the API. The API key remains active until marked as inactive or deleted.
    /// </remarks>
    public Task<ApikeysResponseResult> PostApikeys(PostApikeysRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apikeys"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ApikeysResponseResult>(),
            PostApikeysError.Response,
            [
                new AuthSchemeAny(
                    _auth.ApiKey,
                    _auth.SessionKey,
                    _auth.TxnSessionKey,
                    new AuthSchemeAll(_auth.Username, _auth.Password)),
            ],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putApikeysId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApikeysResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutApikeysIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an API key, which represents a permanent method of authentication to the API. Each API key remains active until you mark it as inactive or delete it.
    /// </remarks>
    public Task<ApikeysResponseResult> PutApikeysId(PutApikeysIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apikeys/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ApikeysResponseResult>(),
            PutApikeysIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
