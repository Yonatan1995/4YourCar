using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainProject
{
    public partial class carDisable : Form
    {
        public carDisable()
        {
            InitializeComponent();
            fillComboBoxCarNumber(comboBoxCarNumber);
            fillComboBoxIdCustomer(comboBoxIdCustomer);
        }
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)//פונקציה המאפשרת רק הכנסה של מספרים לטקסט בטקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        public void fillComboBoxCarNumber(ComboBox comboBoxCarNumber)// פונקציה למילוי אפשרויות בחירה בקומבו בוקס מתוך הדאטא בייס של רכבים
        {
            try
            {
                mySqlConnection.Open();
                SqlCommand cmd = mySqlConnection.CreateCommand();
                cmd.CommandText = "select carNumber from carsTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBoxCarNumber.Items.Add(dr["carNumber"]);
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void fillComboBoxIdCustomer(ComboBox comboBoxIdCustomer)//פונקציה למילוי אפשרויות בחירה בקומבו בוקס מתוך הדאטא בייס של לקוחות
        {
            try
            {
                mySqlConnection.Open();
                SqlCommand cmd = mySqlConnection.CreateCommand();
                cmd.CommandText = "select IdCustomer from customersTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBoxIdCustomer.Items.Add(dr["IdCustomer"]);
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisableCarBtn_Click(object sender, EventArgs e)//פונקציה להשבתת רכב ועדכן של זה בדאטא בייס+בקובץ טקסט
        {
            if(comboBoxCarNumber.Text==""||comboBoxIdCustomer.Text=="")
                MessageBox.Show("All fields are required");
            else
            {
                SqlDataAdapter ckCustomerExist = new SqlDataAdapter("Select count(*)From customersTable where IdCustomer='" + int.Parse(comboBoxIdCustomer.Text) + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckCustomerExist.Fill(dt);
                if (dt.Rows[0][0].ToString() != "1")
                    MessageBox.Show("there is no customer with this id,\n Please add a new customer first");
                else
                {
                    SqlDataAdapter ckCarExist = new SqlDataAdapter("Select count(*)From carsTable where carNumber='" + int.Parse(comboBoxCarNumber.Text) + "'", mySqlConnection);
                    DataTable dt2 = new DataTable();
                    ckCarExist.Fill(dt2);
                    if (dt2.Rows[0][0].ToString() != "1")
                        MessageBox.Show("there is no car with this car number");
                    else
                    {
                        dt2.Clear();
                        SqlDataAdapter ckOwner = new SqlDataAdapter("Select count(*)From carsTable where carNumber='" + int.Parse(comboBoxCarNumber.Text) + "'and IdCustomer='" + int.Parse(comboBoxIdCustomer.Text) + "'", mySqlConnection);
                        ckOwner.Fill(dt2);
                        if (dt2.Rows[0][0].ToString() != "1")
                            MessageBox.Show("This customer is not the owner of the car");
                        else
                        {
                            try
                            {
                                mySqlConnection.Open();
                                SqlCommand workCardsFalse = mySqlConnection.CreateCommand();
                                workCardsFalse.CommandText = "update garageWorkCardTable set WorkIsDone='True' where carNumber='" + int.Parse(comboBoxCarNumber.Text) + "';";
                                workCardsFalse.ExecuteNonQuery();
                                SqlCommand cmd = new SqlCommand("insert into carsDisabledTable values(@carNumber,@IdCustomer)", mySqlConnection);
                                cmd.Parameters.AddWithValue("@carNumber", int.Parse(comboBoxCarNumber.Text));
                                cmd.Parameters.AddWithValue("@IdCustomer", int.Parse(comboBoxIdCustomer.Text));
                                cmd.ExecuteNonQuery();
                                mySqlConnection.Close();
                                using (StreamWriter writetext = File.AppendText("carsDisable.txt"))
                                    writetext.WriteLine("car number : " + comboBoxCarNumber.Text + " id customer : " + comboBoxIdCustomer.Text + "\n");
                                MessageBox.Show("The car is Disabled");
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
}
