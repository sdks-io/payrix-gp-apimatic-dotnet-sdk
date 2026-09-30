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
using Payrix.Requests.ConfirmationCodes;

namespace Payrix.Api;

/// <summary>
/// Represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.
/// </summary>
public sealed class ConfirmationCodes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ConfirmationCodes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteConfirmCodesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConfirmCodesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteConfirmCodesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a confirmCode resource. A confirmCode resource represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.
    /// </remarks>
    public Task<ConfirmCodesResponseResult> DeleteConfirmCodesId(DeleteConfirmCodesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/confirmCodes/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<ConfirmCodesResponseResult>(),
            DeleteConfirmCodesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getConfirmCodes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConfirmCodesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetConfirmCodesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a confirmCode resource. A confirmCode resource represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.
    /// </remarks>
    public Task<ConfirmCodesResponseResult> GetConfirmCodes(GetConfirmCodesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/confirmCodes"),
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
            JsonResponse.Create<ConfirmCodesResponseResult>(),
            GetConfirmCodesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getConfirmCodesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConfirmCodesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetConfirmCodesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a confirmCode resource, which represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.
    /// </remarks>
    public Task<ConfirmCodesResponseResult> GetConfirmCodesId(GetConfirmCodesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/confirmCodes/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("search", request.Search),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConfirmCodesResponseResult>(),
            GetConfirmCodesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postConfirmCodes
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConfirmCodesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostConfirmCodesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a confirmCode resource that represents a unique confirmation code issued to an email address, either when a user indicates that they have forgotten their password, or when the system needs to verify the email address associated with a login.
    /// </remarks>
    public Task<ConfirmCodesResponseResult> PostConfirmCodes(PostConfirmCodesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/confirmCodes"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ConfirmCodesResponseResult>(),
            PostConfirmCodesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
