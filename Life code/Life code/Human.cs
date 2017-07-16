using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_code
{
    class Human
    {
        public Human(Human father, Human mother)
        {

        }
        public Int64 Money { get; set; }
        public List<Gene> genes { get; set; }
        public Country country { get; set; }
        public string relegion { get; set; }
        public double Pain { get; set; }
        public double Love { get; set; }
        public int Knowledge { get; set; }
    }
}
