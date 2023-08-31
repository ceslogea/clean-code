namespace CleanCodeBase
{
    internal class LogicalDependencyCase
    {
        // ᄽ●・●ᄿ
        // Logical Dependency
        public class Student
        {
            public bool IsSubscriber { get; set; }

            public void Xpto()
            {
                if (IsSubscriber)
                {
                    // Run if Subscriber
                }
            }
        }
    }
}
