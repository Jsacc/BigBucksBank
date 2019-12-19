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
    public partial class AtmOptions : Form
    {

        private MessageBoxButtons message = MessageBoxButtons.YesNo;
        

        private LogIn inData = new LogIn();

        private DialogResult dialog;
        private withDrawalForm withDraw;
        private deposit depositForm;
        private Transfer transferForm;
        private EndScreen endScreenMenu;

        private int customerIndex;

        public int CustomerIndex { get { return customerIndex; } set { customerIndex = inData.CusNum; } }

        public AtmOptions() { InitializeComponent(); } //default construtor

        public void AtmOptions_Load(object sender, EventArgs e)
        {
            inData.Visible = false;
        }

        private void exit_CheckedChanged(object sender, EventArgs e) //exit mouse click
        {
            dialog = MessageBox.Show( "Are you sure\nyou want to exit?", "Exit ",message);
            this.Close();
            endScreenMenu = new EndScreen(); // new end screen 
            endScreenMenu.Show(); // display end screen
            
        }

        private void balance_MouseClick(object sender, MouseEventArgs e) // balance button click
        {

            Balance balance = new Balance();
            balance.Show();

        }

        private void withdrawal_MouseClick(object sender, MouseEventArgs e) //withdrawal mouse click
        {
            withDraw = new withDrawalForm();
            withDraw.Show();
        }

        private void deposit_MouseClick(object sender, MouseEventArgs e)//deposit mouse click
        {
            depositForm = new deposit();
            depositForm.Show();
        }

        private void tranfer_MouseClick(object sender, MouseEventArgs e)//transfer mouse click
        {
            transferForm = new Transfer();
            transferForm.Show();
        }

    }
}
