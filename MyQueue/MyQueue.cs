using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQueue
{
    internal class MyQueue<T>
    {
        
        public int counter;
        private int currentIn; //входящ эл-т
        private int currentOut; //элемент на выход
        T[] _arg;


        //public bool IsEmpty
        //{
        //    get { return size == 0; }
        //}
        public int size
        { get { return _arg.Length; } }

        public int Count
        { get { return counter; } }

        public void Size(int size)
        {
            _arg = new T[size];
            currentOut = 0;
            currentIn = 0;
        }


        public void Enqueue(T item) //добавление элемента на конец очереди
        {
            if (counter < size)
            {
                _arg[currentIn] = item;
                currentIn++;
                counter++;
            }
            else
            {
                MessageBox.Show("Очередь переполнена!");
            }
        }

        public T Dequeue() //получение первого элемента и удаление его из очереди
        {
            if (counter == 0)
                throw new Exception("Очередь пустая");

            if (currentOut == size)
            {
                T elem = _arg[currentOut];
                _arg[currentOut] = default;
                currentOut = 0;
                counter--;
                return elem;
            }

            else
            {
                T elem = _arg[currentOut];
                _arg[currentOut] = default;
                currentOut++;
                counter--;
                return elem;
            }
        }
        public T Peek() //просмотр первого элемента очереди на выход, без удаления элемента
        {
            if (counter == 0)
                throw new Exception("Очередь пустая");

            return _arg[currentOut];
        }

        public T[] ToArray()
        {
            int index = currentOut;
            T[] arr = new T[counter];
            for (int i = 0; i < counter; i++)
            {
                if (index > size)
                    index = 0;
                arr[i] = _arg[index];
                index++;
            }
            return arr;
        }
    }
}
