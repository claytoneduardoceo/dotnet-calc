// See https://aka.ms/new-console-template for more information
using Calculator.Functions;
using Calculator.Enums;
using Calculator.Exceptions;
using Calculator.Utils;

Console.WriteLine("|--===== O que deseja fazer? =====--|");
Console.WriteLine("0 | Soma");
Console.WriteLine("1 | Subtração");
Console.WriteLine("2 | Divisão");
Console.WriteLine("3 | Multiplicação");
Console.WriteLine("|--===== Selecione uma função! =====--|");
Console.WriteLine("Selecione uma função: ");

try
{
    int selectedFunction = int.Parse(StringUtils.ReadConsoleInputNumber());

    EFunctionType functionType = (EFunctionType)selectedFunction;

    StringUtils.Print($"A função selecionada é: {functionType.GetEnumDescription().ToUpper()}");

    StringUtils.Print("Digite o primeiro valor");
    float firstNumber = float.Parse(StringUtils.ReadConsoleInputNumber());

    StringUtils.Print("Digite o segundo valor");
    float seccondNumber = float.Parse(StringUtils.ReadConsoleInputNumber());

    StringUtils.Print($"Resultado da {functionType.GetEnumDescription()} é:");
    StringUtils.Print($"{firstNumber.Calculate(seccondNumber, functionType)}");

}
catch (System.Exception)
{

    throw;
}




