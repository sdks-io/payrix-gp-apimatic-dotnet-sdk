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
using Payrix.Requests.Credentials;

namespace Payrix.Api;

/// <summary>
/// Represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as send Transactions to the processor, or board a Merchant with the processor.
/// </summary>
public sealed class Credentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Credentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteCredentialsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CredentialsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteCredentialsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a Credential resource. A Credential resource represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as delete a Credential resource.
    /// </remarks>
    public Task<CredentialsResponseResult> DeleteCredentialsId(DeleteCredentialsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/credentials/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<CredentialsResponseResult>(),
            DeleteCredentialsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getCredentials
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CredentialsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Credential resource. A Credential resource represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as send Transactions to the processor, or board a Merchant with the processor
    /// </remarks>
    public Task<CredentialsResponseResult> GetCredentials(GetCredentialsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/credentials"),
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
            JsonResponse.Create<CredentialsResponseResult>(),
            GetCredentialsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getCredentialsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CredentialsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCredentialsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Credential resource that represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as send Transactions to the processor, or board a Merchant with the processor.
    /// </remarks>
    public Task<CredentialsResponseResult> GetCredentialsId(GetCredentialsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/credentials/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CredentialsResponseResult>(),
            GetCredentialsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postCredentials
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CredentialsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Credential resource that represents an authorization that a given Entity has to connect to an integration to perform a particular action, such as send Transactions to the processor, or board a Merchant with the processor.
    /// </remarks>
    public Task<CredentialsResponseResult> PostCredentials(PostCredentialsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/credentials"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CredentialsResponseResult>(),
            PostCredentialsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putCredentialsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CredentialsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutCredentialsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Credential resource represents an authorization that a given Entity has to connect to an integration to perform a particular action.
    /// </remarks>
    public Task<CredentialsResponseResult> PutCredentialsId(PutCredentialsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/credentials/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CredentialsResponseResult>(),
            PutCredentialsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
