using System.Windows.Forms;

namespace Ball.Common
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            size = random.Next(30,80);
        }
    }
}
