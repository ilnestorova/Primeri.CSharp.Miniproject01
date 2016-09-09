using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput01
{
    public class UInput
    {
        //definirane na classa
        About.Me about = new About.Me();
        Colors.ForCLI nc = new Colors.ForCLI();
        Calculations.MainLibrary ncalc = new Calculations.MainLibrary();
      

        public UInput()
        {
        }
        
        public void SayHello()
        {
            nc.Defaulf();
            Console.WriteLine("Wellcome in "+about.shortName+"\n"+about.version+"\n");
        }
        public void GetUserCommands ()
        {
            string ucommand = "";
            do
            {
                //vzimane na comanda
                nc.Promt();
                Console.Write( "Enter your command: " );
                // proverka za nalichni comandi
                nc.Command();
                ucommand = Console.ReadLine();
                if (ucommand.ToLower().Contains("izkop")) ncalc.F01.calc(ucommand);
                if (ucommand.ToLower().Contains("command2")) Console.WriteLine("Command2 is starting");
                if (ucommand.ToLower().Contains("command3")) Console.WriteLine("Command3 is starting");
            } while (ucommand.ToLower() != "exit"); 
        }
       /* public void JustTesting()
         {
             Console.WriteLine("Starting of UserInput.Iunput.JustTesting()");
         }*/
}
}
