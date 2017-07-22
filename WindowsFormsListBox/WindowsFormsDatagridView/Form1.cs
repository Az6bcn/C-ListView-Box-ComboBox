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

namespace WindowsFormsDatagridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(nameListBox.SelectedItem.ToString());
        }

        private ArrayList names_people = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {

           
            names_people.Add("Hazeez");
            names_people.Add("Tobi");
            names_people.Add("Larry");
            names_people.Add("Bisi");
            names_people.Add("T");
            names_people.Add("JJNAJA");

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //iterate the list
            foreach (string name in names_people)
            {
                //populate list to the listbox
                nameListBox.Items.Add(name);
                
            }

            //count the number of items and show in the count textbox
           countTextBox.Text = nameListBox.Items.Count.ToString();

           
        }

        private void addButton_Click(object sender, EventArgs e)
        {   
            //add straight to listbox
           // nameListBox.Items.Add(addTextBox.Text);

            //add to array and will actualise to appear in textbox
            names_people.Add(addTextBox.Text);

            //count the number of items and show in the count textbox
           // countTextBox.Text = nameListBox.Items.Count.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            
        }
    }
}
