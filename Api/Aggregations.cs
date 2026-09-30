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
using Payrix.Requests.Aggregations;

namespace Payrix.Api;

/// <summary>
/// Aggregations acts as a scheduler that contains the needed parameters to properly generate results containing the calculated totals and keep such records in the aggregation results resource.
/// </summary>
public sealed class Aggregations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Aggregations(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteAggregationsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregationsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAggregationsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Aggregation resource or an Aggregation.
    /// </remarks>
    public Task<AggregationsResponseResult> DeleteAggregationsId(DeleteAggregationsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/aggregations/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("searchFilter", request.SearchFilter),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<AggregationsResponseResult>(),
            DeleteAggregationsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAggregations
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregationsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAggregationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Aggregation resource using the search to query for records on the given resource and apply desired calculations (count, sum, min, and/or max) to the specified field.
    /// </remarks>
    public Task<AggregationsResponseResult> GetAggregations(GetAggregationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/aggregations"),
            [],
            [
                new Param("page[number]", request.PageNumber),
                new Param("page[limit]", request.PageLimit),
                new Param("embed", request.Embed),
            ],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("searchFilter", request.SearchFilter),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AggregationsResponseResult>(),
            GetAggregationsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getAggregationsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregationsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAggregationsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Aggregation resource that uses a search to query for records on the given resource and applies the desired calculations (count, sum, min, and/or max) to the field in question.
    /// </remarks>
    public Task<AggregationsResponseResult> GetAggregationsId(GetAggregationsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/aggregations/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("searchFilter", request.SearchFilter),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AggregationsResponseResult>(),
            GetAggregationsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postAggregations
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregationsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAggregationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Aggregation resource that uses the search to query for records on a given resource and applies the desired calculations (count, sum, min, and/or max) to the field in question.
    /// </remarks>
    public Task<AggregationsResponseResult> PostAggregations(PostAggregationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/aggregations"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AggregationsResponseResult>(),
            PostAggregationsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putAggregationsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AggregationsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutAggregationsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Aggregation resource or Update an Aggregation.
    /// </remarks>
    public Task<AggregationsResponseResult> PutAggregationsId(PutAggregationsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/aggregations/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("searchFilter", request.SearchFilter),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AggregationsResponseResult>(),
            PutAggregationsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
