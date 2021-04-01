using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatthewParker_CountriesProject
{
    public class SubRegion
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public List<string> Countries { get; set; }
        public string Region { get; set; }

        //Constructor
        public SubRegion(string subName, string rName)
        {
            Name = subName;
            Region = rName;
            Countries = new List<string>();
        }

        //Add Country to List and update Population Number
        public void addCountry(int num, string cName)
        {
            Population += num;
            Countries.Add(cName);
        }
    }
}
