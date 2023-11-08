using Antlr4.Runtime;
using DemoParser.Parsing;
using MyExcelMAUIApp;
namespace MyExcelMAUIAppTest;

[TestClass]
public sealed class TestInc
{
    [TestMethod]
    public void IncTwoInt()
    {
        //INIT 
        var Value = 0;
        var eval = string.Format("inc({0})", Value);
        var expectedValue = 1;

        //ACT
        var actual = Calculator.Evaluate(eval);
        
        //ASSERT
        Assert.AreEqual(expectedValue, actual);
    }
}