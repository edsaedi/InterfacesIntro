using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace InterfacesIntro
{
    internal interface IJumpable
    {
        void Jump(int height);
    }

    internal class A : IJumpable
    {
        public int Value;

        public void Jump(int height)
        {
            throw new NotImplementedException();
        }
    }

    internal class B<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){ 1, 2, 3 };
            B<int> other = new B<int>();
            

            if(numbers.SequenceEqual(other))
            {
                ;
            }
            else
            {
                ;
            }



        }
    }
}
