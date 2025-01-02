using System.Windows.Forms;

namespace BallCamesWindowsFormsApp
{
    public class PointBall : Ball
    {
        public PointBall(Form form, int x, int y) : base(form) 
        {
            this.x = x;
            this.y = y;
        }
    }
}
