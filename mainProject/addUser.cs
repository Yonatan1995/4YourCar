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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)// פונקציה שמאפשרת רק הכנסה של מספרים לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        private void addNewUserBtn_Click(object sender, EventArgs e)//פונקציה להוספת משתמש חדש
        {
            int typeAccount;
            if (txtIdWorker.Text == "" || txtUserName.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                if (!ManagerButton.Checked && !ReceptionistButton.Checked && !MechanicButton.Checked)
                {
                    MessageBox.Show("Please select user role");
                }
                else
                {
                    if (ManagerButton.Checked)
                        typeAccount = 1;
                    else if (ReceptionistButton.Checked)
                        typeAccount = 2;
                    else
                        typeAccount = 3;
                    SqlDataAdapter ckUserIdExist = new SqlDataAdapter("Select count(*)From workersTable where idWorker='" + int.Parse(txtIdWorker.Text) + "'", mySqlConnection);
                    DataTable dt = new DataTable();
                    ckUserIdExist.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                        MessageBox.Show("there is user With this id");
                    else
                    {
                        SqlDataAdapter ckUserUsernameExist = new SqlDataAdapter("Select count(*)From workersTable where userName='" + int.Parse(txtUserName.Text) + "'", mySqlConnection);
                        dt.Clear();
                        ckUserUsernameExist.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                            MessageBox.Show("there is user with this username\n please use a different username");
                        else
                        {
                            try
                            {
                                mySqlConnection.Open();
                                SqlCommand cmd = new SqlCommand("insert into workersTable values(@idWorker,@typeAccount,@userName,@password,@firstName,@lastName,@phone)", mySqlConnection);
                                cmd.Parameters.AddWithValue("@idWorker", int.Parse(txtIdWorker.Text));
                                cmd.Parameters.AddWithValue("@typeAccount", typeAccount);
                                cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                                cmd.ExecuteNonQuery();
                                mySqlConnection.Close();
                                MessageBox.Show("You add new user");
                                txtIdWorker.Text = "";
                                txtFirstName.Text = "";
                                txtLastName.Text = "";
                                txtPassword.Text = "";
                                txtPhone.Text = "";
                                txtUserName.Text = "";
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
        private void btnDelete_Click(object sender, EventArgs e)//פונקציה למחיקת משתמש לפי אי.די
        {
            if (txtIdWorker.Text == "")
                MessageBox.Show("enter id for delete user");
            else
            {
                SqlDataAdapter ckForOpenWorkCard = new SqlDataAdapter("Select count(*) From garageWorkCardTable where idWorker='" + int.Parse(txtIdWorker.Text) + "' and WorkIsDone='False'", mySqlConnection);
                DataTable dt = new DataTable();
                ckForOpenWorkCard.Fill(dt);
                if (dt.Rows[0][0].ToString() != "0")
                    MessageBox.Show("The worker still has an open work card,\n please close the work card first");
                else
                {

                    SqlDataAdapter ckUserExist = new SqlDataAdapter("Select count(*)From workersTable where idWorker='" + int.Parse(txtIdWorker.Text) + "'", mySqlConnection);
                    dt.Clear();
                    ckUserExist.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        try
                        {
                            mySqlConnection.Open();
                            SqlCommand DeleteUserCMD = new SqlCommand("Delete workersTable where idWorker=@idWorker", mySqlConnection);
                            DeleteUserCMD.Parameters.AddWithValue("@idWorker", int.Parse(txtIdWorker.Text));
                            DeleteUserCMD.ExecuteNonQuery();
                            txtIdWorker.Text = "";
                            mySqlConnection.Close();
                            MessageBox.Show("The user has been deleted");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("there is no user with this id");
                }
            }
        }
    }
}
