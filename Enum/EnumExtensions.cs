using System.ComponentModel;
using Calculator.Exceptions;

namespace Calculator.Enums
{
    public static class Teste
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (field != null && Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new UnrecognizedFunctionTypeException();
        }


    }
}
