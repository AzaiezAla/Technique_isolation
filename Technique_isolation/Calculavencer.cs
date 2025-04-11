using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technique_isolation
{
    public class Calculavencer
    {
        IAuthentification auth;
        public Calculavencer(IAuthentification authentification)
        {
            auth = authentification;
            auth.login();
        }
        public int f1(int x)
        {
            if (auth.Isauthentified())
            {
                return x;
            }
            else
                throw new Exception("Erreur d'authentification");
                
        }


    }
}
