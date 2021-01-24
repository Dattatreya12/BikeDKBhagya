using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.Models
{
    public class PayoutDescriptionDetails
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int payoutID { get; set; }
    }
}
