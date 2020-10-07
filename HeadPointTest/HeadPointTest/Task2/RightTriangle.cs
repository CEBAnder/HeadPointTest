namespace HeadPointTest.Task2
{
    public class RightTriangle : Shape
    {
        private readonly double _firstCathetus, _secondCathetus;

        public RightTriangle(double firstCathehus, double secondCathetus)
        {
            _firstCathetus = validateValue(firstCathehus, nameof(firstCathehus));
            _secondCathetus = validateValue(secondCathetus, nameof(secondCathetus));
        }

        public override double GetArea()
        {
            return (_firstCathetus * _secondCathetus) / 2;
        }
    }
}
