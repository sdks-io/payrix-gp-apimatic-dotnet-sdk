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
using Payrix.Requests.TeamLogins;

namespace Payrix.Api;

/// <summary>
/// Represents the link between a Login and a Team as well as the Login's rights on the Team. The Login resource identified in its login field is considered part of the Team.
/// </summary>
public sealed class TeamLogins
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TeamLogins(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteTeamLoginsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamLoginResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteTeamLoginsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Team Login, which represents the link between a Login and a Team as well as the Login's rights on the Team, where the Login resource identified in its 'login' field is considered part of the Team.
    /// </remarks>
    public Task<TeamLoginResponseResult> DeleteTeamLoginsId(DeleteTeamLoginsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/teamLogins/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TeamLoginResponseResult>(),
            DeleteTeamLoginsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTeamLogins
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamLoginResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTeamLoginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a teamLogins resource.
    /// A teamLogins resource represents the link between a Login and a Team as well as the Login's rights on the Team. The Login resource identified in its 'login' field is considered part of the Team.
    /// </remarks>
    public Task<TeamLoginResponseResult> GetTeamLogins(GetTeamLoginsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/teamLogins"),
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
            JsonResponse.Create<TeamLoginResponseResult>(),
            GetTeamLoginsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getTeamLoginsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamLoginResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTeamLoginsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a teamLogins or Team Login resource that represents the link between a Login and a Team as well as the Login's rights on the Team, where the Login resource identified in its 'login' field is considered part of the Team.
    /// </remarks>
    public Task<TeamLoginResponseResult> GetTeamLoginsId(GetTeamLoginsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/teamLogins/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamLoginResponseResult>(),
            GetTeamLoginsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postTeamLogins
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamLoginResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTeamLoginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a teamLogins resource.
    /// A teamLogins resource represents the link between a Login and a Team as well as the Login's rights on the Team. The Login resource identified in its 'login' field is considered part of the Team.
    /// </remarks>
    public Task<TeamLoginResponseResult> PostTeamLogins(PostTeamLoginsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/teamLogins"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TeamLoginResponseResult>(),
            PostTeamLoginsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putTeamLoginsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamLoginResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutTeamLoginsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a teamLogins or Team Login resource, representing the link between a Login and a Team as well as the Login's rights on the Team, where the Login resource identified in its 'login' field is considered part of the Team.
    /// </remarks>
    public Task<TeamLoginResponseResult> PutTeamLoginsId(PutTeamLoginsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/teamLogins/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TeamLoginResponseResult>(),
            PutTeamLoginsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
