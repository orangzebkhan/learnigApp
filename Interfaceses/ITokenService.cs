using ClientApi.Models;

namespace ClientApi.Interfaceses
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
                          