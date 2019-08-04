using System;
using DesignPatterns.BuilderPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test.BuilderPattern
{
    [TestClass]
    public class BuilderPatternsTests
    {
        [TestMethod]
        public void BuilderPatternRun()
        {
            var b = new ConcreteBuilder();

            var product = b.WithName("Name")
                .WithTag("Tag")
                .Build();

            Console.WriteLine($"Name:\t {product.Name}");
            Console.WriteLine($"Tag:\t {product.Tag}");
        }
    }
}
