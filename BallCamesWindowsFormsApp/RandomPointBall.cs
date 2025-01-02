﻿using System;
using System.Windows.Forms;

namespace BallCamesWindowsFormsApp
{
    public class RandomPointBall : Ball
    {
        
        public RandomPointBall(Form form) : base(form) 
        {
            x = random.Next(0, form.ClientSize.Width);
            y = random.Next(0, form.ClientSize.Height);
        }
    }
}
