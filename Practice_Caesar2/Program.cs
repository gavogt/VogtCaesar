using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Caesar2
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            // Variables 
            string message = default;
            int shift = default;

            // Console color change
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Please enter your message to be encrypted: ");
            message = Console.ReadLine();

            try
            {
                Console.WriteLine("Please enter the shift amount: ");
                shift = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                // Error message color change
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error! Please try again");
            }
        }

        #region Encrypt
        /// <summary>
        /// String variable to be Caesar ciphered
        /// </summary>
        /// <param name="message">String variable to pass in</param>
        /// <param name="shift">How many shifts of the character</param>
        /// <returns></returns>
        public static string Encrypt(string message, int shift)
        {
            char[] messageEncDecry = default;

            messageEncDecry = message.ToCharArray();

            for (int i = 0; i < messageEncDecry.Length; i++)
            {
                Console.WriteLine(i);
            }

            return "";

        }
        #endregion

        #region Decrypt
        /// <summary>
        /// String variable to be decrypt the Caesar cipher
        /// </summary>
        /// <param name="message">String variable to pass in</param>
        /// <param name="shift">How many shifts of the character</param>
        /// <returns></returns>
        public static string Decrypt(string message, int shift)
        {
            return "";

        }
        #endregion

        #region DisplayWelcome
        /// <summary>
        /// Welcome message to be displayed
        /// </summary>
        public static void DisplayWelcome()
        {
            Console.WriteLine("**********************"+"\n* Welcome to Caesar! *"+ "\n**********************");

        }
        #endregion
    }
}
