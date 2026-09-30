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
using Payrix.Requests.OptOuts;

namespace Payrix.Api;

/// <summary>
/// Opt Outs provides the ability to disable merchants or entities from participating in specific Value Added Services, such as FraudSight.
/// </summary>
public sealed class OptOuts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OptOuts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// postOptouts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VasOptOutResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostOptoutsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable a merchant or entity from a specific Value Added Service (VAS). This endpoint allows you to opt out a merchant or entity from participating in available VAS features.
    /// </remarks>
    public Task<VasOptOutResponseResult> PostOptouts(PostOptoutsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/valueAddedServices/{service}/{target}/{targetId}/OptOut"),
            [
                new TemplateParam("service", request.Service),
                new TemplateParam("target", request.Target),
                new TemplateParam("targetId", request.TargetId),
            ],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<VasOptOutResponseResult>(),
            PostOptoutsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
