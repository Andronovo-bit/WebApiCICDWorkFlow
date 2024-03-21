namespace WebApiCICDWorkFlow
{
    public class DiceRolling
    {
        // This method will return a random number between 1 and 6
        public static int RollDice()
        {
            Random random = new();
            return random.Next(1, 7);
        }
    }
}
