using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomPointBall : Ball
    {
        
        public RandomPointBall(Form form) : base(form) 
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
    }
}
