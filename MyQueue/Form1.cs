using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        MyQueue<int> queue = new MyQueue<int>();

        
        private void butt_Enqueue_Click(object sender, EventArgs e)
        {
            
            queue.Enqueue(Convert.ToInt32(tbox_Enqueue.Text));
            listBoxAdd();
        }
        public void listBoxAdd()
        {


            listBox.Items.Clear();
            int[] arr = queue.ToArray();

            foreach (int items in arr)
            {
                listBox.Items.Add(items);
            }
        }

        private void butt_capasity_Click(object sender, EventArgs e)
        {
            queue.Size(Convert.ToInt32(tbox_capasity.Text));
        }

        private void butt_Dequeue_Click(object sender, EventArgs e)
        {
            
            tbox_Dequeue.Text = Convert.ToString(queue.Dequeue());
            listBoxAdd();

        }

        private void butt_Peek_Click(object sender, EventArgs e)
        {
            
            tbox_Peek.Text = Convert.ToString(queue.Peek());
            listBoxAdd();

        }
    }
}
