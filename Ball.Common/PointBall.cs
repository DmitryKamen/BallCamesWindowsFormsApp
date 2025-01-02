using System.Windows.Forms;

namespace Ball.Common
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
