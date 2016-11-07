namespace Delegates
{
    public delegate int PerformCalculation(int firstNumber, int secondNumber);

    class CalcFactory
    {
        public static PerformCalculation Create(MathOperations mp)
        {
            PerformCalculation calculation = null;

            switch (mp)
            {
                case MathOperations.Addtion:
                    calculation = Addition;
                    break;
                case MathOperations.Substract:
                    calculation = Substract;
                    break;
                case MathOperations.Multiply:
                    calculation = Multiply;
                    break;
                default:
                    calculation = Addition;
                    break;
            }

            return calculation;
        }

        private static int Addition(int x, int y)
        {
            return x + y;
        }

        private static int Substract(int x, int y)
        {
            return x - y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}