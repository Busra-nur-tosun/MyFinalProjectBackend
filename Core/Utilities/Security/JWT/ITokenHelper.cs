using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //Bu interface'in amaci test ederken bir token verilmesi ya da baska bir teknik ile token üretilebilecegini göz önüne almaktir.

        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}