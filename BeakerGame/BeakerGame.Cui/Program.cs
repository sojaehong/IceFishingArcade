using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeakerGame.Logic;

namespace BeakerGame.Cui
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                Console.WriteLine("입력하시오");
                string input = Console.ReadLine();

                if (input.Length != 2)
                    continue;

                game.Move(input[0], input[1]);
                Console.WriteLine($"{game.GetLiter("A")} / {game.GetLiter("B")} / {game.GetLiter("C")}");

                if (game.IsCompleted())
                {
                    Console.WriteLine($"Finished with {game.MoveCount}");
                    break;
                }
            }

            game.Move("A", "C");
            Console.WriteLine(game.GetLiter("A")); // 5
            Console.WriteLine(game.GetLiter("C")); // 3
        }
    }
}
