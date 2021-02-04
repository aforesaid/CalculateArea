using System;
using CalculateArea.InputModels;

namespace CalculateArea.Figures.Kind
{
    public class CircleService<T>: IBaseFigure 
        where T: CircleInput
    {
        private readonly CircleInput _inputValue;

        public CircleService(T input)
            => _inputValue = input;

        public double GetArea()
            => Math.Round(Math.Pow(_inputValue.Radius,2) * Math.PI,2);
    }
}
