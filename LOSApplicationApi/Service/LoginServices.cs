using LOSApplicationApi.Data;
using LOSApplicationApi.DTO;
using LOSApplicationApi.Repository;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace LOSApplicationApi.Service
{
    public class LoginServices: ILogin
    {
        ApplicationDbContext db;
        IConfiguration configuration;
        IToken tokens;
        public LoginServices(ApplicationDbContext db, IConfiguration configuration, IToken tokens)
        {
            this.db = db;
            this.configuration = configuration;
            this.tokens = tokens;
        }

        public string Login(LoginDTO datas)
        {
            
            var details = db.UserRole.Include(x => x.User).Where(x=>x.User.Email == datas.UserName || x.User.UserName==datas.UserName).Select(p=>p.User.PasswordHash).FirstOrDefault();

            if(details!=null && details == datas.PasswordHash)
            {
                return tokens.GenerateToken(datas);
            }
            return null;
        }


    }
}
