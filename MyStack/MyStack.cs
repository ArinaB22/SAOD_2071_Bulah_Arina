using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyStack<T>
    {
        private T[] array;
        private int count;

        public MyStack(int length)
        {
            array = new T[length];
            count = 0;
        }

        public bool IsEmpty => count == 0; 

        public int Count => count;

        public int Capacity => array.Length;

        public void Push(T x)
        {
            if (count >= array.Length) 
                throw new Exception("Stack overflow");

            array[count++] = x;
        }

        public T Pop()
        {
            if (IsEmpty) 
                throw new Exception("Stack is empty");
            count--;
            return array[count];
        }

        public T Top()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");

            return array[count-1];
        }

        public T[] Values()
        {
            int index = 0;
            T[] array_ = new T[count];
            for (int i = count-1; i >= 0; i--)
            {
                array_[i] = array[index];
                index++;
            }
            return array_ ;
        }
    }
}
