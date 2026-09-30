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
using Payrix.Requests.LoginsHelpers;

namespace Payrix.Api;

/// <summary>
/// To view and manage utilities that assist with login-related actions such as password resets.
/// </summary>
public sealed class LoginsHelpers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LoginsHelpers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getLoginsHelpers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LoginsHelpersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLoginsHelpersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query loginsHelpers.
    /// </remarks>
    public Task<LoginsHelpersResponseResult> GetLoginsHelpers(GetLoginsHelpersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/loginsHelpers"),
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
            JsonResponse.Create<LoginsHelpersResponseResult>(),
            GetLoginsHelpersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getLoginsHelpersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LoginsHelpersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLoginsHelpersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a loginsHelper.
    /// </remarks>
    public Task<LoginsHelpersResponseResult> GetLoginsHelpersId(GetLoginsHelpersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/loginsHelpers/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LoginsHelpersResponseResult>(),
            GetLoginsHelpersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putLoginsHelpersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LoginsHelpersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutLoginsHelpersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a loginsHelper.
    /// </remarks>
    public Task<LoginsHelpersResponseResult> PutLoginsHelpersId(PutLoginsHelpersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/loginsHelpers/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<LoginsHelpersResponseResult>(),
            PutLoginsHelpersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
