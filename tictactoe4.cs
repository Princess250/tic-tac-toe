using System;

namespace tictactoe4
{
    class Program
    {
        static char c1, c2, c3, c4, c5, c6, c7, c8, c9, c = 'X';

        int i = 0;
        static bool win = false;
        static bool quit;
        enum Menu { New = 1, About, Quit }
        static Menu k;
        static void Main(string[] args)
        {

            bool quit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to tic-tac-toe!\n");
                Console.WriteLine("1. New game\n2. About the author\n" +
                       "3. Quit");

                while (!Enum.TryParse<Menu>(Console.ReadKey().KeyChar.ToString(), out k)) ;

                Console.Clear();

                cases();

            } while (!quit);
        }


        static void cases()
        {
            switch (k)
            {
                case Menu.New:


                    do
                    {
                        Console.Clear();

                        c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = ' ';
                        int i = 0;

                        gameboard();


                        if (++i > 9 || win)
                            break;

                        bool ok = false;

                        do
                        {
                            Console.Write(c + "'s move > ");
                            switch (Console.ReadKey().KeyChar)
                            {
                                case '1':
                                    if (c1 == ' ')
                                    {
                                        c1 = c; ok = true;
                                        win = c2 == c && c3 == c
                                           || c4 == c && c7 == c
                                           || c5 == c && c9 == c;
                                    }
                                    break;
                                case '2':
                                    if (c2 == ' ')
                                    {
                                        c2 = c; ok = true;
                                        win = c1 == c && c3 == c
                                           || c5 == c && c8 == c;
                                    }
                                    break;
                                case '3':
                                    if (c3 == ' ')
                                    {
                                        c3 = c; ok = true;
                                        win = c1 == c && c2 == c
                                           || c6 == c && c9 == c
                                           || c5 == c && c7 == c;
                                    }
                                    break;
                                case '4':
                                    if (c4 == ' ')
                                    {
                                        c4 = c; ok = true;
                                        win = c5 == c && c6 == c
                                           || c1 == c && c7 == c;
                                    }
                                    break;
                                case '5':
                                    if (c5 == ' ')
                                    {
                                        c5 = c; ok = true;
                                        win = c4 == c && c6 == c
                                           || c2 == c && c8 == c
                                           || c1 == c && c9 == c
                                           || c3 == c && c7 == c;
                                    }
                                    break;
                                case '6':
                                    if (c6 == ' ')
                                    {
                                        c6 = c; ok = true;
                                        win = c4 == c && c5 == c
                                           || c3 == c && c9 == c;
                                    }
                                    break;
                                case '7':
                                    if (c7 == ' ')
                                    {
                                        c7 = c; ok = true;
                                        win = c8 == c && c9 == c
                                           || c1 == c && c4 == c
                                           || c3 == c && c5 == c;
                                    }
                                    break;
                                case '8':
                                    if (c8 == ' ')
                                    {
                                        c8 = c; ok = true;
                                        win = c7 == c && c9 == c
                                           || c2 == c && c5 == c;
                                    }
                                    break;
                                case '9':
                                    if (c9 == ' ')
                                    {
                                        c9 = c; ok = true;
                                        win = c7 == c && c8 == c
                                           || c3 == c && c6 == c
                                           || c1 == c && c5 == c;
                                    }
                                    break;
                            }
                            if (!ok)
                                Console.WriteLine("Illegal move! Try again.");
                        } while (!ok);

                        if (!win)
                            if (c == 'X')
                                c = 'O';
                            else
                                c = 'X';
                    } while (true);

                    if (win)
                        Console.WriteLine(c + " won!");
                    else
                        Console.WriteLine("Game over!");
                    Console.WriteLine("[Press Enter to return to main menu...]");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    break;
                case Menu.About:
                    Console.WriteLine("About the author.");
                    Console.WriteLine("The author of this game is Princess Ingabire\n");
                    Console.WriteLine("[Press Enter to return to main menu...]");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    break;
                case Menu.Quit:
                    Console.Write("Quit? [y/n]");
                    if (Console.ReadKey().KeyChar == 'y')
                        quit = true;
                    else
                        Console.Clear();
                    break;
            }

        }

        static void gameboard()
        {
            Console.WriteLine("\n" + c1 + "|" + c2 + "|" + c3 + "\n-----\n" +
                                                   c4 + "|" + c5 + "|" + c6 + "\n-----\n" +
                                                   c7 + "|" + c8 + "|" + c9 + "\n");
        }
    }
}
