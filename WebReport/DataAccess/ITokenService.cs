using KitanoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebReport.DataAccess
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, CurrentUserModel user);
        bool IsTokenValid(string key, string issuer, string token);
    }
}
