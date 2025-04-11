using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Technique_isolation
{
    public class Authentification : IAuthentification
    {
        public User User { get; private set; }
        private bool isOk = false;
        public Authentification(User user)
        {
            User = user;
        }

        public void login()
        {

            //un peu de traitaiment pour la login 
            isOk = true;

        }

        public bool Isauthentified()
        {
            return isOk;
        }
    }
}
