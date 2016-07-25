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
            Console.WriteLine("What is your date of birth?");
            Console.Write(prompt);
            String birthday_string = Console.ReadLine();

            DateTime user_birthday = DateTime.Parse (birthday_string);
            DateTime current_date = DateTime.Now;
            DateTime current_year = new DateTime(2016, 1, 1);
            Console.WriteLine(current_year);
            Console.WriteLine("user birthday: " + user_birthday);
            Console.WriteLine("current date " + current_date);
            Console.WriteLine(current_date.DayOfYear);
            Console.WriteLine(user_birthday.DayOfYear);
            // Console.WriteLine(user_birthday.CompareTo);
            Console.WriteLine(user_birthday.Ticks);
            for (int i =0; i < user_name.Length; i++){
                if (requires_an.IndexOf(user_name[i]) > -1){
                    //then the character is in the requires_an array
                    Console.WriteLine(cheer_prefix + "n.. " + user_name[i]);
                } else {
                Console.WriteLine(cheer_prefix + ".. " + user_name[i]); 
                }
            }
            Console.WriteLine(user_name.ToUpper() + " is...GRAND!");
            if (DateTime.Compare(user_birthday, current_date) == 1)
                {
                    int days_until_next_birthday = user_birthday.DayOfYear - current_date.DayOfYear;
                    Console.WriteLine("It is " + days_until_next_birthday + " days until your next birthday.");
                }
                else if (DateTime.Compare(user_birthday, current_date) == -1)
                {
                    int days_until_next_birthday = (365 - current_date.DayOfYear) + (365 - user_birthday.DayOfYear); 
                    Console.WriteLine("It is " + days_until_next_birthday + " days until your next birthday");
                }
                
            Console.WriteLine(DateTime.Compare(user_birthday, current_date));
            // public int days_until_next_birthday()
            // {
            //  DateTime current_date = new DateTime();

            // } 


    }
}
}