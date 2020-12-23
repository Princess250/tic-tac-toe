using System;

namespace tictactoe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to tic tac toe!");
            // State
            int gameStatus = 0;
            int Player1 = -1;
            char[] gameplayers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            do
            {
                Console.Clear();

                Player1 = GetNextPlayer(Player1);

                HeadsUpDisplay(Player1);
                DrawGameboard(gameplayers);

                GameEngine(gameplayers, Player1);

            } while (gameStatus.Equals(0));

            Console.Clear();
            HeadsUpDisplay(Player1);
            DrawGameboard(gameplayers);
        }


        private static void GameEngine(char[] gameplayers, int Player1)
        {
            bool notValidMove = true;

            do
            {
                
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) &&
                    (userInput.Equals("1") ||
                    userInput.Equals("2") ||
                    userInput.Equals("3") ||
                    userInput.Equals("4") ||
                    userInput.Equals("5") ||
                    userInput.Equals("6") ||
                    userInput.Equals("7") ||
                    userInput.Equals("8") ||
                    userInput.Equals("9")))
                {

                    int.TryParse(userInput, out var gameplacementmarketer);

                    char player2 = gameplayers[gameplacementmarketer- 1];

                    if (player2.Equals('X') || player2.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again.");
                    }
                    else
                    {
                        gameplayers[gameplacementmarketer - 1] = GetPlayerMarker(Player1);

                        notValidMove = false;
                    }
                }
                else
                {
                    Console.WriteLine("move made was illegal");
                }
            } while (notValidMove);
        }

        private static char GetPlayerMarker(int player)
        {
            if (player % 2 == 0)
            {
                return 'O';
            }

            return 'X';
        }

        static void HeadsUpDisplay(int PlayerNumber)
        {
            // Greeting
            Console.WriteLine("Welcome to tic-tac-toe!");
        }

        static void DrawGameboard(char[] gameplayers)
        {
            // 2. Draw the game board
            // 2.1 Game will have 3 rows and 3 columns will be numbered 1 through 9

            Console.WriteLine($" {gameplayers[0]} | {gameplayers[1]} | {gameplayers[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameplayers[3]} | {gameplayers[4]} | {gameplayers[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameplayers[6]} | {gameplayers[7]} | {gameplayers[8]} ");
        }

        // Next Player
        static int GetNextPlayer(int player)
        {
            if (player.Equals(1))
            {
                return 2;
            }

            return 1;
        }
    }
}