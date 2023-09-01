namespace CleanCodeBase
{
    internal class CascadingNullCoalescingCase
    {  
        // ლ(́◉◞౪◟◉‵ლ) 
        public void CascadingNullCoalescing(bool? value1, bool? value2, bool? value3, bool? value4)
        {
            bool result = value1.HasValue && (bool)value1 ||
                value2.HasValue && (bool)value2 ||
                value3.HasValue && (bool)value3 ||
                value4.HasValue && (bool)value4;
        }

        public bool CascadingNullCoalescing2(bool? value1, bool? value2, bool? value3, bool? value4) 
            => value1 ?? value2 ?? value3 ?? value4 ?? false;
    }
}
