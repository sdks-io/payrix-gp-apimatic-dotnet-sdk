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
using Payrix.Requests.ChangeRequests;

namespace Payrix.Api;

/// <summary>
/// Change Requests Accounts Verification deals with  payment account details for merchant boarding and entity funding. Ultimately, all the business performed within Payrix Pro (be it merchant transactions, vendor income or facilitator fees) must end up in the entity's payment account.
/// </summary>
public sealed class ChangeRequests
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChangeRequests(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteChangeRequestsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChangeRequestsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteChangeRequestsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Change Request.
    /// ChangeRequests is a resource that manages changes to a certain resource.
    /// </remarks>
    public Task<ChangeRequestsResponseResult> DeleteChangeRequestsId(DeleteChangeRequestsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/changeRequests/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<ChangeRequestsResponseResult>(),
            DeleteChangeRequestsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getChangeRequests
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChangeRequestsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChangeRequestsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Change Request.
    /// ChangeRequests is a resource that manages changes to a certain resource.
    /// </remarks>
    public Task<ChangeRequestsResponseResult> GetChangeRequests(GetChangeRequestsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/changeRequests"),
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
            JsonResponse.Create<ChangeRequestsResponseResult>(),
            GetChangeRequestsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getChangeRequestsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChangeRequestsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetChangeRequestsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Change Request.
    /// ChangeRequests is a resource that manages changes to a certain resource.
    /// </remarks>
    public Task<ChangeRequestsResponseResult> GetChangeRequestsId(GetChangeRequestsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/changeRequests/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChangeRequestsResponseResult>(),
            GetChangeRequestsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
