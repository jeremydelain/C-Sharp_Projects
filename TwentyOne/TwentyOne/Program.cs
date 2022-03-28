using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my blackjack table, kid. What do you want me to call you?");
            string playerName = Console.ReadLine();
            Console.WriteLine("\nHow much money are you starting with, {0}?", playerName);
            int bank = Convert.ToInt32(Console.ReadLine());
            Player player = new Player(playerName, bank);
            Game game = new TwentyOneGame();
            game += player;
            player.isActivelyPlaying = true;
            while (player.isActivelyPlaying && player.Balance > 0)
            {
                game.Play();
            }
            game -= player;
            Console.WriteLine("Thanks for the money, {0}.", playerName);
            Console.WriteLine("See ya around.");
            Console.ReadLine();
        }

        
    }
}
