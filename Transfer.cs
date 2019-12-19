using System;
using System.Windows.Forms;

namespace Big_Bucks_Bank_Atm
{
    public partial class Transfer : Form
    {
        LogIn login = new LogIn();

        private int accountFromNum;
        private int accountToNum;
        private int numTo;           //account number too
        private int numFrom;

        public Transfer()
        {
            InitializeComponent();
        }


        private void okayBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons transferMessage = MessageBoxButtons.OK; //messageBox
            DialogResult dialog;

            bool isItGood = false; //bool isItGood
            accountFromNum = int.Parse(amountFrom.Text.ToString());     //amount from num
            accountToNum = int.Parse(amountTo.Text.ToString());         //amount to num

            numTo = int.Parse(amountTo.Text.ToString());            //account number too
            numFrom = int.Parse(amountFrom.Text.ToString());        


            isItGood = validNumbers();   //validate the user input

            if (!isItGood)      //is it good if not return to the bankoptions form
                return;
            else
                moveTheMoney(); //go on to transfer

            string savingsBalance = login.customer[login.CusNum].Savings.ToString();   //savingsbalance

            string checkingBalance = login.customer[login.CusNum].Checking.ToString(); //checkingbalance

            string savBalOut = String.Format("{0:0.00}", savingsBalance); //Format them to show point
            string checkBalOut = String.Format("{0:0.00}", checkingBalance); //Format them to show point

            dialog = MessageBox.Show("Your new balances are:\nSavins account: " //show message box
                + savBalOut + "\nChecking: " + checkBalOut, "Transfer Successful", transferMessage);

            this.Close();

        }

        public void moveTheMoney()  //transfer money between two accounts
        {
            float amountToTransfer = float.Parse(transferAmount.Text.ToString());
            
            if (accountFromNum == login.customer[login.CusNum].SavNum)
            {
                login.customer[login.CusNum].Savings -= amountToTransfer; // take from savings
                login.customer[login.CusNum].Checking += amountToTransfer; //give to checking
            }
            else if(accountFromNum == login.customer[login.CusNum].ChkNum)
            {
                login.customer[login.CusNum].Checking -= amountToTransfer; //take from checking 
                login.customer[login.CusNum].Savings += amountToTransfer; //give to savings
                
            }

        }

        private bool validNumbers()
        {
            if (numTo == accountToNum || numFrom == accountFromNum)
                return true;
            else
                return false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // close it
        }
    }
}
