using Antlr4.Runtime;
using DemoParser.Parsing;
using MyExcelMAUIApp;
namespace MyExcelMAUIAppTest;

[TestClass]
public sealed class TestMax
{
    [TestMethod]
    public void MaxTwoInt()
    {
        //INIT 
        var leftValue = 10;
        var rightValue = 22;
        var eval = string.Format("max({0}, {1})", leftValue, rightValue);
        var expectedValue = 22;

        //ACT
        var actual = Calculator.Evaluate(eval);
        
        //ASSERT
        Assert.AreEqual(expectedValue, actual);
    }
}