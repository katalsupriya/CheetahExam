﻿namespace CheetahExam.Application.Common.Exceptions;

public class AuthorizationException : Exception
{
    public AuthorizationException() : base("Authorization failed.") { }

    public AuthorizationException(string message) : base(message) { }

    public AuthorizationException(string message, Exception innerException) : base(message, innerException) { }
}
