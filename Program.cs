using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            Console.Write("> ");
            String user_name = Console.ReadLine(); //captures user input for name and saves to variable;
            //user_name.ToUpper() turns string to uppercase;
            //ToUpper() accepts no arguments;
            for (int i =0; i < user_name.Length; i++){
                Console.WriteLine("gimme a.. " + user_name[i]);
            }
            Console.WriteLine(user_name.ToUpper() + " is...GRAND!");
        }
    }
}
