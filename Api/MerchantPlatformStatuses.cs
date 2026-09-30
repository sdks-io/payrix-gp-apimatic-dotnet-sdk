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
using Payrix.Requests.MerchantPlatformStatuses;

namespace Payrix.Api;

/// <summary>
/// Merchant Platform Statuses provides access to view the status of a merchant's onboarding process to Payrix Pro, including the activation of individual value-added services.
/// </summary>
public sealed class MerchantPlatformStatuses
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal MerchantPlatformStatuses(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getMerchantPlatformStatuses
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MerchantPlatformStatusesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantPlatformStatusesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Merchant Platform Statuses.
    /// </remarks>
    public Task<MerchantPlatformStatusesResponseResult> GetMerchantPlatformStatuses(GetMerchantPlatformStatusesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/merchantPlatformStatuses"),
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
            JsonResponse.Create<MerchantPlatformStatusesResponseResult>(),
            GetMerchantPlatformStatusesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getMerchantPlatformStatusesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MerchantPlatformStatusesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantPlatformStatusesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a merchantPlatformStatuses.
    /// </remarks>
    public Task<MerchantPlatformStatusesResponseResult> GetMerchantPlatformStatusesId(GetMerchantPlatformStatusesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/merchantPlatformStatuses/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MerchantPlatformStatusesResponseResult>(),
            GetMerchantPlatformStatusesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
