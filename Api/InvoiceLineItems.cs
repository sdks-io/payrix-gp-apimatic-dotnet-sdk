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
using Payrix.Requests.InvoiceLineItems;

namespace Payrix.Api;

/// <summary>
/// A resource that relates an invoice item with an invoice.  It holds information such as quantity, and price each item.
/// </summary>
public sealed class InvoiceLineItems
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal InvoiceLineItems(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteInvoiceLineItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceLineItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteInvoiceLineItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an InvoiceLineItem or Invoice Line Item.
    /// </remarks>
    public Task<InvoiceLineItemsResponseResult> DeleteInvoiceLineItemsId(DeleteInvoiceLineItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceLineItems/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<InvoiceLineItemsResponseResult>(),
            DeleteInvoiceLineItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoiceLineItems
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceLineItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceLineItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an InvoiceLineItem. InvoiceLineItem is a resource that relates an invoice item with an invoice. It holds information such as quantity, and price each item.
    /// </remarks>
    public Task<InvoiceLineItemsResponseResult> GetInvoiceLineItems(GetInvoiceLineItemsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceLineItems"),
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
            JsonResponse.Create<InvoiceLineItemsResponseResult>(),
            GetInvoiceLineItemsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoiceLineItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceLineItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceLineItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an InvoiceLineItem or Invoice Line Item.
    /// </remarks>
    public Task<InvoiceLineItemsResponseResult> GetInvoiceLineItemsId(GetInvoiceLineItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceLineItems/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoiceLineItemsResponseResult>(),
            GetInvoiceLineItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postInvoiceLineItems
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceLineItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostInvoiceLineItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an InvoiceLineItem or Invoice Line Item.InvoiceLineItem is a resource that relates an invoice item with an invoice. It holds information such as quantity, and price each item.
    /// </remarks>
    public Task<InvoiceLineItemsResponseResult> PostInvoiceLineItems(PostInvoiceLineItemsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceLineItems"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoiceLineItemsResponseResult>(),
            PostInvoiceLineItemsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putInvoiceLineItemsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceLineItemsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutInvoiceLineItemsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an InvoiceLineItem or Invoice Line Item.
    /// </remarks>
    public Task<InvoiceLineItemsResponseResult> PutInvoiceLineItemsId(PutInvoiceLineItemsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceLineItems/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoiceLineItemsResponseResult>(),
            PutInvoiceLineItemsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
