using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Calculator
{
    [Binding]
    public class CalculatorSteps
    {
        private double _number;
        [Given(@"the number is Pi")]
        public void GivenTheNumberIsPi()
        {
            _number = Math.PI;
        }
                
        [Then(@"sin is (.*)")]
        public void ThenSinIs(int p0)
        {
            var expected = p0;
            Assert.Equal(expected, Math.Sin(_number),5);
        }
        
        [Then(@"Cos is (.*)")]
        public void ThenCosIs(int p0)
        {
            var expected = p0;
            Assert.Equal(expected, Math.Cos(_number),5);
        }
        
        [Then(@"tan is (.*)")]
        public void ThenTanIs(int p0)
        {
            var expected = p0;
            Assert.Equal(expected, Math.Tan(_number),5);
        }
    }
}
