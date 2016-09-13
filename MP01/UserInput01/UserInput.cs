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
        Colors.ForCLI cl = new Colors.ForCLI();
        Calculations.MainLibrary ncalc = new Calculations.MainLibrary();
      

        public UInput()
        {
        }
        
        public void SayHello()
        {
            cl.Defaulf();
            Console.WriteLine("Wellcome in "+about.shortName+"\n"+about.version+"\n");
        }
        public void GetUserCommands ()
        {
            string ucommand = "";
            do
            {
                //vzimane na comanda
                cl.Promt();
                Console.Write( "Enter your command: " );
                // proverka za nalichni comandi
                cl.Command();
                ucommand = Console.ReadLine();
                if (ucommand.ToLower().Contains("izkop"))    ncalc.F01.calc(ucommand);
                if (ucommand.ToLower().Contains("inangle"))  ncalc.F02.calc(ucommand);
                if (ucommand.ToLower().Contains("outangle")) ncalc.F03.calc(ucommand);
                if (ucommand.ToLower().Contains("sangle"))   ncalc.F04.calc(ucommand);
                if (ucommand.ToLower().Contains("cangle"))   ncalc.F05.calc(ucommand);


                if (ucommand.ToLower().Contains("help")||    
                    ucommand.ToLower()=="h")                 ncalc.commnds();

                if (ucommand.ToLower().Contains("clear") ||
                                    ucommand.ToLower() == "c")
                {
                    Console.Clear();
                    SayHello();
                }
            } while (ucommand.ToLower() != "exit"); 
        }
       /* public void JustTesting()
         {
             Console.WriteLine("Starting of UserInput.Iunput.JustTesting()");
         }*/
}
}
