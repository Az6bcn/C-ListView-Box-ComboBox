using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create List of type person //strongly-typed
        List<Persons> personsList = new List<Persons>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //createPerson and add person to the Personslist
            var p1 = new Persons();
            p1.createPerson("Azeez", "Odumosu", "Martorell");
            personsList.Add(p1);
            var p2 = new Persons();
            p2.createPerson("hola", "tu madre", "madrid");
            personsList.Add(p2);

        
            //creamos las columnas de cabecera
            listViewPersons.Columns.Add("Name");
            listViewPersons.Columns.Add("Surname");
            listViewPersons.Columns.Add("Address");



            // recorremos PersonList para sacar cada campo y añadirlo a la colunmna q toque
            foreach (Persons person in personsList)
            {
                //create ListViewItem item 
                //---> This Item must have values for all the Columns as subItem to ADD
                //first Colunm takes text 
                ListViewItem itm = new ListViewItem();
                itm.Text = person.GetName();
                itm.SubItems.Add(person.GetAddress());
                itm.SubItems.Add(person.GetSurname());

                listViewPersons.Items.Add(itm);
                
            }

           

    }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //iterate the ListView items in our listviewPersons to get the selected one
            foreach (ListViewItem item in listViewPersons.SelectedItems)
            {
                //item.Remove();
                 MessageBox.Show("The selected item is :" + item);
            }

            
        }


    }
}
