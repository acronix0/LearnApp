using LearnApp.Collections.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Collections.Enumerable
{
    public class ProductCollection : IEnumerable<Product>
    {
        private  List<Product> _products;

        public ProductCollection()
        {
            _products = new List<Product>();
        }

        public void Add(Product product)=>
            _products.Add(product);

        public IEnumerator<Product> GetEnumerator() =>
            new ProductEnumerator(_products);

        //реализация обобщенного интерфейса для обеспечения совместимости
        IEnumerator IEnumerable.GetEnumerator()=>
            GetEnumerator();
    }
}
