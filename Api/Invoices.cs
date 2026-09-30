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
using Payrix.Requests.Invoices;

namespace Payrix.Api;

/// <summary>
/// Invoices deals with  customer invoice details allowing for presenting charges to a customer and for payments to be made related to certain products or services.
/// </summary>
public sealed class Invoices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Invoices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteInvoicesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteInvoicesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Invoice or use it for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.
    /// </remarks>
    public Task<InvoicesResponseResult> DeleteInvoicesId(DeleteInvoicesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoices/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<InvoicesResponseResult>(),
            DeleteInvoicesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Invoice or query an Invoice. An Invoice resource is used for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.
    /// </remarks>
    public Task<InvoicesResponseResult> GetInvoices(GetInvoicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoices"),
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
            JsonResponse.Create<InvoicesResponseResult>(),
            GetInvoicesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoicesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoicesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an Invoice or use it for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.
    /// </remarks>
    public Task<InvoicesResponseResult> GetInvoicesId(GetInvoicesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoices/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoicesResponseResult>(),
            GetInvoicesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postInvoices
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostInvoicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Invoice, which is used for invoicing customers, emailing the invoice to them, allowing them to pay the invoice and tracking payments with invoices.
    /// </remarks>
    public Task<InvoicesResponseResult> PostInvoices(PostInvoicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoices"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoicesResponseResult>(),
            PostInvoicesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putInvoicesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutInvoicesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an Invoice. An Invoice resource is used for invoicing customers, email the invoice to them, allow them to pay the invoice and track payments with invoices.
    /// </remarks>
    public Task<InvoicesResponseResult> PutInvoicesId(PutInvoicesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoices/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoicesResponseResult>(),
            PutInvoicesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
