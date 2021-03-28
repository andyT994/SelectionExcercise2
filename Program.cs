using System;

namespace SelectionExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Name");
            string Username = Console.ReadLine();
            
            // Selection - if
            if (Username == "AndyT") {
            System.Console.WriteLine("Username Exist");

             Console.WriteLine("Enter Your Password");
            string Pass = Console.ReadLine();

            if (Pass == "Acdb") {
                System.Console.WriteLine("Login Successful");
            } else {
                System.Console.WriteLine("Login Unsuccessful");

            }    

        } else {
            System.Console.WriteLine("Login Unsuccessful");
      }
    }
  }
} 
