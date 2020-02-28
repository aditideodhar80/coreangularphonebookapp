using System;
using System.Collections.Generic;
using System.Text;
using CoreAngularDemo.EntityFrameworkCore;
using System.Linq;
using CoreAngularDemo.PhoneBook;

namespace CoreAngularDemo.Migrations.Seed.Host
{
    class InitialPeopleAndPhoneCreator
    {

        private readonly CoreAngularDemoDbContext _context;

        public InitialPeopleAndPhoneCreator(CoreAngularDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            if (douglas == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Douglas",
                        Surname = "Adams",
                        EmailAddress = "douglas.adams@fortytwo.com",
                        Phones = new List<Phone>
                                    {
                                    new Phone {Type = PhoneType.Home, Number = "1112242"},
                                    new Phone {Type = PhoneType.Mobile, Number = "2223342"}
                                    }
                    });
            }

            var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@foundation.org");
            if (asimov == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Isaac",
                        Surname = "Asimov",
                        EmailAddress = "isaac.asimov@foundation.org",
                        Phones = new List<Phone>
                                    {
                                    new Phone {Type = PhoneType.Home, Number = "8889977"}
                                    }
                    });
            }
        }
    }
}
    