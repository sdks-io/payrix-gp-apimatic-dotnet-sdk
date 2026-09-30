using Payrix.Core.Authentication;
using Payrix.Core.Authentication.ApiKey;

namespace Payrix;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKey { get; }
    public IAuthScheme SessionKey { get; }
    public IAuthScheme TxnSessionKey { get; }
    public IAuthScheme Username { get; }
    public IAuthScheme Password { get; }

    public AuthSchemes(PayrixClientOptions options)
    {
        ApiKey = ApiKeyHeaderScheme.Create("APIKEY", options.ApiKey);
        SessionKey = ApiKeyHeaderScheme.Create("SESSIONKEY", options.SessionKey);
        TxnSessionKey = ApiKeyHeaderScheme.Create("TXNSESSIONKEY", options.TxnSessionKey);
        Username = ApiKeyHeaderScheme.Create("USERNAME", options.Username);
        Password = ApiKeyHeaderScheme.Create("PASSWORD", options.Password);
    }
}
