using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    /// Kullanıcı işlemlerini yöneten servis arayüzüdür.
    /// Bu arayüz, kullanıcı hakları (claims) almak, yeni bir kullanıcı eklemek ve 
    /// bir e-posta adresine göre kullanıcı bilgilerini almak gibi kullanıcı işlemlerini gerçekleştirmek için kullanılır.

    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}