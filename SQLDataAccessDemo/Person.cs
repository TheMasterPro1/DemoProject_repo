using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDataAccessDemo
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        private int myVar;

        public string FullInfo
        {
            get 
            {
                return $"{FirstName} {LastName} ({ EmailAdress })";
            }
            
        }

    }
}
