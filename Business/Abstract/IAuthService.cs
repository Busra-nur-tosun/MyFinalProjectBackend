using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    // Kullanıcı kimlik doğrulama işlemlerini yöneten servis arayüzüdür.
    /// Bu arayüz, kullanıcı kaydı, girişi, varlık kontrolü ve erişim belirteci oluşturma gibi
    /// kimlik doğrulama işlemlerini gerçekleştirmek için kullanılır.
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
