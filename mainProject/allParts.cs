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
    public partial class allParts : Form
    {
        public allParts()
        {
            InitializeComponent();
            this.parameterBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPartsBtn_Click(object sender, EventArgs e)//פונקציה לצפייה בכל החלקים מתוך הדאטא בייס
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM partsTable", mySqlConnection);
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
                if (this.parameterBox.Text == "idPart")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    else
                    sqlData1 = new SqlDataAdapter("Select * from partsTable where idPart='" + txtParameter.Text + " ';", mySqlConnection);
                }
                else if (this.parameterBox.Text == "partName")
                {
                    sqlData1 = new SqlDataAdapter("Select * from partsTable where partName='" + txtParameter.Text + " ';", mySqlConnection);
                }
                else if (this.parameterBox.Text == "price")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    else
                    sqlData1 = new SqlDataAdapter("Select * from partsTable where price='" + txtParameter.Text + " ';", mySqlConnection);
                }
                else if (this.parameterBox.Text == "cost")
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    else
                    sqlData1 = new SqlDataAdapter("Select * from partsTable where cost='" + txtParameter.Text + " ';", mySqlConnection);
                }
                else
                {
                    if (!txtParameter.Text.All(char.IsDigit))
                        MessageBox.Show("the parameter must be number");
                    else
                    sqlData1 = new SqlDataAdapter("Select * from partsTable where stock='" + txtParameter.Text + " ';", mySqlConnection);
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

        private void button1_Click(object sender, EventArgs e)//פונקציה לצפייה בחלקי מלאי שצריך להזמין למלאי 
        {
            try
            {
                mySqlConnection.Open();
                SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT * FROM partsTable where stock<=minInStock", mySqlConnection);
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
