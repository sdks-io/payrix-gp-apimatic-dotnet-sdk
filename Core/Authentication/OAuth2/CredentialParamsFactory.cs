using System.Collections.Generic;

namespace Payrix.Core.Authentication.OAuth2;

internal delegate IReadOnlyList<T> CredentialParamsFactory<out T>(string clientId, string? clientSecret);
