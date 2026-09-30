using System.Threading.Tasks;
using Payrix.Core.ErrorResponse;
using Payrix.Core.Models;
using Payrix.Models;

namespace Payrix.Errors;

public sealed class PutAuthTokensIdError : ApiError
{
    private readonly Optional<ErrorFourHundred1> _errorFourHundred1Value;

    private PutAuthTokensIdError(Optional<ErrorFourHundred1> errorFourHundred1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorFourHundred1Value = errorFourHundred1Value;
    }

    private static PutAuthTokensIdError AsErrorFourHundred1(ErrorFourHundred1 value) =>
        new(Optional<ErrorFourHundred1>.Some(value), default);

    private static PutAuthTokensIdError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorFourHundred1(out ErrorFourHundred1 value) => _errorFourHundred1Value.TryGetValue(out value);

    private static Task<PutAuthTokensIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorFourHundred1>().As(AsErrorFourHundred1),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PutAuthTokensIdError> Response { get; } = new(Create);
}
