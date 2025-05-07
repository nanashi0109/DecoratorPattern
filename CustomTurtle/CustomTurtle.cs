namespace DecoratorPattern.TurtleDecorator
{
    public class CustomTurtle : ATurtle
    {
        private IDrawStrategy _strategy;

        public CustomTurtle(IDrawStrategy strategy) 
            => _strategy = strategy;


        public override void Draw()
        {
            _strategy.Draw();
        }
    }
}