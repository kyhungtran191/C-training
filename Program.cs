using MyNameSpace;
namespace Review
{
    internal class Program
    {
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
            foreach(int temp in n)
            {
                Console.WriteLine(temp);
            }
            LearnNamspace.XinChao();
            // Generic
            // Delegate 
            //Lambda
        }
    }
}