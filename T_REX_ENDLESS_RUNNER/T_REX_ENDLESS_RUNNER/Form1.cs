using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_REX_ENDLESS_RUNNER
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Trex.Top += jumpSpeed;
            ScoreText.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            
            if (Trex.Top >= 366 && jumping == false)
            {
                force = 12;
                Trex.Top = 366;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(500, 800);
                        score++;
                    }

                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        Trex.Image = Properties.Resources.dead;
                        GameOver_label.Text = "GAME OVER !!!";
                        isGameOver = true;
                    }
                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            ScoreText.Text = "Score: " + score;
            Trex.Image = Properties.Resources.running;
            isGameOver = false;
            Trex.Top = 366; 

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800);
                    x.Left = position;
                }
            }

            GameTimer.Start();
        }
    }
}
