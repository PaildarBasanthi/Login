﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleassign5_2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string validUsername = "john";
            string validPassword = "pass123";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == validUsername && password == validPassword)
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else if (username == validUsername)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attempts++;
            }

            if (attempts == 3)
            {
                Console.WriteLine("Login failed.");
            }

        }
    }
}
