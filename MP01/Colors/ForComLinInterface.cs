﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    public class ForCLI
    {

        public ForCLI ()
            {
            }
        public void Defaulf()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void Promt()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Command()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        public void Result()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
