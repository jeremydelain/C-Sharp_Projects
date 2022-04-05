using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class TwentyOneGame : Game
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            

            foreach(Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("\n\nPlace your bet!     Balance: {0}", player.Balance);
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Enter digits integers only - no decimals:");
                }
                if (bet < 0)
                {
                    throw new FraudException("Negative bet placed.");
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n...Dealing...");
                System.Threading.Thread.Sleep(1000);
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    System.Threading.Thread.Sleep(1000);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\nBLACKJACK! {0} wins {1}", player.Name, Bets[player]);
                            System.Threading.Thread.Sleep(1000);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                System.Threading.Thread.Sleep(1000);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("\n...DEALER HAS BLACKJACK...");
                        System.Threading.Thread.Sleep(1000);
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("\n\nYour cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("|{0}|", card.ToString());
                    }
                    string currentHandValue = TwentyOneRules.GetAllPossibleHandValues(player.Hand).First().ToString();
                    Console.Write("  -[{0}]-", currentHandValue);
                    Console.WriteLine("\n\nHIT or STAY?");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "stay" || answer == "s")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit" || answer == "h")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} BUSTED! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "y" || answer == "ye" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("\n...Dealer is hitting...");
                System.Threading.Thread.Sleep(1000);
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                string stay = TwentyOneRules.GetAllPossibleHandValues(Dealer.Hand).Max().ToString();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("...Dealer is staying at {0}...", stay);
                System.Threading.Thread.Sleep(1000);
            }
            if (Dealer.isBusted)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\n!!!Dealer BUSTED!!!");
                System.Threading.Thread.Sleep(1000);
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("...Push! No one wins...");
                    System.Threading.Thread.Sleep(1000);
                    player.Balance += Bets[player];
                    Bets.Remove(player);
                }
                else if (playerWon == true)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\n{0} won {1}!", player.Name, Bets[player]);
                    System.Threading.Thread.Sleep(1000);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    System.Threading.Thread.Sleep(1000);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y" || answer == "ye" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
