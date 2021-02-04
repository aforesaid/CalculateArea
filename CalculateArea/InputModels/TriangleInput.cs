namespace CalculateArea.InputModels
{
    public class TriangleInput : BaseInputModel
    {
        public double FirstLine { get; set; }
        public double SecondLine { get; set; }
        public double ThirdLine { get; set; }


        public TriangleInput(double firstLine,
            double secondLine, double thirdLine)
        {
            FirstLine  = firstLine;
            SecondLine = secondLine;
            ThirdLine  = thirdLine;
        }
    }
}