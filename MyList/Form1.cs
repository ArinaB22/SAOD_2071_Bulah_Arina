using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyList list = new MyList();

        private void butnPrepend_Click(object sender, EventArgs e)
        {
            list.Prepend(textBPrepend.Text);
            listBoxAdd();
        }
        public void listBoxAdd()
        {
            string[] arr = list.ToArray();
            listBox1.Items.Clear();

            foreach (string str in arr)
            {
                listBox1.Items.Add(str);
            }
        }
        private void butApp_Click(object sender, EventArgs e)
        {
            list.Append(textBAppend.Text);
            listBoxAdd();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void butAt_Click(object sender, EventArgs e)
        {
            tbAt.Clear();
            tbAt.Text = list.At((int)NudAt.Value);
        }

        private void butIndexOf_Click(object sender, EventArgs e)
        {
            //textB_index.Clear();
            int index = list.Find(textB_find.Text);
            textB_index.Text = index.ToString();
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            
            list.Remove(tb_remove.Text);
            listBoxAdd();
        }

        private void butRemoveAt_Click(object sender, EventArgs e)
        {
            list.RemoveAt((int)nud_removeAt.Value);
            listBoxAdd();
        }

        private void butInsrt_Click(object sender, EventArgs e)
        {
            list.Insert(tb_insert.Text, (int)nud_insert.Value);
            listBoxAdd();
        }
    }
}
