namespace MyQueue
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butt_capasity = new System.Windows.Forms.Button();
            this.tbox_capasity = new System.Windows.Forms.TextBox();
            this.tbox_Peek = new System.Windows.Forms.TextBox();
            this.butt_Peek = new System.Windows.Forms.Button();
            this.tbox_Dequeue = new System.Windows.Forms.TextBox();
            this.butt_Dequeue = new System.Windows.Forms.Button();
            this.tbox_Enqueue = new System.Windows.Forms.TextBox();
            this.butt_Enqueue = new System.Windows.Forms.Button();
            this.lb_count = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // butt_capasity
            // 
            this.butt_capasity.Location = new System.Drawing.Point(378, 42);
            this.butt_capasity.Name = "butt_capasity";
            this.butt_capasity.Size = new System.Drawing.Size(230, 38);
            this.butt_capasity.TabIndex = 1;
            this.butt_capasity.Text = "Задать размер очереди";
            this.butt_capasity.UseVisualStyleBackColor = true;
            this.butt_capasity.Click += new System.EventHandler(this.butt_capasity_Click);
            // 
            // tbox_capasity
            // 
            this.tbox_capasity.Location = new System.Drawing.Point(243, 48);
            this.tbox_capasity.Name = "tbox_capasity";
            this.tbox_capasity.Size = new System.Drawing.Size(100, 26);
            this.tbox_capasity.TabIndex = 2;
            // 
            // tbox_Peek
            // 
            this.tbox_Peek.Location = new System.Drawing.Point(106, 211);
            this.tbox_Peek.Name = "tbox_Peek";
            this.tbox_Peek.Size = new System.Drawing.Size(100, 26);
            this.tbox_Peek.TabIndex = 4;
            // 
            // butt_Peek
            // 
            this.butt_Peek.Location = new System.Drawing.Point(252, 205);
            this.butt_Peek.Name = "butt_Peek";
            this.butt_Peek.Size = new System.Drawing.Size(122, 38);
            this.butt_Peek.TabIndex = 3;
            this.butt_Peek.Text = "Peek";
            this.butt_Peek.UseVisualStyleBackColor = true;
            this.butt_Peek.Click += new System.EventHandler(this.butt_Peek_Click);
            // 
            // tbox_Dequeue
            // 
            this.tbox_Dequeue.Location = new System.Drawing.Point(106, 280);
            this.tbox_Dequeue.Name = "tbox_Dequeue";
            this.tbox_Dequeue.Size = new System.Drawing.Size(100, 26);
            this.tbox_Dequeue.TabIndex = 6;
            // 
            // butt_Dequeue
            // 
            this.butt_Dequeue.Location = new System.Drawing.Point(252, 274);
            this.butt_Dequeue.Name = "butt_Dequeue";
            this.butt_Dequeue.Size = new System.Drawing.Size(122, 38);
            this.butt_Dequeue.TabIndex = 5;
            this.butt_Dequeue.Text = "Dequeue";
            this.butt_Dequeue.UseVisualStyleBackColor = true;
            this.butt_Dequeue.Click += new System.EventHandler(this.butt_Dequeue_Click);
            // 
            // tbox_Enqueue
            // 
            this.tbox_Enqueue.Location = new System.Drawing.Point(106, 140);
            this.tbox_Enqueue.Name = "tbox_Enqueue";
            this.tbox_Enqueue.Size = new System.Drawing.Size(100, 26);
            this.tbox_Enqueue.TabIndex = 8;
            // 
            // butt_Enqueue
            // 
            this.butt_Enqueue.Location = new System.Drawing.Point(252, 134);
            this.butt_Enqueue.Name = "butt_Enqueue";
            this.butt_Enqueue.Size = new System.Drawing.Size(122, 38);
            this.butt_Enqueue.TabIndex = 7;
            this.butt_Enqueue.Text = "Enqueue";
            this.butt_Enqueue.UseVisualStyleBackColor = true;
            this.butt_Enqueue.Click += new System.EventHandler(this.butt_Enqueue_Click);
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(313, 361);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(0, 20);
            this.lb_count.TabIndex = 10;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(484, 120);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(331, 244);
            this.listBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 470);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.tbox_Enqueue);
            this.Controls.Add(this.butt_Enqueue);
            this.Controls.Add(this.tbox_Dequeue);
            this.Controls.Add(this.butt_Dequeue);
            this.Controls.Add(this.tbox_Peek);
            this.Controls.Add(this.butt_Peek);
            this.Controls.Add(this.tbox_capasity);
            this.Controls.Add(this.butt_capasity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butt_capasity;
        private System.Windows.Forms.TextBox tbox_capasity;
        private System.Windows.Forms.TextBox tbox_Peek;
        private System.Windows.Forms.Button butt_Peek;
        private System.Windows.Forms.TextBox tbox_Dequeue;
        private System.Windows.Forms.Button butt_Dequeue;
        private System.Windows.Forms.TextBox tbox_Enqueue;
        private System.Windows.Forms.Button butt_Enqueue;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.ListBox listBox;
    }
}

