using System.Runtime.CompilerServices;

namespace CallerArgumentExpressionAttribute;

class Program
{
    public static void ValidateArgument(string parameterName,
                                        bool condition,
                                        [System.Runtime.CompilerServices.CallerArgumentExpression("condition")]
                                        string? message = null)
    {
        if (!condition)
        {
            throw new ArgumentException($"Argument failed validation: <{message}>", parameterName);
        }
    }

    static void Main(string[] args)
    {
        (int x, int y) point = (x: 1, y: 2);
        ValidateArgument(nameof(point), point is (0, 0));
    }
}