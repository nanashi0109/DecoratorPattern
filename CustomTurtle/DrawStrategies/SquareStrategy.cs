using DecoratorPattern.Tools;
using TurtleGraphics;

namespace DecoratorPattern.TurtleDecorator
{
    public class SquareStrategy : IDrawStrategy
    {
        private const int _agile = 90;

        public void Draw()
        {
            for(int i = 0; i <4; i++)
            {
                Turtle.Forward(Constants.LENGTH_DRAWING_LINE);
                Turtle.TurnRight(_agile);
            }
        }
    }
}