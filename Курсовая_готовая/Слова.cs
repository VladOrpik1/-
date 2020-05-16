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
    public partial class Слова : Form
    {

        string[] words = {"Adore","Agile","Amaze","Angel","hjghjgjg",
                            "Black","badly","baker","begin","being",
                            "daily","darts","delay","dirty","docks",
                            "eaten","empty","enjoy","enter","every",
                            "sauce","scene","sense","shake","share"
        };
        string keywrd;
        char[] keyWrdChar;
        int health = 3;
        string[] simbols = { "$", "%" };


        public Слова()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            health--;
            Button button = (Button)sender;
            char[] pressWrd = button.Text.ToCharArray();

            int letterGues = 0;
            for (int i = 0; i < keyWrdChar.Length; i++)
            {
                if (keyWrdChar[i] == pressWrd[i]) { letterGues++; }
            }
            if (letterGues == keyWrdChar.Length)
            {
                MessageBox.Show("Вы выйграли ");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Вы угадали" + letterGues + "БУКВ");
            }

            if (health <= 0)
            {
                MessageBox.Show("Вы выйграли ");
                Application.Restart();
            }
        }

        private void s_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "$")
            {
                health++;
                button.Enabled = false;
            }
            else if (button.Text == "%")
            {
                MessageBox.Show("проиграли");
                Application.Restart();
            }
        }

        private void Слова_Load(object sender, EventArgs e)
        {
            List<string> sessionWrd = new List<string>();
            Random rmd = new Random();

            int chooseWord = rmd.Next(0, words.Length);
            button1.Text = words[chooseWord];
            sessionWrd.Add(words[chooseWord]);

            chooseWord = rmd.Next(0, words.Length);
            button2.Text = words[chooseWord];
            sessionWrd.Add(words[chooseWord]);

            chooseWord = rmd.Next(0, words.Length);
            button3.Text = words[chooseWord];
            sessionWrd.Add(words[chooseWord]);

            chooseWord = rmd.Next(0, words.Length);
            button4.Text = words[chooseWord];
            sessionWrd.Add(words[chooseWord]);

            chooseWord = rmd.Next(0, words.Length);
            button5.Text = words[chooseWord];
            sessionWrd.Add(words[chooseWord]);

            keywrd = sessionWrd[rmd.Next(0, sessionWrd.Count)];
            keyWrdChar = keywrd.ToCharArray();

            button7.Text = simbols[rmd.Next(0, 2)];
            button6.Text = simbols[rmd.Next(0, 2)];
            button8.Text = simbols[rmd.Next(0, 2)];
            button9.Text = simbols[rmd.Next(0, 2)];

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Крестики_нолики kr = new Крестики_нолики();
            kr.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }
    }
}
