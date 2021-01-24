using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Models
{
    public class InvestmentMaster
    {
        public int ID { get; set; }
        public string BrokerName { get; set; }
        public int Investment { get; set; }
        public string status { get; set; }
        public DateTime CreatedOn { get; set; }

    }

}
