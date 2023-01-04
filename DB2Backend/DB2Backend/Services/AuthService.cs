using DB2Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DB2Backend.Services
{
    public class AuthService : IAuthService
    {
        private Db2Context context = new Db2Context();
        public int Login(string email, string password)
        {
            KontoPortalu konto = context.KontoPortalus.Where(m => m.Email ==email).FirstOrDefault();
            Obywatel obywatel;
            if (konto != null)
            {
                obywatel = context.Obywatels.Where(m => m.KontoPortalu == konto.Id).FirstOrDefault();
                if(obywatel!=null)
                {

                    if (obywatel.Pesel == password)
                    {

                        return obywatel.Id;
                    }
                }

            }
            return -1;
        }
    }
}
