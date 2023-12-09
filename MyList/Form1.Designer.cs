namespace MyList
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
            this.butnPrepend = new System.Windows.Forms.Button();
            this.butApp = new System.Windows.Forms.Button();
            this.butAt = new System.Windows.Forms.Button();
            this.butInsrt = new System.Windows.Forms.Button();
            this.butRemoveAt = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.butfind = new System.Windows.Forms.Button();
            this.nud_insert = new System.Windows.Forms.NumericUpDown();
            this.NudAt = new System.Windows.Forms.NumericUpDown();
            this.tbAt = new System.Windows.Forms.TextBox();
            this.tb_insert = new System.Windows.Forms.TextBox();
            this.textBAppend = new System.Windows.Forms.TextBox();
            this.textBPrepend = new System.Windows.Forms.TextBox();
            this.tb_remove = new System.Windows.Forms.TextBox();
            this.textB_find = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_removeAt = new System.Windows.Forms.NumericUpDown();
            this.textB_index = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_insert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_removeAt)).BeginInit();
            this.SuspendLayout();
            // 
            // butnPrepend
            // 
            this.butnPrepend.Location = new System.Drawing.Point(59, 84);
            this.butnPrepend.Name = "butnPrepend";
            this.butnPrepend.Size = new System.Drawing.Size(135, 44);
            this.butnPrepend.TabIndex = 0;
            this.butnPrepend.Text = "Prepend";
            this.butnPrepend.UseVisualStyleBackColor = true;
            this.butnPrepend.Click += new System.EventHandler(this.butnPrepend_Click);
            // 
            // butApp
            // 
            this.butApp.Location = new System.Drawing.Point(59, 150);
            this.butApp.Name = "butApp";
            this.butApp.Size = new System.Drawing.Size(135, 44);
            this.butApp.TabIndex = 1;
            this.butApp.Text = "Append";
            this.butApp.UseVisualStyleBackColor = true;
            this.butApp.Click += new System.EventHandler(this.butApp_Click);
            // 
            // butAt
            // 
            this.butAt.Location = new System.Drawing.Point(59, 290);
            this.butAt.Name = "butAt";
            this.butAt.Size = new System.Drawing.Size(135, 44);
            this.butAt.TabIndex = 3;
            this.butAt.Text = "At";
            this.butAt.UseVisualStyleBackColor = true;
            this.butAt.Click += new System.EventHandler(this.butAt_Click);
            // 
            // butInsrt
            // 
            this.butInsrt.Location = new System.Drawing.Point(59, 224);
            this.butInsrt.Name = "butInsrt";
            this.butInsrt.Size = new System.Drawing.Size(135, 44);
            this.butInsrt.TabIndex = 2;
            this.butInsrt.Text = "Insert";
            this.butInsrt.UseVisualStyleBackColor = true;
            this.butInsrt.Click += new System.EventHandler(this.butInsrt_Click);
            // 
            // butRemoveAt
            // 
            this.butRemoveAt.Location = new System.Drawing.Point(59, 504);
            this.butRemoveAt.Name = "butRemoveAt";
            this.butRemoveAt.Size = new System.Drawing.Size(135, 44);
            this.butRemoveAt.TabIndex = 6;
            this.butRemoveAt.Text = "Remove At";
            this.butRemoveAt.UseVisualStyleBackColor = true;
            this.butRemoveAt.Click += new System.EventHandler(this.butRemoveAt_Click);
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(59, 430);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(135, 44);
            this.butRemove.TabIndex = 5;
            this.butRemove.Text = "Remove value";
            this.butRemove.UseVisualStyleBackColor = true;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // butfind
            // 
            this.butfind.Location = new System.Drawing.Point(59, 364);
            this.butfind.Name = "butfind";
            this.butfind.Size = new System.Drawing.Size(135, 44);
            this.butfind.TabIndex = 4;
            this.butfind.Text = "Find";
            this.butfind.UseVisualStyleBackColor = true;
            this.butfind.Click += new System.EventHandler(this.butIndexOf_Click);
            // 
            // nud_insert
            // 
            this.nud_insert.Location = new System.Drawing.Point(226, 235);
            this.nud_insert.Name = "nud_insert";
            this.nud_insert.Size = new System.Drawing.Size(104, 26);
            this.nud_insert.TabIndex = 8;
            // 
            // NudAt
            // 
            this.NudAt.Location = new System.Drawing.Point(226, 300);
            this.NudAt.Name = "NudAt";
            this.NudAt.Size = new System.Drawing.Size(104, 26);
            this.NudAt.TabIndex = 9;
            this.NudAt.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // tbAt
            // 
            this.tbAt.Location = new System.Drawing.Point(360, 300);
            this.tbAt.Name = "tbAt";
            this.tbAt.Size = new System.Drawing.Size(100, 26);
            this.tbAt.TabIndex = 10;
            // 
            // tb_insert
            // 
            this.tb_insert.Location = new System.Drawing.Point(360, 235);
            this.tb_insert.Name = "tb_insert";
            this.tb_insert.Size = new System.Drawing.Size(100, 26);
            this.tb_insert.TabIndex = 11;
            // 
            // textBAppend
            // 
            this.textBAppend.Location = new System.Drawing.Point(226, 159);
            this.textBAppend.Name = "textBAppend";
            this.textBAppend.Size = new System.Drawing.Size(100, 26);
            this.textBAppend.TabIndex = 12;
            // 
            // textBPrepend
            // 
            this.textBPrepend.Location = new System.Drawing.Point(226, 93);
            this.textBPrepend.Name = "textBPrepend";
            this.textBPrepend.Size = new System.Drawing.Size(100, 26);
            this.textBPrepend.TabIndex = 13;
            // 
            // tb_remove
            // 
            this.tb_remove.Location = new System.Drawing.Point(226, 439);
            this.tb_remove.Name = "tb_remove";
            this.tb_remove.Size = new System.Drawing.Size(100, 26);
            this.tb_remove.TabIndex = 15;
            // 
            // textB_find
            // 
            this.textB_find.Location = new System.Drawing.Point(226, 372);
            this.textB_find.Name = "textB_find";
            this.textB_find.Size = new System.Drawing.Size(100, 26);
            this.textB_find.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(524, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(454, 524);
            this.listBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 19;
            // 
            // nud_removeAt
            // 
            this.nud_removeAt.Location = new System.Drawing.Point(226, 513);
            this.nud_removeAt.Name = "nud_removeAt";
            this.nud_removeAt.Size = new System.Drawing.Size(104, 26);
            this.nud_removeAt.TabIndex = 20;
            // 
            // textB_index
            // 
            this.textB_index.Location = new System.Drawing.Point(360, 372);
            this.textB_index.Name = "textB_index";
            this.textB_index.Size = new System.Drawing.Size(100, 26);
            this.textB_index.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 623);
            this.Controls.Add(this.textB_index);
            this.Controls.Add(this.nud_removeAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textB_find);
            this.Controls.Add(this.tb_remove);
            this.Controls.Add(this.textBPrepend);
            this.Controls.Add(this.textBAppend);
            this.Controls.Add(this.tb_insert);
            this.Controls.Add(this.tbAt);
            this.Controls.Add(this.NudAt);
            this.Controls.Add(this.nud_insert);
            this.Controls.Add(this.butRemoveAt);
            this.Controls.Add(this.butRemove);
            this.Controls.Add(this.butfind);
            this.Controls.Add(this.butAt);
            this.Controls.Add(this.butInsrt);
            this.Controls.Add(this.butApp);
            this.Controls.Add(this.butnPrepend);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_insert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_removeAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butnPrepend;
        private System.Windows.Forms.Button butApp;
        private System.Windows.Forms.Button butAt;
        private System.Windows.Forms.Button butInsrt;
        private System.Windows.Forms.Button butRemoveAt;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butfind;
        private System.Windows.Forms.NumericUpDown nud_insert;
        private System.Windows.Forms.NumericUpDown NudAt;
        private System.Windows.Forms.TextBox tbAt;
        private System.Windows.Forms.TextBox tb_insert;
        private System.Windows.Forms.TextBox textBAppend;
        private System.Windows.Forms.TextBox textBPrepend;
        private System.Windows.Forms.TextBox tb_remove;
        private System.Windows.Forms.TextBox textB_find;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_removeAt;
        private System.Windows.Forms.TextBox textB_index;
    }
}

