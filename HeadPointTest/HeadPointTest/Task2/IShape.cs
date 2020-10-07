namespace HeadPointTest.Task2
{
    public abstract class Shape
    {
        public abstract double GetArea();

        protected double validateValue(double inputValue, string paramName)
        {
            if (inputValue <= 0)
                throw new IncorrectParamException(paramName);

            return inputValue;
        }
    }
}
