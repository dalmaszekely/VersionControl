using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week06.Entities
{
    class RateData
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public Decimal Value { get; set; }
    }
}
