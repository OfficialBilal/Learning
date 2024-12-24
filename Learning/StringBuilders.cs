using System.Text;

namespace Learning
{
    class StringBuilders
    {
        public static void Main(string[] args)
        {
            StringBuilder dstr = new ("This is a Strong");

            dstr.Append(" message");
            dstr.Append(" .");

            Console.WriteLine(dstr); 

            
        }
    }
}
