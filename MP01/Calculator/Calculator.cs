using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        // definirane na biblioteki, ne sa static
        public UserInput01.UInput uInput = new UserInput01.UInput();
        public About.Me about = new About.Me();



            public static void Main(string[] args)
        {
            /*predefinirame nashata programa,zashtoto
            Main e ot tip console app i e static, a nashia klas UserInput ne e static=
            Ima razlika v nachina na sadeliane na pamet=
            Chrez novata promenliva "nprogram" dostapvame ne statichnite metodi
            */
            Calculator nprogram = new Calculator();
            //formatirane na programata
            Console.Title = nprogram.about.shortName+ ", " + nprogram.about.version;

            //starting of program
            nprogram.uInput.SayHello();
            nprogram.uInput.GetUserCommands();
        }
    }
}
