using DecoratorPattern.Tools;
using TurtleGraphics;

namespace DecoratorPattern.TurtleDecorator
{
    public class HexagonStrategy : IDrawStrategy
    {
        private const int _agile = 60;

        public void Draw()
        {
            for (int i = 0; i < 6; i++)
            {
                Turtle.Forward(Constants.LENGTH_DRAWING_LINE);
                Turtle.TurnRight(_agile);
            }
        }
    }
}