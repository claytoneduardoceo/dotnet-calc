namespace Calculator.Exceptions
{
    public class UnrecognizedFunctionTypeException : Exception
    {
        public UnrecognizedFunctionTypeException()
        {
            Console.WriteLine($"Não foi possível identificar a função solicitada, tente novamente.");
        }

    }
}