using System.Net.Cache;

namespace Learning
{
    class ConditionalOperator
    {
        public static void Main(string[] args)
        {
            bool CanVote = false;

            int Age = 18;

            string Vote;

            CanVote = Age >= 18 ? true : false;

            Vote = CanVote ? "You are allowed to Vote" : "You are not allowed to vote";

            Console.WriteLine(Vote);
        } 
    }
}
