namespace BallCamesWindowsFormsApp
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form1 form) : base(form)
        {
            size = random.Next(30,80);
        }
    }
}
