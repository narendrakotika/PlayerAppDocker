// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

class Program
{
    static List<Player> players = new List<Player>();

    static void Main()
    {
        Console.WriteLine("*** Player Management System ***");

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. View All Players");
            Console.WriteLine("3. View Player by ID");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddPlayer();
                    break;
                case "2":
                    ViewAllPlayers();
                    break;
                case "3":
                    ViewPlayerById();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

   public static void AddPlayer()
    {
        Console.Write("Enter player name: ");
        string name = Console.ReadLine();

        // In a real-world scenario, you might want to validate input and generate a unique ID.
        int id = players.Count + 1;

        Player newPlayer = new Player(id, name);
        players.Add(newPlayer);

        Console.WriteLine($"Player '{name}' added with ID: {id}");
    }

  public static void ViewAllPlayers()
    {
        Console.WriteLine("All Players:");

        foreach (var player in players)
        {
            Console.WriteLine($"ID: {player.Id}, Name: {player.Name}");
        }
    }

  public static void ViewPlayerById()
    {
        Console.Write("Enter player ID: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            Player player = players.Find(p => p.Id == id);

            if (player != null)
            {
                Console.WriteLine($"Player found - ID: {player.Id}, Name: {player.Name}");
            }
            else
            {
                Console.WriteLine($"Player with ID {id} not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid player ID.");
        }
    }
}

 public class Player
{
    public int Id { get; }
    public string Name { get; }

    public Player(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

