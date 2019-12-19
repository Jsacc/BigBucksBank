using System;
using System.Windows.Forms;


namespace Big_Bucks_Bank_Atm
{
    static class Program
    {
       public static bool keepOn = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (keepOn)// set from form 3 and 1. It allows user to add more taxrecords or exit 
            {
                Application.Run(new LogIn());
                if (keepOn) // rigged there has to be a better way to quit fRom fOrm 1 w/o error  
                            //which is because form 2 ("calculationDisplay") runs while input fields are blank
                            // **THought but functions add more lines!
                {
                    Application.Run(new AtmOptions());
                    Application.Run(new EndScreen());
                }
            }





        }
    }
}
