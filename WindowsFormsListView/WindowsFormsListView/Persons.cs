using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsListView
{
    class Persons
    {
        private String name { set; get; }
        private string surname { set; get; }
        private string address { set; get; }

        //method to manipulate the private attributes of this class
        public void createPerson(string nom, string surnom, string addr)
        {
            this.name = nom;
            this.surname = surnom;
            this.address = addr;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetAddress()
        {
            return address;
        }
    }
}
