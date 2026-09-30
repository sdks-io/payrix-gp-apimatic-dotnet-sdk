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
using Payrix.Requests.AccountsVerifications;

namespace Payrix.Api;

/// <summary>
/// Accounts Verification represents an attempt to verify the ownership of a particular bank account by verifying a known deposit amount or credential.
/// </summary>
public sealed class AccountsVerifications
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountsVerifications(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getAccountVerifications
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountVerificationsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountVerificationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a list of all account verifications representing attempts to verify the ownership of a particular bank account by verifying a known deposit amount or credential.
    /// </remarks>
    public Task<AccountVerificationsResponseResult> GetAccountVerifications(GetAccountVerificationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/accountVerifications"),
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
            JsonResponse.Create<AccountVerificationsResponseResult>(),
            GetAccountVerificationsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAccountVerificationsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountVerificationsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountVerificationsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a list of all account verifications that query an accountVerifications resource, representing attempts to verify the ownership of a particular bank account by verifying a known deposit amount or credential.
    /// </remarks>
    public Task<AccountVerificationsResponseResult> GetAccountVerificationsId(GetAccountVerificationsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/accountVerifications/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountVerificationsResponseResult>(),
            GetAccountVerificationsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
