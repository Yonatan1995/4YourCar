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
    public partial class addWorkCard : Form
    {
        public addWorkCard()
        {
            InitializeComponent();
            fillComboBoxCarNumber(comboBoxCarNumber);
            fillComboBoxIdWorker(comboBoxIdWorker);
        }
        public void onlyNumbers(object sender, KeyPressEventArgs e)// פונקציה שמאפשרת רק הכנסה של מספרים לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        public void fillComboBoxCarNumber(ComboBox comboBoxCarNumber)//פונקציה הממלאת קומבו בוקס מתוך הבסיס נתונים
        {
            SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
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
        public void fillComboBoxIdWorker(ComboBox comboBoxIdWorker)//פונקציה הממלאת קומבו בוקס מתוך הבסיס נתונים
        {
            SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
            mySqlConnection.Open();
            SqlCommand cmd = mySqlConnection.CreateCommand();
            cmd.CommandText = "select idWorker from workersTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxIdWorker.Items.Add(dr["idWorker"]);
            }
            mySqlConnection.Close();
        }
        public static int getNewId()//פונקציה הנותנת מספר אי.די רמנדומלי חדש
        {
            int newId = 0;
            Random rnd = new Random();
            SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
            SqlDataAdapter ckIdExist = new SqlDataAdapter("Select count(*)From partsTable where idPart='" + newId + "'", mySqlConnection);
            DataTable dt = new DataTable();
            do
            {
                dt.Clear();
                newId = rnd.Next(100000, 1000001);
                ckIdExist.Fill(dt);

            } while (dt.Rows[0][0].ToString() == "1");
            mySqlConnection.Close();
            return newId;
        }
        private void addNewWorkCardBtn_Click(object sender, EventArgs e)//פונקציה לפתיחת כרטיס עבודה חדש
        {
            int idCustomer;
            if (comboBoxCarNumber.Text == "" || txtDescription.Text == "" || comboBoxIdWorker.Text == "" || txtKMcar.Text == "")
                MessageBox.Show("All fields are required");
            else
            {
                if(float.Parse(txtKMcar.Text)<0)
                    MessageBox.Show("The car KM cannot be negative");
                else
                { 
                SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
                DataTable dt = new DataTable();
                    SqlDataAdapter ckCarExist = new SqlDataAdapter("Select count(*)From carsTable where carNumber='" + int.Parse(comboBoxCarNumber.Text) + "'", mySqlConnection);
                    ckCarExist.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "1")
                        MessageBox.Show("there is no car with this car number,\n Please add a new car first");
                    else
                    {
                        dt.Clear();
                        SqlDataAdapter takeIdCustomer = new SqlDataAdapter("Select IdCustomer From carsTable where carNumber='" + int.Parse(comboBoxCarNumber.Text) + "'", mySqlConnection);
                        takeIdCustomer.Fill(dt);
                        idCustomer=int.Parse(dt.Rows[0][1].ToString());
                        dt.Clear();
                        SqlDataAdapter sql3 = new SqlDataAdapter("Select count(*)From workersTable where idWorker='" + int.Parse(comboBoxIdWorker.Text) + "' AND ( typeAccount=1 OR typeAccount=3) ", mySqlConnection);
                        sql3.Fill(dt);
                            if (dt.Rows[0][0].ToString() != "1")
                                MessageBox.Show("there is no worker With this id or the worker is not mechanic,\n Please check the id worker");
                            else
                            {
                                try
                                {
                                    int idGarageWorkCard = getNewId();
                                    mySqlConnection.Open();
                                    SqlCommand insertWorkCardCMD = new SqlCommand("insert into garageWorkCardTable values(@idGarageWorkCard,@carNumber,@IdCustomer,@idWorker,@price,@KMcar,@WorkIsDone,@Description,@openingTime,@closingTime)", mySqlConnection);
                                    insertWorkCardCMD.Parameters.AddWithValue("@idGarageWorkCard", idGarageWorkCard);
                                    insertWorkCardCMD.Parameters.AddWithValue("@carNumber", int.Parse(comboBoxCarNumber.Text));
                                    insertWorkCardCMD.Parameters.AddWithValue("@IdCustomer", idCustomer);
                                    insertWorkCardCMD.Parameters.AddWithValue("@idWorker", int.Parse(comboBoxIdWorker.Text));
                                    insertWorkCardCMD.Parameters.AddWithValue("@KMcar", float.Parse(txtKMcar.Text));
                                    insertWorkCardCMD.Parameters.AddWithValue("@price", 0.0);
                                    insertWorkCardCMD.Parameters.AddWithValue("@WorkIsDone", "False");
                                    insertWorkCardCMD.Parameters.AddWithValue("@Description", txtDescription.Text);
                                    insertWorkCardCMD.Parameters.AddWithValue("@openingTime", DateTime.Now.ToString());
                                    insertWorkCardCMD.Parameters.AddWithValue("@closingTime", "");
                                    insertWorkCardCMD.ExecuteNonQuery();
                                    mySqlConnection.Close();
                                    MessageBox.Show("You add new work card");
                                    comboBoxCarNumber.Text = "";
                                    comboBoxIdWorker.Text = "";
                                    txtKMcar.Text = "";
                                    txtDescription.Text = "";
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
