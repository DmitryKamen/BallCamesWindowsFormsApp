using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(Form form) : base(form)
        {
            vx = (float)random.NextDouble() * 10 - 5;
            vy = (float)random.NextDouble() * 10 - 5;
        }
    }
}
