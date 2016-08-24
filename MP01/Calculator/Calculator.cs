using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        // definirane na biblioteka, ne e static
        public UserInput01.UInput uInput = new UserInput01.UInput();
            public static void Main(string[] args)
        {
            //predefinirame nashata programa,zashtoto
            //Main e ot tip console app i e static, a nashia klas Calculator ne e
            Calculator nprogram = new Calculator();
            nprogram.uInput.JustTesting();
        }
    }
}
