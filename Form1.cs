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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool isFileChange = false;
        private int scale = 14;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "*.txt|*.txt";
                saveFileDialog.Title = "choose file dest";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }

        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dowloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Times New Roman", 10);

        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "ALL|*.*";
                saveFileDialog.Title = "choose file dest";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this.textBox1.Text);
            f.ShowDialog();
            

        }

        private void оПрограмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect(GC.GetGeneration(new AboutBox1().ShowDialog()));
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TEXT|*.txt|All|*.*";
                openFileDialog.Title = "choose file dest";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isFileChange)
            {
                isFileChange = true;
            }
            

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "ALL|*.*";
                saveFileDialog.Title = "choose file dest";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {

                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print(); 
            }
            GC.Collect();
        }

        private void ParametriscСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (PrintFileDialog printDialog = new PrintDialog())
            //{

            //    if (printDialog.ShowDialog() == DialogResult.OK)
            //        printDialog.Document.Print();
            //}
        }

        private void переносПоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void переносПоToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            textBox1.WordWrap = TransferПоToolStripMenuItem.Checked;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog1 = new FontDialog())
            {
                fontDialog1.ShowColor = true;

                fontDialog1.Font = textBox1.Font;
                fontDialog1.Color = textBox1.ForeColor;

                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    textBox1.Font = fontDialog1.Font;
                    textBox1.ForeColor = fontDialog1.Color;
                    
                }
            }
        }

        private void TimeAndDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Paste(DateTime.Now.ToString());
                
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void HightLightsВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
            textBox1.Focus();
            
        }
        

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            //if (isFileChange)
            //{
            //    DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            //}
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length - textBox1.SelectionStart);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scale < 100)
            {
                scale += 5;
            }
            this.textBox1.Font = new Font(textBox1.Font.FontFamily, scale += 3);
        }

        private void decreaseScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scale > 1)
            {
                scale -= 5;
            }
            this.textBox1.Font = new Font(textBox1.Font.FontFamily, scale -= 3);
        }

        private void DefaultScaleМаштабПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font(textBox1.Font.FontFamily, 14);
            scale = 14;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                searchToolStripMenuItem.Enabled = false;
                SearchNextToolStripMenuItem.Enabled = false;
                replaceToolStripMenuItem.Enabled = false;
            }
            else
            {
                searchToolStripMenuItem.Enabled = true;
                SearchNextToolStripMenuItem.Enabled = true;
                replaceToolStripMenuItem.Enabled = true;
            }
            if (TransferПоToolStripMenuItem.CheckState == CheckState.Checked)
            {
                GoToolStripMenuItem.Enabled = false;
            }
            else
            {
                GoToolStripMenuItem.Enabled = true;
            }
        }

        private void GoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(this.textBox1.Text);
            f.ShowDialog();
        }

        private void строкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
