using System.ComponentModel;

namespace Calculator.Enums
{
    public enum EFunctionType
    {
        [Description("Soma")]
        Sum,
        [Description("Subtração")]
        Subtract,
        [Description("Divisão")]
        Divide,
        [Description("Multiplicação")]
        Multiply
    }
}