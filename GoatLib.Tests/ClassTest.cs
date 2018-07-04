using FluentAssertions;
using NUnit.Framework;

namespace GoatLib.Tests
{
  [TestFixture]
  public class ClassTest
  {
    [Test]
    public void Test()
    {
      var @class = new Class();
      @class.Prop.Should().Be("Greatest Of All Time");
    }
  }
}
