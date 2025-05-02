using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        Room cave = new Room("Cave", "A dark, ominous cave alooms to the player. Seems like a great starting room.");
        Room passageWay = new Room("Passage", "A long corrider awaits exploration, throughout dimly lit by torches at the end of there life.");

        Room treasureRoom = new Room("Treasure Room", "Filled with gold but lures the atmosphere of uneasiness.");

        cave.ConnectRoom(passageWay);
        passageWay.ConnectRoom(treasureRoom);
        cave.AddMonster(new Monster("Goblin", 50, 10));
        cave.AddItem(new Item("Dagger", "A short blade great for quick attacks.", Item.ItemType.Weapon));
        passageWay.AddMonster(new Monster("DireWolf", 75, 15));
        passageWay.AddItem(new Item("Torch", "A flaming torch great for spotting mosnters lurking in the dark."));
        treasureRoom.AddMonster(new Monster("Dragon", 200, 25));
        treasureRoom.AddItem(new Item("Health Potion", "Restores 50 HP.", Item.ItemType.Potion));


        Player player = new Player({name}, 100, 20, cave);

        while (true)
        {
            player.CurrentRoom.ShowRoomDetails();
            Console.WriteLine($"\n{player.Name}'s HP: {player.Health}");
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Move to another room");
            Console.WriteLine("2. Fight the monster");
            Console.WriteLine("3. Pick up the item");
            Console.WriteLine("4. View inventory");
            Console.WriteLine("5. Use an item");
            Console.WriteLine("6. Quit");

            Console.Write("Your choice: ");
            if (input == "1")
            {
                for (int i = 0; i < player.CurrentRoom.ConnectedRooms.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {player.CurrentRoom.ConnectedRooms[i].Name}");
                }
                Console.WriteLine("Enter room number: ");
                string roomChoice = Console.ReadLine();
                if (int.TryParse(roomChoice, out int roomIndex) &&
                    roomIndex >= 1 && roomIndex <= player.CurrentRoom.ConnectedRooms.Count)
                {
                    player.MoveToRoom(player.CurrentRoom.ConnectedRooms[roomIndex - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid room choice.");
                }}
            else if (input == "2")
            {
                if (player.CurrentRoom.Monster != null)
                {
                    player.Attack(player.CurrentRoom.Monster);
                    if (player.CurrentRoom.Monster.Health > 0)
                    {
                        player.CurrentRoom.Monster.Attack(player);
                    }
                    else
                    {
                        player.CurrentRoom.Monster = null;
                    }
                }
            }
            else if (input == "3")
            {
                if (player.CurrentRoom.Item != null)
                {
                    player.Inventory.AddItem(player.CurrentRoom.Item);
                    player.CurrentRoom.Item = null;
                }
                else
                {
                    Console.WriteLine("There is no item to pick up.");
                }
            }
            else if (input == "4")
            {
                player.Inventory.ShowInventory();
            }
             else if (input == "6")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
            string input = Console.ReadLine();
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            Console.WriteLine("Waiting for your Implementation");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    }
    }
