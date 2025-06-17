using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class AddNewPersonBusinessLayerClass
    {
     
        public static int AddNewPersonRecord( string first,  string second,  string third,
             string last,  string nationalid,
             string email,  string phone,  DateTime birthdate,
             int countryid,
             string address,  byte gendor,  string imagepath)
        {
            return AddNewPersonDataLayerClass.AddNewPersonToPeopleList( first,  second,  third,  last,  nationalid,  email,  phone,  birthdate,  countryid,  address,  gendor,  imagepath);
        }

        public static int GetCountryId(string name)
        {
            return AddNewPersonDataLayerClass.GetCountryID(name);
        }
    }
}
