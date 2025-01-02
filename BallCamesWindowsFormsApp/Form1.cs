using Ball.Common;
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
        List<RandomMoveBall> randomMoveBalls;
        
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
                randomMoveBalls[i].Stop();
                if (randomMoveBalls[i].OnForm()) countBalls++;
            }
            MessageBox.Show(countBalls.ToString());
            stopButton.Enabled = false;
            clearButton.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;
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
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in randomMoveBalls)
            {
                moveBall.Clear();
            }
            clearButton.Enabled = false;
            startButton.Enabled = true;
        }
    }
}
