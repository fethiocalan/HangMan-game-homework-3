using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace hangManGame
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] animals = new string[4];
        char[] guessedWordArray = new char[25];
        int randomnum;
        string word = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            pictureBox2.Image = Properties.Resources._1;

            
            Random random = new Random();
            int randomNumber = random.Next(animals.Length);
            randomnum = randomNumber;
            animals[0] = "lion";
            animals[1] = "elephant";
            animals[2] = "tiger";
            animals[3] = "zebra";

            switch (randomnum)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.lion;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.elephant;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.tiger;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.zebra;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.No_image;
                    break;
            }




            for (int i = 0; i < animals[randomNumber].Length; i++)
            {
                if (animals[randomNumber][i] != ' ')
                {
                    guessedWordArray[i] = '-'; // 
                }
                else
                {
                    guessedWordArray[i] = ' ';
                }
                word += guessedWordArray[i]+" ";

                guessedWord.Text = word;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value >= 120)
            {
                timer1.Stop();
                MessageBox.Show("Time has done!");
                MessageBox.Show("The word which you tried to guess is '" + animals[randomnum] +"'");
            }
            else
            {
                progressBar.Value++;
            }
        }


        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void letterBox_Click(object sender, EventArgs e)
        {
            guessBox.Clear();
        }

        private void guessBox_Click(object sender, EventArgs e)
        {
            letterBox.Clear();
        }


        string[] usedLetter = new string[15];
        int countChar = 0;



        int count = 0;
        private void btnLetterBox_Click(object sender, EventArgs e)
        {
            string compare = "";
            word = "";
            for (int i = 0; i < animals[randomnum].Length; i++) {
                if (letterBox.Text.ToLower() == animals[randomnum][i].ToString().ToLower()) {
                    guessedWordArray[i] = animals[randomnum][i];
                }
                word += guessedWordArray[i]+" ";
                compare += guessedWordArray[i];
            }
            guessedWord.Text = word;

            if (compare == animals[randomnum]) {
                timer1.Stop();
                MessageBox.Show("Congrats!");
                guessBox.Enabled = false;
                letterBox.Enabled = false;
                timer1.Stop();
                this.Close();
                frm2.ShowDialog();
                
            }

            string display = "";
           
            bool alreadyHaveTheLetter = false;
            for (int i = 0; i <= countChar; i++) {
                if (letterBox.Text== usedLetter[i]) {
                    alreadyHaveTheLetter = true;
                }

            }


            bool have = false;
            if (!alreadyHaveTheLetter)
            {
                usedLetter[countChar] = letterBox.Text;
                for (int i = 0; i <= countChar; i++)
                {
                    display += " - "+usedLetter[i];
                }
                countChar++;
            }

            else {
                MessageBox.Show("You have already entered '"+letterBox.Text+"'");
                
                for (int i = 0; i <= countChar-1; i++)
                {
                    display += " - " + usedLetter[i];
                }
                have = true;
            }
                usedLetters.Text = display;



           
            for (int i = 0; i < animals[randomnum].Length; i++) {
                if (letterBox.Text == compare[i].ToString()) {
                    have = true;
                }
            }
            if (!have) {
     
                count++;
                if (count == 1) {
                    pictureBox2.Image = Properties.Resources._2;
                }
                else if (count == 2)
                {
                    pictureBox2.Image = Properties.Resources._3;
                }
                else if (count == 3)
                {
                    pictureBox2.Image = Properties.Resources._4;
                }
                else if (count == 4)
                {
                    pictureBox2.Image = Properties.Resources._5;
                }
                else if (count == 5)
                {
                    pictureBox2.Image = Properties.Resources._6;
                }
                else if (count == 6)
                {
                    pictureBox2.Image = Properties.Resources._7;
                    MessageBox.Show("You lost The word which you were guessed is '" + animals[randomnum] +"'");
                    guessBox.Enabled = false;
                    letterBox.Enabled = false;
                    timer1.Stop();
                   
                    frm2.ShowDialog();
                    
                }
               
            }
            
           
            letterBox.Clear();
            guessBox.Clear();

        }
        Form2 frm2 = new Form2();
        private void btnGuessBox_Click(object sender, EventArgs e)
        {

            if (guessBox.Text.ToLower() == animals[randomnum].ToLower()) {
                MessageBox.Show("Congrats!");
                guessBox.Enabled = false;
                letterBox.Enabled = false;
                timer1.Stop();
              
                frm2.ShowDialog();
                
            }
            letterBox.Clear();
            guessBox.Clear();
        }

        private void guessedWord_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
