using System;
using System.Windows.Forms;

namespace Big_Bucks_Bank_Atm
{
    /**
     * 
     *This and deposit.cs are very similar in "future updates" 
     * it will  be one class but for the time factor seperate
     * */
    public partial class withDrawalForm : Form
    {
        private LogIn indata = new LogIn();                     //indata is new login

        MessageBoxButtons buttons = MessageBoxButtons.OK;    //

        DialogResult dialog;

        float newAmount;                                   //message to the user   
        float amount = 0.00f;                                     //int variable amount to deposit

        public withDrawalForm()
        {
            InitializeComponent();
        }

        private string savingsOrChecking(float accNum)
        {

            for (int i = 0; i < indata.customer.Capacity; i++)
            {
                if (accNum == indata.customer[i].ChkNum)
                    return "checking";
                else if (accNum == indata.customer[i].SavNum)
                    return "savings";
            }
            //if no account found 
            dialog = MessageBox.Show("Invalid account number.\nPlease retry...", "Error", buttons); //pops up a dialog box
            return "";

        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            long accNum;
            string acctype; // account type
            
            accNum = int.Parse(accountNumBox.Text.ToString());

            amount = float.Parse(amountBox.Text.ToString());  //takes in amount from textbox

            acctype = savingsOrChecking(accNum);
            if (acctype == "savings")
            {
                if (checkIfEmpty(acctype))
                    withDrawThatCashSavings();
                else
                    dialog = MessageBox.Show("Insufficient Funds", "Error", buttons); //pops up a dialog box
                return;
            }
            else if (acctype == "checking")
                if (checkIfEmpty(acctype))
                    withDrawThatCashChecking();
                else
                    dialog = MessageBox.Show("Insufficient Funds", "Error", buttons); //pops up a dialog box
            return;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkIfEmpty(string type)
        {
            if (type == "checking")
            {
                if (indata.customer[indata.CusNum].Checking <= amount)
                    return false;
                else
                    return true;
            }
            else
            {
                if (indata.customer[indata.CusNum].Savings <= amount)
                    return false;
                else
                    return true;
            }
        }

        public void withDrawThatCashSavings()
        {

           
            
            newAmount = indata.customer[indata.CusNum].Savings -= amount;   //subtracts amount from the current balance

            string balOut = String.Format("{0:0.##}", newAmount.ToString());

            dialog = MessageBox.Show('$' + balOut, "Your new balance is:", buttons); //pops up a dialog box
            this.Close();
        }

        

        public void withDrawThatCashChecking()
        {

            amount = float.Parse(amountBox.Text.ToString());  //takes in amount from textbox

            newAmount = indata.customer[indata.CusNum].Checking -= amount;   //subtracts amount from the current balance

            string balOut = String.Format("{0:0.##}", newAmount.ToString());

            dialog = MessageBox.Show('$' + balOut, "Your new balance is:", buttons); //pops up a dialog box
            this.Close();
        }
    }
}
