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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace mainProject
{
    public partial class closingWorkCard : Form
    {
        public closingWorkCard(int idWorker)
        {
            InitializeComponent();
            this.idWorker = idWorker;
            fillComboBoxIdWorkCard(comboBoxIdWorkCard);
        }
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");
        int idWorker;
        public void onlyNumbers(object sender, KeyPressEventArgs e)//פונקציה המאפשרת רק הכנסת מספרים לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) &&( e.Handled=!char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        public void fillComboBoxIdWorkCard(ComboBox comboBoxIdWorkCard)// פונקציה למילוי כומבו בוקס מתוך הדאטא בייס של מספרי כרטיסי עבודה פתוחים
        {
            try
            {
                mySqlConnection.Open();
                SqlCommand cmd = mySqlConnection.CreateCommand();
                cmd.CommandText = "select idGarageWorkCard from garageWorkCardTable where WorkIsDone='False'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void closeWorkCardBtn_Click(object sender, EventArgs e)//פונקציה לסגירת כרטיס עבודה עדכון בדאטא בייס ויצירת קבלה מסוג פי.די.אפ
        {
            int workCardPrice = 0;
            if (comboBoxIdWorkCard.Text == "" || txtHoursWork.Text == "")
                MessageBox.Show("All fields are required");
            else
            {
                SqlDataAdapter ckIfExist = new SqlDataAdapter("Select count(*)From garageWorkCardTable where idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "' and WorkIsDone='False'", mySqlConnection);
                DataTable dt = new DataTable();
                ckIfExist.Fill(dt);
                if (dt.Rows[0][0].ToString() != "1")
                    MessageBox.Show("There is no working card with this number or it is already closed");
                else
                {
                    dt.Clear();
                    SqlDataAdapter ckIfMyWorkCard = new SqlDataAdapter("Select count(*)From garageWorkCardTable where idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "' and idWorker='" + idWorker + "'", mySqlConnection);
                    SqlDataAdapter ckIfManager = new SqlDataAdapter("Select count(*)From workersTable where idWorker='" + idWorker + "' and typeAccount=1", mySqlConnection);
                    ckIfMyWorkCard.Fill(dt);
                    ckIfManager.Fill(dt);
                    if (dt.Rows[1][0].ToString() != "1" && dt.Rows[0][0].ToString() != "1")
                        MessageBox.Show("Only the car worker or manager can close a work card");
                    else
                    {
                        try
                        {
                            dt.Clear();
                            mySqlConnection.Open();
                            SqlCommand takeIdAndStockCMD = mySqlConnection.CreateCommand();
                            takeIdAndStockCMD.CommandText = "select idPart,Stock from partsForUseTable where idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "'";
                            takeIdAndStockCMD.ExecuteNonQuery();
                            SqlDataAdapter idAndStock = new SqlDataAdapter(takeIdAndStockCMD);
                            idAndStock.Fill(dt);
                            DataTable dtPartsForUseTable = new DataTable();

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                SqlCommand takePartPriceCMD = mySqlConnection.CreateCommand();
                                SqlDataAdapter pricePart = new SqlDataAdapter(takePartPriceCMD);
                                takePartPriceCMD.CommandText = "select price from partsTable where idPart='" + int.Parse(dt.Rows[i][1].ToString()) + "'";
                                takePartPriceCMD.ExecuteNonQuery();
                                pricePart.Fill(dtPartsForUseTable);

                                workCardPrice += int.Parse(dtPartsForUseTable.Rows[0][0].ToString()) * int.Parse(dt.Rows[i][2].ToString());
                                dtPartsForUseTable.Clear();
                            }
                            dt.Clear();
                            SqlCommand takePriceForWorkCMD = mySqlConnection.CreateCommand();
                            SqlDataAdapter priceHourWork = new SqlDataAdapter(takePriceForWorkCMD);
                            takePriceForWorkCMD.CommandText = "select price from pricePerHourOfWorkTable where workTime='hour';";
                            takePriceForWorkCMD.ExecuteNonQuery();
                            priceHourWork.Fill(dt);
                            workCardPrice += int.Parse(dt.Rows[0][3].ToString()) * int.Parse(txtHoursWork.Text.ToString());
                            SqlCommand closeWorkCard = mySqlConnection.CreateCommand();
                            closeWorkCard.CommandText = " update garageWorkCardTable set price ='" + workCardPrice + "' , WorkIsDone ='True',closingTime ='" + DateTime.Now.ToString() + "' where idGarageWorkCard = '" + int.Parse(comboBoxIdWorkCard.Text) + "'; ";
                            closeWorkCard.ExecuteNonQuery();

                            int carNumber, IdCustomer;
                            float KMcar;
                            string Description, openingTime, closingTime;
                            DataTable dataTable = new DataTable();
                            SqlCommand takeWorkCardDataCMD = mySqlConnection.CreateCommand();
                            SqlDataAdapter workCardData = new SqlDataAdapter(takeWorkCardDataCMD);
                            takeWorkCardDataCMD.CommandText = "select carNumber,IdCustomer,KMcar,Description,openingTime,closingTime from garageWorkCardTable where idGarageWorkCard='" + int.Parse(comboBoxIdWorkCard.Text) + "';";
                            takeWorkCardDataCMD.ExecuteNonQuery();
                            workCardData.Fill(dataTable);
                            carNumber = int.Parse(dataTable.Rows[0][0].ToString());
                            IdCustomer = int.Parse(dataTable.Rows[0][1].ToString());
                            KMcar = float.Parse(dataTable.Rows[0][2].ToString());
                            Description = dataTable.Rows[0][3].ToString();
                            openingTime = dataTable.Rows[0][4].ToString();
                            closingTime = dataTable.Rows[0][5].ToString();
                            mySqlConnection.Close();
                            Document doc = new Document();
                            PdfWriter.GetInstance(doc, new FileStream("Receipt " + comboBoxIdWorkCard.Text + ".pdf", FileMode.Create));
                            doc.Open();
                            Paragraph p1 = new Paragraph("                                                                     Receipt\n\n\n" +
                                "Customer car number : " + carNumber + "                    Customer ID number : " + IdCustomer + "\ncurrent car km : " + KMcar + "\n" +
                                "customer fault description : " + Description + " \n\nworking time on the car (hours) : " + txtHoursWork.Text + "\n" +
                                "Price to pay : " + workCardPrice + "₪\n\nWorking card opening time : " + openingTime + "\nWorking card closing time : " + closingTime + "  ");
                            doc.Add(p1);
                            doc.Close();
                            MessageBox.Show("The work card closed successfully");
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