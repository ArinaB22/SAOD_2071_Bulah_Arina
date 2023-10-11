using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_SAOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MyFigure> figurlist = new List<MyFigure>();
        private void button1_Click(object sender, EventArgs e)
        {
            MyCircle cir = new MyCircle(Convert.ToInt32(Value_X.Text), Convert.ToInt32(Value_Y.Text), Convert.ToInt32(Value_R.Text));
            figurlist.Add(cir);
            Graphics g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            foreach (MyFigure c in figurlist)
            {
                c.Draw(g);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyRectangle rec = new MyRectangle(Convert.ToInt32(Value_X_Rec.Text), Convert.ToInt32(Value_Y_Rec.Text), Convert.ToInt32(Value_Height.Text), Convert.ToInt32(Value_Height.Text));
            figurlist.Add(rec);
            Graphics g = this.CreateGraphics();
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            e.x
            e.y
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
