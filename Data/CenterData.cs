using Exmination.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data
{
    public class CenterData
    {
        public IEnumerable<ExameCenter> Center()
        {
            return new List<ExameCenter>()
            {
                new ExameCenter(){ CenterName ="SBL"},
                new ExameCenter(){ CenterName ="SBN"},
                new ExameCenter(){ CenterName ="SBK"},
                new ExameCenter(){ CenterName ="SBJ"},
            };
        }
    }
}
