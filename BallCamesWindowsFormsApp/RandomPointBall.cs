using System;

namespace BallCamesWindowsFormsApp
{
    public class RandomPointBall : Ball
    {
        
        public RandomPointBall(Form1 form) : base(form) 
        {
            x = random.Next(0, form.ClientSize.Width);
            y = random.Next(0, form.ClientSize.Height);
        }
    }
}
