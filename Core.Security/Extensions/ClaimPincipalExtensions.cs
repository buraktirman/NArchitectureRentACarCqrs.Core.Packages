using System.Security.Claims;

namespace Core.Security.Extensions;

public static class ClaimsPrincipalExtensions
    //Kullanıcın bilgisinden yararlanarak claimlerini liste haline getirir.
    //Claim Principal: O an giriş yapmış olan kullanıcıdır. (Bize token göndermiş kişi)
{
    public static List<string>? Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
    {
        var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
        return result;
    }

    //O anki kullanıcının rollerini getirir.
    public static List<string>? ClaimRoles(this ClaimsPrincipal claimsPrincipal) => claimsPrincipal?.Claims(ClaimTypes.Role);

    public static int GetUserId(this ClaimsPrincipal claimsPrincipal) =>
        Convert.ToInt32(claimsPrincipal?.Claims(ClaimTypes.NameIdentifier)?.FirstOrDefault());
}
