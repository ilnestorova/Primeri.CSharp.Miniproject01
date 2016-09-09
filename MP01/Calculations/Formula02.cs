using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
     public class Formula02
    {
        public Formula02()
            {
            }
        public void calc(string uInput)
        {
            try
            {
                string[] param = uInput.Split(' ');

                if (param.Length > 1 && uInput.ToLower().Contains("help"))
                {
                    help();
                }
                if (param.Length == 4)
                {
                    double result = 0;
                    if (runcolculation(param, out result))
                    {
                        Console.Write("Obema na izkopa e: ");
                        Console.WriteLine(result.ToString("N2") + " m3");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.You can see sintaxes with \"help\"");
                    Console.WriteLine();
                }
                    
                
            }
            catch { }
        }
        public bool runcolculation(string[] param, out double result)
        {
            try
            {
                double a = 0;  double.TryParse(param[1], out a);
                double b = 0; double.TryParse(param[2], out b);
                double h = 0; double.TryParse(param[3], out h);
                result = a * b * h / 3;
                return true;
            }
            catch { }
            result = 0;
            return false;
        }
                private void help()
        {
            Console.Write( "inangel" );
            Console.WriteLine("-indandet angel\n");

            Console.Write("parametri: ");
            Console.WriteLine("a, b, h\n");

            Console.Write("a i b");
            Console.WriteLine(" - shirina i daljina na izkop");
            Console.Write("h ");
            Console.WriteLine("- visochina na izkop\n");

        }
    }
}
