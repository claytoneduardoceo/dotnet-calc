namespace Calculator.Exceptions
{
    public class UnrecognizedInputedValue : Exception
    {
        public UnrecognizedInputedValue()
        {
            Console.WriteLine($"Erro: Não foi possível ler o valor inserido, verifique se digitou um número válido e tente novamente");
        }

    }
}