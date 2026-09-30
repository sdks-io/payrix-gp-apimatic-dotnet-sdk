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
using Payrix.Requests.InvoiceItems;

namespace Payrix.Api;

/// <summary>
/// A resource that stores line item details for an invoice.
/// </summary>
public sealed class InvoiceItems
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal InvoiceItems(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteInvoiceItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteInvoiceItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Invoice Item or a resource that stores line item details for an invoice.
    /// </remarks>
    public Task<InvoiceItemsResponseResult> DeleteInvoiceItemsId(DeleteInvoiceItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceItems/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<InvoiceItemsResponseResult>(),
            DeleteInvoiceItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoiceItems
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Invoice Item. A Invoice Item is a resource that stores line item details for an invoice.
    /// </remarks>
    public Task<InvoiceItemsResponseResult> GetInvoiceItems(GetInvoiceItemsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceItems"),
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
            JsonResponse.Create<InvoiceItemsResponseResult>(),
            GetInvoiceItemsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoiceItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Invoice Item or query Invoice Items.
    /// </remarks>
    public Task<InvoiceItemsResponseResult> GetInvoiceItemsId(GetInvoiceItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceItems/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoiceItemsResponseResult>(),
            GetInvoiceItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postInvoiceItems
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostInvoiceItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Invoice Item, a resource that stores line item details for an invoice.
    /// </remarks>
    public Task<InvoiceItemsResponseResult> PostInvoiceItems(PostInvoiceItemsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceItems"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoiceItemsResponseResult>(),
            PostInvoiceItemsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putInvoiceItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutInvoiceItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Invoice Item, A InvoiceItem is a resource that stores line item details for an invoice.
    /// </remarks>
    public Task<InvoiceItemsResponseResult> PutInvoiceItemsId(PutInvoiceItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceItems/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoiceItemsResponseResult>(),
            PutInvoiceItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
