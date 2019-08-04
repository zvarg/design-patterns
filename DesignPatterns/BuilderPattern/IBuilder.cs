namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        IBuilder WithName(string name);

        IBuilder WithTag(string tag);

        Product Build();
    }
}
