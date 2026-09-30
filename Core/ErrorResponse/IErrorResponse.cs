using System.Threading;
using System.Threading.Tasks;
using Payrix.Core.Models;

namespace Payrix.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}