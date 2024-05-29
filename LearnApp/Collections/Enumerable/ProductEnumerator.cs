using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LearnApp.Collections.Data;
namespace LearnApp.Collections.Enumerable
{
    public class ProductEnumerator : IEnumerator<Product>
    {
        private List<Product> _products;
        private int _position = -1;

        public ProductEnumerator(List<Product> products)
        {
            _products = products;
        }

        public Product Current
        {
            get
            {   //foreach сперва вызывает MoveNext поэтому индекс не может быть -1
                if (_position < 0  || _position >= _products.Count)
                    throw new ArgumentException();
                return _products[_position];
            }
        }
        
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _products.Count;
        }

        public void Reset()=> _position = -1;
        public void Dispose() { }
    }
}
