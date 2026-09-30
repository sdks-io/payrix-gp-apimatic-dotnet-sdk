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
using Payrix.Requests.PinlessDebitConversions;

namespace Payrix.Api;

/// <summary>
/// Pinless Debit Conversion is a new Value-Added Service (VAS) in the Payrix system. This feature is designed to generate additional revenue and will follow the same merchant enablement process as value-added services.
/// </summary>
public sealed class PinlessDebitConversions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PinlessDebitConversions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getPinlessDebitConversions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PinlessDebitConversionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPinlessDebitConversionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a pinlessDebitConversions.
    /// </remarks>
    public Task<PinlessDebitConversionsResponseResult> GetPinlessDebitConversions(GetPinlessDebitConversionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pinlessDebitConversions"),
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
            JsonResponse.Create<PinlessDebitConversionsResponseResult>(),
            GetPinlessDebitConversionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPinlessDebitConversionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PinlessDebitConversionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPinlessDebitConversionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a pinlessDebitConversion.
    /// </remarks>
    public Task<PinlessDebitConversionsResponseResult> GetPinlessDebitConversionsId(GetPinlessDebitConversionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pinlessDebitConversions/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PinlessDebitConversionsResponseResult>(),
            GetPinlessDebitConversionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
