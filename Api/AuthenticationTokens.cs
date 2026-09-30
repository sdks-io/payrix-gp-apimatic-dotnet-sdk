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
using Payrix.Requests.AuthenticationTokens;

namespace Payrix.Api;

/// <summary>
/// Tokens provide the means through which to safely and securely store payment methods (e.g. credit cards or bank accounts) for later use. A transaction may be initiated for a customer by providing the token as the source of payment data. Similarly, a subscription may be associated with a token for automated recurring billing on that payment instrument.
/// </summary>
public sealed class AuthenticationTokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AuthenticationTokens(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteAuthTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAuthTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an AuthToken, which is an additional layer of authentication security and tracking for Apikeys and Sessions.
    /// </remarks>
    public Task<AuthTokensResponseResult> DeleteAuthTokensId(DeleteAuthTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/authTokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<AuthTokensResponseResult>(),
            DeleteAuthTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAuthTokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAuthTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an AuthToken, which is an additional layer of authentication security and tracking for Apikeys and Sessions.
    /// </remarks>
    public Task<AuthTokensResponseResult> GetAuthTokens(GetAuthTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/authTokens"),
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
            JsonResponse.Create<AuthTokensResponseResult>(),
            GetAuthTokensError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAuthTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAuthTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an AuthToken, an AuthToken resource is an additional layer of authentication security and tracking for Apikeys and Sessions.
    /// </remarks>
    public Task<AuthTokensResponseResult> GetAuthTokensId(GetAuthTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/authTokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AuthTokensResponseResult>(),
            GetAuthTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postAuthTokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAuthTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an AuthToken to add an additional layer of authentication, security, and tracking for Apikeys and Sessions.
    /// </remarks>
    public Task<AuthTokensResponseResult> PostAuthTokens(PostAuthTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/authTokens"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AuthTokensResponseResult>(),
            PostAuthTokensError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putAuthTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutAuthTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an AuthToken to add an additional layer of authentication security and tracking for Apikeys and Sessions.
    /// </remarks>
    public Task<AuthTokensResponseResult> PutAuthTokensId(PutAuthTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/authTokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AuthTokensResponseResult>(),
            PutAuthTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
