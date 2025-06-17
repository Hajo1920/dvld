using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class PeopleListBusinessClass
    {
        public static DataTable PeopleList()
        {
            return PeopleListDataClass.ListPeople();
        }

        public static DataTable CountryList()
        {
            return PeopleListDataClass.ListCountries();
        }
    }
}
