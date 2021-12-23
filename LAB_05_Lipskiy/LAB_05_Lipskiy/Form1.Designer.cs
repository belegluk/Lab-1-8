
namespace LAB_05_Olshewski
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
            this.tInFilePath = new System.Windows.Forms.TextBox();
            this.tOutFilePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_SHA512 = new System.Windows.Forms.RadioButton();
            this.rB_SHA384 = new System.Windows.Forms.RadioButton();
            this.rB_SHA256 = new System.Windows.Forms.RadioButton();
            this.rB_SHA1 = new System.Windows.Forms.RadioButton();
            this.rB_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rB_HAVAL = new System.Windows.Forms.RadioButton();
            this.rB_CRC32 = new System.Windows.Forms.RadioButton();
            this.rB_MD5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bInFile = new System.Windows.Forms.Button();
            this.bOutFile = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.labelInLength = new System.Windows.Forms.Label();
            this.labelOutLength = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідний файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вихідний файл:";
            // 
            // tInFilePath
            // 
            this.tInFilePath.Location = new System.Drawing.Point(97, 10);
            this.tInFilePath.Name = "tInFilePath";
            this.tInFilePath.Size = new System.Drawing.Size(253, 20);
            this.tInFilePath.TabIndex = 2;
            // 
            // tOutFilePath
            // 
            this.tOutFilePath.Location = new System.Drawing.Point(97, 37);
            this.tOutFilePath.Name = "tOutFilePath";
            this.tOutFilePath.Size = new System.Drawing.Size(253, 20);
            this.tOutFilePath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_SHA512);
            this.groupBox1.Controls.Add(this.rB_SHA384);
            this.groupBox1.Controls.Add(this.rB_SHA256);
            this.groupBox1.Controls.Add(this.rB_SHA1);
            this.groupBox1.Controls.Add(this.rB_RIPEMD160);
            this.groupBox1.Controls.Add(this.rB_HAVAL);
            this.groupBox1.Controls.Add(this.rB_CRC32);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи:";
            // 
            // rB_SHA512
            // 
            this.rB_SHA512.AutoSize = true;
            this.rB_SHA512.Location = new System.Drawing.Point(99, 92);
            this.rB_SHA512.Name = "rB_SHA512";
            this.rB_SHA512.Size = new System.Drawing.Size(68, 17);
            this.rB_SHA512.TabIndex = 6;
            this.rB_SHA512.TabStop = true;
            this.rB_SHA512.Text = "SHA-512";
            this.rB_SHA512.UseVisualStyleBackColor = true;
            // 
            // rB_SHA384
            // 
            this.rB_SHA384.AutoSize = true;
            this.rB_SHA384.Location = new System.Drawing.Point(99, 68);
            this.rB_SHA384.Name = "rB_SHA384";
            this.rB_SHA384.Size = new System.Drawing.Size(68, 17);
            this.rB_SHA384.TabIndex = 5;
            this.rB_SHA384.TabStop = true;
            this.rB_SHA384.Text = "SHA-384";
            this.rB_SHA384.UseVisualStyleBackColor = true;
            // 
            // rB_SHA256
            // 
            this.rB_SHA256.AutoSize = true;
            this.rB_SHA256.Location = new System.Drawing.Point(99, 44);
            this.rB_SHA256.Name = "rB_SHA256";
            this.rB_SHA256.Size = new System.Drawing.Size(68, 17);
            this.rB_SHA256.TabIndex = 4;
            this.rB_SHA256.TabStop = true;
            this.rB_SHA256.Text = "SHA-256";
            this.rB_SHA256.UseVisualStyleBackColor = true;
            // 
            // rB_SHA1
            // 
            this.rB_SHA1.AutoSize = true;
            this.rB_SHA1.Location = new System.Drawing.Point(99, 20);
            this.rB_SHA1.Name = "rB_SHA1";
            this.rB_SHA1.Size = new System.Drawing.Size(56, 17);
            this.rB_SHA1.TabIndex = 3;
            this.rB_SHA1.TabStop = true;
            this.rB_SHA1.Text = "SHA-1";
            this.rB_SHA1.UseVisualStyleBackColor = true;
            // 
            // rB_RIPEMD160
            // 
            this.rB_RIPEMD160.AutoSize = true;
            this.rB_RIPEMD160.Location = new System.Drawing.Point(7, 68);
            this.rB_RIPEMD160.Name = "rB_RIPEMD160";
            this.rB_RIPEMD160.Size = new System.Drawing.Size(85, 17);
            this.rB_RIPEMD160.TabIndex = 2;
            this.rB_RIPEMD160.TabStop = true;
            this.rB_RIPEMD160.Text = "RIPEMD160";
            this.rB_RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // rB_HAVAL
            // 
            this.rB_HAVAL.AutoSize = true;
            this.rB_HAVAL.Location = new System.Drawing.Point(7, 44);
            this.rB_HAVAL.Name = "rB_HAVAL";
            this.rB_HAVAL.Size = new System.Drawing.Size(93, 17);
            this.rB_HAVAL.TabIndex = 1;
            this.rB_HAVAL.TabStop = true;
            this.rB_HAVAL.Text = "HashAlgorithm";
            this.rB_HAVAL.UseVisualStyleBackColor = true;
            // 
            // rB_CRC32
            // 
            this.rB_CRC32.AutoSize = true;
            this.rB_CRC32.Location = new System.Drawing.Point(7, 20);
            this.rB_CRC32.Name = "rB_CRC32";
            this.rB_CRC32.Size = new System.Drawing.Size(59, 17);
            this.rB_CRC32.TabIndex = 0;
            this.rB_CRC32.TabStop = true;
            this.rB_CRC32.Text = "CRC32";
            this.rB_CRC32.UseVisualStyleBackColor = true;
            // 
            // rB_MD5
            // 
            this.rB_MD5.AutoSize = true;
            this.rB_MD5.Location = new System.Drawing.Point(19, 156);
            this.rB_MD5.Name = "rB_MD5";
            this.rB_MD5.Size = new System.Drawing.Size(48, 17);
            this.rB_MD5.TabIndex = 5;
            this.rB_MD5.TabStop = true;
            this.rB_MD5.Text = "MD5";
            this.rB_MD5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelInLength);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(189, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 43);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (МБайт):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вхідного файлу:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelOutLength);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(188, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 41);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Байти):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Вихідного файлу:";
            // 
            // bInFile
            // 
            this.bInFile.Location = new System.Drawing.Point(356, 8);
            this.bInFile.Name = "bInFile";
            this.bInFile.Size = new System.Drawing.Size(33, 23);
            this.bInFile.TabIndex = 9;
            this.bInFile.Text = "...";
            this.bInFile.UseVisualStyleBackColor = true;
            this.bInFile.Click += new System.EventHandler(this.bInFile_Click);
            // 
            // bOutFile
            // 
            this.bOutFile.Location = new System.Drawing.Point(356, 35);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(32, 23);
            this.bOutFile.TabIndex = 10;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.bOutFile_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(189, 160);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(95, 23);
            this.bStart.TabIndex = 11;
            this.bStart.Text = "Виконати";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(290, 160);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(98, 23);
            this.bClean.TabIndex = 12;
            this.bClean.Text = "Скасувати";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тривалість кодування:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(145, 190);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 13);
            this.label_time.TabIndex = 14;
            // 
            // labelInLength
            // 
            this.labelInLength.AutoSize = true;
            this.labelInLength.Location = new System.Drawing.Point(101, 20);
            this.labelInLength.Name = "labelInLength";
            this.labelInLength.Size = new System.Drawing.Size(0, 13);
            this.labelInLength.TabIndex = 1;
            // 
            // labelOutLength
            // 
            this.labelOutLength.AutoSize = true;
            this.labelOutLength.Location = new System.Drawing.Point(102, 21);
            this.labelOutLength.Name = "labelOutLength";
            this.labelOutLength.Size = new System.Drawing.Size(0, 13);
            this.labelOutLength.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 219);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bOutFile);
            this.Controls.Add(this.bInFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rB_MD5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tOutFilePath);
            this.Controls.Add(this.tInFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tInFilePath;
        private System.Windows.Forms.TextBox tOutFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_SHA512;
        private System.Windows.Forms.RadioButton rB_SHA384;
        private System.Windows.Forms.RadioButton rB_SHA256;
        private System.Windows.Forms.RadioButton rB_SHA1;
        private System.Windows.Forms.RadioButton rB_RIPEMD160;
        private System.Windows.Forms.RadioButton rB_HAVAL;
        private System.Windows.Forms.RadioButton rB_CRC32;
        private System.Windows.Forms.RadioButton rB_MD5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bInFile;
        private System.Windows.Forms.Button bOutFile;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label labelInLength;
        private System.Windows.Forms.Label labelOutLength;
    }
}

