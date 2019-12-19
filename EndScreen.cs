using System;

using System.Windows.Forms;

namespace Big_Bucks_Bank_Atm
{
    public partial class EndScreen : Form
    {
        private int userIdis;
        private long chkNumDis;
        private long savNumDis;
        private float chkBalDis;
        private float savBalDis;
        private LogIn login = new LogIn();
        private DialogResult dialog;
        private MessageBoxButtons buttons = MessageBoxButtons.OK;    //messagebox 
        
        public EndScreen()
        {
            
            userIdis = login.customer[login.CusNum].IdNum;
            chkNumDis = login.customer[login.CusNum].ChkNum;
            savNumDis = login.customer[login.CusNum].SavNum;
            chkBalDis = login.customer[login.CusNum].Checking;
            savBalDis = login.customer[login.CusNum].Savings;
            InitializeComponent();
            displayInfo();
        }

        private void goodByeBtn_Click(object sender, EventArgs e)
        {


            if (login.UsName == "ADMIN")
            {
                dialog = MessageBox.Show("System exited by the administrator.","Goodbye", buttons);
                Program.keepOn = false; // sets the bool to false to end the 
                
            }
            this.Close();
                


        }

        private void displayInfo()
        {

            userIDisplay.Text = Convert.ToString(userIdis.ToString());
            chkAccNumDis.Text = Convert.ToString(chkNumDis.ToString());
            chkAccBalDis.Text = Convert.ToString(chkBalDis.ToString());
            savAccNumDis.Text = Convert.ToString(savNumDis.ToString());
            savingsAccBal.Text = Convert.ToString(savBalDis.ToString());

        }
    }
}
