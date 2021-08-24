using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PracticeProblems
{
    // create the snake portion for a snake game
    class SnakeGame
    {
        static int foodCount;

        public static void MainSnake()
        {
            Console.CursorVisible = false;
            var snake = new Snake(new Point(Console.WindowWidth / 2, Console.WindowHeight / 2),
                5, '*');

            snake.Draw();

            while (true)
            {
                var ch = Console.ReadKey(true).Key;
                if (ch == ConsoleKey.Q) break;

                switch (ch)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        snake.Move(Snake.Direction.Up);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        snake.Move(Snake.Direction.Down);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        snake.Move(Snake.Direction.Left);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        snake.Move(Snake.Direction.Right);
                        break;

                }
            }
        }

        public class SnakeParts
        {
            public char Symbol { get; set; }
            public Point Position { get; set; }

            public SnakeParts(Point position, char symbol)
            {
                Position = position;
                Symbol = symbol;
            }

            public void Draw()
            {
                Console.SetCursorPosition(Position.X, Position.Y);
                Console.Write(Symbol);
            }

            public void Erase()
            {
                Console.SetCursorPosition(Position.X, Position.Y);
                Console.Write(' ');
            }

        }

        public class Snake
        {
            public enum Direction { Up, Down, Left, Right }

            public char Symbol { get; set; }

            public  readonly SnakeParts[] _body;
            private SnakeParts Head => _body.First();
            private SnakeParts Tail => _body.Last();

            public Snake(Point startingPoint, int length, char symbol = '*')
            {
                Symbol = symbol;

                //intiate the arrasy and build the snake 
                _body = Enumerable
                    .Range(0, length)
                    .Select(x => new SnakeParts(startingPoint, symbol))
                    .ToArray();
            }

            public void Draw()
            {
                foreach (var snakePart in _body)
                {
                    snakePart.Draw();
                }
            }

            public void Move(Direction direction)
            {
                //create the part that will be the head
                SnakeParts newHead = null;

                switch(direction)
                {
                    case Direction.Up:
                        newHead = new SnakeParts(new Point(Head.Position.X, Head.Position.Y - 1), Symbol);
                        break;
                    case Direction.Down:
                        newHead = new SnakeParts(new Point(Head.Position.X, Head.Position.Y + 1), Symbol);
                        break;
                    case Direction.Left:
                        newHead = new SnakeParts(new Point(Head.Position.X - 1, Head.Position.Y), Symbol);
                        break;
                    case Direction.Right:
                        newHead = new SnakeParts(new Point(Head.Position.X + 1, Head.Position.Y), Symbol);
                        break;
                }
                Tail.Erase();
                for(var i = _body.Length - 1; i > 0; i--)
                {
                    _body[i] = _body[i - 1];
                }
                _body[0] = newHead;
                Draw();
            }

            
        }
    }
}
