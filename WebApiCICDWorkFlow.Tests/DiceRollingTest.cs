namespace WebApiCICDWorkFlow.Tests;

[TestClass]
public class DiceRollingTest
{
    [TestMethod]
    public void TestRollDice()
    {
        int result = DiceRolling.RollDice();
        Assert.IsTrue(result >= 1 && result <= 6);
    }
}

