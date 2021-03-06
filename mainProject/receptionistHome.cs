using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainProject
{
    public partial class receptionistHome : Form
    {
        public receptionistHome(int idWorker, string firstName)
        {
            InitializeComponent();
            timer.Start();
            lblName.Text = firstName;
        }
        private void timer_Tick(object sender, EventArgs e)//פונקציה לעדכון שעון בדף
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }


        private void allCarsBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף כל הרכבים
        {
            allCars allcars = new allCars();
            allcars.Show();
        }

        private void allPartsBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף כל החלקים
        {
            allParts allparts = new allParts();
            allparts.Show();
        }

        private void allWorkCardBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף כל כרטיסי העבודה
        {
            allGarageWorkCard allworkcards = new allGarageWorkCard();
            allworkcards.Show();
        }

        private void allCustomersBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף כל הלקוחות
        {
            allCustomer allcustomer = new allCustomer();
            allcustomer.Show();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף ניהול לקוח
        {
            addCustomer addcustomer = new addCustomer();
            addcustomer.Show();
        }

        private void addCarBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף ניהול רכב
        {
            addCar addcar = new addCar();
            addcar.Show();
        }

        private void addPartBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף ניהול חלק
        {
            addPart addpart = new addPart();
            addpart.Show();
        }

        private void addWorkCardBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף ניהול כרטיס עבודה
        {
            addWorkCard addworkcard = new addWorkCard();
            addworkcard.Show();
        }

        private void EXIT_Click(object sender, EventArgs e)//פונקציה לסגירת הדף
        {
            this.Close();
        }
    }
}
