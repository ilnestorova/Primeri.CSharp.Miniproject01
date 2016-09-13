using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Formula05
    {
        private Colors.ForCLI cl = new Colors.ForCLI();
        public Formula05()
        {
        }
        public void calc(string uInput)
        {
            string[] param = uInput.Split(' ');
            double result = 0;
            try
            {
                if (param.Length > 1 && uInput.ToLower().Contains("help")) help();
                else if (param.Length == 5)
                {
                    if (runcalculation(param, out result))
                    {
                        cl.Defaulf(); Console.Write("Obema na izkopa e: ");
                        cl.Result(); Console.WriteLine("{0:N2}" + " m3", result);
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
            
        public bool runcalculation(string[] param, out double result)
        {
            try
            {
                double a = 0, b = 0, L = 0, h = 0;
                double.TryParse(param[1], out a);
                double.TryParse(param[2], out b);
                double.TryParse(param[3], out L);
                double.TryParse(param[4], out h);

                result = (a + b) / 2 * L * h;
                return true;
            }
            catch { }
            result = 0;
            return false;
        }
        public void help()
        {
            cl.Command(); Console.Write("cangle");
            cl.Defaulf(); Console.WriteLine("-canal angle");

            cl.Command(); Console.Write("parametri: ");
            cl.Defaulf(); Console.WriteLine("a, b,L, h\n");

            cl.Command(); Console.Write("a i b");
            cl.Defaulf(); Console.WriteLine(" - gorna i dolna shirina na izkop");
            cl.Command(); Console.Write("L ");
            cl.Defaulf(); Console.WriteLine("- daljina na izkop\n");
            cl.Command(); Console.Write("h ");
            cl.Defaulf(); Console.WriteLine("- visochina na izkop\n");


        }
    }
}
