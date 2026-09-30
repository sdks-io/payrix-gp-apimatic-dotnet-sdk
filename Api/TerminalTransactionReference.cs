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
using Payrix.Requests.TerminalTransactionReference;

namespace Payrix.Api;

/// <summary>
/// Terminal Transaction Reference represents a reference code issued by the Processor in relation to a particular Transaction.
/// </summary>
public sealed class TerminalTransactionReference
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalTransactionReference(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// postTerminalTxnRefs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalTxnRefResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTerminalTxnRefsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a terminalTxnRefs resource, which represents a reference code issued by the Processor in relation to a particular Transaction.
    /// </remarks>
    public Task<TerminalTxnRefResponseResult> PostTerminalTxnRefs(PostTerminalTxnRefsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/terminalTxnRefs"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TerminalTxnRefResponseResult>(),
            PostTerminalTxnRefsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
