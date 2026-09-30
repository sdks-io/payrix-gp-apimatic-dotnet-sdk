using System.Threading.Tasks;
using Payrix.Core.ErrorResponse;
using Payrix.Core.Models;
using Payrix.Models;

namespace Payrix.Errors;

public sealed class PutOrgEntitiesIdError : ApiError
{
    private readonly Optional<ErrorFourHundred1> _errorFourHundred1Value;

    private PutOrgEntitiesIdError(Optional<ErrorFourHundred1> errorFourHundred1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorFourHundred1Value = errorFourHundred1Value;
    }

    private static PutOrgEntitiesIdError AsErrorFourHundred1(ErrorFourHundred1 value) =>
        new(Optional<ErrorFourHundred1>.Some(value), default);

    private static PutOrgEntitiesIdError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorFourHundred1(out ErrorFourHundred1 value) => _errorFourHundred1Value.TryGetValue(out value);

    private static Task<PutOrgEntitiesIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorFourHundred1>().As(AsErrorFourHundred1),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PutOrgEntitiesIdError> Response { get; } = new(Create);
}
