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
            // Variables 
            string message = default;
            int shift = default;
            int optionSelection = default;

            DisplayWelcome();
            DisplayOptions();

            while (optionSelection > 3 || optionSelection < 1)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nPlease enter your option: ");
                    optionSelection = Convert.ToInt32(Console.ReadLine());
                    Console.BackgroundColor = ConsoleColor.Black;

                    if (optionSelection > 3 || optionSelection < 1)
                    {
                        DisplayErrorValidSelection();

                    }

                }
                catch
                {
                    DisplayError();
                    DisplayOptions();

                }
            }

            // Console color change
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("\nPlease enter your message to be encrypted: ");
            message = Console.ReadLine();

            // Bad design?
            try
            {
                Console.WriteLine("Please enter the shift amount: ");
                shift = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                DisplayError();

            }
        }

        #region Encrypt
        /// <summary>
        /// String variable to be Caesar ciphered
        /// </summary>
        /// <param name="message">String variable to pass in</param>
        /// <param name="shift">How many shifts of the character</param>
        /// <returns>An encrypted message</returns>
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
        /// <returns>A decrypted message</returns>
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
            Console.WriteLine("**********************" + "\n* Welcome to Caesar! *" + "\n**********************");

        }
        #endregion

        #region DisplayOptions
        /// <summary>
        /// Display options for the user to encrypt, decrypt or exit
        /// </summary>
        public static void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1. For Encrypting your message");
            Console.WriteLine("2. For Decrypting your message");
            Console.WriteLine("3. To exit the system");

        }
        #endregion

        #region ErrorDisplay
        /// <summary>
        /// Display an error message with a color of DarkRed
        /// </summary>
        public static void DisplayError()
        {
            // Error message with a color change!
            ChangeConsoleToRed();
            Console.WriteLine("Error! Please try again");

        }
        #endregion

        #region ErrorDisplayValidNumber
        /// <summary>
        /// Provide an enter for selection between 1 and 3
        /// </summary>
        public static void DisplayErrorValidSelection()
        {
            ChangeConsoleToRed();
            Console.WriteLine("Error! Please enter a number between 1 and 3");

        }
        #endregion

        #region DisplayRed
        /// <summary>
        /// Change the color to red
        /// </summary>
        public static void ChangeConsoleToRed()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        #endregion
    }
}
