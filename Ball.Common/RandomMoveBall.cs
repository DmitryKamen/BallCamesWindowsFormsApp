﻿using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(Form form) : base(form)
        {
            vx = random.Next(-5, 6);
            vy = random.Next(-5, 6);
        }
    }
}
