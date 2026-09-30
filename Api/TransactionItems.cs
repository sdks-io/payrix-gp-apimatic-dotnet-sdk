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
using Payrix.Requests.TransactionItems;

namespace Payrix.Api;

/// <summary>
/// An Item is a line item that is associated with a particular Transaction.  It allows you to describe the cost, quantity and other details of each line in the Transaction.
/// </summary>
public sealed class TransactionItems
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransactionItems(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Item.
    /// An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.
    /// </remarks>
    public Task<ItemsResponseResult> DeleteItemsId(DeleteItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/items/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<ItemsResponseResult>(),
            DeleteItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getItems
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Item.
    /// An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.
    /// </remarks>
    public Task<ItemsResponseResult> GetItems(GetItemsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/items"),
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
            JsonResponse.Create<ItemsResponseResult>(),
            GetItemsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Item.
    /// An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.
    /// </remarks>
    public Task<ItemsResponseResult> GetItemsId(GetItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/items/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ItemsResponseResult>(),
            GetItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postItems
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Item.
    /// An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.
    /// </remarks>
    public Task<ItemsResponseResult> PostItems(PostItemsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/items"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemsResponseResult>(),
            PostItemsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Item.
    /// An Item is a line item that is associated with a particular Transaction. It allows you to describe the cost, quantity and other details of each line in the Transaction.
    /// </remarks>
    public Task<ItemsResponseResult> PutItemsId(PutItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/items/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ItemsResponseResult>(),
            PutItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
