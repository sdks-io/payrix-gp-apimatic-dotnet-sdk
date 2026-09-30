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
using Payrix.Requests.AppleDomainsMassEnablement;

namespace Payrix.Api;

/// <summary>
/// An Apple Domains Mass Enablement resource represents the bulk registration of multiple merchants, each associated with a respective domain, to enable the Apple Pay service.
/// </summary>
public sealed class AppleDomainsMassEnablement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AppleDomainsMassEnablement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// postApplePayForCsv
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppleDomainsMassEnablementCsvResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostApplePayForCsvError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// "Registers Apple Pay domains for multiple merchants using a CSV file. The uploaded CSV must include at least two columns: <c>"domain"</c> and <c>"merchant_id"</c>. All other columns are ignored. The file is parsed using the header row, and any data rows with missing or extra columns are also rejected.
    /// <para>
    /// For each merchant-domain pair, the system creates an <c>appleDomains</c> record. Domains not already registered are marked as <c>registering</c>, and asynchronous processing begins. If verification succeeds, the status updates to <c>registered</c>. If verification fails, the status changes to <c>failed_registration</c>, with an <c>errorNote</c> explaining the reason.
    /// </para>
    /// <para>
    /// This endpoint is idempotent for previously registered domains, allowing repeated submissions without adverse effects. You can resubmit the same CSV to retry failed registrations after resolving any issues.
    /// </para>
    /// <para>
    /// Upload the CSV file as a form-data field named files. All domains must be fully qualified domain names (FQDNs) and must host the Apple Pay verification file at:
    /// https://{merchantDomain}/.well-known/apple-developer-merchantid-domain-association
    /// </para>
    /// </remarks>
    public Task<AppleDomainsMassEnablementCsvResponseResult> PostApplePayForCsv(PostApplePayForCsvRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities/{id}/enableApplePayForCsv"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<AppleDomainsMassEnablementCsvResponseResult>(),
            PostApplePayForCsvError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postApplePayForMerchantList
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppleDomainsMassEnablementForMerchantList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostApplePayForMerchantListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers Apple Pay domains for a list of merchants using a JSON request body. For each merchant-domain pair, the system creates an <c>appleDomains</c> record. Domains not already registered update their status to <c>registering</c>, and asynchronous verification begins. If verification succeeds, the status updates to <c>registered</c>. If verification fails, the status changes to <c>failed_registration</c>, with an <c>errorNote</c> explaining the reason.
    /// <para>
    /// This endpoint is idempotent, allowing repeated submissions of the same request body without adverse effects. Only failed registrations are retried.
    /// </para>
    /// <para>
    /// All domains must be fully qualified domain names (FQDNs) and must host the Apple Pay verification file at:
    /// https://{merchantDomain}/.well-known/apple-developer-merchantid-domain-association
    /// </para>
    /// </remarks>
    public Task<AppleDomainsMassEnablementForMerchantList> PostApplePayForMerchantList(PostApplePayForMerchantListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities/{id}/enableApplePayForMerchantList"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AppleDomainsMassEnablementForMerchantList>(),
            PostApplePayForMerchantListError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postApplePayForMerchantListDisable
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppleDomainsMassEnablementForMerchantList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostApplePayForMerchantListDisableError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Unregisters Apple Pay domains for a list of merchants using a JSON request body. For each merchant-domain pair, the system updates the corresponding appleDomains record to reflect the <c>unregistered</c> status. Domains not yet unregistered are marked as <c>unregistering</c>, and asynchronous processing begins. If unregistration succeeds, the status updates to <c>unregistered</c>. If unregistration fails, the status reverts back to <c>registered</c>, with an <c>errorNote</c> explaining the reason.
    /// <para>
    /// This endpoint is idempotent, allowing repeated submissions of the same request body without adverse effects. Only failed de-registrations are retried.
    /// </para>
    /// <para>
    /// All domains must be fully qualified domain names (FQDNs) and must have previously been registered for Apple Pay and verified.
    /// </para>
    /// </remarks>
    public Task<AppleDomainsMassEnablementForMerchantList> PostApplePayForMerchantListDisable(PostApplePayForMerchantListDisableRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/entities/{id}/disableApplePayForMerchantList"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AppleDomainsMassEnablementForMerchantList>(),
            PostApplePayForMerchantListDisableError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postUpdateApplePayDomain
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateApplePayDomainResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostUpdateApplePayDomainError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Verifies a remote Apple Pay configuration file.
    /// <para>
    /// The configuration file must be stored on the merchant's or vendor's domain, but accessible to the Payrix systems.
    /// </para>
    /// <para>
    /// This endpoint can be used to ensure the configuration file is in the correct location with the correct rights for remote access.
    /// </para>
    /// <para>
    /// It is meant to validate one configuration file with the provided Fully Qualified Domain Name (fqdn).
    /// </para>
    /// <para>
    /// This endpoint does not do any action towards registration. It only verifies access to the remote file.
    /// </para>
    /// </remarks>
    public Task<UpdateApplePayDomainResponseResult> PostUpdateApplePayDomain(PostUpdateApplePayDomainRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/merchants/{id}/updateApplePayDomain"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateApplePayDomainResponseResult>(),
            PostUpdateApplePayDomainError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}
