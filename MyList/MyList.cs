using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyList
{
    internal class MyList
    {
        public ListNode first;
        public ListNode last;
        public int counter = 0;

        public string this[int index] 
        {
            get{ return At(index); }
            set { setValue(index, value) ; }
        }
           
        public int lenght
        {
            get { return counter; }
        }

        public void Prepend(string val) //добавляет элемент в начало списка
        {
            ListNode node = new ListNode(); //создали элемент
            node.val = val; //положили в него значение

            if (first == null)
            { 
                first = node; 
                last = node;
                counter ++;
            }
            else
            {
                node.next = first;
                first.prev = node;
                first = node;
                counter ++;
            }
            

        }

        public void setValue(int index, string value) //по индексу меняет значение какому то элементу
        {
            ListNode current = first;
            if (index < 0 || index >= lenght)
                return;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            current.val = value;
        
        }

        public void Append(string val) //добавляет элемент в конец списка
        {
            ListNode node = new ListNode(); //создали элемент
            node.val = val; //положили в него значение

            if (first == null)
            {
                first = node;
                last = node;
            }
            else
            {
                node.prev = last;
                last.next = node;
                last = node;
            }
            counter++;
        }

        public void Insert(string val, int index) //int что добавляем, int куда добавляем
        {
            ListNode node = new ListNode();
            node.val = val;

            if (index < 0 || index >= lenght)
                return;

            if (counter == 0)
            {
                first = node;
                last = node;
                counter++;
            }
            if (index == 0)
            {
                Prepend(val);
            }
            else if (index == lenght)
            {
                Append(val);
            }
            else
            {
                ListNode current = first;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }
                node.prev = current;
                node.next = current.next;
                current.next.prev = node;
                current.next = node;
                counter++;
            }
            
        }

        public string At(int index) 
        {
            ListNode node = new ListNode(); //создали элемент
            ListNode current = first;
            int i = 0;
            if (index < 0 || index >= lenght)
                return "";

            while (i < index)
            {
                current = current.next;
                i++;
            }
            return current.val;
        }

        public int Find(string val) //находит индекс элемента
        {
            ListNode node = new ListNode();
            node.val = val;
            ListNode current = first;
            int i = 0;
            while (current.val != val)
            {
                current = current.next;
                i++;
            }
            return i;
        }

        public void Remove(string val) //удаление 
        {
            ListNode curr = first;
            while (curr.val != val)
            {
                curr = curr.next;
            }
            if (first == last)
            {
                first = null;
                last = null;
                counter = 0;
                return;
            }
            if (curr == first)
            {
                first = first.next;
                first.prev = null;
                counter--;
                return;
            }
            if (curr == last)
            {
                last = last.prev;
                last.next = null;
                counter--;
                return;
            }
            else
            {
                curr.prev.next = curr.next;
                curr.next.prev = curr.prev;
                counter--;
                return;
            }
        }
       
        public void RemoveAt(int index) //удаление по индексу
        {
            ListNode node = first;
            int choosenIndex = 0;

            if (index < 0 || index >= lenght)
                return;

            while (node.next != null && choosenIndex < index)
            {
                node = node.next;
                choosenIndex++;

            }

            if (index == 0)
            {
                if (counter == 1) first = null;
                else first = node.next;
            }

            else if (node.prev != null) node.prev.next = node.next;

            else if (node.next != null) node.prev.next = node.prev;

            counter--;
        }

        public string[] ToArray()
        {
            string[] arr = new string[counter];
            ListNode current = first;
            
            int i = 0;

            while (current != null)
            {
                arr[i] = current.val;
                i++;
                current = current.next;
            }        

            return arr ;
        }


        
    }
}
