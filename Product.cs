using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class Product
    {
        protected double Price { get; set; }
        public virtual void ProductInfo()
        {
            Console.Write(Price.ToString());
        }
    }
    public class Iphone : Product
    {
        public override void ProductInfo()
        {
            Console.WriteLine("Hello");
            base.ProductInfo(); 
        }
        public void ABC() => Console.WriteLine("Hello");
    }
}
