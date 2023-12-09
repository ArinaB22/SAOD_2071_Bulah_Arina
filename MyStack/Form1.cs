using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStack
{
    public partial class Stack : Form
    {
        MyStack<int> stack = new MyStack<int>(7);

        public Stack()
        {
            InitializeComponent();
            
        }

        private void printItems()
        {
            Top_elem.Text = "";
            Pop_elem.Text = "";

            Stack_array.Items.Clear();


            //int[] st = stack.Values();

            //for (int i = stack.Count - 1; i >= 0; i--) Stack_array.Items.Add(st[i]);

            foreach(int val in stack.Values())
            {
                Stack_array.Items.Add(val);
            }

            Capacity_value.Text = Convert.ToString(stack.Capacity);
            Count_value.Text = Convert.ToString(stack.Count);

            Push_elem.Text = "";
        }

        private void Push_button_Click(object sender, EventArgs e)
        {
              
            stack.Push(Convert.ToInt32(Push_elem.Text));
            printItems(); 
        }

        private void Pop_button_Click(object sender, EventArgs e)
        {
            
            int pop = stack.Pop();
            printItems();
            Pop_elem.Text = Convert.ToString(pop);
            
        }

        private void Top_button_Click(object sender, EventArgs e)
        {
            Pop_elem.Text = "";

            Top_elem.Text = Convert.ToString(stack.Top());

        }

        private void Count_value_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
