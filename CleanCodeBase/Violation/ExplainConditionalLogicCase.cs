namespace CleanCodeBase
{
    internal class ExplainConditionalLogicCase
    {
        // ┻━┻︵ \(°□°)/ ︵ ┻━┻
        public bool ExplainConditionalLogic(int age)
        {
            bool isOldEnoughToDrink = age >= 18;
            if (isOldEnoughToDrink)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
