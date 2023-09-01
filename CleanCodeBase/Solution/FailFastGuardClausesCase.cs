namespace CleanCodeBase.Solution
{
    internal partial class Class1
    {
        internal class FailFastGuardClausesCase
        {
            public bool FailFastGuardClauses_1(string? password)
            {
                const int PASSWORD_LENGTH = 20;
                const string MUST_HAVE_VALUE_MESSAGE = "Password must have a value";
                const string MUST_HAVE_SPECIAL_CHARACTER_MESSAGE = "Must have at Least 1 special character";
                const string MIN_LENGTH_MESSAGE = "Must be at Least {0} characters";

                if (!string.IsNullOrEmpty(password)) throw new ArgumentException(MUST_HAVE_VALUE_MESSAGE);
                if (password?.Any(c => !char.IsLetterOrDigit(c)) ?? false) throw new ArgumentException(MUST_HAVE_SPECIAL_CHARACTER_MESSAGE);
                if (password?.Length > PASSWORD_LENGTH) throw new ArgumentException(string.Format(MIN_LENGTH_MESSAGE, PASSWORD_LENGTH));

                return true;
            }
        }



    }
}
