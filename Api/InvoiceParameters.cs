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
using Payrix.Requests.InvoiceParameters;

namespace Payrix.Api;

/// <summary>
/// Invoice Parameters holds a certain configuration used for creating an invoice such as dba, address, API Key.
/// </summary>
public sealed class InvoiceParameters
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal InvoiceParameters(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteInvoiceParametersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceParametersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteInvoiceParametersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete an Invoice Parameter.
    /// </remarks>
    public Task<InvoiceParametersResponseResult> DeleteInvoiceParametersId(DeleteInvoiceParametersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceParameters/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<InvoiceParametersResponseResult>(),
            DeleteInvoiceParametersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoiceParameters
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceParametersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceParametersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an invoice parameter resource that holds a certain configuration used for creating an invoice, including dba, address, and api key.
    /// </remarks>
    public Task<InvoiceParametersResponseResult> GetInvoiceParameters(GetInvoiceParametersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceParameters"),
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
            JsonResponse.Create<InvoiceParametersResponseResult>(),
            GetInvoiceParametersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getInvoiceParametersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceParametersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetInvoiceParametersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query an invoice parameter that holds a certain configuration used for creating an invoice such as dba, address, and apikey.
    /// </remarks>
    public Task<InvoiceParametersResponseResult> GetInvoiceParametersId(GetInvoiceParametersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceParameters/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoiceParametersResponseResult>(),
            GetInvoiceParametersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postInvoiceParameters
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceParametersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostInvoiceParametersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Invoice Parameter that holds a certain configuration used for creating an invoice such as dba, address, and apikey.
    /// </remarks>
    public Task<InvoiceParametersResponseResult> PostInvoiceParameters(PostInvoiceParametersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceParameters"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoiceParametersResponseResult>(),
            PostInvoiceParametersError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// putInvoiceParametersId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoiceParametersResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PutInvoiceParametersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an invoice parameter.
    /// </remarks>
    public Task<InvoiceParametersResponseResult> PutInvoiceParametersId(PutInvoiceParametersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/invoiceParameters/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<InvoiceParametersResponseResult>(),
            PutInvoiceParametersIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
