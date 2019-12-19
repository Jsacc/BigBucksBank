using System;
using System.Windows.Forms;

namespace Big_Bucks_Bank_Atm
{
    /**
     * 
     *This and deposit.cs are very similar in "future updates" 
     * it will  be one class but for the time factor seperate
     * */
    public partial class deposit : Form
    {
        private LogIn indata = new LogIn();                     //indata is new login

        MessageBoxButtons buttons = MessageBoxButtons.OK;    //message box

        DialogResult dialog;                                    //a dialog box

        private float newAmount; //int variable amounter

        private float amount;
        public deposit()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string savingsOrChecking(int accNum)
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
        private void ok_Click(object sender, EventArgs e)
        {
            int accNum;
            string acctype; // account type

            accNum = int.Parse(accountNum.Text.ToString());

            acctype = savingsOrChecking(accNum);

            if (acctype == "savings")
                depositThatCashSavings();
            else if (acctype == "checking")
                depositThatCashChecking();
                                              //adds money to balance
        }

        public void depositThatCashChecking()
        {


                                              //int variable amounter

            amount = float.Parse(amountBox.Text.ToString());  //takes in amount from textbox



            newAmount = indata.customer[indata.CusNum].Checking += amount;   //adds amount to the current balance


            String.Format("{0:0.00}", newAmount.ToString());

            dialog = MessageBox.Show("$"+newAmount.ToString(), "Your new balance is:", buttons); //pops up a dialog box

            this.Close(); // close this window done with the deposit
        }

        public void depositThatCashSavings()
        {
            

                                             

            amount = float.Parse(amountBox.Text.ToString());  //takes in amount from textbox



            newAmount = indata.customer[indata.CusNum].Savings += amount;   //adds amount to the current balance


            String.Format("{0:0.00}", newAmount.ToString());           //format string to displays decimals

            dialog = MessageBox.Show("$" + newAmount.ToString(), "Your new balance is:", buttons); //pops up a dialog box

            this.Close(); // close this window done with the deposit
        }
    }
}
