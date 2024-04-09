using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class RefreshToken : Entity<int>
//Access token süresi dolduğunda refresh token ile
//tekrar giriş yapmaya gerek kalmadan yeni bir access token almak için kullanılır.
{
    public int UserId { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public string CreatedByIp { get; set; }
    public DateTime? Revoked { get; set; } //İptal edilmiş mi ?
    public string? RevokedByIp { get; set; }
    public string? ReplacedByToken { get; set; } //Hangi token ile değiştirildi ?
    public string? ReasonRevoked { get; set; }

    public virtual User User { get; set; } = null!;

    public RefreshToken()
    {
        Token = string.Empty;
        CreatedByIp = string.Empty;
    }

    public RefreshToken(int userId, string token, DateTime expires, string createdByIp)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
    }

    public RefreshToken(int id, int userId, string token, DateTime expires, string createdByIp)
        : base(id)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
    }
}
