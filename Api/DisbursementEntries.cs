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
using Payrix.Requests.DisbursementEntries;

namespace Payrix.Api;

/// <summary>
/// A record of disbursement amount come from.
/// </summary>
public sealed class DisbursementEntries
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DisbursementEntries(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getDisbursementEntries
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisbursementEntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisbursementEntriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query DisbursementEntries to get records of where each disbursement amount is coming from.
    /// </remarks>
    public Task<DisbursementEntriesResponseResult> GetDisbursementEntries(GetDisbursementEntriesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/disbursementEntries"),
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
            JsonResponse.Create<DisbursementEntriesResponseResult>(),
            GetDisbursementEntriesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getDisbursementEntriesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisbursementEntriesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDisbursementEntriesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Disbursement Entry that is a record of where a disbursement amount is coming from.
    /// </remarks>
    public Task<DisbursementEntriesResponseResult> GetDisbursementEntriesId(GetDisbursementEntriesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/disbursementEntries/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DisbursementEntriesResponseResult>(),
            GetDisbursementEntriesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
