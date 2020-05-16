using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Models
{
    public class EximinationCenter
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string CenterInchargeName { get; set; }
        public string CenterInchargeEmail { get; set; }
        public string SeatAvailable { get; set; }

    }
}
