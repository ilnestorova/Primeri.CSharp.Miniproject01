using System;


namespace Calculations
{
    public class Formula01
    {
        //libraries
        private Colors.ForCLI nc = new Colors.ForCLI();
        public Formula01()// formula za obiknoven izkop
        {
        }
        // Parsvane
        public void calc(string nuserInput)
        {
            try
            {
                string[] param = nuserInput.Split(' ');
                if (param.Length > 1 && nuserInput.Contains("help"))
                {
                    //help about command
                    help();

                }
                if (param.Length >1 && !nuserInput.ToLower(). Contains("help"))
                {
                    //calculations
                    double result = 0;
                    if (runCalculations(param, out result))
                    {
                        nc.Defaulf(); Console.Write("Obema na izkopa e: ");
                        nc.Result(); Console.WriteLine(result.ToString("N2") + " m3");
                    }

                    else
                    {
                        nc.Defaulf(); Console.WriteLine("Invalid input.You can see sintaxes with \"help\"\n");
                    }
                }
            }
            catch { }
        }
        // Izchislenie i izpisvane
        public bool runCalculations(string[] nparam, out double result)
        {
            try
            {
                //nparam[0] must be == name of command
                double a1 = 0, b1 = 0, a2 = 0, b2 = 0, h = 0;
                double.TryParse(nparam[1], out a1);
                double.TryParse(nparam[2], out b1);
                double.TryParse(nparam[3], out a2);
                double.TryParse(nparam[4], out b2);
                double.TryParse(nparam[5], out h);
                double F1 = a1 * b1, F2 = a2 * b2;
                result = h * (F1 + F2) / 2;

                return true;
            }
            catch { }

            result = 0;
            return false;
        }

        //Help about command
        private void help()
        {
         nc.Result(); Console.Write("[izkop ]");
                    nc.Defaulf(); Console.WriteLine("- Komanda za presmiatane na stroitelen izkop");
                    nc.Result(); Console.Write("[parametri na izkopa ]");
                    nc.Defaulf(); Console.WriteLine("- a1, b1, a2, b2, h\n");

                    nc.Command(); Console.Write("a1 i b1 ");
                    nc.Defaulf(); Console.WriteLine("- shirina i daljina na gornata chast na izkopa");
                    nc.Command(); Console.Write("a2 i b2 ");
                    nc.Defaulf(); Console.WriteLine("- shirina i daljina na dolnata chast na izkopa");
                    nc.Command(); Console.Write("h ");
                    nc.Defaulf(); Console.WriteLine("- visochina na izkopa\n");
            }
   }
}
    
    
