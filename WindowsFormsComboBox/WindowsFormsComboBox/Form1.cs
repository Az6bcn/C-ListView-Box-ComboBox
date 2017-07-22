using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create Persons list
        List<Person> personsList = new List<Person>();
        private ArrayList names = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            names.Add("Azeez");
            names.Add("Larry");
            names.Add("t");
            names.Add("unas");
            names.Add("Bisih");
            names.Add("babe");

            //add item to combo at run time
            foreach (var name in names)
            {
                namesComboBox.Items.Add(name);
            }


           

            //add persons to the list
            Person p1 = new Person();
            p1.createPerson("Ola", "Odu", "Martorell");
            Person p2 = new Person();
            p2.createPerson("Azzz", "Ola", "Sant Andreu");
            Person p3 = new Person();
            p3.createPerson("Sergio", "Zapaterza", "Martorell");
            Person p4 = new Person();
            p4.createPerson("AHmed", "Olsasasaa", "Sants");

            //add the created people in the list
            personsList.Add(p1);
            personsList.Add(p2);
            personsList.Add(p3);
            personsList.Add(p4);

            //add Persons names to combo at run time
            foreach (var person in personsList)
            {
                namesComboBox.Items.Add(person.Name);
            }


            /*        int num_person2create = 5;

               //CREATE MULTIPLE PERSON WITH LOOP
               for (int i = 0; i < num_person2create; i++)
               {
                   //create person en each position of the List
                   personsList[i] = new Person();
                   personsList[i].createPerson("Ola", "Odu", "Martorell");
                   personsList[i].createPerson("Azzz", "Ola", "Sant Andreu");
                   personsList[i].createPerson("Sergio", "Zapaterza", "Martorell");
                   personsList[i].createPerson("AHmed", "Olsasasaa", "Sants");
               } */







        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get selected property
            MessageBox.Show(namesComboBox.SelectedItem.ToString());
            //MessageBox.Show(namesComboBox.Items.Count.ToString());

            //display the selected persons name , address and surname in textboes
            for (int i = 0; i < personsList.Count; i++)
            {
                //get selected name in the list by looping through iit 
                if (personsList[i].Name.ToString() == namesComboBox.SelectedItem.ToString())
                {
                    nameListtextBox.Text = personsList[i].Name;
                    surnameTextBox.Text = personsList[i].Surname;
                    addressTextBox.Text = personsList[i].Address;

                    return;
                }
                else {
                    MessageBox.Show("Selected name is not from personslIST");
                }
                return;
            }

            


        }
    }
}
