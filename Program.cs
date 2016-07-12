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
            // Variable Section
            String prompt = "> ";
            String cheer_prefix = "Give me a";
            String requires_an = "aeiolnfshrmx";
            Console.WriteLine("What's your name?");
            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower(); //captures user input for name and saves to variable;
            //user_name.ToUpper() turns string to uppercase;
            //ToUpper() accepts no arguments;
            for (int i =0; i < user_name.Length; i++){
                if (requires_an.IndexOf(user_name[i]) > -1){
                    //then the character is in the requires_an array
                    Console.WriteLine(cheer_prefix + "n.. " + user_name[i]);
                } else {
            Console.WriteLine(cheer_prefix + ".. " + user_name[i]); 
            }
        }
        Console.WriteLine(user_name.ToUpper() + " is...GRAND!");
    }
}
}