namespace CleanCodeBase.Solution
{
    internal partial class Class1
    {
        internal class ConditionalMemberAcccessCaseSoltunio
        {
            public void ConditionalMemberAcccess()
            {
                string text = "like a pro";
                bool isAllowed = text?.Contains("pro") ?? false;
            }
        }



    }
}
