using TurtleGraphics;

namespace DecoratorPattern.TurtleDecorator
{
    public class ColorDecorator : TurtleDecorator
    {
        private readonly string _color;

        public ColorDecorator(ATurtle customTurtle, string color) : base(customTurtle)
        {
            _color = color;
        }

        public override void Draw()
        {
            Turtle.SetColor(_color);

            _wrapper.Draw();
        }
    }
}