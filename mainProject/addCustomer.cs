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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)// פונקציה שמאפשרת רק הכנסה של מספרים לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        private void deleteBtn_Click(object sender, EventArgs e)// פונקציה למחיקת לקוח לפי מספר ת"ז לקוח
        {
            if (txtIdCustomer.Text == "")
                MessageBox.Show("enter id for delete customer");
            else
            {
                SqlDataAdapter ckCustomerExist = new SqlDataAdapter("Select count(*)From customersTable where IdCustomer='" + int.Parse(txtIdCustomer.Text) + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckCustomerExist.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    try
                    {
                        mySqlConnection.Open();
                        SqlCommand deleteCustomerCMD = new SqlCommand("Delete customersTable where IdCustomer=@IdCustomer", mySqlConnection);
                        deleteCustomerCMD.Parameters.AddWithValue("@IdCustomer", int.Parse(txtIdCustomer.Text));
                        deleteCustomerCMD.ExecuteNonQuery();
                        txtIdCustomer.Text = "";
                        mySqlConnection.Close();
                        MessageBox.Show("The customer has been deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("there is no customer With this id");
            }
        }

        private void addNewCustomerBtn_Click(object sender, EventArgs e)//פונקציה להוספת לקוח חדש
        {
            if (txtIdCustomer.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                SqlDataAdapter ckCustomerExist = new SqlDataAdapter("Select count(*)From customersTable where IdCustomer='" + int.Parse(txtIdCustomer.Text) + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckCustomerExist.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                    MessageBox.Show("there is customer with this id");
                else
                {
                    try
                    {
                        mySqlConnection.Open();
                        SqlCommand insertCustomerCMD = new SqlCommand("insert into customersTable values(@IdCustomer,@firstName,@lastName,@phone)", mySqlConnection);
                        insertCustomerCMD.Parameters.AddWithValue("@IdCustomer", int.Parse(txtIdCustomer.Text));
                        insertCustomerCMD.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                        insertCustomerCMD.Parameters.AddWithValue("@lastName", txtLastName.Text);
                        insertCustomerCMD.Parameters.AddWithValue("@phone", txtPhone.Text);
                        insertCustomerCMD.ExecuteNonQuery();
                        mySqlConnection.Close();
                        MessageBox.Show("You add new customer");
                        txtIdCustomer.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtPhone.Text = "";
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
