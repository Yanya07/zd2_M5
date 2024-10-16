using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void текстBox1_TextChanged(object sender, EventArgs e)
        {
            // Обновление статуса с количеством символов
            statusLabel.Text = "Количество символов: " + textBox1.Text.Length;
        }

        private void жирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Изменение стиля текста на жирный
            if (textBox1.SelectionFont != null)
            {
                Font currentFont = textBox1.SelectionFont;
                FontStyle newFontStyle = textBox1.SelectionFont.Style ^ FontStyle.Bold;
                textBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void курсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Изменение стиля текста на курсив
            if (textBox1.SelectionFont != null)
            {
                Font currentFont = textBox1.SelectionFont;
                FontStyle newFontStyle = textBox1.SelectionFont.Style ^ FontStyle.Italic;
                textBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void подчеркнутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Изменение стиля текста на подчеркнутый
            if (textBox1.SelectionFont != null)
            {
                Font currentFont = textBox1.SelectionFont;
                FontStyle newFontStyle = textBox1.SelectionFont.Style ^ FontStyle.Underline;
                textBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Выбор цвета текста
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открытие файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Сохранение файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Обновление статуса с количеством символов
            statusLabel.Text = "Количество символов: " + textBox1.Text.Length;
        }
    }

}
