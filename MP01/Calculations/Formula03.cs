﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
   public class Formula03
    {
        private Colors.ForCLI cl = new Colors.ForCLI();
        public Formula03()
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
                else if (param.Length == 4)
                {
                    double result = 0;
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
        public bool runcalculation(string[] param, out double result)
        {
            try
            {
                double a = 0; double.TryParse(param[1], out a);
                double b = 0; double.TryParse(param[2], out b);
                double h = 0; double.TryParse(param[3], out h);
                result = 2*a * b * h / 3;
                return true;
            }
            catch { }
            result = 0;
            return false;
        }
        public void help()
        {
            cl.Command(); Console.Write("outangle");
            cl.Defaulf(); Console.WriteLine("-convex angle");

            cl.Command(); Console.Write("parametri: ");
            cl.Defaulf(); Console.WriteLine("a, b, h\n");

            cl.Command(); Console.Write("a i b");
            cl.Defaulf(); Console.WriteLine(" - shirina i daljina na izkop");
            cl.Command(); Console.Write("h ");
            cl.Defaulf(); Console.WriteLine("- visochina na izkop\n");

        }
    }
}
