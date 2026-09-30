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
using Payrix.Requests.Tokens;

namespace Payrix.Api;

/// <summary>
/// Tokens provide the means through which to safely and securely store payment methods (e.g. credit cards or bank accounts) for later use.
/// </summary>
public sealed class Tokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Tokens(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Token, which is a resource that acts as a storage place for credit card and customer information, allowing you to run Transactions.
    /// </remarks>
    public Task<TokensResponseResult> DeleteTokensId(DeleteTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TokensResponseResult>(),
            DeleteTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Token. A Token is a resource that acts as a storage place for credit card and customer information. You can use a Token to run Transactions.
    /// </remarks>
    public Task<TokensResponseResult> GetTokens(GetTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tokens"),
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
            JsonResponse.Create<TokensResponseResult>(),
            GetTokensError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Token, which is a resource that acts as a storage place for credit card and customer information, allowing you to run Transactions.
    /// </remarks>
    public Task<TokensResponseResult> GetTokensId(GetTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokensResponseResult>(),
            GetTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Token. A Token is a resource that acts as a storage place for credit card and customer information. You can use a Token to run Transactions.
    /// </remarks>
    public Task<TokensResponseResult> PostTokens(PostTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tokens"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TokensResponseResult>(),
            PostTokensError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Token, which is a resource that acts as a storage place for credit card and customer information, allowing you to run Transactions.
    /// </remarks>
    public Task<TokensResponseResult> PutTokensId(PutTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/tokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("token", request.Token), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TokensResponseResult>(),
            PutTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
