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
    public partial class mechanicHome : Form
    {
        public mechanicHome(int idWorker, string firstName)
        {
            InitializeComponent();
            timer.Start();
            lblName.Text = firstName;
            this.idWorker = idWorker;
        }
        int idWorker;

        private void EXIT_Click(object sender, EventArgs e)//פונקציה לסגירת הדף
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)//פונקציה לעדכון שעון בדף
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void allWorkCardBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף כרטיסי עבודה שלי
        {
            myWorkCards myworkcards = new myWorkCards(idWorker);
            myworkcards.Show();
        }

        private void allPartsBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף כל החלקים
        {
            allParts allparts = new allParts();
            allparts.Show();
        }

        private void carDisableBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף השבתת רכב
        {
            carDisable cardisable = new carDisable();
            cardisable.Show();
        }

        private void partsForWorkCardBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף הוספת חלקים לכרטיס עבודה
        {
            partsForWorkCard partsforworkcard = new partsForWorkCard();
            partsforworkcard.Show();
        }

        private void closingWorkCardBtn_Click(object sender, EventArgs e)//פונקציה להפעלת דף סגירת כרטיס עבודה
        {
            closingWorkCard closingWorkCard = new closingWorkCard(idWorker);
            closingWorkCard.Show();
        }
    }
}
