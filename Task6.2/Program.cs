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
            Renderer renderer = new Renderer();
            renderer.Draw(player.PositionX, player.PositionY, '#');
            Console.ReadKey();
        }
    }
    
    class Renderer
    {
        public void Draw(int positionX, int positionY, char symbol)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
