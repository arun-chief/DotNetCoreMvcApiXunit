using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainProjectChief.TestClass;
using Xunit;

namespace XunitTestCore
{
   public class Class1
   {
      [Fact]
      public void PassingTest()
      {
         Assert.Equal(4, Add(2, 2));
      }

      [Fact]
      public void FailingTest()
      {
         Assert.Equal(5, Add(2, 2));
      }

      [Fact]
      public void ConcatenateName()
      {
         TestClass concat = new TestClass(); // initialising the class to test
         

         Assert.Equal("ArunPrasad", concat.ConcateName("Arun", "Prasad")); // checking the result by mathing

      }

      int Add(int x, int y)
      {
         return x + y;
      }
   }
}
