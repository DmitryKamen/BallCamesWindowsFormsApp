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

namespace BallCamesWindowsFormsApp
{
    public partial class Form1 : Form
    {
        PointBall pointBall;
        List<Ball> balls;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var countBalls = 0;
            for (int i = 0; i < 10; i++)
            {
                balls[i].Stop();
                if (balls[i].OnForm()) countBalls++;
            }
            MessageBox.Show(countBalls.ToString());
            stopButton.Enabled = false;
            clearButton.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;
            balls = new List<Ball>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in balls)
            {
                moveBall.Clear();
            }
            clearButton.Enabled = false;
            startButton.Enabled = true;
        }
    }
}
