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
using Payrix.Requests.Disbursements;

namespace Payrix.Api;

/// <summary>
/// A disbursement represents a movement of funds in an entity's payment account. Records of an occasion where money is either paid to a bank account or received from a bank account.
/// </summary>
public sealed class Disbursements
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Disbursements(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getDisbursements
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisbursementsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisbursementsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Disbursements, each of which represents a record of an occasion where money is either paid to a bank account or received from a bank account.
    /// </remarks>
    public Task<DisbursementsResponseResult> GetDisbursements(GetDisbursementsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/disbursements"),
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
            JsonResponse.Create<DisbursementsResponseResult>(),
            GetDisbursementsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getDisbursementsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisbursementsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisbursementsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Disbursement, which represents a record of an occasion where money is either paid to a bank account or received from a bank account.
    /// </remarks>
    public Task<DisbursementsResponseResult> GetDisbursementsId(GetDisbursementsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/disbursements/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DisbursementsResponseResult>(),
            GetDisbursementsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
