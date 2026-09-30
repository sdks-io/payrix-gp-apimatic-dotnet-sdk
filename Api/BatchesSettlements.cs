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
using Payrix.Requests.BatchesSettlements;

namespace Payrix.Api;

/// <summary>
/// Batches are a container for transactions that enables batch processing to the processor for a merchant (to settle customer sales). Processing transactions for settlement to the processor is done in batches.
/// </summary>
public sealed class BatchesSettlements
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal BatchesSettlements(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getBatches
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBatchesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Batch, which represents a group of Transactions that are sent together to the processor to be settled.
    /// </remarks>
    public Task<BatchesResponseResult> GetBatches(GetBatchesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches"),
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
            JsonResponse.Create<BatchesResponseResult>(),
            GetBatchesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getBatchesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBatchesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Batch, a Batch resource represents a group of Transactions that are sent together to the processor to be settled.
    /// </remarks>
    public Task<BatchesResponseResult> GetBatchesId(GetBatchesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BatchesResponseResult>(),
            GetBatchesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postBatches
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBatchesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Batch. A Batch resource represents a group of Transactions that are sent together to the processor to be settled.
    /// </remarks>
    public Task<BatchesResponseResult> PostBatches(PostBatchesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchesResponseResult>(),
            PostBatchesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putBatchesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutBatchesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a Batch. A Batch resource represents a group of Transactions that are sent together to the processor to be settled.
    /// </remarks>
    public Task<BatchesResponseResult> PutBatchesId(PutBatchesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/batches/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BatchesResponseResult>(),
            PutBatchesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
