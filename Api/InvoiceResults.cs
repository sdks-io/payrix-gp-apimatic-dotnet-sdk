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
using Payrix.Requests.InvoiceResults;

namespace Payrix.Api;

/// <summary>
/// Invoice Results represents the result of an invoice processing.  In other words, when the customer pays for an invoice it will then generate an invoice result.
/// </summary>
public sealed class InvoiceResults
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal InvoiceResults(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getInvoiceResults
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceResultsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query InvoiceResults resource that represents the result of an invoice processing. In other words, when the customer pays for an invoice it will then generate an invoice result.
    /// </remarks>
    public Task<InvoiceResultsResponseResult> GetInvoiceResults(GetInvoiceResultsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceResults"),
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
            JsonResponse.Create<InvoiceResultsResponseResult>(),
            GetInvoiceResultsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoiceResultsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceResultsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an invoiceResults resource that represents the result of an invoice processing, which is generated when a customer pays for an invoice.
    /// </remarks>
    public Task<InvoiceResultsResponseResult> GetInvoiceResultsId(GetInvoiceResultsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceResults/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoiceResultsResponseResult>(),
            GetInvoiceResultsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postInvoiceResults
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostInvoiceResultsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// create a invoiceResult.
    /// </remarks>
    public Task<InvoiceResultsResponseResult> PostInvoiceResults(PostInvoiceResultsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceResults"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoiceResultsResponseResult>(),
            PostInvoiceResultsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
