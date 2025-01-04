using Balls.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe2WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private List<RandomMoveBall> randomMoveBalls;
        private int countBalls = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            clearButton.Enabled = true;
            randomMoveBalls = new List<RandomMoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                randomMoveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (randomMoveBalls != null)
            {
                foreach (var ball in randomMoveBalls)
                {
                    if (ball.IsMovable() && ball.Contains(e.X, e.Y))
                    {
                        ball.Stop();
                        countBalls++;
                    }
                    countBallsLabel.Text = countBalls.ToString();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in randomMoveBalls)
            {
                ball.Clear();
            }
            clearButton.Enabled = false;
            startButton.Enabled = true;
        }
    }
}
