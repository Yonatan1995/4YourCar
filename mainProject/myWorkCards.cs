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
    public partial class myWorkCards : Form
    {
        public myWorkCards(int idWorker)
        {
            InitializeComponent();
            this.parameterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.idWorker = idWorker;
        }
        int idWorker;
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        private void exitBtn_Click(object sender, EventArgs e)//פונקציה לסגירת הדף
        {
            this.Close();
        }

        private void openWorkCardsBtn_Click(object sender, EventArgs e)//פונקציה לצפייה בכרטיסי עבודה פתוחים שלי
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM garageWorkCardTable where( WorkIsDone='False') and (idWorker='" + idWorker + "')", mySqlConnection);
                DataTable table1 = new DataTable();
                sqlData1.Fill(table1);
                dataGridView1.DataSource = table1;
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void endWorkCardsBtn_Click(object sender, EventArgs e)//פונקציה לצפייה בכרטיסי עבודה סגורים שלי
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM garageWorkCardTable where( WorkIsDone='True') and (idWorker='" + idWorker + "')", mySqlConnection);
                DataTable table1 = new DataTable();
                sqlData1.Fill(table1);
                dataGridView1.DataSource = table1;
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void parameterBtn_Click(object sender, EventArgs e)//פונקציה לחיפוש כרטיסה עבודה לפי פרמטר
        {
            if (txtParameter.Text == "")
                MessageBox.Show("enter parameter first");
            else
            {
                SqlDataAdapter sqlData1 = new SqlDataAdapter();
                if (this.parameterBox.Text == "idGarageWorkCard")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where idGarageWorkCard='" + txtParameter.Text + "' and idWorker='" + idWorker + "';", mySqlConnection);
                }
                else if (this.parameterBox.Text == "carNumber")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where carNumber='" + txtParameter.Text + "' and idWorker='" + idWorker + "';", mySqlConnection);
                }
                else if (this.parameterBox.Text == "IdCustomer")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where IdCustomer='" + txtParameter.Text + "' and idWorker='" + idWorker + "';", mySqlConnection);
                }
                else
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where idWorker='" + txtParameter.Text + "' and idWorker='" + idWorker + "';", mySqlConnection);
                }
                try
                {
                    DataTable dt = new DataTable();
                    sqlData1.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        mySqlConnection.Open();
                        DataTable table1 = new DataTable();
                        sqlData1.Fill(table1);
                        dataGridView1.DataSource = table1;
                        mySqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void showAlWorkCardBtn_Click(object sender, EventArgs e)//פונקציה לצפייה בכל הכרטיסי עבודה שלי
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM garageWorkCardTable where idWorker='" + idWorker + "'", mySqlConnection);
                DataTable table1 = new DataTable();
                sqlData1.Fill(table1);
                dataGridView1.DataSource = table1;
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
