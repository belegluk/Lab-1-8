
namespace LAB_06_Olshewski
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileKey_out = new System.Windows.Forms.Button();
            this.textBox_fileKey_out = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox_viewPassWord = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_fileSave = new System.Windows.Forms.Label();
            this.label_fileCipher = new System.Windows.Forms.Label();
            this.label_fileOpen = new System.Windows.Forms.Label();
            this.button_fileSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_fileCipher = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_bits = new System.Windows.Forms.Label();
            this.comboBox_keyLength_byte = new System.Windows.Forms.ComboBox();
            this.radioButton_passWord = new System.Windows.Forms.RadioButton();
            this.radioButton_keyGen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл з ключем";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileKey_out);
            this.groupBox1.Controls.Add(this.textBox_fileKey_out);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шлях до файлу";
            // 
            // button_fileKey_out
            // 
            this.button_fileKey_out.Location = new System.Drawing.Point(493, 27);
            this.button_fileKey_out.Name = "button_fileKey_out";
            this.button_fileKey_out.Size = new System.Drawing.Size(75, 23);
            this.button_fileKey_out.TabIndex = 1;
            this.button_fileKey_out.Text = "...";
            this.button_fileKey_out.UseVisualStyleBackColor = true;
            this.button_fileKey_out.Click += new System.EventHandler(this.button_fileKey_out_Click);
            // 
            // textBox_fileKey_out
            // 
            this.textBox_fileKey_out.Location = new System.Drawing.Point(6, 29);
            this.textBox_fileKey_out.Name = "textBox_fileKey_out";
            this.textBox_fileKey_out.Size = new System.Drawing.Size(481, 20);
            this.textBox_fileKey_out.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ключ у HEX форматі";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_hand);
            this.groupBox3.Controls.Add(this.textBox_Key);
            this.groupBox3.Location = new System.Drawing.Point(4, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 61);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ключ (НЕХ формат)";
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.AutoSize = true;
            this.checkBox_hand.Location = new System.Drawing.Point(412, 24);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(161, 17);
            this.checkBox_hand.TabIndex = 1;
            this.checkBox_hand.Text = "Свій ключ/Зміна існуючого";
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.checkBox_hand_CheckedChanged);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(6, 22);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.ReadOnly = true;
            this.textBox_Key.Size = new System.Drawing.Size(393, 20);
            this.textBox_Key.TabIndex = 0;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox_viewPassWord);
            this.tabPage3.Controls.Add(this.textBox_password);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(590, 74);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власний пароль";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox_viewPassWord
            // 
            this.checkBox_viewPassWord.AutoSize = true;
            this.checkBox_viewPassWord.Location = new System.Drawing.Point(513, 29);
            this.checkBox_viewPassWord.Name = "checkBox_viewPassWord";
            this.checkBox_viewPassWord.Size = new System.Drawing.Size(71, 17);
            this.checkBox_viewPassWord.TabIndex = 2;
            this.checkBox_viewPassWord.Text = "Видимий";
            this.checkBox_viewPassWord.UseVisualStyleBackColor = true;
            this.checkBox_viewPassWord.CheckedChanged += new System.EventHandler(this.checkBox_viewPassWord_CheckedChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(104, 27);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(403, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Власний пароль:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label_fileSave);
            this.tabPage4.Controls.Add(this.label_fileCipher);
            this.tabPage4.Controls.Add(this.label_fileOpen);
            this.tabPage4.Controls.Add(this.button_fileSave);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.button_fileCipher);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.button_fileOpen);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(590, 74);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Файл XOR Ключ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label_fileSave
            // 
            this.label_fileSave.AutoSize = true;
            this.label_fileSave.ForeColor = System.Drawing.Color.Red;
            this.label_fileSave.Location = new System.Drawing.Point(524, 45);
            this.label_fileSave.Name = "label_fileSave";
            this.label_fileSave.Size = new System.Drawing.Size(38, 13);
            this.label_fileSave.TabIndex = 8;
            this.label_fileSave.Text = "НЕМА";
            // 
            // label_fileCipher
            // 
            this.label_fileCipher.AutoSize = true;
            this.label_fileCipher.ForeColor = System.Drawing.Color.Red;
            this.label_fileCipher.Location = new System.Drawing.Point(278, 45);
            this.label_fileCipher.Name = "label_fileCipher";
            this.label_fileCipher.Size = new System.Drawing.Size(38, 13);
            this.label_fileCipher.TabIndex = 7;
            this.label_fileCipher.Text = "НЕМА";
            // 
            // label_fileOpen
            // 
            this.label_fileOpen.AutoSize = true;
            this.label_fileOpen.ForeColor = System.Drawing.Color.Red;
            this.label_fileOpen.Location = new System.Drawing.Point(36, 45);
            this.label_fileOpen.Name = "label_fileOpen";
            this.label_fileOpen.Size = new System.Drawing.Size(38, 13);
            this.label_fileOpen.TabIndex = 6;
            this.label_fileOpen.Text = "НЕМА";
            // 
            // button_fileSave
            // 
            this.button_fileSave.Location = new System.Drawing.Point(502, 19);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(82, 23);
            this.button_fileSave.TabIndex = 5;
            this.button_fileSave.Text = "...";
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.button_fileSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Зберегти файл";
            // 
            // button_fileCipher
            // 
            this.button_fileCipher.Location = new System.Drawing.Point(258, 19);
            this.button_fileCipher.Name = "button_fileCipher";
            this.button_fileCipher.Size = new System.Drawing.Size(80, 23);
            this.button_fileCipher.TabIndex = 3;
            this.button_fileCipher.Text = "Click";
            this.button_fileCipher.UseVisualStyleBackColor = true;
            this.button_fileCipher.Click += new System.EventHandler(this.button_fileCipher_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "2. Шифрування";
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Location = new System.Drawing.Point(7, 19);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(91, 23);
            this.button_fileOpen.TabIndex = 1;
            this.button_fileOpen.Text = "...";
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "1. Відкрити файл";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_bits);
            this.groupBox2.Controls.Add(this.comboBox_keyLength_byte);
            this.groupBox2.Controls.Add(this.radioButton_passWord);
            this.groupBox2.Controls.Add(this.radioButton_keyGen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // label_bits
            // 
            this.label_bits.AutoSize = true;
            this.label_bits.Location = new System.Drawing.Point(53, 75);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(22, 13);
            this.label_bits.TabIndex = 5;
            this.label_bits.Text = "     ";
            this.label_bits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_keyLength_byte
            // 
            this.comboBox_keyLength_byte.FormattingEnabled = true;
            this.comboBox_keyLength_byte.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.comboBox_keyLength_byte.Location = new System.Drawing.Point(6, 38);
            this.comboBox_keyLength_byte.Name = "comboBox_keyLength_byte";
            this.comboBox_keyLength_byte.Size = new System.Drawing.Size(130, 21);
            this.comboBox_keyLength_byte.TabIndex = 4;
            this.comboBox_keyLength_byte.TextChanged += new System.EventHandler(this.comboBox_keyLength_byte_TextChanged);
            this.comboBox_keyLength_byte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_keyLength_byte_KeyPress);
            // 
            // radioButton_passWord
            // 
            this.radioButton_passWord.AutoSize = true;
            this.radioButton_passWord.Location = new System.Drawing.Point(176, 59);
            this.radioButton_passWord.Name = "radioButton_passWord";
            this.radioButton_passWord.Size = new System.Drawing.Size(229, 17);
            this.radioButton_passWord.TabIndex = 3;
            this.radioButton_passWord.TabStop = true;
            this.radioButton_passWord.Text = "Ключ генерується розширенням пароля";
            this.radioButton_passWord.UseVisualStyleBackColor = true;
            this.radioButton_passWord.CheckedChanged += new System.EventHandler(this.radioButton_passWord_CheckedChanged);
            // 
            // radioButton_keyGen
            // 
            this.radioButton_keyGen.AutoSize = true;
            this.radioButton_keyGen.Location = new System.Drawing.Point(176, 24);
            this.radioButton_keyGen.Name = "radioButton_keyGen";
            this.radioButton_keyGen.Size = new System.Drawing.Size(394, 17);
            this.radioButton_keyGen.TabIndex = 2;
            this.radioButton_keyGen.TabStop = true;
            this.radioButton_keyGen.Text = "Ключ з криптографічного генератора псевдовипадкових послідовностей";
            this.radioButton_keyGen.UseVisualStyleBackColor = true;
            this.radioButton_keyGen.CheckedChanged += new System.EventHandler(this.radioButton_keyGen_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Довжина ключа (біти):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Довжина ключа (байти):";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(28, 224);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(126, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "Згенерувати ключ";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тривалість розрахунків (хв:сек):";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(371, 229);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(40, 13);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "           ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 257);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileKey_out;
        private System.Windows.Forms.TextBox textBox_fileKey_out;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_passWord;
        private System.Windows.Forms.RadioButton radioButton_keyGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_hand;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.CheckBox checkBox_viewPassWord;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_fileSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_fileCipher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_fileOpen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_bits;
        private System.Windows.Forms.ComboBox comboBox_keyLength_byte;
        private System.Windows.Forms.Label label_fileOpen;
        private System.Windows.Forms.Label label_fileSave;
        private System.Windows.Forms.Label label_fileCipher;
    }
}

