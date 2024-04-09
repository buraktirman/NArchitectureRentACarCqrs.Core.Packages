namespace Core.Application.Pipelines.Caching;

public interface ICachableRequest
{
    string CacheKey { get; }
    bool BypassCache { get; } //Cache bazı durumlarda bypass edilebilir
    string? CacheGroupKey { get; } //Cache'in gruplanmasını sağlar (markalar, modeller, arabalar gibi)
    TimeSpan? SlidingExpiration { get; } //Cache'in ne zaman expire olacağını belirler
}