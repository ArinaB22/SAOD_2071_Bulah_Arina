namespace MyStack
{
    partial class Stack
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
            this.Push_button = new System.Windows.Forms.Button();
            this.Push_elem = new System.Windows.Forms.TextBox();
            this.Pop_elem = new System.Windows.Forms.TextBox();
            this.Pop_button = new System.Windows.Forms.Button();
            this.Top_elem = new System.Windows.Forms.TextBox();
            this.Top_button = new System.Windows.Forms.Button();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Capacity_value = new System.Windows.Forms.TextBox();
            this.Count_value = new System.Windows.Forms.TextBox();
            this.Stack_array = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Push_button
            // 
            this.Push_button.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Push_button.Location = new System.Drawing.Point(281, 104);
            this.Push_button.Name = "Push_button";
            this.Push_button.Size = new System.Drawing.Size(165, 60);
            this.Push_button.TabIndex = 0;
            this.Push_button.TabStop = false;
            this.Push_button.Text = "Добавление";
            this.Push_button.UseVisualStyleBackColor = true;
            this.Push_button.Click += new System.EventHandler(this.Push_button_Click);
            // 
            // Push_elem
            // 
            this.Push_elem.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Push_elem.Location = new System.Drawing.Point(135, 104);
            this.Push_elem.Multiline = true;
            this.Push_elem.Name = "Push_elem";
            this.Push_elem.Size = new System.Drawing.Size(69, 60);
            this.Push_elem.TabIndex = 3;
            this.Push_elem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pop_elem
            // 
            this.Pop_elem.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pop_elem.Location = new System.Drawing.Point(135, 258);
            this.Pop_elem.Multiline = true;
            this.Pop_elem.Name = "Pop_elem";
            this.Pop_elem.Size = new System.Drawing.Size(69, 60);
            this.Pop_elem.TabIndex = 5;
            this.Pop_elem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pop_button
            // 
            this.Pop_button.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pop_button.Location = new System.Drawing.Point(281, 258);
            this.Pop_button.Name = "Pop_button";
            this.Pop_button.Size = new System.Drawing.Size(165, 60);
            this.Pop_button.TabIndex = 4;
            this.Pop_button.TabStop = false;
            this.Pop_button.Text = "Удаление";
            this.Pop_button.UseVisualStyleBackColor = true;
            this.Pop_button.Click += new System.EventHandler(this.Pop_button_Click);
            // 
            // Top_elem
            // 
            this.Top_elem.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_elem.Location = new System.Drawing.Point(135, 411);
            this.Top_elem.Multiline = true;
            this.Top_elem.Name = "Top_elem";
            this.Top_elem.Size = new System.Drawing.Size(69, 73);
            this.Top_elem.TabIndex = 7;
            this.Top_elem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Top_button
            // 
            this.Top_button.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_button.Location = new System.Drawing.Point(281, 411);
            this.Top_button.Name = "Top_button";
            this.Top_button.Size = new System.Drawing.Size(165, 73);
            this.Top_button.TabIndex = 6;
            this.Top_button.TabStop = false;
            this.Top_button.Text = "Последний элемент";
            this.Top_button.UseVisualStyleBackColor = true;
            this.Top_button.Click += new System.EventHandler(this.Top_button_Click);
            // 
            // Capacity
            // 
            this.Capacity.BackColor = System.Drawing.SystemColors.Control;
            this.Capacity.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capacity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Capacity.Location = new System.Drawing.Point(135, 611);
            this.Capacity.Multiline = true;
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(179, 70);
            this.Capacity.TabIndex = 8;
            this.Capacity.Text = "Вместимость стека";
            this.Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.SystemColors.Control;
            this.Count.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Count.Location = new System.Drawing.Point(583, 611);
            this.Count.Multiline = true;
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(217, 70);
            this.Count.TabIndex = 9;
            this.Count.Text = "Сейчас элементов в стеке";
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Capacity_value
            // 
            this.Capacity_value.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capacity_value.Location = new System.Drawing.Point(357, 608);
            this.Capacity_value.Multiline = true;
            this.Capacity_value.Name = "Capacity_value";
            this.Capacity_value.Size = new System.Drawing.Size(69, 73);
            this.Capacity_value.TabIndex = 10;
            this.Capacity_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Count_value
            // 
            this.Count_value.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_value.Location = new System.Drawing.Point(863, 608);
            this.Count_value.Multiline = true;
            this.Count_value.Name = "Count_value";
            this.Count_value.Size = new System.Drawing.Size(69, 73);
            this.Count_value.TabIndex = 11;
            this.Count_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Count_value.TextChanged += new System.EventHandler(this.Count_value_TextChanged);
            // 
            // Stack_array
            // 
            this.Stack_array.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stack_array.FormattingEnabled = true;
            this.Stack_array.ItemHeight = 29;
            this.Stack_array.Location = new System.Drawing.Point(551, 103);
            this.Stack_array.Name = "Stack_array";
            this.Stack_array.Size = new System.Drawing.Size(397, 381);
            this.Stack_array.TabIndex = 12;
            // 
            // Stack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1038, 794);
            this.Controls.Add(this.Stack_array);
            this.Controls.Add(this.Count_value);
            this.Controls.Add(this.Capacity_value);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.Top_elem);
            this.Controls.Add(this.Top_button);
            this.Controls.Add(this.Pop_elem);
            this.Controls.Add(this.Pop_button);
            this.Controls.Add(this.Push_elem);
            this.Controls.Add(this.Push_button);
            this.Name = "Stack";
            this.Text = "Stack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Push_button;
        private System.Windows.Forms.TextBox Push_elem;
        private System.Windows.Forms.TextBox Pop_elem;
        private System.Windows.Forms.Button Pop_button;
        private System.Windows.Forms.TextBox Top_elem;
        private System.Windows.Forms.Button Top_button;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Capacity_value;
        private System.Windows.Forms.TextBox Count_value;
        private System.Windows.Forms.ListBox Stack_array;
    }
}

