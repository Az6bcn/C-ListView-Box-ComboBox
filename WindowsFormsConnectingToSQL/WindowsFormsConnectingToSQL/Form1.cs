using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsConnectingToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connection Object
            SqlConnection con = new SqlConnection();
            //connectionString 
            con.ConnectionString = "server = AZEEZOLUSEGUN; Database = AzeezTest; integrated security = true";
            //command Object with Query along with the connection to use for the query
            SqlCommand cmd = new SqlCommand("Select * from Customers", con);

            //DataAdapter to get data from DB and pass it the Query
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            //create DataTable to store the retrieved data
            DataTable table = new DataTable();

            //fill the DataTable with the adapter data
            adapter.Fill(table);

            //populate the data filled in the table to the DataGridView
            CustomerDataGridView.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get name of the cell clicked content
            MessageBox.Show("Name :" +  e.RowIndex.);
        }
    }
}
