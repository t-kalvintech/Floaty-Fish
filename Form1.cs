using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floaty_Fish
{
    public partial class Form1 : Form
    {
        int coralSpeed = 8;
        int gravity = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void floatyFish_Click(object sender, EventArgs e)
        {

        }

        private void boatTop_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            floatyFish.Top += gravity;
            coralBottom.Left -= coralSpeed;
            boatTop.Left -= coralSpeed;
            scoreText.Text = "Score: "+score;

            if (coralBottom.Left < -50)
            {
                coralBottom.Left = 800;
                score++;
            }
            if(boatTop.Left < -80)
            {
                boatTop.Left = 950;
                score++;
            }

            if(floatyFish.Bounds.IntersectsWith(coralBottom.Bounds) ||
                floatyFish.Bounds.IntersectsWith(boatTop.Bounds) ||
                floatyFish.Bounds.IntersectsWith(floor.Bounds)
                )
            {
                endGame();
            }

            if(floatyFish.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                coralSpeed = 12;
            }

            if (score > 10)
            {
                coralSpeed = 15;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gamekeyisup(object sender, KeyPressEventArgs e)
        {

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void coralBottom_Click(object sender, EventArgs e)
        {

        }

        private void floor_Click(object sender, EventArgs e)
        {

        }
        
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!";
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void Version_Click(object sender, EventArgs e)
        {

        }
    }
}
