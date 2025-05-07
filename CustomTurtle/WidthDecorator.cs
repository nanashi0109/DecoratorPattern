using TurtleGraphics;

namespace DecoratorPattern.TurtleDecorator
{
    public class WidthDecorator : TurtleDecorator
    {
        private readonly int _width;

        public WidthDecorator(ATurtle customTurtle, int width) : base(customTurtle)
        {
            _width = width;
        }

        public override void Draw()
        {
            Turtle.SetPenWidth(_width);

            _wrapper.Draw();
        }
    }
}