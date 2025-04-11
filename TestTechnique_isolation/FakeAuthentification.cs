using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technique_isolation;

namespace TestTechnique_isolation
{
    public class FakeAuthentification : IAuthentification
    {
        public User User => throw new NotImplementedException();

        public void login()
        {

        }

        public bool Isauthentified()
        {
            return true ;
        }
    }
}
