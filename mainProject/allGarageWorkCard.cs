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
    public partial class allGarageWorkCard : Form
    {
        public allGarageWorkCard()
        {
            InitializeComponent();
            this.parameterBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        private void exitBtn_Click(object sender, EventArgs e)//פונקציה לסגירת הדף
        {
            this.Close();
        }

        private void showAllWorkCardBtn_Click(object sender, EventArgs e)//פונקציה לצפייה בכל הכרטיסי עבודה
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM garageWorkCardTable", mySqlConnection);
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

        private void endWorkCardsBtn_Click(object sender, EventArgs e)//פונקציה לצפייה בכרטיסי עבודה סגורים
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM garageWorkCardTable where WorkIsDone='True'", mySqlConnection);
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

        private void openWorkCardsBtn_Click(object sender, EventArgs e)//פונקציה לצפייה בכרטיסי עבודה פתוחים
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM garageWorkCardTable where WorkIsDone='False'", mySqlConnection);
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

        private void parameterBtn_Click(object sender, EventArgs e)// פונקציה לחיפוש בתוך הדאטא בייס לפי פראמטר
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
                    else
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where idGarageWorkCard='" + txtParameter.Text + " ';", mySqlConnection);
                }
                else if (this.parameterBox.Text == "carNumber")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    else
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where carNumber='" + txtParameter.Text + " ';", mySqlConnection);
                }
                else if (this.parameterBox.Text == "IdCustomer")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    else
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where IdCustomer='" + txtParameter.Text + " ';", mySqlConnection);
                }
                else
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    else
                    sqlData1 = new SqlDataAdapter("Select * from garageWorkCardTable where idWorker='" + txtParameter.Text + " ';", mySqlConnection);
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
    }
}
