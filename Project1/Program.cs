using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = new List<string>();

            while (true)
            {
                Console.WriteLine("What is your command?");
                string command = Console.ReadLine();
                if (command == "add")
                {
                    // add to list 
                    Console.WriteLine("What is the song?");
                    string name = Console.ReadLine();
                    songs.Add(name);
                    Console.WriteLine("The song was added");
                }
                else if (command == "remove")
                {
                    Console.WriteLine("Which song");
                    string name = Console.ReadLine();
                    if (songs.Contains(name))
                    {
                        songs.Remove(name);
                        Console.WriteLine($"{name} was Removed");
                    }
                    else
                    {
                        Console.WriteLine($"The song {name} not found");
                    }

                    {


                       




                    }

                }
                else if (command == "list")
                {
                    songs.ForEach(Console.WriteLine);
                }
                else if (command == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I don't understand that command");
                }
            }
        }
    }
}
