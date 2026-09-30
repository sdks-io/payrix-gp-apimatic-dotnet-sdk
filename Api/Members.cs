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
using Payrix.Requests.Members;

namespace Payrix.Api;

/// <summary>
/// A member represents a control or beneficiary member of the entity. At least one primary member record is required for merchant boarding.
/// </summary>
public sealed class Members
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Members(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteMembersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MembersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteMembersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Member. A Member is a person who is associated with a Merchant. One Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.
    /// </remarks>
    public Task<MembersResponseResult> DeleteMembersId(DeleteMembersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/members/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<MembersResponseResult>(),
            DeleteMembersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getMembers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MembersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMembersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Member, A Member being a person who is associated with a Merchant, and one Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.
    /// </remarks>
    public Task<MembersResponseResult> GetMembers(GetMembersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/members"),
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
            JsonResponse.Create<MembersResponseResult>(),
            GetMembersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getMembersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MembersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMembersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Member. A Member is a person who is associated with a Merchant; One Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.
    /// </remarks>
    public Task<MembersResponseResult> GetMembersId(GetMembersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/members/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MembersResponseResult>(),
            GetMembersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postMembers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MembersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMembersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Member. A Member is a person who is associated with a Merchant, and one Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.
    /// </remarks>
    public Task<MembersResponseResult> PostMembers(PostMembersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/members"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<MembersResponseResult>(),
            PostMembersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putMembersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MembersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutMembersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Member, A Member is a person who is associated with a Merchant, One Member associated with each Merchant can be the 'primary' Member, meaning the Member with the most share of ownership in the Merchant.
    /// </remarks>
    public Task<MembersResponseResult> PutMembersId(PutMembersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/members/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<MembersResponseResult>(),
            PutMembersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
