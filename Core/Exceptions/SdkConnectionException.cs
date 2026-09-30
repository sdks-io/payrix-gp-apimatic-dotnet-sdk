using System;

namespace Payrix.Core.Exceptions;

public class SdkConnectionException(string message, Exception? innerException = null)
    : SdkException(message, innerException);
