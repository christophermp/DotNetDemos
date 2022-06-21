using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CityModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{Address}, {City}, {State} - {ZipCode}";
            }
        }

        public CityModel()
        {

        }

    }
}
