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
    public partial class pricePerHourOfWork : Form
    {
        public pricePerHourOfWork()
        {
            InitializeComponent();
            
        }
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)//פונקציה לקבלת רק מספרים לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        private void showCurrentPriceBtn_Click(object sender, EventArgs e)//פונקציה להצגת מחיר שעת עבודה עדכני
        {
            SqlDataAdapter sql = new SqlDataAdapter("Select price From pricePerHourOfWorkTable where workTime='hour'", mySqlConnection);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            lblPrice.Text = dt.Rows[0][0].ToString();
        }

        private void updateTheNewPriceBtn_Click(object sender, EventArgs e)//פונקציה לעדכן מחיר שעת עבודה 
        {
            if (txtNewPrice.Text == "" )
                MessageBox.Show("enter new price for edit the price ");
            else
            {
                if(int.Parse(txtNewPrice.Text)<0)
                    MessageBox.Show("The price must be positive");
                else
                {
                    try
                    {
                        SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                        mySqlConnection.Open();
                        mySqlCommand.CommandText = "update pricePerHourOfWorkTable set price='" + int.Parse(txtNewPrice.Text) + "' where workTime='hour';"; ;
                        mySqlCommand.ExecuteNonQuery();
                        mySqlConnection.Close();
                        MessageBox.Show("The new price has been updated");
                        txtNewPrice.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
