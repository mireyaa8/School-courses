using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace GameOfWars
{
    internal class GameOfWarlk
    {

        public void Main(string[] args)
        {
            // Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(
@"
================================================================================
|| Welcome to the Game of War!                                                ||
||                                                                            ||
|| HOW TO PLAY:                                                               ||
|| + Each of the two players are dealt one half of a shuffled deck of cards.  ||
|| + Each turn, each player draws one card from their deck.                   ||
|| + The player that drew the card with higher value gets both cards.         ||
|| + Both cards return to the winner's deck.                                  ||
|| + If there is a draw, both players place the next three cards face down    ||
|| and then another card face-up. The owner of the higher face-up             ||
|| card gets all the cards on the table.                                      ||
||                                                                            ||
|| HOW TO WIN:                                                                ||
|| + The player who collects all the cards wins.                              ||
||                                                                            ||
|| CONTROLS:                                                                  ||
|| + Press [Enter] to draw a new card until we have a winner.                 ||
||                                                                            ||
|| Have fun!                                                                  ||
================================================================================

               "
);

            List<Cards> deck = GenerateDeck();
            ShuffleDeck(deck);

            Queue<Cards> firstPlayerDeck = new Queue<Cards>();
            Queue<Cards> secondPlayerDeck = new Queue<Cards>();

            DealCardsToPlayers(deck);

            Cards firstPlayerCard;
            Cards secondPlayerCard;

            int totalMoves = 0;

            while (!GameHasWinner(firstPlayerDeck, secondPlayerDeck, totalMoves,firstPlayerCard, secondPlayerCard))
            {
                Console.ReadLine();
                DrawPlayerCards(firstPlayerCard, secondPlayerCard, firstPlayerDeck,  secondPlayerDeck,  totalMoves);

                Queue<Cards> pool = new Queue<Cards>();
                pool.Enqueue(firstPlayerCard);
                pool.Enqueue(secondPlayerCard);

                ProcessWar(pool,firstPlayerCard,  secondPlayerCard,  firstPlayerDeck, secondPlayerDeck);
                DetermineRoundWinner(pool, firstPlayerCard, secondPlayerCard, firstPlayerDeck, secondPlayerDeck);

                Console.WriteLine("================================================================================");
                Console.WriteLine($"First player currently has {firstPlayerDeck.Count} cards.");
                Console.WriteLine($"Second player currently has {secondPlayerDeck.Count} cards.");
                Console.WriteLine("================================================================================");
                totalMoves++;
            }

        }
        List<Cards> GenerateDeck()
        {
            List<Cards> deck = new List<Cards>();
            CardFace[] faces = (CardFace[])Enum.GetValues(typeof(CardFace));
            CardSuit[] suits = (CardSuit[])Enum.GetValues(typeof(CardSuit));

            for (int suit = 0; suit < suits.Length; suit++)
            {
                for (int face = 0; face < faces.Length; face++)
                {
                    CardFace currentFace = faces[face];
                    CardSuit currentSuit = suits[suit];
                    deck.Add(new Cards
                    {
                        Face = currentFace,
                        Suite = currentSuit
                    });
                }

            }


            return deck;
        }

         void ShuffleDeck(List<Cards> deck)
        {
            Random random = new Random();
            for (int i = 0; i < deck.Count; i++)
            {
                int firstCardIndex = random.Next(deck.Count);
                Cards tempCard = deck[firstCardIndex];
                deck[firstCardIndex] = deck[i];
                deck[i] = tempCard;
            }


        }

        void DealCardsToPlayers(List<Cards> deck)
        {
            Queue<Cards> firstPlayerDeck = new Queue<Cards>();
            Queue<Cards> secondPlayerDeck = new Queue<Cards>();


            while (deck.Count > 0)
            {
                Cards[] firstTwoDrawnCards = deck.Take(2).ToArray();
                deck.RemoveRange(0, 2);
                firstPlayerDeck.Enqueue(firstTwoDrawnCards[0]);
                secondPlayerDeck.Enqueue(firstTwoDrawnCards[1]);


            }


        }
           bool GameHasWinner(Queue<Cards> firstPlayerDeck, Queue<Cards> secondPlayerDeck, int totalMoves,Queue<Cards> firstPlayerCard, Queue<Cards> secondPlayerCard)
        {
            if (!firstPlayerDeck.Any())
            {
                Console.WriteLine($"After a total of {totalMoves} moves, the second player has won!");
                return true;

            }
            if (!secondPlayerDeck.Any())
            {

                Console.WriteLine($"After a total of {totalMoves} moves, the first player has won!");
                return true;
            }
            return false;



        }
        void DrawPlayerCards(Queue<Cards> firstPlayerCard, Queue<Cards> secondPlayerCard, Queue<Cards> firstPlayerDeck, Queue<Cards> secondPlayerDeck, int totalMoves)
        {


            firstPlayerCard = firstPlayerDeck.Dequeue();
            Console.WriteLine($"First player has drawn: {firstPlayerCard}");
            secondPlayerCard = secondPlayerDeck.Dequeue();
            Console.WriteLine($"Second player has drawn: {secondPlayerCard}");

            while (!GameHasWinner(firstPlayerDeck, secondPlayerDeck, totalMoves))
            {
                Console.ReadLine();
                DrawPlayerCards(firstPlayerCard, secondPlayerCard, firstPlayerDeck, secondPlayerDeck, totalMoves);

                Queue<Cards> pool = new Queue<Cards>();
                pool.Enqueue(firstPlayerCard);
                pool.Enqueue(secondPlayerCard);

                ProcessWar(pool, firstPlayerCard, secondPlayerCard, firstPlayerDeck, secondPlayerDeck);
                DetermineRoundWinner(pool, firstPlayerCard, secondPlayerCard, firstPlayerDeck, secondPlayerDeck);

                Console.WriteLine("================================================================================");
                Console.WriteLine($"First player currently has {firstPlayerDeck.Count} cards.");
                Console.WriteLine($"Second player currently has {secondPlayerDeck.Count} cards.");
                Console.WriteLine("================================================================================");
                totalMoves++;
            }

        }
        void ProcessWar(Queue<Cards> pool, Queue<Cards> firstPlayerCard, Queue<Cards> secondPlayerCard, Queue<Cards> firstPlayerDeck, Queue<Cards> secondPlayerDeck )
        {
            while ((int)firstPlayerCard.Face == (int)secondPlayerCard.Face)
            {
                Console.WriteLine("WAR!");
                if (firstPlayerDeck.Count < 4)
                {
                    AddCardsToWinnerDeck(firstPlayerDeck, secondPlayerDeck);
                    Console.WriteLine($"First player does not have enough card to continue playing...");
                    break;



                }
                if (secondPlayerDeck.Count < 4)
                {
                    AddCardsToWinnerDeck(firstPlayerDeck, secondPlayerDeck);
                    Console.WriteLine($"Second player does not have enough card to continue playing...");
                    break;



                }
                AddWarCardsToPool(pool,firstPlayerCard, secondPlayerCard, firstPlayerDeck, secondPlayerDeck);

                firstPlayerCard = firstPlayerDeck.Dequeue();
                Console.WriteLine($"First player has drawn: {firstPlayerCard}");
                secondPlayerCard = secondPlayerDeck.Dequeue();
                Console.WriteLine($"Second player has drawn: {secondPlayerCard}");
                pool.Enqueue(firstPlayerCard);
                pool.Enqueue(secondPlayerCard);

            }
        }

        void AddCardsToWinnerDeck(Queue<Cards> loserDeck, Queue<Cards> winnerDeck)
        {
            while (loserDeck.Count > 0)
            {
                winnerDeck.Enqueue(loserDeck.Dequeue());

            }
        }
        void AddWarCardsToPool(Queue<Cards> pool, Queue<Cards> firstPlayerDeck, Queue<Cards> secondPlayerDeck, Queue<Cards> firstPlayerCard, Queue<Cards> secondPlayerCard)
        {
            for (int i = 0; i < 3; i++)
            {
                pool.Enqueue(firstPlayerDeck.Dequeue());
                pool.Enqueue(secondPlayerDeck.Dequeue());

            }
        }
        void DetermineRoundWinner(Queue<Cards> pool, Queue<Cards> firstPlayerCard, Queue<Cards> secondPlayerCard, Queue<Cards> firstPlayerDeck, Queue<Cards> secondPlayerDeck,CardFace currentFace)
        {
            if ((int)firstPlayerCard.Face > (int)secondPlayerCard.Face)
            {
                Console.WriteLine("The first player has won the cards!");

                foreach (var card in pool)
                {
                    firstPlayerDeck.Enqueue(card);

                }
            }
            else
            {
                Console.WriteLine("The second player has won the cards!");

                foreach (var card in pool)
                {
                    secondPlayerDeck.Enqueue(card);

                }
            }
        }

    }

}