using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantservice;

        public PttManager(IApplicantService applicantService)
        {
            _applicantservice = applicantService;
                
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantservice.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " Maske Verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " MASKE VERİLEMEDİ");
            }
        }
    }
}
