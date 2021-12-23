
namespace LAB_02_Olshewski
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.Label();
            this.P10 = new System.Windows.Forms.Label();
            this.P16 = new System.Windows.Forms.Label();
            this.key16 = new System.Windows.Forms.Label();
            this.key10 = new System.Windows.Forms.Label();
            this.key2 = new System.Windows.Forms.Label();
            this.C16 = new System.Windows.Forms.Label();
            this.C10 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.textBox_P_dec = new System.Windows.Forms.TextBox();
            this.textBox_key_dec = new System.Windows.Forms.TextBox();
            this.textBox_C_dec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(15, 58);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(159, 23);
            this.button_XOR.TabIndex = 3;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(15, 114);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(159, 23);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(74, 6);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 20);
            this.textBox_P.TabIndex = 5;
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(74, 32);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(100, 20);
            this.textBox_key.TabIndex = 6;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(74, 88);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 20);
            this.textBox_C.TabIndex = 7;
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Location = new System.Drawing.Point(180, 9);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(0, 13);
            this.P2.TabIndex = 8;
            // 
            // P10
            // 
            this.P10.AutoSize = true;
            this.P10.Location = new System.Drawing.Point(239, 9);
            this.P10.Name = "P10";
            this.P10.Size = new System.Drawing.Size(0, 13);
            this.P10.TabIndex = 9;
            // 
            // P16
            // 
            this.P16.AutoSize = true;
            this.P16.Location = new System.Drawing.Point(280, 9);
            this.P16.Name = "P16";
            this.P16.Size = new System.Drawing.Size(0, 13);
            this.P16.TabIndex = 10;
            // 
            // key16
            // 
            this.key16.AutoSize = true;
            this.key16.Location = new System.Drawing.Point(280, 35);
            this.key16.Name = "key16";
            this.key16.Size = new System.Drawing.Size(0, 13);
            this.key16.TabIndex = 13;
            // 
            // key10
            // 
            this.key10.AutoSize = true;
            this.key10.Location = new System.Drawing.Point(239, 35);
            this.key10.Name = "key10";
            this.key10.Size = new System.Drawing.Size(0, 13);
            this.key10.TabIndex = 12;
            // 
            // key2
            // 
            this.key2.AutoSize = true;
            this.key2.Location = new System.Drawing.Point(180, 35);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(0, 13);
            this.key2.TabIndex = 11;
            // 
            // C16
            // 
            this.C16.AutoSize = true;
            this.C16.Location = new System.Drawing.Point(280, 91);
            this.C16.Name = "C16";
            this.C16.Size = new System.Drawing.Size(0, 13);
            this.C16.TabIndex = 16;
            // 
            // C10
            // 
            this.C10.AutoSize = true;
            this.C10.Location = new System.Drawing.Point(239, 91);
            this.C10.Name = "C10";
            this.C10.Size = new System.Drawing.Size(0, 13);
            this.C10.TabIndex = 15;
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Location = new System.Drawing.Point(180, 91);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(0, 13);
            this.C2.TabIndex = 14;
            // 
            // textBox_P_dec
            // 
            this.textBox_P_dec.Location = new System.Drawing.Point(378, 9);
            this.textBox_P_dec.Name = "textBox_P_dec";
            this.textBox_P_dec.Size = new System.Drawing.Size(100, 20);
            this.textBox_P_dec.TabIndex = 17;
            // 
            // textBox_key_dec
            // 
            this.textBox_key_dec.Location = new System.Drawing.Point(378, 36);
            this.textBox_key_dec.Name = "textBox_key_dec";
            this.textBox_key_dec.Size = new System.Drawing.Size(100, 20);
            this.textBox_key_dec.TabIndex = 18;
            // 
            // textBox_C_dec
            // 
            this.textBox_C_dec.Location = new System.Drawing.Point(378, 91);
            this.textBox_C_dec.Name = "textBox_C_dec";
            this.textBox_C_dec.Size = new System.Drawing.Size(100, 20);
            this.textBox_C_dec.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 143);
            this.Controls.Add(this.textBox_C_dec);
            this.Controls.Add(this.textBox_key_dec);
            this.Controls.Add(this.textBox_P_dec);
            this.Controls.Add(this.C16);
            this.Controls.Add(this.C10);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.key16);
            this.Controls.Add(this.key10);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.P16);
            this.Controls.Add(this.P10);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_XOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P10;
        private System.Windows.Forms.Label P16;
        private System.Windows.Forms.Label key16;
        private System.Windows.Forms.Label key10;
        private System.Windows.Forms.Label key2;
        private System.Windows.Forms.Label C16;
        private System.Windows.Forms.Label C10;
        private System.Windows.Forms.Label C2;
        private System.Windows.Forms.TextBox textBox_P_dec;
        private System.Windows.Forms.TextBox textBox_key_dec;
        private System.Windows.Forms.TextBox textBox_C_dec;
    }
}

