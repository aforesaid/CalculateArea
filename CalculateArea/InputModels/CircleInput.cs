namespace CalculateArea.InputModels
{
    public class CircleInput : BaseInputModel
    {
        public double Radius { get; set; }

        public CircleInput(double radius)
            => Radius = radius;
    }
}
