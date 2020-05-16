using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_готовая
{
    public partial class Крестики_нолики : Form
    {
        bool xT = true;
        bool gameStart;
        public Крестики_нолики()
        {
            InitializeComponent();
        }
        void Win(Button pressedButton)
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false)
            {
                MessageBox.Show("Победили" + pressedButton.Text);
                Application.Restart();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили" + pressedButton.Text);
                Application.Restart();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false)
            {
                MessageBox.Show("Победили" + pressedButton.Text);
                Application.Restart();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили" + pressedButton.Text);
                Application.Restart();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили" + pressedButton.Text);
                Application.Restart();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)
            {
                MessageBox.Show("Победили" + pressedButton.Text);
                Application.Restart();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false)
            {
                MessageBox.Show("Победили" + pressedButton.Text);
                Application.Restart();
            }
            if (button1.Text != "" & button2.Text!="" & button3.Text!="" & button4.Text!="" & button5.Text!="" & button6.Text!="" & button7.Text!="" & button8.Text!="" & button9.Text!="") {
                MessageBox.Show("НИЧЬЯ");
            }
            
        }
            private void button1_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gameStart = true;
            Button senderB = (Button)sender;
            senderB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            if (xT)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xT = !xT;
            senderB.Enabled = false;
            Win(senderB);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                xT = true;
            }
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xT = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Слова slv = new Слова();
            slv.Show();
            Hide();

        }
    }
}
