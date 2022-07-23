using System;

namespace SequenceSymbol
{
    class Symbols
    {
        public static string DoOperation(string words)
        {
            string result = "";
            string name = "";
            int[] a = new int[100];
            for (int i = 0; i < words.Length; i++)
            {
                name += words[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }
          
            return result;
        }

        static void SendMessage(string name, int msg)
        {
            Console.WriteLine( name + " " + msg);
        }
    }
    class Program
        {
        static void Main()
        {
                bool endApp = false;
                // Display title as the C# console calculator app.
                Console.WriteLine("Sequence of Symbols in C#\r");
                Console.WriteLine("------------------------\n");

                while (!endApp)
                {
                    // Declare variables and set to empty.
                    string Input1 = "";

                    // Ask the user to type the first number.
                    Console.Write("Type a word, and then press Enter: ");
                    Input1 = Console.ReadLine();
            

                    try
                    {
                        Symbols.DoOperation(Input1);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Oh no! An exception occurred trying to do the operation.\n - Details: " + e.Message);
                    }

                    Console.WriteLine("------------------------\n");

                    // Wait for the user to respond before closing.
                    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "n") endApp = true;

                    Console.WriteLine("\n"); // Friendly linespacing.
                }
                return;
            }
        }
}