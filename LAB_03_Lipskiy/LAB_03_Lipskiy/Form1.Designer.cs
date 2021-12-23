
namespace LAB_03_Olshewski
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_IN = new System.Windows.Forms.GroupBox();
            this.textBox_P_IN = new System.Windows.Forms.TextBox();
            this.textBox_key_IN = new System.Windows.Forms.TextBox();
            this.textBox_C_IN = new System.Windows.Forms.TextBox();
            this.groupBox_OUT = new System.Windows.Forms.GroupBox();
            this.textBox_P_OUT = new System.Windows.Forms.TextBox();
            this.textBox_key_OUT = new System.Windows.Forms.TextBox();
            this.textBox_C_OUT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.toolTip_HEX = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_IN.SuspendLayout();
            this.groupBox_OUT.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_IN
            // 
            this.groupBox_IN.Controls.Add(this.textBox_P_IN);
            this.groupBox_IN.Controls.Add(this.textBox_key_IN);
            this.groupBox_IN.Controls.Add(this.textBox_C_IN);
            this.groupBox_IN.Location = new System.Drawing.Point(72, 12);
            this.groupBox_IN.Name = "groupBox_IN";
            this.groupBox_IN.Size = new System.Drawing.Size(113, 100);
            this.groupBox_IN.TabIndex = 0;
            this.groupBox_IN.TabStop = false;
            this.groupBox_IN.Text = "Зашифрування";
            // 
            // textBox_P_IN
            // 
            this.textBox_P_IN.Location = new System.Drawing.Point(6, 19);
            this.textBox_P_IN.Name = "textBox_P_IN";
            this.textBox_P_IN.Size = new System.Drawing.Size(100, 20);
            this.textBox_P_IN.TabIndex = 5;
            // 
            // textBox_key_IN
            // 
            this.textBox_key_IN.Location = new System.Drawing.Point(6, 45);
            this.textBox_key_IN.Name = "textBox_key_IN";
            this.textBox_key_IN.Size = new System.Drawing.Size(100, 20);
            this.textBox_key_IN.TabIndex = 6;
            // 
            // textBox_C_IN
            // 
            this.textBox_C_IN.Location = new System.Drawing.Point(6, 71);
            this.textBox_C_IN.Name = "textBox_C_IN";
            this.textBox_C_IN.Size = new System.Drawing.Size(100, 20);
            this.textBox_C_IN.TabIndex = 7;
            // 
            // groupBox_OUT
            // 
            this.groupBox_OUT.Controls.Add(this.textBox_P_OUT);
            this.groupBox_OUT.Controls.Add(this.textBox_key_OUT);
            this.groupBox_OUT.Controls.Add(this.textBox_C_OUT);
            this.groupBox_OUT.Location = new System.Drawing.Point(221, 12);
            this.groupBox_OUT.Name = "groupBox_OUT";
            this.groupBox_OUT.Size = new System.Drawing.Size(112, 100);
            this.groupBox_OUT.TabIndex = 1;
            this.groupBox_OUT.TabStop = false;
            this.groupBox_OUT.Text = "Розшифрування";
            // 
            // textBox_P_OUT
            // 
            this.textBox_P_OUT.Location = new System.Drawing.Point(6, 19);
            this.textBox_P_OUT.Name = "textBox_P_OUT";
            this.textBox_P_OUT.Size = new System.Drawing.Size(100, 20);
            this.textBox_P_OUT.TabIndex = 11;
            // 
            // textBox_key_OUT
            // 
            this.textBox_key_OUT.Location = new System.Drawing.Point(6, 45);
            this.textBox_key_OUT.Name = "textBox_key_OUT";
            this.textBox_key_OUT.Size = new System.Drawing.Size(100, 20);
            this.textBox_key_OUT.TabIndex = 12;
            // 
            // textBox_C_OUT
            // 
            this.textBox_C_OUT.Location = new System.Drawing.Point(6, 71);
            this.textBox_C_OUT.Name = "textBox_C_OUT";
            this.textBox_C_OUT.Size = new System.Drawing.Size(100, 20);
            this.textBox_C_OUT.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(12, 12);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(54, 100);
            this.button_XOR.TabIndex = 14;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(339, 12);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(53, 100);
            this.button_clean.TabIndex = 15;
            this.button_clean.Text = "CLEAN";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 122);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_OUT);
            this.Controls.Add(this.groupBox_IN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_IN.ResumeLayout(false);
            this.groupBox_IN.PerformLayout();
            this.groupBox_OUT.ResumeLayout(false);
            this.groupBox_OUT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_IN;
        private System.Windows.Forms.TextBox textBox_P_IN;
        private System.Windows.Forms.TextBox textBox_key_IN;
        private System.Windows.Forms.TextBox textBox_C_IN;
        private System.Windows.Forms.GroupBox groupBox_OUT;
        private System.Windows.Forms.TextBox textBox_P_OUT;
        private System.Windows.Forms.TextBox textBox_key_OUT;
        private System.Windows.Forms.TextBox textBox_C_OUT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.ToolTip toolTip_HEX;
    }
}

