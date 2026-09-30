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
using Payrix.Requests.VasEfeOffers;

namespace Payrix.Api;

/// <summary>
/// VAS EfeOffers provides Access to view Embedded Finance offers for Referrers and Merchants, including terms, eligibility and application details.
/// </summary>
public sealed class VasEfeOffers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VasEfeOffers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getVasEfeOffers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VasEfeOffersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetVasEfeOffersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a vasEfeOffers.
    /// </remarks>
    public Task<VasEfeOffersResponseResult> GetVasEfeOffers(GetVasEfeOffersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/vasEfeOffers"),
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
            JsonResponse.Create<VasEfeOffersResponseResult>(),
            GetVasEfeOffersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getVasEfeOffersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VasEfeOffersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetVasEfeOffersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a vasEfeOffers.
    /// </remarks>
    public Task<VasEfeOffersResponseResult> GetVasEfeOffersId(GetVasEfeOffersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/vasEfeOffers/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VasEfeOffersResponseResult>(),
            GetVasEfeOffersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
