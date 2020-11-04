using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinDirec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Ordlistan!");
            Console.WriteLine("Skriv 'sluta' för att avsluta!");
            string command;
            string[] dict = new string[] {"caput-huvud", "videre-se", "pater-pappa",
                "arbor-träd", "luna-måne", "movere-flytta", "urbs-stad"};
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (command == "visa")
                {
                    for (int i = 0; i < dict.Length; i++)
                    {
                        Console.WriteLine($"{dict[i]}");
                    }

                }
                else if (command == "svenska")
                {
                    Console.WriteLine("Vilket ord vill du ha översatt: ");
                    string lookUp = Console.ReadLine();
                    for (int i = 0; i < dict.Length; i++)
                    {
                        string[] word = dict[i].Split('-');
                        if (word[0] == lookUp)
                        {
                            Console.WriteLine($"{word[0]} betyder {word[1]} på svenska");
                        }

                    }
                }
                else if (command == "latinska")
                {
                    Console.WriteLine("Vilket ord vill du ha översatt: ");
                    string lookUp = Console.ReadLine();
                    for (int i = 0; i < dict.Length; i++)
                    {
                        string[] word = dict[i].Split('-');
                        if (word[1] == lookUp)
                        {
                            Console.WriteLine($"{word[1]} betyder {word[0]} på latinsk");
                        }

                    }
                }
                else if (command == "sort")
                {
                    for (int j = 0; j < dict.Length; j++)
                    { 
                        string smallest = dict[j];
                        int smallIndex = j;
                        for (int i = j+1; i < dict.Length; i++)
                        { 
                            int comp = String.Compare(smallest, dict[i]);                                               
                            if (comp > 0)
                            {
                                Console.WriteLine("'{0}' > '{1}'", smallest, dict[i]);
                                smallest = dict[i];
                                smallIndex = i;
                            }
                        }
                        string save = dict[j];
                        dict[j] = smallest;
                        dict[smallIndex] = save;
                    }
                    Console.WriteLine("Sorted!");
                }
            }//done and done
            while (command != "sluta");
        }
    }
}
