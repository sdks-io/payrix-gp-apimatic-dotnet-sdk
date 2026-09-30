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
using Payrix.Requests.ValueAddedServices;

namespace Payrix.Api;

/// <summary>
/// Value Added Services is a collection of additional services and features beyond the core payment processing functionality that provide additional value to the user.
/// </summary>
public sealed class ValueAddedServices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ValueAddedServices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getValueAddedServicesEnablementStatusTargetId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VasEnablementStatusResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetValueAddedServicesEnablementStatusTargetIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve the enablement status of a specific merchant or entity for a Value Added Service (VAS).
    /// </remarks>
    public Task<VasEnablementStatusResponseResult> GetValueAddedServicesEnablementStatusTargetId(GetValueAddedServicesEnablementStatusTargetIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/valueAddedServices/{service}/{target}/{targetId}"),
            [
                new TemplateParam("service", request.Service),
                new TemplateParam("target", request.Target),
                new TemplateParam("targetId", request.TargetId),
            ],
            [],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VasEnablementStatusResponseResult>(),
            GetValueAddedServicesEnablementStatusTargetIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
