using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in FontFamily.Families)
            {
                comboBox_Font.Items.Add(item.Name);
            }
            comboBox_Size.Items.Add(8);
            comboBox_Size.Items.Add(9);
            comboBox_Size.Items.Add(10);
            comboBox_Size.Items.Add(12);
            comboBox_Size.Items.Add(14);
            comboBox_Size.Items.Add(11);
            comboBox_Size.Items.Add(16);
            comboBox_Size.Items.Add(18);
            comboBox_Size.Items.Add(20);
            comboBox_Size.Items.Add(22);
            comboBox_Size.Items.Add(24);
            comboBox_Size.Items.Add(26);
            comboBox_Size.Items.Add(28);
            comboBox_Size.Items.Add(36);
            comboBox_Size.Items.Add(48);
            comboBox_Size.Items.Add(72);

            foreach (Color color in new ColorConverter().GetStandardValues())
            {
                comboBox_Color.Items.Add(color.Name); 
            }   
            checkBox_B.Appearance=System.Windows.Forms.Appearance.Button;   
            checkBox_U.Appearance=System.Windows.Forms.Appearance.Button;   
            checkBox_I.Appearance=System.Windows.Forms.Appearance.Button;   
            radioButton_L.Appearance=System.Windows.Forms.Appearance.Button;    
            radioButton_C.Appearance=System.Windows.Forms.Appearance.Button;    
            radioButton_R.Appearance=System.Windows.Forms.Appearance.Button;    
            comboBox_Size.SelectedIndex = 0;    
        }
        private void button_Load_Click(object sender, EventArgs e)
        {
            richTextBox_Write.LoadFile(textBox_Load.Text + ".docx");
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            richTextBox_Write.SaveFile(textBox_Save.Text + ".docx");
        }

        private void comboBox_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox_Write.SelectedText == null)
            {
                Font ExistingFont = richTextBox_Write.SelectionFont;
                float size = float.Parse(comboBox_Size.SelectedItem.ToString());
                richTextBox_Write.Font = new Font(comboBox_Font.SelectedItem.ToString(), size, ExistingFont.Style);
            }
            else
            {
                Font ExistingFont = richTextBox_Write.SelectionFont;
                float size = float.Parse(comboBox_Size.SelectedItem.ToString());
                richTextBox_Write.SelectionFont = new Font(comboBox_Font.SelectedItem.ToString(), size, ExistingFont.Style);
            }
        }
        int t = 0;

        private void comboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox_Write.SelectedText == null)
            {
                Font ExistingFont = richTextBox_Write.SelectionFont;
                float t = float.Parse(comboBox_Size.SelectedItem.ToString());
                richTextBox_Write.Font = new Font(comboBox_Font.SelectedItem.ToString(), t, ExistingFont.Style);

            }
            else
            {
                if (t != 0)
                {
                    Font ExistingFont = richTextBox_Write.SelectionFont;
                    float t = float.Parse(comboBox_Size.SelectedItem.ToString());
                    richTextBox_Write.SelectionFont = new Font(comboBox_Font.SelectedItem.ToString(), t, ExistingFont.Style);
                }
                t = 1;
            }
        }

        private void checkBox_B_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_B.Checked)
            {
                if (richTextBox_Write.SelectedText == null)
                {
                    Font ExistingFont = richTextBox_Write.Font;
                    FontStyle NewFontStyle = new FontStyle();
                    if (checkBox_B.Checked)
                        NewFontStyle = FontStyle.Bold;

                    if (checkBox_U.Checked)
                        NewFontStyle |= FontStyle.Underline;

                    if (checkBox_I.Checked)
                        NewFontStyle |= FontStyle.Italic;
                    richTextBox_Write.Font = new Font(ExistingFont, NewFontStyle);
                }
                else
                {
                    Font ExistingFont = richTextBox_Write.SelectionFont;
                    FontStyle NewFontStyle = new FontStyle();
                    if (checkBox_B.Checked)
                        NewFontStyle = FontStyle.Bold;

                    if (checkBox_U.Checked)
                        NewFontStyle |= FontStyle.Underline;

                    if (checkBox_I.Checked)
                        NewFontStyle |= FontStyle.Italic;
                    richTextBox_Write.SelectionFont = new Font(ExistingFont, NewFontStyle);
                }
            }
        }

        private void checkBox_U_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_U.Checked)
            {
                if (richTextBox_Write.SelectedText == null)
                {
                    Font ExistingFont = richTextBox_Write.Font;
                    FontStyle NewFontStyle = new FontStyle();
                    if (checkBox_B.Checked)
                        NewFontStyle = FontStyle.Bold;

                    if (checkBox_U.Checked)
                        NewFontStyle |= FontStyle.Underline;

                    if (checkBox_I.Checked)
                        NewFontStyle |= FontStyle.Italic;
                    richTextBox_Write.Font = new Font(ExistingFont, NewFontStyle);
                }
                else
                {
                    Font ExistingFont = richTextBox_Write.SelectionFont;
                    FontStyle NewFontStyle = new FontStyle();
                    if (checkBox_B.Checked)
                        NewFontStyle = FontStyle.Bold;

                    if (checkBox_U.Checked)
                        NewFontStyle |= FontStyle.Underline;

                    if (checkBox_I.Checked)
                        NewFontStyle |= FontStyle.Italic;
                    richTextBox_Write.SelectionFont = new Font(ExistingFont, NewFontStyle);
                }
            }
        }

        private void checkBox_I_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_I.Checked)
            {
                if (richTextBox_Write.SelectedText == null)
                {
                    Font ExistingFont = richTextBox_Write.Font;
                    FontStyle NewFontStyle = new FontStyle();
                    if (checkBox_B.Checked)
                        NewFontStyle = FontStyle.Bold;

                    if (checkBox_U.Checked)
                        NewFontStyle |= FontStyle.Underline;

                    if (checkBox_I.Checked)
                        NewFontStyle |= FontStyle.Italic;
                    richTextBox_Write.Font = new Font(ExistingFont, NewFontStyle);
                }
                else
                {
                    Font ExistingFont = richTextBox_Write.SelectionFont;
                    FontStyle NewFontStyle = new FontStyle();
                    if (checkBox_B.Checked)
                        NewFontStyle = FontStyle.Bold;

                    if (checkBox_U.Checked)
                        NewFontStyle |= FontStyle.Underline;

                    if (checkBox_I.Checked)
                        NewFontStyle |= FontStyle.Italic;
                    richTextBox_Write.SelectionFont = new Font(ExistingFont, NewFontStyle);
                }
            }
        }

        private void radioButton_L_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox_Write.Text != null)
            {
                richTextBox_Write.SelectAll();
                richTextBox_Write.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox_Write.DeselectAll();
            }
        }

        private void radioButton_C_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox_Write.Text != null)
            {
                richTextBox_Write.SelectAll();
                richTextBox_Write.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox_Write.DeselectAll();
            }
        }

        private void radioButton_R_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox_Write.Text != null)
            {
                richTextBox_Write.SelectAll();
                richTextBox_Write.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox_Write.DeselectAll();
            }
        }

        private void comboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox_Write.SelectedText == null)
            {
                foreach (Color color in new ColorConverter().GetStandardValues())
                {
                    if (color.Name == comboBox_Color.SelectedItem.ToString())
                    {
                        richTextBox_Write.ForeColor = color;
                    }
                }
            }
            else
            {
                foreach (Color color in new ColorConverter().GetStandardValues())
                {
                    if (color.Name == comboBox_Color.SelectedItem.ToString())
                    {
                        richTextBox_Write.SelectionColor = color;
                    }
                }
            }
        }

        private void textBox_Load_Click(object sender, EventArgs e)
        {
            if((sender as TextBox).Name == "textBox_Load")
            {
                (sender as TextBox).Text = "";
            }
            else if ((sender as TextBox).Name == "textBox_Save")
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}