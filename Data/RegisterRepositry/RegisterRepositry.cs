﻿using Exmination.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Data.RegisterRepositry
{
    public class RegisterRepositry : IRegisterRepositry
    {
        private readonly ExaminationDBAccess repo;

        public RegisterRepositry(ExaminationDBAccess repo)
        {
            this.repo = repo;
        }
        //public bool SaveAll()
        //{

        //    //return dBWebData.SaveChanges() > 0;
        //}
        public void Add(Registation registation)
        {
            try
            {
                Console.WriteLine(registation.Email);
                repo.Registations.Add(registation);
                repo.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public IEnumerable<Registation> GetRegistation()
        {
           return repo.Registations
                                .OrderBy(r => r.Email)
                                .ThenBy(r => r.CandidateName)
                                .Take(5)
                                .ToList();
        }

        public Registation GetRegistationById(string email)
        {
            return repo.Registations
                                    .FirstOrDefault(r => r.Email == email);
        }

        public bool Remove(string email)
        {
           repo.Registations
                            .Remove(repo.Registations.FirstOrDefault(r => r.Email == email));
            try
            {
                repo.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
