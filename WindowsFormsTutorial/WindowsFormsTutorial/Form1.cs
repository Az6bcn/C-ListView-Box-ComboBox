using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;
            //try to Read texboxinput-->convert the string to int
            try
            {
                 res = Convert.ToInt32(entradaTxtBox.Text)*2;

            } //throw exception
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                //write error in the resulttextbox
                salidaTxtBox.Text = "Error";
                return;
            }
            //if no error Convert res to int to show result in resulttextbox
            salidaTxtBox.Text = Convert.ToString(res);
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormLoading");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
