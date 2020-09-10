using System;
using System.Reflection.PortableExecutable;

namespace Test_1__Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
           
            char exclamation = '!'; 
            bool passwordIsAppropriateLength = false;
            bool passwordContainsExclamation = false;
            bool passwordContainsLowerCase = false;
            bool passwordContainsUpperCase = false;


            Console.Write("Please enter a valid password:");
            string passWord =  Console.ReadLine();


            for (int i = 0; i < passWord.Length; i++)
            {

                if (char.IsLower(passWord[i]))
                {
                   passwordContainsLowerCase = true;
                  
                }  

                if (char.IsUpper(passWord[i]))
                {
                    passwordContainsUpperCase = true;
                }

                if (passWord.Length >= 7 && passWord.Length <= 12)
                {
                    passwordIsAppropriateLength = true;
                }
                if (passWord.Contains(exclamation))
                {
                    passwordContainsExclamation = true;
                }

            }
           

             if (passWord.Contains(exclamation) == true && passwordIsAppropriateLength == true && passwordContainsUpperCase == true && passwordContainsLowerCase ==true)
            {

                Console.WriteLine("Password is valid and accepted");

            }

            else
            {
                Console.WriteLine("Error");
            }










            






        }


    }
}
