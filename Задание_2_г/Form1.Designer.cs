namespace Задание_2_г
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Alabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.Hlabel = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.NumericUpDown();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.H = new System.Windows.Forms.NumericUpDown();
            this.Rashbutton = new System.Windows.Forms.Button();
            this.Ot = new System.Windows.Forms.RichTextBox();
            this.FunpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alabel.Location = new System.Drawing.Point(12, 9);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(335, 28);
            this.Alabel.TabIndex = 0;
            this.Alabel.Text = "Начальное значение числа x";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blabel.Location = new System.Drawing.Point(12, 46);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(323, 28);
            this.Blabel.TabIndex = 1;
            this.Blabel.Text = "Конечное значение числа x";
            // 
            // Hlabel
            // 
            this.Hlabel.AutoSize = true;
            this.Hlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hlabel.Location = new System.Drawing.Point(12, 87);
            this.Hlabel.Name = "Hlabel";
            this.Hlabel.Size = new System.Drawing.Size(62, 28);
            this.Hlabel.TabIndex = 2;
            this.Hlabel.Text = "Шаг";
            // 
            // A
            // 
            this.A.DecimalPlaces = 5;
            this.A.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(372, 7);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(120, 36);
            this.A.TabIndex = 3;
            this.A.ValueChanged += new System.EventHandler(this.A_ValueChanged);
            // 
            // B
            // 
            this.B.DecimalPlaces = 5;
            this.B.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(372, 44);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(120, 36);
            this.B.TabIndex = 4;
            // 
            // H
            // 
            this.H.DecimalPlaces = 5;
            this.H.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.H.Location = new System.Drawing.Point(372, 85);
            this.H.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(120, 36);
            this.H.TabIndex = 5;
            this.H.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Rashbutton
            // 
            this.Rashbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rashbutton.Location = new System.Drawing.Point(317, 183);
            this.Rashbutton.Name = "Rashbutton";
            this.Rashbutton.Size = new System.Drawing.Size(175, 43);
            this.Rashbutton.TabIndex = 6;
            this.Rashbutton.Text = "Рассчитать";
            this.Rashbutton.UseVisualStyleBackColor = true;
            this.Rashbutton.Click += new System.EventHandler(this.Rashbutton_Click);
            // 
            // Ot
            // 
            this.Ot.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ot.Location = new System.Drawing.Point(26, 232);
            this.Ot.Name = "Ot";
            this.Ot.ReadOnly = true;
            this.Ot.Size = new System.Drawing.Size(754, 175);
            this.Ot.TabIndex = 7;
            this.Ot.Text = "";
            // 
            // FunpictureBox
            // 
            this.FunpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FunpictureBox.Image")));
            this.FunpictureBox.Location = new System.Drawing.Point(498, 9);
            this.FunpictureBox.Name = "FunpictureBox";
            this.FunpictureBox.Size = new System.Drawing.Size(285, 181);
            this.FunpictureBox.TabIndex = 8;
            this.FunpictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 432);
            this.Controls.Add(this.FunpictureBox);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Rashbutton);
            this.Controls.Add(this.H);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Hlabel);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Alabel);
            this.Name = "Form1";
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.Label Hlabel;
        private System.Windows.Forms.NumericUpDown A;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.NumericUpDown H;
        private System.Windows.Forms.Button Rashbutton;
        private System.Windows.Forms.RichTextBox Ot;
        private System.Windows.Forms.PictureBox FunpictureBox;
    }
}

