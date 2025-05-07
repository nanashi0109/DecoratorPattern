using DecoratorPattern.Tools;
using TurtleGraphics;

namespace DecoratorPattern.TurtleDecorator
{
    public class TriangleStrategy : IDrawStrategy
    {
        private const int _angle = 120;

        public void Draw()
        {
            for(int i = 0; i < 3; i++)
            {
                Turtle.Forward(Constants.LENGTH_DRAWING_LINE);
                Turtle.TurnRight(_angle);
            }
        }
    }
}