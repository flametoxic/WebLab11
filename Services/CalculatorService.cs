using webLab2._1.Models;

namespace webLab2._1.Services
{
    public class CalculatorService
    {
        private readonly Random _random = new();

        public CalculatorModel GetCalcModel()
        {
            var x = _random.Next() % 11;
            var y = _random.Next() % 11;
            return new CalculatorModel(
                x,
                y,
                sum: $"{x} + {y} = {x + y}",
                dif: $"{x} - {y} = {x - y}",
                mult: $"{x} * {y} = {x * y}",
                div: y != 0 ? $"{x} /  {y} = {x / y}" : "Division by zero"
            );
        }
    }
}
