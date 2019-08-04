namespace DesignPatterns.BuilderPattern
{
    public class ConcreteBuilder : IBuilder
    {
        private readonly Product _product = new Product();

        public IBuilder WithName(string name)
        {
            _product.Name = name;

            return this;
        }

        public IBuilder WithTag(string tag)
        {
            _product.Tag = tag;

            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }
}
