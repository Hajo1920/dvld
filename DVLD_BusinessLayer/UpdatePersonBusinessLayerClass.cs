using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class UpdatePersonBusinessLayerClass
    {
        public static bool UpdatePerson(int id, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime BirthDate, string Email, string Phone, byte Gendor, string Address, int CountryId, string ImagePath)
        {
            return UpdatePersonDataLayerClass.UpdatePerson(id, NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, Email, Phone, Address, BirthDate, CountryId, ImagePath);
        }
    }
}
