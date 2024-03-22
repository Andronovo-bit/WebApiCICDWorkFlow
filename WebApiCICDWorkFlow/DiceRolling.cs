using System.Security.Cryptography;

namespace WebApiCICDWorkFlow;

public class DiceRolling
{
    // This method will return a random number between 1 and 6
    public static int RollDice()
    {
        var randomGenerator = RandomNumberGenerator.Create();
        byte[] randomNumber = new byte[1];
        randomGenerator.GetBytes(randomNumber);
        return (randomNumber[0] % 6) + 1;

    }
}
