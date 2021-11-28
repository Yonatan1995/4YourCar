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
    public partial class partsForWorkCard : Form
    {
        public partsForWorkCard()
        {
            InitializeComponent();
            fillComboBoxIdWorkCard(comboBoxIdWorkCard);
            fillComboBoxIdWorkCard(comboBoxIdWorkCard2);
            fillComboBoxIdPart(comboBoxIdPart);
        }
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)//פונציה לקבלת רק מספרים בטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        public void fillComboBoxIdWorkCard(ComboBox comboBoxIdWorkCard)//פונקציה למילוי קומבו בוקס בכרטיסי עבודה
        {
            mySqlConnection.Open();
            SqlCommand cmd = mySqlConnection.CreateCommand();
            cmd.CommandText = "select idGarageWorkCard from garageWorkCardTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxIdWorkCard.Items.Add(dr["idGarageWorkCard"]);
            }
            mySqlConnection.Close();
        }
        public void fillComboBoxIdPart(ComboBox comboBoxIdPart)//פונקציה למילוי כומבו בוקס בחלקים
        {
            mySqlConnection.Open();
            SqlCommand cmd = mySqlConnection.CreateCommand();
            cmd.CommandText = "select idPart from partsTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxIdPart.Items.Add(dr["idPart"]);
            }
            mySqlConnection.Close();
        }

        private void parameterBtn_Click(object sender, EventArgs e)//פונקציה לצפיה בחלקים שהוספו לכרטיס עבודה
        {
            if (comboBoxIdWorkCard2.Text == "")
                MessageBox.Show("enter id work card first");
            if (!comboBoxIdWorkCard2.Text.All(char.IsDigit))
                MessageBox.Show("the id must be number");
            else
            {
                SqlDataAdapter sqlData1 = new SqlDataAdapter();
                sqlData1 = new SqlDataAdapter("Select * from partsForUseTable where idGarageWorkCard='" + comboBoxIdWorkCard2.Text + " ';", mySqlConnection);
                mySqlConnection.Open();
                DataTable table1 = new DataTable();
                sqlData1.Fill(table1);
                dataGridView1.DataSource = table1;
                mySqlConnection.Close();
            }
        }

        private void addPartBtn_Click(object sender, EventArgs e)//פונקציה להוספת חלק לכרטיס עבודה
        {
            if (comboBoxIdWorkCard.Text == "" || comboBoxIdPart.Text == "" || txtStock.Text == "")
                MessageBox.Show("All fields are required");
            else
            {
                if (int.Parse(txtStock.Text) < 0)
                    MessageBox.Show("The stock can not be negative");
                else
                {
                    SqlDataAdapter ckInStock = new SqlDataAdapter("Select count(*)From partsTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "' and Stock>='" + int.Parse(txtStock.Text) + "'", mySqlConnection);
                    DataTable dt = new DataTable();
                    ckInStock.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "1")
                        MessageBox.Show("The ID does not match or is not in stock");
                    else
                    {
                        int nowStock, newStock;
                        dt.Clear();
                        SqlDataAdapter takeStockFromPartTable = new SqlDataAdapter("Select Stock From partsTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "'", mySqlConnection);
                        takeStockFromPartTable.Fill(dt);
                        nowStock = int.Parse(dt.Rows[0][1].ToString());
                        newStock = nowStock - int.Parse(txtStock.Text);
                        try
                        {
                            mySqlConnection.Open();
                            SqlCommand updateNewStockInPartTable = new SqlCommand("update partsTable set Stock=" + newStock + " where idPart='" + int.Parse(comboBoxIdPart.Text) + "'", mySqlConnection);
                            updateNewStockInPartTable.ExecuteNonQuery();
                            dt.Clear();
                            SqlDataAdapter ckIfHaveRow = new SqlDataAdapter("Select count(*)From partsForUseTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "' and idGarageWorkCard>='" + int.Parse(comboBoxIdWorkCard.Text) + "'", mySqlConnection);
                            ckIfHaveRow.Fill(dt);
                            if (dt.Rows[0][0].ToString() != "1")
                            {
                                SqlCommand NewRow = new SqlCommand("insert into partsForUseTable values(@idGarageWorkCard,@idPart,@Stock)", mySqlConnection);
                                NewRow.Parameters.AddWithValue("@idGarageWorkCard", int.Parse(comboBoxIdWorkCard.Text));
                                NewRow.Parameters.AddWithValue("@idPart", int.Parse(comboBoxIdPart.Text));
                                NewRow.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                                NewRow.ExecuteNonQuery();
                            }
                            else
                            {
                                dt.Clear();
                                SqlDataAdapter takeStockFromPartsForUseTable = new SqlDataAdapter("Select Stock From partsForUseTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "'and idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "' ", mySqlConnection);
                                takeStockFromPartsForUseTable.Fill(dt);
                                nowStock = int.Parse(dt.Rows[0][1].ToString());
                                newStock = nowStock + int.Parse(txtStock.Text);
                                SqlCommand updateRow = new SqlCommand("update partsForUseTable set Stock=" + newStock + " where idPart='" + int.Parse(comboBoxIdPart.Text) + "'and idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "'", mySqlConnection);
                                updateRow.ExecuteNonQuery();
                            }
                            mySqlConnection.Close();
                            MessageBox.Show("You add new part");
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

        private void removeBtn_Click(object sender, EventArgs e)//פונקציה להסרת חלק מכרטיס עבודה
        {
            if (comboBoxIdWorkCard.Text == "" || comboBoxIdPart.Text == "" || txtStock.Text == "")
                MessageBox.Show("All fields are required");
            else
            {
                if (int.Parse(txtStock.Text) < 0)
                    MessageBox.Show("The stock can not be negative");
                else
                {
                    SqlDataAdapter ckInStock = new SqlDataAdapter("Select count(*)From partsTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "'", mySqlConnection);
                    DataTable dt = new DataTable();
                    ckInStock.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "1")
                        MessageBox.Show("The ID part does not match");
                    else
                    {
                        int nowStock, newStock;
                        dt.Clear();
                        SqlDataAdapter takeStockFromPartsForUseTable = new SqlDataAdapter("Select Stock From partsForUseTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "'and idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "' ", mySqlConnection);
                        takeStockFromPartsForUseTable.Fill(dt);
                        nowStock = int.Parse(dt.Rows[0][1].ToString());
                        if (nowStock < int.Parse(txtStock.Text))
                            MessageBox.Show("You can not remove a stock that does not exist");
                        else
                        {
                            dt.Clear();
                            SqlDataAdapter takeStockFromPartTable = new SqlDataAdapter("Select Stock From partsTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "'", mySqlConnection);
                            takeStockFromPartTable.Fill(dt);
                            nowStock = int.Parse(dt.Rows[0][1].ToString());
                            newStock = nowStock + int.Parse(txtStock.Text);
                            try
                            {
                                mySqlConnection.Open();
                                SqlCommand updateNewStockInPartTable = new SqlCommand("update partsTable set Stock=" + newStock + " where idPart='" + int.Parse(comboBoxIdPart.Text) + "'", mySqlConnection);
                                updateNewStockInPartTable.ExecuteNonQuery();
                                dt.Clear();
                                takeStockFromPartsForUseTable.Fill(dt);
                                nowStock = int.Parse(dt.Rows[0][1].ToString());
                                newStock = nowStock - int.Parse(txtStock.Text);
                                SqlCommand updateRow = new SqlCommand("update partsForUseTable set Stock=" + newStock + " where idPart='" + int.Parse(comboBoxIdPart.Text) + "'and idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "'", mySqlConnection);
                                updateRow.ExecuteNonQuery();
                                dt.Clear();
                                takeStockFromPartsForUseTable.Fill(dt);
                                if (dt.Rows[0][1].ToString() == "0")
                                {
                                    SqlCommand deleteRow = new SqlCommand("delete from partsForUseTable where idPart='" + int.Parse(comboBoxIdPart.Text) + "'and idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "'", mySqlConnection);
                                    deleteRow.ExecuteNonQuery();
                                }
                                mySqlConnection.Close();
                                MessageBox.Show("You remove the part");
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
        }
    }
}
