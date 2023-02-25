using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(25, 10);
            Renderer renderer = new Renderer();
            renderer.Draw(player1.X, player1.Y);
        }
    }

    class Renderer
    {
        public void Draw(int x,int y,char character ='@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x,y);
            Console.Write(character);
            Console.ReadKey(true);

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
    }

}
