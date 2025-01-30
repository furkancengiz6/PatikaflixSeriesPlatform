using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaflixSeriesPlatform.Models
{
    public class Series : BaseSeries
    {
        public int YearOfProduction { get; set; }
        public int StartYear { get; set; }
        public string Platform { get; set; }



    }
}
