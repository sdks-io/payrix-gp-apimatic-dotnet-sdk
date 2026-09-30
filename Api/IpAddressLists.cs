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
using Payrix.Requests.IpAddressLists;

namespace Payrix.Api;

/// <summary>
/// An iplist represents a whitelisted or blacklisted IP address or range. As an additional security measure, it may be useful for users to set specific, known IP addresses to be the only allowed IPs for API interaction.
/// </summary>
public sealed class IpAddressLists
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal IpAddressLists(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteIplistsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IplistsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteIplistsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an IP lists resource that represents a list of IP addresses, stored as a range between the lowest and highest IP addresses that should be included.
    /// </remarks>
    public Task<IplistsResponseResult> DeleteIplistsId(DeleteIplistsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/iplists/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IplistsResponseResult>(),
            DeleteIplistsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getIplists
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IplistsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetIplistsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an iplist resource representing a list of IP addresses stored as a range between the lowest and highest IP addresses that should be included, which you can use to whitelist or blacklist particular incoming IP addresses for a given Login.
    /// </remarks>
    public Task<IplistsResponseResult> GetIplists(GetIplistsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/iplists"),
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
            JsonResponse.Create<IplistsResponseResult>(),
            GetIplistsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getIplistsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IplistsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetIplistsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an iplist resource that represents a list of IP addresses stored as a range between the lowest and highest IP addresses, which can be used to whitelist or blacklist particular incoming IP addresses for a given Login.
    /// </remarks>
    public Task<IplistsResponseResult> GetIplistsId(GetIplistsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/iplists/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IplistsResponseResult>(),
            GetIplistsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postIplists
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IplistsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostIplistsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an iplists resource. An IP List represents a list of IP (Internet Protocol) addresses, stored as a range between the lowest and highest IP addresses that should be included.
    /// You can use an IP List to whitelist (allow) or blacklist (deny) particular incoming IP addresses for a given Login. If you set up a whitelist for a Login, then the only allowed IP addresses are those in the whitelist, minus any blacklisted IP addresses. If you do not set up a whitelist for a Login, then all IP addresses are allowed, except for those explicitly blacklisted.
    /// You can select whether to store IPv4 or IPv6 addresses in an IP list.
    /// </remarks>
    public Task<IplistsResponseResult> PostIplists(PostIplistsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/iplists"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IplistsResponseResult>(),
            PostIplistsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putIplistsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IplistsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutIplistsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// _CONFLICT Update an iplist resource that represents a list of IP addresses stored as a range between the lowest and highest IP addresses, which can be used to whitelist or blacklist particular incoming IP addresses for a given Login.
    /// </remarks>
    public Task<IplistsResponseResult> PutIplistsId(PutIplistsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/iplists/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IplistsResponseResult>(),
            PutIplistsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
