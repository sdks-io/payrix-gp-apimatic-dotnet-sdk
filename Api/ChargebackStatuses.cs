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
using Payrix.Requests.ChargebackStatuses;

namespace Payrix.Api;

/// <summary>
/// The logged status changes of a Chargeback.
/// </summary>
public sealed class ChargebackStatuses
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChargebackStatuses(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getChargebackStatuses
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackStatusesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebackStatusesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query ChargebackStatuses. A ChargebackStatuses is the logged status changes of a Chargeback; The resource for each Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.
    /// </remarks>
    public Task<ChargebackStatusesResponseResult> GetChargebackStatuses(GetChargebackStatusesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackStatuses"),
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
            JsonResponse.Create<ChargebackStatusesResponseResult>(),
            GetChargebackStatusesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getChargebackStatusesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargebackStatusesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChargebackStatusesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query ChargebackStatuses. A ChargebackStatuses is the logged status changes of a Chargeback, The resource for each Chargeback gives details of the Chargeback, including the reason why it occurred and the date when it occurred.
    /// </remarks>
    public Task<ChargebackStatusesResponseResult> GetChargebackStatusesId(GetChargebackStatusesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chargebackStatuses/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChargebackStatusesResponseResult>(),
            GetChargebackStatusesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
