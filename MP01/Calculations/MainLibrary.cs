using System;


namespace Calculations
{
    public class MainLibrary
    {
        //Definicii
       public Formula01 F01 = new Formula01();
       public Formula02 F02 = new Formula02();
       public Formula03 F03 = new Formula03();
       public Formula04 F04 = new Formula04();
       public Formula05 F05 = new Formula05();

        // Libraries
        Colors.ForCLI cl = new Colors.ForCLI();
        public MainLibrary()
        {
        }
       public void commnds()
        {
            cl.Defaulf(); Console.WriteLine("All commands:\n");

            cl.Command(); Console.Write(  "izkop"  );
            cl.Defaulf(); Console.WriteLine(" - calculations about earthwork");

            cl.Command(); Console.Write("inangle");
            cl.Defaulf(); Console.WriteLine(" - calculations about indanded angle");

            cl.Command(); Console.Write("outangle");
            cl.Defaulf(); Console.WriteLine(" - calculationa about convex angle");

            cl.Command(); Console.Write("sangle");
            cl.Defaulf(); Console.WriteLine(" - calculationa about side angle\n");

            cl.Command(); Console.Write("cangle");
            cl.Defaulf(); Console.WriteLine(" - calculationa about canal angle");

           
        }
    }
    }
