using MyNameSpace;
using System.Collections;

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
            //Console.WriteLine("Hello, World!");
            //int x = 1;
            //double y = 1.2;
            //string z = "Hung";
            //char a = '1';
            //bool b = true || false;
            //const char p = '1';
            //int[] n = { 1, 2, 3, 4 };
            //foreach (int temp in n)
            //{
            //    Console.WriteLine(temp);
            //}
            //Generic
            //static T Swap<T>(T a, T b)
            //{
            //    if (a != null && b != null)
            //    {
            //        return a;
            //    }
            //    return b;
            //}
            //LearnNamspace.XinChao();
            //Anonymous
            //new {name : "1123"}
            //Delegate 
            //Lambda
            //LinQ
            //int? age;
            //age = null;
            //if (age.HasValue)
            //{
            //    Console.WriteLine("Yes");
            //}
            //Virtual method, abstract class
            //ShowLog info = Info;
            //Action, Func :delegate
            //Action<string, int> action1; // 2 params => void
            //Func<int> f1; // delegate 1 param => void
            //info("123");
            //Action thongbao;
            //thongbao = () =>
            //{
            //    Console.WriteLine("Hello");
            //};
            //Func<int, int, int> f3;
            //f3 = (int a, int b) =>
            //{
            //    return a + b;
            //};
            //f3(1, 2);
            //thongbao?.Invoke();
            //List<int> ds1;
            // List
            /* 
            Count
            Add
            Insert(vitri, value)
            AddRange
            RemoveAt
            Remove
            FindAll
            FindIndex
            Indexof
            LastIndexOf
            Find
            Sort
            SortedList<key,value>
            //ArrayList
            Add
             */
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("key1", "value1");
            //hashtable.Add("key1", "value");
            //foreach(DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            /*
            HashTable
            Add(Key,Value)
            Remove(key)
            Contains()
            ContainsValue()
             */
            var brands = new List<Brand>() {
            new Brand{ID = 1, Name = "Công ty AAA"},
            new Brand{ID = 2, Name = "Công ty BBB"},
            new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };
            //LINQ
            /// Select
            /// SelectMany
            /// Where
            /// Min, Max, Sum, Average
            /// Join
            /// Group Join
            /// Take
            /// Skip
            /// OrderBy OrderByDescending
            /// Reverse
            /// GroupBy
            /// Distinct
            /// Single SingleOrDefault
            /// Any All
            /// Count ()
            //String
            /*
             Concat
             Length
             IndexOf
             Substring
             Replace
             ToUpper
             ToLower
             Trim
             */
        }
    }
}