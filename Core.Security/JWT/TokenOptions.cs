namespace Core.Security.JWT;

public class TokenOptions
{
    public string Audience { get; set; } //Tokenı kullanacak olan
    public string Issuer { get; set; } //Tokenı oluşturan
    public int AccessTokenExpiration { get; set; }
    public string SecurityKey { get; set; }
    public int RefreshTokenTTL { get; set; } //Refresh tokenın ne kadar süreyle geçerli olacağı
    //TTL -> Time To Live

    public TokenOptions()
    {
        Audience = string.Empty;
        Issuer = string.Empty;
        SecurityKey = string.Empty;
    }

    public TokenOptions(string audience, string issuer, int accessTokenExpiration, string securityKey, int refreshTokenTtl)
    {
        Audience = audience;
        Issuer = issuer;
        AccessTokenExpiration = accessTokenExpiration;
        SecurityKey = securityKey;
        RefreshTokenTTL = refreshTokenTtl;
    }
}
