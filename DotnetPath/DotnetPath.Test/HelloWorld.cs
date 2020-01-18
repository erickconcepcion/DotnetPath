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
        [Fact]
        public void TestTernary()
        {
            int a = 0;
            int b = 0;
            var cantBeZero = true;
            if (cantBeZero)
            {
                b += 1;
                              
            }
            cantBeZero = true;
            a = cantBeZero ? 1 : 0; 


            // Use ternary to asing 1 on a variable.

            Assert.Equal(a, b);
        }
        [Fact]
        public void TestNullCheck()
        {
            string a = null;
            string b = null;
            if (string.IsNullOrEmpty(b))
            {
                b = "Hello";
            }

            a = a ??=  "World";

            //use the ?? null check operator to asing other value to a Variable
            Assert.NotNull(b);
            Assert.NotNull(a);

        }
    }
}
