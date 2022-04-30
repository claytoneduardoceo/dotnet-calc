using Calculator.Exceptions;
using Calculator.Enums;

namespace Calculator.Functions
{
    public static class Functions
    {
        public static float? Calculate(this float firstNumber, float seccondNumber, EFunctionType? eFunctionType)
        {
            try
            {
                if (eFunctionType == null)
                {
                    throw new UnrecognizedFunctionTypeException();
                }
                else
                {
                    switch (eFunctionType)
                    {
                        case EFunctionType.Sum: return Sum(firstNumber, seccondNumber);
                        case EFunctionType.Subtract: return Sum(firstNumber, seccondNumber);
                        case EFunctionType.Divide: return Sum(firstNumber, seccondNumber);
                        case EFunctionType.Multiply: return Sum(firstNumber, seccondNumber);
                        default: throw new UnrecognizedFunctionTypeException();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro inesperado ao efetuar o cálculo solicitado. {e.Message}");
                throw;
            }

        }

        private static float Sum(float firstNumber, float seccondNumber)
        {
            return firstNumber + seccondNumber;
        }

        private static float Subtract(float firstNumber, float seccondNumber)
        {
            return firstNumber - seccondNumber;
        }

        private static float Divide(float firstNumber, float seccondNumber)
        {
            return firstNumber / seccondNumber;
        }

        private static float Multiply(float firstNumber, float seccondNumber)
        {
            return firstNumber * seccondNumber;
        }
    }
}