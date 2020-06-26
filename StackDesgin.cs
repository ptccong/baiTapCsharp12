using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesginStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
    internal class stack : IEnumerable
    {
        private List<object> ds = new List<object>();
        private object _object;

        public IEnumerator GetEnumerator()
        {
            while (ds.Any())
            {
                yield return Pop();
            };
         
        }
        public object Pop()
        {
            if (ds.Count == 0)
            {
                throw new InvalidOperationException("loi");
               
            }
            _object = ds.FirstOrDefault();
            ds.RemoveAt(0);
            return _object;
        }
        public void Clear()
        {
            if (ds.Count == 0) throw new InvalidOperationException("loi");
            ds.Clear();

        }
        public void Push(object obj)
        {
            _object = obj;
            if (_object == null) throw new InvalidOperationException("Loi");

        }
        public void Show()
        {
            if (ds.Count==0) throw new InvalidOperationException("mang trong");
            foreach(int s in ds)
            {
                Console.WriteLine(s);
            }
        }
    }
}
