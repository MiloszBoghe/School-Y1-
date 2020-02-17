using System;

namespace Voting
{
    public class VotingValidator
    {
        public bool Check(int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException($"age = {age}, but should be > 0!");
            }
            bool votingAllowed = true;
            if (age <= 17)
            {
                votingAllowed = false;
            }
            return votingAllowed;
        }
    }
}
