using System;
using CalculateArea.InputModels;

namespace CalculateArea.Figures.Kind
{
    public class TriangleService<T> : IBaseFigure
        where T : TriangleInput
    {
        private readonly TriangleInput _inputValue;

        public TriangleService(T input)
        => _inputValue = input;

        public double GetArea()
        {
            var p           = (_inputValue.FirstLine + _inputValue.SecondLine + _inputValue.ThirdLine)/2;
            return Math.Round(Math.Sqrt(p * (p - _inputValue.FirstLine) * (p - _inputValue.SecondLine) * (p - _inputValue.ThirdLine)),2);
        }

        public bool IsStraight()
        {
            var max = Math.Max(Math.Max(_inputValue.FirstLine, _inputValue.SecondLine), _inputValue.ThirdLine);
            var value = 2 *Math.Pow(max, 2) - (Math.Pow(_inputValue.FirstLine,    2)
                                                         + Math.Pow(_inputValue.SecondLine, 2)
                                                         + Math.Pow(_inputValue.ThirdLine,  2));
            return value == 0;
        }
    }
}