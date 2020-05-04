namespace Задание_1_г
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
            this.Xlabel = new System.Windows.Forms.Label();
            this.Ylable = new System.Windows.Forms.Label();
            this.Zlable = new System.Windows.Forms.Label();
            this.Vlabel = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.Y = new System.Windows.Forms.NumericUpDown();
            this.Z = new System.Windows.Forms.NumericUpDown();
            this.V = new System.Windows.Forms.NumericUpDown();
            this.Otlabel = new System.Windows.Forms.Label();
            this.Ot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V)).BeginInit();
            this.SuspendLayout();
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xlabel.Location = new System.Drawing.Point(32, 31);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(100, 28);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "Число x";
            // 
            // Ylable
            // 
            this.Ylable.AutoSize = true;
            this.Ylable.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ylable.Location = new System.Drawing.Point(32, 74);
            this.Ylable.Name = "Ylable";
            this.Ylable.Size = new System.Drawing.Size(101, 28);
            this.Ylable.TabIndex = 1;
            this.Ylable.Text = "Число y";
            // 
            // Zlable
            // 
            this.Zlable.AutoSize = true;
            this.Zlable.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zlable.Location = new System.Drawing.Point(32, 115);
            this.Zlable.Name = "Zlable";
            this.Zlable.Size = new System.Drawing.Size(100, 28);
            this.Zlable.TabIndex = 2;
            this.Zlable.Text = "Число z";
            // 
            // Vlabel
            // 
            this.Vlabel.AutoSize = true;
            this.Vlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vlabel.Location = new System.Drawing.Point(32, 157);
            this.Vlabel.Name = "Vlabel";
            this.Vlabel.Size = new System.Drawing.Size(102, 28);
            this.Vlabel.TabIndex = 3;
            this.Vlabel.Text = "Число v";
            // 
            // X
            // 
            this.X.DecimalPlaces = 5;
            this.X.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(187, 29);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(120, 36);
            this.X.TabIndex = 4;
            this.X.ValueChanged += new System.EventHandler(this.XandYandZandV_ValueChanged);
            // 
            // Y
            // 
            this.Y.DecimalPlaces = 5;
            this.Y.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(187, 71);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(120, 36);
            this.Y.TabIndex = 5;
            this.Y.ValueChanged += new System.EventHandler(this.XandYandZandV_ValueChanged);
            // 
            // Z
            // 
            this.Z.DecimalPlaces = 5;
            this.Z.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.Location = new System.Drawing.Point(187, 113);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(120, 36);
            this.Z.TabIndex = 6;
            this.Z.ValueChanged += new System.EventHandler(this.XandYandZandV_ValueChanged);
            // 
            // V
            // 
            this.V.DecimalPlaces = 5;
            this.V.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.V.Location = new System.Drawing.Point(187, 155);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(120, 36);
            this.V.TabIndex = 7;
            this.V.ValueChanged += new System.EventHandler(this.XandYandZandV_ValueChanged);
            // 
            // Otlabel
            // 
            this.Otlabel.AutoSize = true;
            this.Otlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otlabel.Location = new System.Drawing.Point(32, 233);
            this.Otlabel.Name = "Otlabel";
            this.Otlabel.Size = new System.Drawing.Size(246, 28);
            this.Otlabel.TabIndex = 8;
            this.Otlabel.Text = "Минимальное число";
            // 
            // Ot
            // 
            this.Ot.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ot.Location = new System.Drawing.Point(295, 230);
            this.Ot.Name = "Ot";
            this.Ot.ReadOnly = true;
            this.Ot.Size = new System.Drawing.Size(120, 36);
            this.Ot.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 294);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Otlabel);
            this.Controls.Add(this.V);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Vlabel);
            this.Controls.Add(this.Zlable);
            this.Controls.Add(this.Ylable);
            this.Controls.Add(this.Xlabel);
            this.Name = "Form1";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Ylable;
        private System.Windows.Forms.Label Zlable;
        private System.Windows.Forms.Label Vlabel;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.NumericUpDown Y;
        private System.Windows.Forms.NumericUpDown Z;
        private System.Windows.Forms.NumericUpDown V;
        private System.Windows.Forms.Label Otlabel;
        private System.Windows.Forms.TextBox Ot;
    }
}

