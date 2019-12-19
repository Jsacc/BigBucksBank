

namespace Big_Bucks_Bank_Atm
{


    public class UserInfo //person class for everything
    {

        private int chkNum;
        private int idNum;                      //variable for checking account number
        private int savNum;                     //variable for savings account
        private int attempts;                   //variable for attempts 
        private string User_Name;               //variable for user name
        private int User_Password;              //variable for password

        public static float checking = 8594.88f;
        public static float savings = 852.63f;

        public UserInfo(string User_Name, int User_Password, int attempts, int savNum, int chkNum, int idNum)// constructor
        {
            this.User_Name = User_Name;
            this.User_Password = User_Password;
            this.attempts = attempts;
            this.idNum = idNum;
            this.savNum = savNum;
            this.chkNum = chkNum;


        }


        //setters and getters 
        public string User_Name1 { get { return User_Name; } set { User_Name = value; } } //setters and getters 

        public int User_Password1 { get { return User_Password; } set { User_Password = value; } }  //setters and getters 

        public int Attempts { get { return attempts; } set { attempts = value; } }  //setters and getters 

        public int IdNum { get { return idNum; } set { idNum = value; } }  //setters and getters 

        public float Checking { get { return checking; } set { checking = value; } }

        public float Savings { get { return savings; } set { savings = value; } }

        public int SavNum { get { return savNum; } set { savNum = value; } }

        public int ChkNum { get { return chkNum; } set { chkNum = value; } }

        public int SavNum1 { get { return savNum; } set { savNum = value; } }
    };
}
