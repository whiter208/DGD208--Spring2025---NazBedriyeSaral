using System;

namespace GameProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Game game = new Game();
            await game.GameLoop();
        }
    }
}
