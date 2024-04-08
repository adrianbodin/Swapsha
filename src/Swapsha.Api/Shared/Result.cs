namespace Swapsha.Api.Shared;

public abstract record Result();

public sealed record Success<T>(T Entity) : Result;
public sealed record Error(Exception Exception) : Result;
