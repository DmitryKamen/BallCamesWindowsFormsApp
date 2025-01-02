using System.Windows.Forms;

namespace BallCamesWindowsFormsApp
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            size = random.Next(30,80);
        }
    }
}
