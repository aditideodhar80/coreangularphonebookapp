using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAngularDemo.PhoneBook
{
    public class EditPersonInput
    {
        public int id { get; set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
    }

    public class GetPersonForEditOutput
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
    }

    public class GetPersonForEditInput
    {
        public int id { get; set; }
       
    }
}
