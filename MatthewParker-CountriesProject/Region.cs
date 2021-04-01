using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatthewParker_CountriesProject
{
    public class Region
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public List<string> Countries { get; set; }
        public List<string> SubRegions{ get; set; }

        //Constructor
        public Region(string rName)
        {
            Name = rName;
            Countries = new List<string>();
            SubRegions = new List<string>();
        }

        //Add Country to List and update Population Number
        public void addCountry(int num, string cName)
        {
            Population += num;
            Countries.Add(cName);
        }

        //Add SubRegion to List
        public void addSubRegion(string subRegName)
        {
            SubRegions.Add(subRegName);
        }
    }
}
