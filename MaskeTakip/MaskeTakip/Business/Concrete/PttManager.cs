using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class PttManager:iSupplierService
    {
        private iApplicantService _applicantService;

        public PttManager(iApplicantService applicantService)
        { 
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");
            }
        }
    }
}
