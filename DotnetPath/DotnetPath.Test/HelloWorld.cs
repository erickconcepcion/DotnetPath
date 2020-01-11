using System;
using Xunit;

namespace DotnetPath.Test
{
    public class HelloWorld
    {
        [Fact]
        public void TestAdd()
        {
            var a = 2 + 2;
            Assert.Equal(a, 4);
        }
    }
}
