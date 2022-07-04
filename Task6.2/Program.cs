using System;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positionX = 10;
            int positionY = 5;
            Player player = new Player(positionX, positionY);
            player.Draw('%');
            Console.ReadKey();
        }
    }

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(symbol);
        }
    }
}
