using MyNameSpace;
namespace Review
{
    public delegate void ShowLog(string message);
    internal class Program
    {
        static void Info(string s)
        {
            Console.WriteLine("1");
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 1;
            double y = 1.2;
            string z = "Hung";
            char a = '1';
            bool b = true || false;
            const char p = '1';
            int[] n = { 1, 2, 3, 4 };
            foreach (int temp in n)
            {
                Console.WriteLine(temp);
            }
            //Generic
            static T Swap<T>(T a, T b)
            {
                if (a != null && b != null)
                {
                    return a;
                }
                return b;
            }
            LearnNamspace.XinChao();
            //Anonymous
            //new {name : "1123"}
            //Delegate 
            //Lambda
            //LinQ
            int? age;
            age = null;
            if (age.HasValue)
            {
                Console.WriteLine("Yes");
            }
            //Virtual method, abstract class
            ShowLog info = Info;
            //Action, Func :delegate
            info("123");
        }
    }
}