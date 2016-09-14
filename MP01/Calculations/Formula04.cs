using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
   public  class Formula04
    {
        private Colors.ForCLI cl = new Colors.ForCLI();
        public Formula04()
        {
        }
        public void calc(string uInput)
        {
            try
            {
                string[] param = uInput.Split(' ');
                double result = 0;

                if (param.Length > 1 && uInput.ToLower().Contains("help")) help();
                else if (param.Length == 4)
                {
                    if (runcalculation(param, out result))
                    {
                        cl.Defaulf(); Console.Write("Obema na izkopa e: ");
                        cl.Result(); Console.WriteLine(result.ToString("N2") + " m3");
                        Console.WriteLine();
                    }
                }
                else
                {
                    cl.Defaulf(); Console.WriteLine("Invalid input.You can see sintaxes with \"help\"");
                    Console.WriteLine();
                }
            }
            catch { }
            }
        private bool runcalculation(string[]param,out double result)
        {
            try
            {
                double a = 0, L = 0, h = 0;
                double.TryParse(param[1], out a);
                double.TryParse(param[2], out L);
                double.TryParse(param[3], out h);
                result = a * (h / 2) * L;
                return true;
            }
            catch { }
            result = 0;
            return false;
        }
        private void help()
        {
            cl.Command(); Console.Write("sangle");
            cl.Defaulf(); Console.WriteLine("-side angle");

            cl.Command(); Console.Write("parametri: ");
            cl.Defaulf(); Console.WriteLine("a, L, h\n");

            cl.Command(); Console.Write("a i L");
            cl.Defaulf(); Console.WriteLine(" - shirina i daljina na izkop");
            cl.Command(); Console.Write("h ");
            cl.Defaulf(); Console.WriteLine("- visochina na izkop\n");
        }
    }
}
