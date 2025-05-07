using DecoratorPattern.Tools;
using DecoratorPattern.TurtleDecorator;
using SkiaSharp;
using System;
using System.Collections.Generic;
using TurtleGraphics;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Start();
        }
    }

    public class App
    {
        private Dictionary<DrawStrategies, IDrawStrategy> _drawStrategies;

        public App()
        {
            _drawStrategies = new Dictionary<DrawStrategies, IDrawStrategy>()
            {
                {DrawStrategies.Square, new SquareStrategy() },
                {DrawStrategies.Triangle, new TriangleStrategy() },
                {DrawStrategies.Hexagon, new HexagonStrategy()}
            };
        }

        public void Start()
        {
            ATurtle turtle = new CustomTurtle(GetUserDrawStrategy());

            turtle = new ColorDecorator(turtle, GetUserColor());
            turtle = new WidthDecorator(turtle, GetUserWidth());
            turtle.Draw();

            Turtle.ShowTurtle();
        }

        public string GetUserColor()
        {
            Console.Write(Constants.INPUT_COLOR);

            var user_data = Console.ReadLine();

            return user_data;
        }

        public int GetUserWidth()
        {
            Console.Write(Constants.INPUT_WIDTH_LINE);

            var user_data = Console.ReadLine();

            int.TryParse(user_data, out int result);

            return result;
        }

        public IDrawStrategy GetUserDrawStrategy()
        {
            Console.WriteLine(Constants.CHOICE_SHAPE);

            int.TryParse(Console.ReadLine(), out int result);

            return _drawStrategies[(DrawStrategies)result];
        }
    }
}