using System;


namespace Calculations
{
    public class MainLibrary
    {
        //Definicii
       public Formula01 F01 = new Formula01();
       public Formula02 F02 = new Formula02();
       public Formula03 F03 = new Formula03();

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
            cl.Defaulf(); Console.WriteLine(" - calculationa about convex angle\n");
        }
    }
    }
