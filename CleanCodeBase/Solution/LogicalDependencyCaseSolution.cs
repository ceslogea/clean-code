namespace CleanCodeBase.Solution
{
    internal partial class Class1
    {
        public class LogicalDependencyCaseSolution
        {
            // Logical Dependency
            public class Student
            {
                //...
            }

            public class Subscriber : Student
            {
                public void Xpto()
                {
                    //...        
                }
            }
        }

    }
}
