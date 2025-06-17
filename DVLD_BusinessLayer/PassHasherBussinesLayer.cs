using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class PassHasherBussinesLayer
    {

        public static string Hash(string password)
        {
            return PassHasher.Hash256(password);
        }
    }
}
