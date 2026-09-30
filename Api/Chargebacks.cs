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
using Payrix.Requests.Chargebacks;

namespace Payrix.Api;

/// <summary>
/// Resources that deal with chargebacks. A chargeback is a dispute of a purchase that has already been charged to an account that can result in a return of funds.
/// </summary>
public sealed class Chargebacks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Chargebacks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getChargebacks
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebacksResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebacksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Chargebacks. A Chargeback is the reversal of a Transaction, meaning that the funds have been returned to their source. The resource for each Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.
    /// </remarks>
    public Task<ChargebacksResponseResult> GetChargebacks(GetChargebacksRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebacks"),
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
            JsonResponse.Create<ChargebacksResponseResult>(),
            GetChargebacksError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getChargebacksId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebacksResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebacksIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Chargeback. A Chargeback is the reversal of a Transaction and means that the funds have been returned to their source. The resource for a Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.
    /// </remarks>
    public Task<ChargebacksResponseResult> GetChargebacksId(GetChargebacksIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebacks/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChargebacksResponseResult>(),
            GetChargebacksIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
