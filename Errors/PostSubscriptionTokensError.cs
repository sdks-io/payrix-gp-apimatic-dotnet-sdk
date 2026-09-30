using System.Threading.Tasks;
using Payrix.Core.ErrorResponse;
using Payrix.Core.Models;
using Payrix.Models;

namespace Payrix.Errors;

public sealed class PostSubscriptionTokensError : ApiError
{
    private readonly Optional<ErrorFourHundred1> _errorFourHundred1Value;

    private PostSubscriptionTokensError(Optional<ErrorFourHundred1> errorFourHundred1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorFourHundred1Value = errorFourHundred1Value;
    }

    private static PostSubscriptionTokensError AsErrorFourHundred1(ErrorFourHundred1 value) =>
        new(Optional<ErrorFourHundred1>.Some(value), default);

    private static PostSubscriptionTokensError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorFourHundred1(out ErrorFourHundred1 value) => _errorFourHundred1Value.TryGetValue(out value);

    private static Task<PostSubscriptionTokensError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorFourHundred1>().As(AsErrorFourHundred1),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostSubscriptionTokensError> Response { get; } = new(Create);
}
