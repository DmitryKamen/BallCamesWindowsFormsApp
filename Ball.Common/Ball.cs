using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls.Common
{
    public class Ball
    {
        private Form form;
        private Timer timer;

        protected int vx = 1;
        protected int vy = 1;

        protected int centerX = 10;
        protected int centerY = 10;
        protected int radius = 25;
        protected static Random random = new Random();
        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public void Show() 
        {  
            var brush = Brushes.Aqua;
            Drow(brush);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
            
        }

        private void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Clear()
        {
            
            var brush = new SolidBrush(form.BackColor);
            Drow(brush);
        }

        public bool Contains(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }

        public void Drow(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }

        public int LeftSide()
        { 
            return radius; 
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
    }
}
