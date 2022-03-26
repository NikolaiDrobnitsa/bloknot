using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2(string data)
        {
            InitializeComponent();
            this.all_text = data;
            
        }
        public string all_text;
        public string search_word;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search_word = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (all_text.IndexOf(search_word)>= 0)
            {
                //all_text.SelectionStart = 0;
                //all_text.SelectionLength = all_text.Text.Length;
            }
        }
    }
}
