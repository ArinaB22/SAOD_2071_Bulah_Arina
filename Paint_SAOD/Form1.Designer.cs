namespace Paint_SAOD
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Value_X = new System.Windows.Forms.TextBox();
            this.Value_Y = new System.Windows.Forms.TextBox();
            this.Value_R = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Value_Y_Rec = new System.Windows.Forms.TextBox();
            this.Value_X_Rec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Value_Height = new System.Windows.Forms.TextBox();
            this.Value_Width = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "круг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 126);
            this.button2.TabIndex = 4;
            this.button2.Text = "квадрат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Value_X
            // 
            this.Value_X.Location = new System.Drawing.Point(133, 479);
            this.Value_X.Name = "Value_X";
            this.Value_X.Size = new System.Drawing.Size(100, 26);
            this.Value_X.TabIndex = 5;
            // 
            // Value_Y
            // 
            this.Value_Y.Location = new System.Drawing.Point(133, 526);
            this.Value_Y.Name = "Value_Y";
            this.Value_Y.Size = new System.Drawing.Size(100, 26);
            this.Value_Y.TabIndex = 6;
            // 
            // Value_R
            // 
            this.Value_R.Location = new System.Drawing.Point(133, 574);
            this.Value_R.Name = "Value_R";
            this.Value_R.Size = new System.Drawing.Size(100, 26);
            this.Value_R.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Введите X";
            // 
            // Value_Y_Rec
            // 
            this.Value_Y_Rec.Location = new System.Drawing.Point(626, 496);
            this.Value_Y_Rec.Name = "Value_Y_Rec";
            this.Value_Y_Rec.Size = new System.Drawing.Size(100, 26);
            this.Value_Y_Rec.TabIndex = 12;
            // 
            // Value_X_Rec
            // 
            this.Value_X_Rec.Location = new System.Drawing.Point(626, 449);
            this.Value_X_Rec.Name = "Value_X_Rec";
            this.Value_X_Rec.Size = new System.Drawing.Size(100, 26);
            this.Value_X_Rec.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите длину";
            // 
            // Value_Height
            // 
            this.Value_Height.Location = new System.Drawing.Point(627, 544);
            this.Value_Height.Name = "Value_Height";
            this.Value_Height.Size = new System.Drawing.Size(100, 26);
            this.Value_Height.TabIndex = 16;
            // 
            // Value_Width
            // 
            this.Value_Width.Location = new System.Drawing.Point(626, 587);
            this.Value_Width.Name = "Value_Width";
            this.Value_Width.Size = new System.Drawing.Size(100, 26);
            this.Value_Width.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Введите ширину";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 676);
            this.Controls.Add(this.Value_Width);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Value_Height);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Value_Y_Rec);
            this.Controls.Add(this.Value_X_Rec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Value_R);
            this.Controls.Add(this.Value_Y);
            this.Controls.Add(this.Value_X);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Value_X;
        private System.Windows.Forms.TextBox Value_Y;
        private System.Windows.Forms.TextBox Value_R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Value_Y_Rec;
        private System.Windows.Forms.TextBox Value_X_Rec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Value_Height;
        private System.Windows.Forms.TextBox Value_Width;
        private System.Windows.Forms.Label label7;
    }
}

