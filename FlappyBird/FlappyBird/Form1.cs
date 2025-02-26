using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 6;
        int gravity = 15;
        int score = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            PipeBotton.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score:    " + score;   

            if(PipeBotton.Left < -150)
            {
                PipeBotton.Left = 600;
                score++;
            }
            if (PipeTop.Left < -180)
            {
                PipeTop.Left = 750;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(PipeBotton.Bounds) ||
               flappyBird.Bounds.IntersectsWith(PipeTop.Bounds) || 
               flappyBird.Bounds.IntersectsWith(Graund.Bounds))
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 10;
            }
            if(score > 15){
                pipeSpeed = 15;
            }
            if (flappyBird.Top <-25)
            {
                endGame();
            }
        }

        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            GameTimer.Stop();
            GameOver_label.Text = "GAME OVER!!!";
        }
    }
}
