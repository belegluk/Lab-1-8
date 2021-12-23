
namespace LAB_04_Olshewski
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.textBox_fileKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKeyLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_KEYgenerator = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_fileKEYsave = new System.Windows.Forms.Button();
            this.button_fileKEYopen = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_fileIN);
            this.groupBox1.Controls.Add(this.button_fileIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_fileOUT);
            this.groupBox1.Controls.Add(this.button_fileOUT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Відкрити файл:";
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(105, 13);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(341, 20);
            this.textBox_fileIN.TabIndex = 1;
            // 
            // button_fileIN
            // 
            this.button_fileIN.Location = new System.Drawing.Point(452, 11);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(63, 23);
            this.button_fileIN.TabIndex = 9;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = false;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зберегти у файл:";
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(105, 39);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(341, 20);
            this.textBox_fileOUT.TabIndex = 2;
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Location = new System.Drawing.Point(452, 37);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(63, 23);
            this.button_fileOUT.TabIndex = 10;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = false;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // textBox_fileKEY
            // 
            this.textBox_fileKEY.Location = new System.Drawing.Point(105, 13);
            this.textBox_fileKEY.Name = "textBox_fileKEY";
            this.textBox_fileKEY.Size = new System.Drawing.Size(341, 20);
            this.textBox_fileKEY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Файл з ключем:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тривалість шифрування (хв:сек.мс):";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(202, 71);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 13);
            this.label_time.TabIndex = 8;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(452, 66);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(63, 23);
            this.button_start.TabIndex = 14;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKeyLength);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_start);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_time);
            this.groupBox2.Controls.Add(this.button_KEYgenerator);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_fileKEY);
            this.groupBox2.Controls.Add(this.button_fileKEYsave);
            this.groupBox2.Controls.Add(this.button_fileKEYopen);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 95);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // labelKeyLength
            // 
            this.labelKeyLength.AutoSize = true;
            this.labelKeyLength.Location = new System.Drawing.Point(400, 45);
            this.labelKeyLength.Name = "labelKeyLength";
            this.labelKeyLength.Size = new System.Drawing.Size(39, 13);
            this.labelKeyLength.TabIndex = 16;
            this.labelKeyLength.Text = "0 байт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Розмір ключа";
            // 
            // button_KEYgenerator
            // 
            this.button_KEYgenerator.ImageIndex = 0;
            this.button_KEYgenerator.ImageList = this.imageList1;
            this.button_KEYgenerator.Location = new System.Drawing.Point(236, 40);
            this.button_KEYgenerator.Name = "button_KEYgenerator";
            this.button_KEYgenerator.Size = new System.Drawing.Size(75, 23);
            this.button_KEYgenerator.TabIndex = 13;
            this.button_KEYgenerator.Text = "key";
            this.button_KEYgenerator.UseVisualStyleBackColor = false;
            this.button_KEYgenerator.Click += new System.EventHandler(this.button_KEYgenerator_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.DarkSalmon;
            this.imageList1.Images.SetKeyName(0, "key.png");
            this.imageList1.Images.SetKeyName(1, "load.png");
            this.imageList1.Images.SetKeyName(2, "save.png");
            // 
            // button_fileKEYsave
            // 
            this.button_fileKEYsave.ImageIndex = 2;
            this.button_fileKEYsave.ImageList = this.imageList1;
            this.button_fileKEYsave.Location = new System.Drawing.Point(452, 40);
            this.button_fileKEYsave.Name = "button_fileKEYsave";
            this.button_fileKEYsave.Size = new System.Drawing.Size(63, 23);
            this.button_fileKEYsave.TabIndex = 12;
            this.button_fileKEYsave.Text = "Зберегти";
            this.toolTip1.SetToolTip(this.button_fileKEYsave, "Save file");
            this.button_fileKEYsave.UseVisualStyleBackColor = false;
            this.button_fileKEYsave.Click += new System.EventHandler(this.button_fileKEYsave_Click);
            // 
            // button_fileKEYopen
            // 
            this.button_fileKEYopen.ImageIndex = 1;
            this.button_fileKEYopen.ImageList = this.imageList1;
            this.button_fileKEYopen.Location = new System.Drawing.Point(452, 11);
            this.button_fileKEYopen.Name = "button_fileKEYopen";
            this.button_fileKEYopen.Size = new System.Drawing.Size(63, 23);
            this.button_fileKEYopen.TabIndex = 11;
            this.button_fileKEYopen.Text = "Відкрити";
            this.button_fileKEYopen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button_fileKEYopen, "Open file");
            this.button_fileKEYopen.UseVisualStyleBackColor = false;
            this.button_fileKEYopen.Click += new System.EventHandler(this.button_fileKEYopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileKEY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_fileKEYopen;
        private System.Windows.Forms.Button button_fileKEYsave;
        private System.Windows.Forms.Button button_KEYgenerator;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelKeyLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

