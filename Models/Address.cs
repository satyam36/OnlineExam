using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Address_ { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}
