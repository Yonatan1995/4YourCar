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
    public partial class userStatistics : Form
    {
        public userStatistics()
        {
            InitializeComponent();
            fillComboBoxIdWorker(comboBoxIdWorker);
        }
        SqlConnection mySqlConnection = new SqlConnection("server=DESKTOP-HEAJH3M\\SQLEXPRESS07;database=mainProject;Integrated Security=SSPI;");

        public void onlyNumbers(object sender, KeyPressEventArgs e)//פונקציה לקבלת מספרים בלבד לטקסט בוקס
        {
            if ((e.Handled = !char.IsDigit(e.KeyChar)) && (e.Handled = !char.IsControl(e.KeyChar)))
                MessageBox.Show("Allow only numeric values");
        }
        public void fillComboBoxIdWorker(ComboBox ComboBoxIdWorker)//פונקציה למילוי כומבו בוקס בתעודות זהות של עובדים
        {
            mySqlConnection.Open();
            SqlCommand cmd = mySqlConnection.CreateCommand();
            cmd.CommandText = "select idWorker from workersTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ComboBoxIdWorker.Items.Add(dr["idWorker"]);
            }
            mySqlConnection.Close();
        }
        private void viewWorkerStatisticsBtn_Click(object sender, EventArgs e)//פונקציה לצפיה בסטטיסטיקת עובד לפי ת"ז
        {
            if (comboBoxIdWorker.Text == "")
                MessageBox.Show("Please enter worker ID");
            else
            {
                SqlDataAdapter ckIfExist = new SqlDataAdapter("Select count(*)From workersTable where idWorker='" + int.Parse(comboBoxIdWorker.Text) + "'", mySqlConnection);
                SqlDataAdapter takeName = new SqlDataAdapter("select firstName from workersTable where idWorker='" + int.Parse(comboBoxIdWorker.Text) + "'", mySqlConnection);
                DataTable dt = new DataTable();
                ckIfExist.Fill(dt);
                takeName.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                    MessageBox.Show("There is no worker with this ID");
                else
                {
                    string workerName = dt.Rows[1][1].ToString();
                    SqlDataAdapter takeAllWorkCards = new SqlDataAdapter("select count(*) from garageWorkCardTable where idWorker='" + int.Parse(comboBoxIdWorker.Text) + "'", mySqlConnection);
                    SqlDataAdapter takeOpenWorkCards = new SqlDataAdapter("select count(*) from garageWorkCardTable where idWorker='" + int.Parse(comboBoxIdWorker.Text) + "'and WorkIsDone='False'", mySqlConnection);
                    takeAllWorkCards.Fill(dt);
                    takeOpenWorkCards.Fill(dt);
                    lblWorkerName.Text = workerName;
                    lblWorkCards.Text = dt.Rows[2][0].ToString();
                    lblOpenWorkCards.Text = dt.Rows[3][0].ToString();
                    lblCloseWorkCards.Text = (int.Parse(dt.Rows[2][0].ToString())-int.Parse(dt.Rows[3][0].ToString())).ToString();
                }
            }
        }
        private void workerWithTheMostWorkCardsBtn_Click(object sender, EventArgs e)//פונקציה לצפיה בעובד עם הכי הרבה כרטיסי עבודה
        {
            DataTable dtAllWorkers = new DataTable();
            SqlDataAdapter takeWorkCards = new SqlDataAdapter("select idWorker from workersTable", mySqlConnection);
            takeWorkCards.Fill(dtAllWorkers);
            DataTable dtCountWorkCards = new DataTable();
            if (dtAllWorkers.Rows.Count == 0)
                MessageBox.Show("There are no workers on the list");
            else
            {
                int maxWorker = 0, maxWorkCards = -1;
                for (int i = 0; i < dtAllWorkers.Rows.Count; i++)
                {
                    SqlDataAdapter countWorkCards = new SqlDataAdapter("select count(*) from garageWorkCardTable where idWorker='" + int.Parse(dtAllWorkers.Rows[i][0].ToString()) + "' ", mySqlConnection);
                    countWorkCards.Fill(dtCountWorkCards);
                    if (int.Parse(dtCountWorkCards.Rows[i][0].ToString()) > maxWorkCards)
                    {
                        maxWorkCards = int.Parse(dtCountWorkCards.Rows[i][0].ToString());
                        maxWorker = int.Parse(dtAllWorkers.Rows[i][0].ToString());
                    }
                }
                DataTable dtWorkerData = new DataTable();
                SqlDataAdapter takeWorkerName = new SqlDataAdapter("select firstName from workersTable where idWorker='" + maxWorker + "' ", mySqlConnection);
                takeWorkerName.Fill(dtWorkerData);                
                SqlDataAdapter takeOpenWorkCards = new SqlDataAdapter("select count(*) from garageWorkCardTable where idWorker='" + maxWorker + "'and WorkIsDone='False'", mySqlConnection);
                takeOpenWorkCards.Fill(dtWorkerData);
                lblMaxWorkerName.Text = dtWorkerData.Rows[0][0].ToString();
                lblMaxWorkerId.Text = maxWorker.ToString();
                lblMaxWorkCards.Text = maxWorkCards.ToString();
                lblMaxOpenWorkCards.Text = dtWorkerData.Rows[1][1].ToString();
                lblMaxCloseWorkCards.Text = (maxWorkCards - int.Parse(dtWorkerData.Rows[1][1].ToString())).ToString();
            }
        }
    }
}
