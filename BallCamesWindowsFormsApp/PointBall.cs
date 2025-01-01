namespace BallCamesWindowsFormsApp
{
    public class PointBall : Ball
    {
        public PointBall(Form1 form, int x, int y) : base(form) 
        {
            this.x = x;
            this.y = y;
        }
    }
}
