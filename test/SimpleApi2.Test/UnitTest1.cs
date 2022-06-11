using System;
using SimpleApi2.Controllers;
using Xunit;

namespace SimpleApi2.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsDCMorrison()
        {
            var ReturnedValue = controller.Get(1);
            Assert.Equal("DC Morrison", ReturnedValue.Value);
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
