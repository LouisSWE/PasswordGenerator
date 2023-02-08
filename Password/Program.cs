using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays password in terminal
            Console.WriteLine("Generated password: " + GeneratePassword());
        }
        /// <summary>
        /// This function generates a random number and translating it through ascii into numbers, letters... etc.
        /// </summary>
        /// <returns></returns>
        static string GeneratePassword()
        {
            //Generate password variable and declare passwordlength
            string password = "";
            int passwordLength = 10;
            //Declaring a randomizer
            Random random = new Random();

            //The first sign has to be a Letter and i chose capital letters
            int asciiValue = random.Next(65, 90);
            password += (char)asciiValue;

            //Start the loop and pick out chosen ascii areas out of a table... chosen ascii areas like capital letters or numbers
            for (int i = 1; i < passwordLength; i++)
            {
                asciiValue = random.Next(33, 126);
                while (!((asciiValue >= 48 && asciiValue <= 57) ||
                         (asciiValue >= 33 && asciiValue <= 47) ||
                         (asciiValue >= 65 && asciiValue <= 90) ||
                         (asciiValue >= 97 && asciiValue <= 122)))
                {
                    asciiValue = random.Next(33, 126);
                }
                //add ascii characters into the password string created in the beginning
                password += (char)asciiValue;
            }

            return password;
        }
    }
}
