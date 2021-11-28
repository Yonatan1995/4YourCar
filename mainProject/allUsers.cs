using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainProject
{
    public partial class allUsers : Form
    {
        public allUsers()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)//פונקציה לסגירת הדף
        {
            this.Close();
        }

        private void showUsersBtn_Click(object sender, EventArgs e)//פונקציה לצפיה בכל המשתמשים ובתפקידיהם
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM workersTable", mySqlConnection);
                DataTable table1 = new DataTable();
                sqlData1.Fill(table1);
                dataGridView1.DataSource = table1;
                SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT * FROM workerTypesTable", mySqlConnection);
                DataTable table2 = new DataTable();
                sqlData2.Fill(table2);
                dataGridView2.DataSource = table2;
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
