using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Bucks_Bank_Atm
{
    public partial class Balance : Form
    {
        public DialogResult dialog;
        private MessageBoxButtons balanceDisp = MessageBoxButtons.OK;
        private LogIn login= new LogIn();
        private int customerIndex;
        public int CustomerIndex { get { return customerIndex; } set { customerIndex = login.CusNum; } }

        public Balance()
        {
            InitializeComponent();
        }

        private void savingsBal_Click(object sender, EventArgs e)
        {
            string savingsBalance = login.customer[CustomerIndex].Savings.ToString();

            string balOut = String.Format("{0:0.##}", savingsBalance);

            dialog = MessageBox.Show('$' + balOut, "Savings Balance", balanceDisp);
        }

        private void checkingBal_Click(object sender, EventArgs e)
        {
            string checkingBalance = login.customer[CustomerIndex].Checking.ToString();
            string balOut = String.Format("{0:0.##}", checkingBalance);
            dialog = MessageBox.Show('$'+balOut, "Checking Balance", balanceDisp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
