using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_me_
{
    public partial class end : Form
    {
        
        public end()
        {
            InitializeComponent();
            restart();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void restart()
        {
            
            if (Form1.winwyswietlacz)
            {
                label1.Text = "Congratulations! \n You correctly guessed the word.";
                button1.Text = "Let's go!";
            }
            else
            {
                label1.Text = "Unfortunately! \n Next time you will succeed.";
                button1.Text = "Try again!";
            }
            label2.Text = "Word: " + Form1.wylosowaneslowo;
        }
    }
}
