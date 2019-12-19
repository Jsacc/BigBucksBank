using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Big_Bucks_Bank_Atm
{

    public partial class LogIn : Form
    {
        private bool lockedOut = false;
        public int counter = 0;                            //counter for the number of tries
        private MessageBoxButtons buttons = MessageBoxButtons.OK;    //messagebox 
        public List<UserInfo> customer = new List<UserInfo>();          //list of customers
        public DialogResult dialog;  //dialog box
        private AtmOptions atmOptionMenu;
        
        
        //*********** Messages**************
        public string message = "Invalid Pin or Username!";
        public string message1 = "Invalid Entry!";
        public string message2 = "Please try again";
        public string message3 = "You have reach the maximum amount of attempts,\nPlease Contanct a Bank Manager to unlock your account.\nHave a Nice Day.";
        public string messageChar = "Your username must begin with a letter. ";
        public string messageLockOut = "You have reached the maximum, ";
        public string messageLockOut2 = "amount of attempts please contact an admin. ";
        

        private static string usName = null;         // usname   

        protected int passWord;                 //password

        public static int cusNum;              //public only used for index    

        public int CusNum { get { return cusNum; } set { cusNum = value; } }     //cusnum is the index

        public string adminAcct = "ADMIN";                                      //adminAcct
        public int adminPass = 1111;         //adminPass

        private bool adminLock = false;
        public string UsName { get { return usName; } set { usName = value; } }

        public bool pass = false, name = false, weGood = false;
        public bool admin = false;

        private string login = "Login";
        private string unlock = "Unlock";


        public LogIn() //login constructor 
        {
            //changeLoginBTNtext(true);
            
            InitializeComponent(); // activates componants
            //string User_Name, int User_Password, int attempts, int savNum, int chkNum,float checking, float savings, int idNum
            customer.Add(new UserInfo("Jsacc12!", 9999, 0, 11111111, 22222222, 86));
        }
        protected override void OnCreateControl()
        {
            changeLoginBTNtext(true);
        }
        public void getPersonIndex(string userName) //returns users index in the array
        {
            for (int i = 0; i < customer.Count; i++)
            {
                if (userName == customer[i].User_Name1)
                    cusNum = i + 1;
            }
        }

        private void changeLoginBTNtext(bool loginLock)
        {
            

            if (loginLock)
                logInBTN.Text = Convert.ToString(login.ToString());
            else if (!loginLock)
                logInBTN.Text = Convert.ToString(unlock.ToString());
        }

        public void adminPin()
        {

            if (lockedOut && UserID.Text.ToString() == adminAcct && int.Parse(UserPin.Text.ToString()) == adminPass)
            {

                lockedOut = false;
                dialog = MessageBox.Show("ATM unlocked by ADMIN\nWelcome in!", "Admin LogIn", buttons);
                counter = 0;
                changeLoginBTNtext(true);
                
            }
        }
       
        public void lockOut()
        {
            lockedOut = true;
            if (!admin)
            {
                dialog = MessageBox.Show("You have reached the maximum amount of attempts\nPlease contact an admin.",
                    "Locked out", buttons);
                changeLoginBTNtext(false);
                
            }

        }

        public void displayMessage()
        {
            dialog = MessageBox.Show(message1, message2, buttons);
        }

        //entry point 
        private bool adminCheck() //checks if admin
        {

            if (usName == adminAcct && passWord == adminPass)
            {
                UsName = UserID.Text.ToString();


                if (lockedOut && UsName == adminAcct && passWord == adminPass)
                {
                    adminPin();
                    return false;
                }
                else
                    return true;

            }
            return false;
        }

        public bool loginCredentialsCheck(bool pass, bool name)
        {


            pass = checkPasswordLength(); //check password
            name = checkUserNameChar();   //check usname

            //Console.WriteLine("here", pass);


            if (usName == adminAcct)
                return true;
            else if (!admin && lockedOut && pass == false || name == false)
            {
                displayMessage();
                counter = 0;
                return false;
            }

            else
                return true;


        }



        public void logInBTN_Click(object sender, EventArgs e)
        {

            pass = false; name = false; weGood = false;


            pass = checkPasswordLength(); //check password
            name = checkUserNameChar();   //check usname
            admin = adminCheck();           //admin check
            weGood = loginCredentialsCheck(pass, name);   //

            if (weGood && !admin)
            {
                string returnVal;

                //Console.WriteLine("here");

                //return value from username pass check
                getPersonIndex(UsName);                  //returns users index in the array

                do
                {
                    returnVal = " ";

                    returnVal = compareUserNameAndPass(UsName, passWord);   //checks if valid input

                    if (returnVal == "badPass" || returnVal == "badUn")
                    {
                        counter++; //counts the attempts

                        if (counter >= 3)           //if 3 times lockout
                            lockOut();              // there is nothing here yet

                        //Console.WriteLine("here");
                        else if (counter < 3 && usName != adminAcct)
                            dialog = MessageBox.Show(message, message2, buttons);   //shows message box "invalid entery"
                        return;
                    }

                    else if (usName == adminAcct)
                        counter = 0;
                    else if (counter < 3)
                        this.Close(); // closes the thing
                } while (returnVal == "badPass" || returnVal == "badUn");
            }
            if (weGood)
                this.Close();
        }

        public bool checkUserNameChar()
        {
            bool number = false, alphabet = false;
            UsName = UserID.Text.ToString();
            string goodPassorBad;


            for (int i = 0; i < UsName.Length; i++)
            {

                if ((int)UsName[i] <= 57 && (int)UsName[i] >= 48)
                    number = true;

                if ((int)UsName[i] >= 65 && (int)UsName[i] <= 90 || (int)UsName[i] >= 97 && (int)UsName[i] <= 122)
                    alphabet = true;
                if (alphabet == true && number == true)
                    break;

            }

            if (UsName.Length <= 8 && UsName.Length > 0 && alphabet == true && number == true)
                return true;
            else
                return false;

        }

        public bool checkPasswordLength()
        {

            if (UserPin.Text.ToString().Length == 4)
            {
                passWord = int.Parse(UserPin.Text.ToString());
                return true;
            }
            else
                return false;
        }



        public string compareUserNameAndPass(string userName, int password) //compares usname and password for lockout
        {
            if (counter == 3)
                return "badUn";
            else
                for (int i = 0; i <= customer.Count() - 1; i++)
                {
                    if (customer[i].User_Name1 == userName)
                    {
                        CusNum = i;             //sets cusnum to i so we can use the customer

                        if (customer[i].User_Password1 != passWord)
                            return "badPass"; //sends srting badPass
                        else
                            return "good";     //if you get here its good we are in 
                    }
                }
            return "badUn";    //sends string badUn, signifing bad username input
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            bool pass, name, weGood = false;
            pass = checkPasswordLength(); //check password
            name = checkUserNameChar();   //check usname
            weGood = loginCredentialsCheck(pass, name);
            if (weGood)
                adminLock = adminCheck(); // so we can cancel as admin

            if (adminLock)
            {
                Program.keepOn = false; // sets the bool to false to end the 
                this.Close();
            }
            else if (!adminLock && weGood)
                dialog = MessageBox.Show("Only admins can shut down the ATM" +
                    "\nplease select another option\nPress Ok to continue.", "Invalid Selection", buttons);
        }
    }
}
