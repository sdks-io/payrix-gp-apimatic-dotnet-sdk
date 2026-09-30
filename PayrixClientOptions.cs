using System;
using System.Collections.Generic;
using Payrix.Core.Configuration;
using Payrix.Core.Hooks;
using Payrix.Servers;

namespace Payrix;

public class PayrixClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public string? ApiKey { get; set; }
    public string? SessionKey { get; set; }
    public string? TxnSessionKey { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}
