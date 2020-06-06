using Exmination.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.RegisterRepositry
{
    public interface IRegisterRepositry
    {
        public void Add(Registation registation);
        public void Remove(int id);
        public Registation GetRegistationById();
        public IEnumerable<Registation> GetRegistation();
    }
}
