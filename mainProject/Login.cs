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


namespace mainProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            timer.Start();
        }

        private void ExitBtn_Click(object sender, EventArgs e)//פונקציה לסגירת הדף
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)// פונקציה לעדכון שעון בדף
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void LoginBtn_Click(object sender, EventArgs e)//פונקציה להתחברות למערכת לפי זיהוי
        {
            int typeAccount;
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                if (!ManagerButton.Checked && !ReceptionistButton.Checked && !MechanicButton.Checked)
                {
                    MessageBox.Show("Please select your role");
                }
                else
                {
                    if (ManagerButton.Checked)
                        typeAccount = 1;
                    else if (ReceptionistButton.Checked)
                        typeAccount = 2;
                    else
                        typeAccount = 3;

                    SqlConnection con = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
                    SqlDataAdapter tryLogin = new SqlDataAdapter("Select count(*)From workersTable where userName='" + txtUserName.Text + "' and password='" + txtPassword.Text + "'and (typeAccount='"+ typeAccount.ToString()+ "'or typeAccount=1)", con);
                    DataTable dt = new DataTable();
                    tryLogin.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        dt.Clear();
                        int idWorker;
                        string firstName;
                        SqlDataAdapter takeIdAndName = new SqlDataAdapter("Select firstName,idWorker from workersTable where userName ='" + txtUserName.Text+"'", con);
                        takeIdAndName.Fill(dt);
                        firstName = dt.Rows[0][1].ToString();
                        idWorker = int.Parse( dt.Rows[0][2].ToString());

                        if (typeAccount == 1)
                        {
                            managerHome managerhome = new managerHome(idWorker, firstName);
                            managerhome.Show();
                            this.Hide();
                        }
                        else if (typeAccount == 2)
                        {
                            receptionistHome receptionisthome = new receptionistHome(idWorker, firstName);
                            receptionisthome.Show();
                            this.Hide();
                            
                        }
                        else if (typeAccount == 3)
                        {
                            mechanicHome mechanichome = new mechanicHome(idWorker, firstName);
                            mechanichome.Show();
                            this.Hide();
                        }
                    }
                    else
                        MessageBox.Show("UserName, Password or typeAccount  is incorrect!!!");
                }
            }

        }
    }
}
