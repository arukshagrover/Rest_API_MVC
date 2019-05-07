using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillAPIProject.Models
{
    public class Result1
    {
        public List<string> CustName{ get; set; }
        public List<string> SubsName { get; set; }
        public List<float?> UnitP { get; set; }
        public List<int> ct { get; set; }

    }
}
