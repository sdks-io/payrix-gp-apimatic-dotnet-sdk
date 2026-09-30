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
using Payrix.Requests.SaferPayments;

namespace Payrix.Api;

/// <summary>
/// Safer Payments provides access to create, view, and update SaferPayments Value Added Service records.
/// </summary>
public sealed class SaferPayments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SaferPayments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getSaferPayments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SaferPaymentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSaferPaymentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Safer Payments.
    /// </remarks>
    public Task<SaferPaymentsResponseResult> GetSaferPayments(GetSaferPaymentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/saferPayments"),
            [],
            [
                new Param("page[number]", request.PageNumber),
                new Param("page[limit]", request.PageLimit),
                new Param("embed", request.Embed),
            ],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("search", request.Search),
                new HeaderParam("totals", request.Totals),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SaferPaymentsResponseResult>(),
            GetSaferPaymentsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSaferPaymentsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SaferPaymentsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSaferPaymentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Safer Payment.
    /// </remarks>
    public Task<SaferPaymentsResponseResult> GetSaferPaymentsId(GetSaferPaymentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/saferPayments/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SaferPaymentsResponseResult>(),
            GetSaferPaymentsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
