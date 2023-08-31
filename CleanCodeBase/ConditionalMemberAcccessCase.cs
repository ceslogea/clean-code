namespace CleanCodeBase
{
    internal class ConditionalMemberAcccessCase
    {
        public class VoStringContainsPro
        {
            private string Text;

        }

        // ( ˘▽˘)っ♨ 
        public void ConditionalMemberAcccess()
        {
            string text = "like a pro";
            if (text is not null && text.Contains("pro"))
            {
            }

            if (VoStringContainsPro.IsValid)
            { 
            }

            if (text?.Contains("pro") ?? false)
            { 
            }
        }
    }
}
