namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_font = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_style = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Font = new System.Windows.Forms.ComboBox();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.textBox_Load = new System.Windows.Forms.TextBox();
            this.textBox_Save = new System.Windows.Forms.TextBox();
            this.richTextBox_Write = new System.Windows.Forms.RichTextBox();
            this.checkBox_B = new System.Windows.Forms.CheckBox();
            this.checkBox_I = new System.Windows.Forms.CheckBox();
            this.checkBox_U = new System.Windows.Forms.CheckBox();
            this.radioButton_L = new System.Windows.Forms.RadioButton();
            this.radioButton_R = new System.Windows.Forms.RadioButton();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_font
            // 
            this.label_font.AutoSize = true;
            this.label_font.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_font.Location = new System.Drawing.Point(64, 20);
            this.label_font.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(56, 27);
            this.label_font.TabIndex = 0;
            this.label_font.Text = "Font";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(216, 20);
            this.label_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(51, 27);
            this.label_size.TabIndex = 1;
            this.label_size.Text = "Size";
            // 
            // label_style
            // 
            this.label_style.AutoSize = true;
            this.label_style.Location = new System.Drawing.Point(351, 20);
            this.label_style.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_style.Name = "label_style";
            this.label_style.Size = new System.Drawing.Size(104, 27);
            this.label_style.TabIndex = 2;
            this.label_style.Text = "FontStyle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // comboBox_Font
            // 
            this.comboBox_Font.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_Font.FormattingEnabled = true;
            this.comboBox_Font.Location = new System.Drawing.Point(12, 63);
            this.comboBox_Font.Name = "comboBox_Font";
            this.comboBox_Font.Size = new System.Drawing.Size(163, 35);
            this.comboBox_Font.TabIndex = 5;
            this.comboBox_Font.SelectedIndexChanged += new System.EventHandler(this.comboBox_Font_SelectedIndexChanged);
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(192, 62);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(130, 35);
            this.comboBox_Size.TabIndex = 6;
            this.comboBox_Size.SelectedIndexChanged += new System.EventHandler(this.comboBox_Size_SelectedIndexChanged);
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(691, 61);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(188, 35);
            this.comboBox_Color.TabIndex = 7;
            this.comboBox_Color.SelectedIndexChanged += new System.EventHandler(this.comboBox_Color_SelectedIndexChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(1171, 65);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(127, 39);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(1171, 23);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(127, 39);
            this.button_Load.TabIndex = 9;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // textBox_Load
            // 
            this.textBox_Load.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Load.Location = new System.Drawing.Point(906, 23);
            this.textBox_Load.Multiline = true;
            this.textBox_Load.Name = "textBox_Load";
            this.textBox_Load.Size = new System.Drawing.Size(259, 39);
            this.textBox_Load.TabIndex = 10;
            this.textBox_Load.Text = "Enter name and load file";
            this.textBox_Load.Click += new System.EventHandler(this.textBox_Load_Click);
            // 
            // textBox_Save
            // 
            this.textBox_Save.Location = new System.Drawing.Point(906, 68);
            this.textBox_Save.Name = "textBox_Save";
            this.textBox_Save.Size = new System.Drawing.Size(259, 35);
            this.textBox_Save.TabIndex = 11;
            this.textBox_Save.Text = "Tap to enter name and save";
            this.textBox_Save.Click += new System.EventHandler(this.textBox_Load_Click);
            // 
            // richTextBox_Write
            // 
            this.richTextBox_Write.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox_Write.Location = new System.Drawing.Point(12, 128);
            this.richTextBox_Write.Multiline = false;
            this.richTextBox_Write.Name = "richTextBox_Write";
            this.richTextBox_Write.Size = new System.Drawing.Size(1286, 544);
            this.richTextBox_Write.TabIndex = 18;
            this.richTextBox_Write.Text = "";
            // 
            // checkBox_B
            // 
            this.checkBox_B.AutoSize = true;
            this.checkBox_B.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_B.Location = new System.Drawing.Point(342, 61);
            this.checkBox_B.Name = "checkBox_B";
            this.checkBox_B.Size = new System.Drawing.Size(54, 30);
            this.checkBox_B.TabIndex = 19;
            this.checkBox_B.Text = "B";
            this.checkBox_B.UseVisualStyleBackColor = true;
            this.checkBox_B.CheckedChanged += new System.EventHandler(this.checkBox_B_CheckedChanged);
            // 
            // checkBox_I
            // 
            this.checkBox_I.AutoSize = true;
            this.checkBox_I.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_I.Location = new System.Drawing.Point(452, 61);
            this.checkBox_I.Name = "checkBox_I";
            this.checkBox_I.Size = new System.Drawing.Size(46, 31);
            this.checkBox_I.TabIndex = 20;
            this.checkBox_I.Text = "I";
            this.checkBox_I.UseVisualStyleBackColor = true;
            this.checkBox_I.CheckedChanged += new System.EventHandler(this.checkBox_I_CheckedChanged);
            // 
            // checkBox_U
            // 
            this.checkBox_U.AutoSize = true;
            this.checkBox_U.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_U.Location = new System.Drawing.Point(392, 61);
            this.checkBox_U.Name = "checkBox_U";
            this.checkBox_U.Size = new System.Drawing.Size(54, 31);
            this.checkBox_U.TabIndex = 21;
            this.checkBox_U.Text = "U";
            this.checkBox_U.UseVisualStyleBackColor = true;
            this.checkBox_U.CheckedChanged += new System.EventHandler(this.checkBox_U_CheckedChanged);
            // 
            // radioButton_L
            // 
            this.radioButton_L.AutoSize = true;
            this.radioButton_L.Location = new System.Drawing.Point(519, 60);
            this.radioButton_L.Name = "radioButton_L";
            this.radioButton_L.Size = new System.Drawing.Size(52, 31);
            this.radioButton_L.TabIndex = 22;
            this.radioButton_L.TabStop = true;
            this.radioButton_L.Text = "L";
            this.radioButton_L.UseVisualStyleBackColor = true;
            this.radioButton_L.CheckedChanged += new System.EventHandler(this.radioButton_L_CheckedChanged);
            // 
            // radioButton_R
            // 
            this.radioButton_R.AutoSize = true;
            this.radioButton_R.Location = new System.Drawing.Point(625, 61);
            this.radioButton_R.Name = "radioButton_R";
            this.radioButton_R.Size = new System.Drawing.Size(53, 31);
            this.radioButton_R.TabIndex = 23;
            this.radioButton_R.TabStop = true;
            this.radioButton_R.Text = "R";
            this.radioButton_R.UseVisualStyleBackColor = true;
            this.radioButton_R.CheckedChanged += new System.EventHandler(this.radioButton_R_CheckedChanged);
            // 
            // radioButton_C
            // 
            this.radioButton_C.AutoSize = true;
            this.radioButton_C.Location = new System.Drawing.Point(566, 60);
            this.radioButton_C.Name = "radioButton_C";
            this.radioButton_C.Size = new System.Drawing.Size(53, 31);
            this.radioButton_C.TabIndex = 24;
            this.radioButton_C.TabStop = true;
            this.radioButton_C.Text = "C";
            this.radioButton_C.UseVisualStyleBackColor = true;
            this.radioButton_C.CheckedChanged += new System.EventHandler(this.radioButton_C_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 685);
            this.Controls.Add(this.radioButton_C);
            this.Controls.Add(this.radioButton_R);
            this.Controls.Add(this.radioButton_L);
            this.Controls.Add(this.checkBox_U);
            this.Controls.Add(this.checkBox_I);
            this.Controls.Add(this.checkBox_B);
            this.Controls.Add(this.richTextBox_Write);
            this.Controls.Add(this.textBox_Save);
            this.Controls.Add(this.textBox_Load);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.comboBox_Color);
            this.Controls.Add(this.comboBox_Size);
            this.Controls.Add(this.comboBox_Font);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_style);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_font);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_style;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Font;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.ComboBox comboBox_Color;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.TextBox textBox_Load;
        private System.Windows.Forms.TextBox textBox_Save;
        private System.Windows.Forms.RichTextBox richTextBox_Write;
        private System.Windows.Forms.CheckBox checkBox_B;
        private System.Windows.Forms.CheckBox checkBox_I;
        private System.Windows.Forms.CheckBox checkBox_U;
        private System.Windows.Forms.RadioButton radioButton_L;
        private System.Windows.Forms.RadioButton radioButton_R;
        private System.Windows.Forms.RadioButton radioButton_C;
    }
}

