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
    public partial class addPart : Form
    {
        public addPart()
        {
            InitializeComponent();
        }

        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)// פונקציה שמאפשרת רק הכנסה של מספרים לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        public static int getNewId()//פונקציה לקבלת מספר אי.די רנדומלי חדש לחלק
        {
            int newId=0;
            Random rnd = new Random();
            SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
            SqlDataAdapter sql = new SqlDataAdapter("Select count(*)From partsTable where idPart='" + newId + "'", mySqlConnection);
            DataTable dt = new DataTable();
            do
            {
                dt.Clear();
                newId = rnd.Next(10000, 100001);
                sql.Fill(dt);

            } while (dt.Rows[0][0].ToString() == "1");
            mySqlConnection.Close();
            return newId;
        }

        private void addNewPartBtn_Click(object sender, EventArgs e)// פונקציה להוספת חלק חדש
        {
            if (txtIdPart.Text == "" || txtCost.Text == "" || txtMinInStock.Text == "" || txtPartName.Text == "" || txtPrice.Text == "" || txtStock.Text == "")
                MessageBox.Show("All fields are required");
            else
            {
                if (int.Parse(txtPrice.Text) < 0|| int.Parse(txtCost.Text)<0)
                    MessageBox.Show("cannot add negative price or cost");
                else
                {
                    SqlDataAdapter ckNameExist = new SqlDataAdapter("Select count(*)From partsTable where partName='" + txtPartName.Text + "'", mySqlConnection);
                    DataTable dt = new DataTable();
                    ckNameExist.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "0")
                        MessageBox.Show("there is part with this name");
                    else
                    {
                        try
                        {
                            int newId = getNewId();
                            mySqlConnection.Open();
                            SqlCommand insertPartCMD = new SqlCommand("insert into partsTable values(@idPart,@partName,@price,@cost,@stock,@minInStock)", mySqlConnection);
                            insertPartCMD.Parameters.AddWithValue("@idPart", newId);
                            insertPartCMD.Parameters.AddWithValue("@partName", txtPartName.Text);
                            insertPartCMD.Parameters.AddWithValue("@price", float.Parse(txtPrice.Text));
                            insertPartCMD.Parameters.AddWithValue("@cost", float.Parse(txtCost.Text));
                            insertPartCMD.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                            insertPartCMD.Parameters.AddWithValue("@minInStock", int.Parse(txtMinInStock.Text));
                            insertPartCMD.ExecuteNonQuery();
                            mySqlConnection.Close();
                            MessageBox.Show("You add new part");
                            txtCost.Text = "";
                            txtMinInStock.Text = "";
                            txtPartName.Text = "";
                            txtPrice.Text = "";
                            txtStock.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)// פונקציה למחיקת חלק לפי אי.די
        {
            if (txtIdPart.Text == "")
                MessageBox.Show("enter id for delete part");

            SqlDataAdapter ckPartExist = new SqlDataAdapter("Select count(*)From partsTable where idPart='" + int.Parse(txtIdPart.Text) + "'", mySqlConnection);
            DataTable dt = new DataTable();
            ckPartExist.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                try
                {
                    mySqlConnection.Open();
                    SqlCommand DeletePartCMD = new SqlCommand("Delete partsTable where idPart=@idPart", mySqlConnection);
                    DeletePartCMD.Parameters.AddWithValue("@idPart", int.Parse(txtIdPart.Text));
                    DeletePartCMD.ExecuteNonQuery();
                    txtIdPart.Text = "";
                    mySqlConnection.Close();
                    MessageBox.Show("The part has been deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("there is no part with this id");
        }
        private void editBtn_Click(object sender, EventArgs e)// פונקציה לשינוי מלאי חלק לפי אי.די
        {
            if (txtIdPart.Text == ""||txtStock.Text=="")
                MessageBox.Show("enter id and stock for edit part");
            else
            {
                int idPart, stockPart;
                idPart = int.Parse(txtIdPart.Text);
                stockPart = int.Parse(txtStock.Text);
                SqlDataAdapter ckPartExist = new SqlDataAdapter("Select count(*)From partsTable where idPart='" + idPart + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckPartExist.Fill(dt);
                if (dt.Rows[0][0].ToString() != "1")
                    MessageBox.Show("there is no part with this id");
                else
                {
                    if (stockPart < 0)
                        MessageBox.Show("Stock can not be negative number");
                    else
                    {
                        try
                        {
                            SqlCommand updatePriceCMD = mySqlConnection.CreateCommand();
                            mySqlConnection.Open();
                            updatePriceCMD.CommandText = "update partsTable set stock=" + stockPart + " where idPart='" + idPart + "';"; ;
                            updatePriceCMD.ExecuteNonQuery();
                            mySqlConnection.Close();
                            MessageBox.Show("The stock has been edited");
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
