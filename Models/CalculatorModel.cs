namespace webLab2._1.Models
{
    public class CalculatorModel
    {
        public readonly int X;
        public readonly int Y;
        public readonly string Sum;
        public readonly string Dif;
        public readonly string Mult;
        public readonly string Div;
        public CalculatorModel(int x, int y, string sum, string dif, string mult, string div)
        {
            X = x;
            Y = y;
            Sum = sum;
            Dif = dif;
            Mult = mult;
            Div = div;
        }
    }
}
