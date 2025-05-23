using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tteset1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "Hello")
            {
                richTextBox2.Text= "Hello! How are you?";
            }
            if (richTextBox1.Text == "Im good" || richTextBox1.Text=="Good")
            {
                richTextBox2.Text = " Happy to hear that! Tell me about your day!";
            }
            if (richTextBox1.Text == "Im not well" || richTextBox1.Text == "Not Well")
            {
                richTextBox2.Text = " What happened? \n Tell me about your day!";
            }
        }
    }
}
