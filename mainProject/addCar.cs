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
    public partial class addCar : Form
    {
        public addCar()
        {
            InitializeComponent();
        }

        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)// פונקציה שמאפשרת רק הכנסה של מספרים לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        private void deleteBtn_Click(object sender, EventArgs e)// פונקציה שמוחקת רכב לפי מספר רכב
        {
            if (txtCarNumber.Text == "")
                MessageBox.Show("enter number car for delete car");
            else
            {
                SqlDataAdapter ckIfCarExist = new SqlDataAdapter("Select count(*)From carsTable where carNumber='" + int.Parse(txtCarNumber.Text) + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckIfCarExist.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    try
                    {
                        mySqlConnection.Open();
                        SqlCommand deleteCarCMD = new SqlCommand("Delete carsTable where carNumber=@carNumber", mySqlConnection);
                        deleteCarCMD.Parameters.AddWithValue("@carNumber", int.Parse(txtCarNumber.Text));
                        deleteCarCMD.ExecuteNonQuery();
                        txtIdCustomer.Text = "";
                        mySqlConnection.Close();
                        MessageBox.Show("The car has been deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("there is no car with this number car");
            }
        }

        private void addNewCarBtn_Click(object sender, EventArgs e)// פונקצית הוספת רכב חדש
        {
            if (txtCarNumber.Text == "" || txtIdCustomer.Text == "" || txtMake.Text == "" || txtManufactureYear.Text == "" || txtModel.Text == "")
                MessageBox.Show("All fields are required");
            else
            {
                SqlDataAdapter ckCustomerExist = new SqlDataAdapter("Select count(*)From customersTable where IdCustomer='" + int.Parse(txtIdCustomer.Text) + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckCustomerExist.Fill(dt);
                if (dt.Rows[0][0].ToString() != "1")
                    MessageBox.Show("there is no customer with this id,\n Please add a new customer first");
                else
                {
                    SqlDataAdapter ckCarExist = new SqlDataAdapter("Select count(*)From carsTable where carNumber='" + int.Parse(txtCarNumber.Text) + "'", mySqlConnection);
                    DataTable dt2 = new DataTable();
                    ckCarExist.Fill(dt2);
                    if (dt2.Rows[0][0].ToString() == "1")
                        MessageBox.Show("there is car with this car number");
                    else
                    {
                        try
                        {
                            mySqlConnection.Open();
                            SqlCommand insertCarCMD = new SqlCommand("insert into carsTable values(@carNumber,@IdCustomer,@make,@model,@manufactureYear)", mySqlConnection);
                            insertCarCMD.Parameters.AddWithValue("@carNumber", int.Parse(txtCarNumber.Text));
                            insertCarCMD.Parameters.AddWithValue("@IdCustomer", int.Parse(txtIdCustomer.Text));
                            insertCarCMD.Parameters.AddWithValue("@make", txtMake.Text);
                            insertCarCMD.Parameters.AddWithValue("@model", txtModel.Text);
                            insertCarCMD.Parameters.AddWithValue("@manufactureYear", int.Parse(txtManufactureYear.Text));
                            insertCarCMD.ExecuteNonQuery();
                            mySqlConnection.Close();
                            MessageBox.Show("You add new car");
                            txtIdCustomer.Text = "";
                            txtCarNumber.Text = "";
                            txtMake.Text = "";
                            txtModel.Text = "";
                            txtManufactureYear.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        private void changeOwnerBtn_Click(object sender, EventArgs e)// פונקציה שמחליפה בעלות לרכב לפי מספר רכב ות"ז לקוח
        {
            if (txtCarNumber.Text == "" || txtIdCustomer.Text == "")
                MessageBox.Show("Required car number and ID number of the new owner");
            else
            {
                SqlDataAdapter ckIdCustomer = new SqlDataAdapter("Select count(*)From customersTable where IdCustomer='" + int.Parse(txtIdCustomer.Text) + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckIdCustomer.Fill(dt);
                if (dt.Rows[0][0].ToString() != "1")
                    MessageBox.Show("there is no customer with this id,\n Please add a new customer first");
                else
                {
                    SqlDataAdapter ckCarNumber = new SqlDataAdapter("Select count(*)From carsTable where carNumber='" + int.Parse(txtCarNumber.Text) + "'", mySqlConnection);
                    dt.Clear();
                    ckCarNumber.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "1")
                        MessageBox.Show("there is no car with this car number");
                    else
                    {
                        try
                        {
                            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                            mySqlConnection.Open();
                            mySqlCommand.CommandText = "update carsTable set IdCustomer=" + int.Parse(txtIdCustomer.Text) + " where carNumber='" + int.Parse(txtCarNumber.Text) + "';"; ;
                            mySqlCommand.ExecuteNonQuery();
                            mySqlConnection.Close();
                            MessageBox.Show("Car ownership has changed");
                            txtIdCustomer.Text = "";
                            txtCarNumber.Text = "";
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
}