using MyNameSpace;
using System.Collections;
using System.Reflection;

namespace Review
{
    public delegate void ShowLog(string message);
    internal class Program
    {
        
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
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
            //var brands = new List<Brand>() {
            //new Brand{ID = 1, Name = "Công ty AAA"},
            //new Brand{ID = 2, Name = "Công ty BBB"},
            //new Brand{ID = 4, Name = "Công ty CCC"},
            //};

            //var products = new List<Product>()
            //{
            //    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
            //    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
            //    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
            //    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
            //    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
            //    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
            //    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            //};
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
            //1 Get All product price 400
            //IEnumerable<Product> products400 = from product in products where product.Price == 400 select product;
            //foreach(var product in products400)
            //{
            //    Console.WriteLine(product.Name + " " + product.Price);
            //}
            //Console.WriteLine(products400?.ToList().Count);
            //2 Return Product with name is TR
            //var productWithTRName = products.Where((p)=>p.Name.StartsWith("Tr"));
            //foreach(var p in productWithTRName)
            //{
            //    Console.WriteLine(p.Name + " " + p.Price);
            //}
            ////3 Select product with brand
            //var kq = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
            //{
            //    return new
            //    {
            //        Name = p.Name,
            //        Price = p.Price,
            //        brand = b.Name
            //    };
            //});
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
            /*
             Type 
             GetType();
             */
            User user = new User()
            {
                Name = "Hung Tran",
                Age = 21,
                Email="trankyhung225@gmail.com",
                PhoneNumber="0936911140"
            };
            var properties = user.GetType().GetProperties();
            var methods = user.GetType().GetMethods();
          
            foreach(PropertyInfo property in properties)
            {
                var name = property.Name;
                var value = property.GetValue(user);
                Console.WriteLine(name + " " + value);
            };
        }
    }
}