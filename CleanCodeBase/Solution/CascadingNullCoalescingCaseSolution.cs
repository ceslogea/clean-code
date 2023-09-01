namespace CleanCodeBase.Solution
{
    internal partial class Class1
    {
        internal class CascadingNullCoalescingCaseSolution
        {
            public void CascadingNullCoalescing(bool? value1, bool? value2, bool? value3, bool? value4)
            {
                bool result = value1 ??
                    value2 ??
                    value3 ??
                    value4 ??
                    false;
            }
        }



    }
}
