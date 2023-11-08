using Antlr4.Runtime;
using DemoParser.Parsing;
using MyExcelMAUIApp;
namespace MyExcelMAUIAppTest;

[TestClass]
public sealed class TestDivide
{
    [TestMethod]
    public void DivideTwoDoubles()
    {
        //INIT 
        var leftValue = 1d;
        var rightValue = 2d;
        var eval = string.Format("{0}/{1}", leftValue, rightValue);
        var expectedValue = 0.5d;

        //ACT
        var actual = Calculator.Evaluate(eval);
        
        //ASSERT
        Assert.AreEqual(expectedValue, actual);
    }
}