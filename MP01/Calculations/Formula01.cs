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
                    //help about comand
                }
                if (param.Length > 1 && !nuserInput.Contains("help"))
                {
                    //calculations
                    double result = 0;
                    if (runCalculations(param, out result))
                    {
                        nc.Defaulf(); Console.Write("Obema na izkopa e: ");
                        nc.Result(); Console.WriteLine(result.ToString("N2")+"m3");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.You can see sintaxes with \"help\"");
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
                result = h*(F1 +  F2 )/2;

                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
        //Help about command
    }
}
