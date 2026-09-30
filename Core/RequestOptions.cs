using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Payrix.Core.Hooks;

namespace Payrix.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
