namespace DecoratorPattern.TurtleDecorator
{
    public abstract class TurtleDecorator : ATurtle
    {
        protected ATurtle _wrapper;

        public TurtleDecorator(ATurtle customTurtle) 
            => _wrapper = customTurtle;
    }
}