using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsComboBox
{
    class Person
    {
        private String name;
        private String surname;
        private String address;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public void createPerson(String nom, string sur, string addr)
        {

            this.Name = nom;
            this.Surname = sur;
            this.Address = addr;
        }

        public static implicit operator List<object>(Person v)
        {
            throw new NotImplementedException();
        }
    }

    
}
