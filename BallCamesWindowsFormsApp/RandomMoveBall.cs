namespace BallCamesWindowsFormsApp
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(Form1 form) : base(form)
        {
            vx = random.Next(-5, 6);
            vy = random.Next(-5, 6);
        }
    }
}
